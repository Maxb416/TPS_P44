Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient
Imports System.Decimal
Public Class frmManagement
    Private con As SqlConnection
    Private sqlCmd As SqlCommand
    Private dataR As SqlDataReader
    Private proNum As String 'Last Tag 
    Private proIndex As Integer 'index position of last selected item 
    Dim errProv As New ErrorProvider()

    'see https://regexlib.com/Search.aspx?k=form&c=-1&m=-1&ps=20
    Dim programPattern As String = "^[a-zA-Z]+(([\'\- ][a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ ])?[a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ]*)*$"
    Dim unitsPattern As String = "^[1-9]+\d?(\.+((33)|(66)|(0)|(00)))?$"
    Dim hoursPattern As String = "^[1-9]+\d{1,3}$"


    Private Sub frmManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source=.\SQLExpress;Initial Catalog=tp_p44;Integrated Security=True;Trust Server Certificate=true")
            con.Open()
            'MessageBox.Show("Connection with server established with success") 'Must be changed to console 

            updateForm()

        Catch ex As SqlException
            MessageBox.Show("Server connection failed,  see error no : " & ex.Number _
               & vbCrLf & "error type " & ex.Message)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadDataToLvProgram()
        sqlCmd = New SqlCommand("Select * From T_programme", con)
        dataR = sqlCmd.ExecuteReader()
        lvPrograms.Items.Clear()

        Dim lvi As ListViewItem
        Try
            Do While dataR.Read() 'Each line w. table T_programme
                lvi = New ListViewItem(dataR("pro_no").ToString())
                lvi.SubItems.Add(dataR("pro_nom").ToString())
                lvi.SubItems.Add(dataR("pro_nbr_unites").ToString())
                lvi.SubItems.Add(dataR("pro_nbr_heures").ToString())
                lvi.Tag = dataR("pro_no").ToString()

                lvPrograms.Items.Add(lvi)

            Loop
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            dataR.Close()
        End Try

        lvPrograms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub


    Private Sub lockControls(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub unlockControls(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = True
        Next
    End Sub


    Private Sub lvPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvStudentsPerPrograms.SelectedIndexChanged
        If lvPrograms.SelectedItems.Count > 0 Then
            proNum = lvPrograms.SelectedItems(0).Tag
            proIndex = lvPrograms.SelectedIndices(0)
            loadProgramToForm(proNum)
            loadStudentsLvByProg(proNum)

            unlockControls(btnRemove, btnModify)
        Else
            lockControls(btnRemove, btnModify)
            lvStudentsPerPrograms.Items.Clear()
        End If
    End Sub

    Private Sub loadStudentsLvByProg(progNum As String)
        sqlCmd = New SqlCommand("SELECT etu_da, pro_no, etu_prenom ,etu_nom 
                                FROM T_etudiants 
                                WHERE pro_no=@pNo", con)
        sqlCmd.Parameters.AddWithValue("@pNo", progNum)

        lvStudentsPerPrograms.Items.Clear()

        Dim lvi As ListViewItem
        Try
            dataR = sqlCmd.ExecuteReader()
            Do While dataR.Read
                lvi = New ListViewItem(dataR("etu_da").ToString())
                lvi.SubItems.Add(dataR("pro_no").ToString())
                lvi.SubItems.Add(dataR("etu_prenom").ToString())
                lvi.SubItems.Add(dataR("etu_nom").ToString())

                lvStudentsPerPrograms.Items.Add(lvi)
            Loop
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            If Not dataR.IsClosed Then
                dataR.Close()
            End If
        End Try

        lvStudentsPerPrograms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub loadProgramToForm(progNum As String)
        sqlCmd = New SqlCommand("SELECT * FROM T_programme
                                 WHERE pro_no=@pNo", con)
        sqlCmd.Parameters.AddWithValue("@pNo", progNum)

        Try
            dataR = sqlCmd.ExecuteReader()
            If dataR.Read() Then 'Single selected value 
                mtbNo.Text = dataR("pro_no")
                txtName.Text = dataR("pro_nom")
                txtUnits.Text = dataR("pro_nbr_unites")
                txtHours.Text = dataR("pro_nbr_heures")

            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            If Not dataR.IsClosed Then
                dataR.Close()
            End If
        End Try
    End Sub

    Private Sub emptyForm() 'Controls As Control.ControlCollection
        'For Each ctrl As Control In Controls
        '    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
        '        ctrl.ResetText()
        '    End If
        '    If ctrl.HasChildren Then
        '        For Each c In ctrl.Controls
        '            emptyForm(grpBoxPrograms.Controls)
        '        Next
        '    End If
        'Next
        mtbNo.Text = ""
        txtName.Text = ""
        txtUnits.Text = ""
        txtHours.Text = ""

    End Sub

    Private Function programExist(p As String)
        Dim doExist As Boolean = False
        Try
            sqlCmd = New SqlCommand("SELECT * FROM T_programme WHERE pro_no=@pro", con)
            sqlCmd.Parameters.AddWithValue("@pro", p)
            dataR = sqlCmd.ExecuteReader()

            If dataR.HasRows Then
                doExist = True
            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            dataR.Close()
        End Try

        Return doExist
    End Function

    Private Function validForm() As Boolean
        Dim valid = True
        errProv.Clear()

        If mtbNo.MaskFull And Not mtbNo.Text.Substring(0, 3) = "LEA" Then
            GoTo line1
        ElseIf programExist(mtbNo.Text) And Not btnOk.Tag = Action.Update Then
            MessageBox.Show(mtbNo.Text + "already exist")
            GoTo line1
        ElseIf Not mtbNo.MaskFull Then
line1:      valid = False
            errProv.SetError(mtbNo, "Program number must Start with 'LEA.' and include a number and a letter in that specific order ")
        End If
        If Not Regex.IsMatch(txtName.Text, programPattern) Or txtName.Text.Length < 4 Then
            valid = False
            errProv.SetError(txtName, "Name must contain at least 4 characters")
        End If
        If Integer.TryParse(txtHours.Text, 0) Then
            If CInt(txtHours.Text) >= 5000 Then
                GoTo Line2
            ElseIf Not Regex.IsMatch(txtHours.Text, hoursPattern) Then
Line2:          valid = False
                errProv.SetError(txtHours, "Number of hours must be a number between 10 and 5000")
            End If
        End If

        If Not Regex.IsMatch(txtUnits.Text, unitsPattern) Then
            valid = False
            errProv.SetError(txtUnits, "Must contain 2 digits and 2 decimals(optional). Note that only .0, .00, .33, .66 are accepted  ")
        End If

        Return valid
    End Function

    Private Sub createProgram()
        Try
            sqlCmd = New SqlCommand("INSERT INTO T_programme(pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures) " &
                                    "VALUES (@no, @name, @units, @hours)", con)

            sqlCmd.Parameters.AddWithValue("@no", mtbNo.Text)
            sqlCmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
            sqlCmd.Parameters.AddWithValue("@units", CDec(txtUnits.Text))
            sqlCmd.Parameters.AddWithValue("@hours", CInt(txtHours.Text))

            MessageBox.Show(sqlCmd.ExecuteNonQuery() & " Program created!")

        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        End Try
    End Sub

    Private Sub removeProgram(proNum As String)
        Try
            sqlCmd = New SqlCommand("DELETE FROM T_programme WHERE pro_no=@pro", con)
            sqlCmd.Parameters.AddWithValue("@pro", proNum)
            sqlCmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            updateForm()
        End Try
    End Sub

    Private Sub ModifyProgram(proNum As String)
        Try
            sqlCmd = New SqlCommand("UPDATE T_programme Set pro_no=@pro, pro_nom=@name, pro_nbr_unites=@units, pro_nbr_heures=@hour " +
                                    "WHERE pro_no=@pNum", con)


            sqlCmd.Parameters.AddWithValue("pNum", proNum)
            sqlCmd.Parameters.Add("@pro", SqlDbType.VarChar).Value = mtbNo.Text.ToString()
            sqlCmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.ToString()
            sqlCmd.Parameters.Add("@units", SqlDbType.Float).Value = CDec(txtUnits.Text)
            sqlCmd.Parameters.Add("@hour", SqlDbType.Int).Value = CInt(txtHours.Text)

            sqlCmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            unlockControls(mtbNo)
        End Try
    End Sub

    Private Sub updateForm()
        lvPrograms.Items.Clear()
        lvStudentsPerPrograms.Items.Clear()
        loadDataToLvProgram()

        If lvPrograms.Items.Count > 0 Then
            lvPrograms.Items(proIndex).Selected = True
        End If
        unlockControls(lvPrograms, lvStudentsPerPrograms, btnNew)
        lockControls(grpBoxPrograms, btnOk, btnCancel)
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        unlockControls(grpBoxPrograms, btnOk, btnCancel, mtbNo)
        lockControls(lvPrograms, btnModify, btnRemove, btnNew)
        lvPrograms.SelectedItems.Clear() 'Remove focus when in creation 
        emptyForm()

        txtName.Focus()
        btnOk.Tag = Action.Create
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not validForm() Then Exit Sub
        If btnOk.Tag = Action.Create Then
            createProgram()
            Dim newItem As String = mtbNo.Text.ToString
            updateForm()
            'Put focus on new created item 
            lvPrograms.Items(lvPrograms.FindItemWithText(newItem).Index).Selected = True
        ElseIf btnOk.Tag = Action.Update Then
            ModifyProgram(proNum)
            updateForm()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        updateForm()
    End Sub


    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        lockControls(btnNew, btnModify, btnRemove, lvPrograms, lvStudentsPerPrograms, mtbNo)
        unlockControls(btnOk, btnCancel, grpBoxPrograms)

        mtbNo.Focus()
        btnOk.Tag = Action.Update
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim title As String = "You're about to remove program " + mtbNo.Text + " " + txtName.Text + " from the system." +
                " Would you like to continue ?"
        Dim ans = MessageBox.Show(title, "remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (ans = System.Windows.Forms.DialogResult.Yes) Then

            IIf(proIndex > 0, proIndex - 1, proIndex)
            removeProgram(proNum)
        End If

        updateForm()
    End Sub

    Private Sub frmManagement_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        con.Close()
    End Sub
End Class

