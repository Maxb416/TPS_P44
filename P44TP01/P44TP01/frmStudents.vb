Imports System.Runtime.Intrinsics.Arm
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient

Public Enum Action
    Read = 0
    Create = 1
    Update = 2
    Delete = 3
End Enum
Public Class frmStudents
    Private con As SqlConnection
    Private sqlCmd As SqlCommand
    Private dataR As SqlDataReader
    Private studentDa As Integer
    Private studentIndex As Integer 'Last index of selected student
    Dim errProv As New ErrorProvider()

    'see https://regexlib.com/Search.aspx?k=form&c=-1&m=-1&ps=20
    Dim namePattern As String = "^[a-zA-Z]+(([\'\,\.\- ][a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ ])?[a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ]*)*$"
    Dim addressPattern As String = "^(\d{1,6}) ([a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ]+(([\'\,\.\-\` ][a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ ])*)){2,}\s?$"
    Dim cityPattern As String = "^[a-zA-Z]+(([\'\,\.\- ][a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ ])?[a-zA-ZÀÂÉÊÈËÌÏÎÔÙÛÇÆŒàâéêèëìïîôùûçæœ]*)*$"

    Dim provinces As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
        {"--Select one --", 0},
        {"Québec", 1},
        {"Ontario", 2},
        {"Terre-Neuve-et-Labrador", 3},
        {"Alberta", 4},
        {"Saskatchewan", 5},
        {"Manitoba", 6},
        {"Colombie-Britannique", 7},
        {"Nouvelle-Écosse", 8},
        {"Nouveau-Brunswick", 9},
        {"Île-du-Prince-Édouard", 10}
    }

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source=.\SQLExpress;Initial Catalog=tp_p44;Integrated Security=True;Trust Server Certificate=true")
            con.Open()
            MessageBox.Show("Connection with server established with success") 'Must be changed to console 

            Dim stringProvinces As String() = GetProvincesArray()
            cboProvince.Items.AddRange(stringProvinces)

            updateForm()

        Catch ex As SqlException
            MessageBox.Show("Server connection failed,  see error no : " & ex.Number _
               & vbCrLf & "error type " & ex.Message)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetProvincesArray() As String()
        Dim stringArr(10) As String
        Dim i As Integer = 0
        For Each pair As KeyValuePair(Of String, Integer) In provinces
            stringArr(i) = pair.Key
            i = i + 1
        Next
        Return stringArr
    End Function

    Private Sub loadDataToLvStudents()
        sqlCmd = New SqlCommand("Select * From T_etudiants", con)
        dataR = sqlCmd.ExecuteReader()
        lvStudentsInfo.Items.Clear()

        Dim lvi As ListViewItem
        Try
            Do While dataR.Read() 'Each line w. table T_programme
                lvi = New ListViewItem(dataR("etu_da").ToString())
                lvi.SubItems.Add(dataR("pro_no").ToString())
                lvi.SubItems.Add(dataR("etu_nom").ToString())
                lvi.SubItems.Add(dataR("etu_prenom").ToString())
                lvi.SubItems.Add(dataR("etu_sexe").ToString())
                lvi.SubItems.Add(dataR("etu_adresse").ToString())
                lvi.SubItems.Add(dataR("etu_ville").ToString())
                lvi.SubItems.Add(dataR("etu_province").ToString())
                lvi.SubItems.Add(dataR("etu_telephone").ToString())
                lvi.SubItems.Add(dataR("etu_codepostal").ToString())
                lvi.Tag = dataR("etu_da").ToString()

                lvStudentsInfo.Items.Add(lvi)
            Loop
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            dataR.Close()
        End Try

        lvStudentsInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
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


    Private Sub lvStudentsInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvStudentsInfo.SelectedIndexChanged
        If lvStudentsInfo.SelectedItems.Count > 0 Then
            studentDa = lvStudentsInfo.SelectedItems(0).Tag
            studentIndex = lvStudentsInfo.SelectedIndices(0)
            loadStudentToForm(studentDa)
            unlockControls(btnModify, btnRemove)
        Else
            lockControls(btnRemove, btnModify)
        End If
    End Sub

    Private Sub loadStudentToForm(studentDa As Integer)
        sqlCmd = New SqlCommand("SELECT * FROM T_etudiants WHERE etu_da=@da", con)
        sqlCmd.Parameters.AddWithValue("@da", studentDa)

        Try
            dataR = sqlCmd.ExecuteReader()
            If dataR.Read() Then
                mtbDa.Text = dataR("etu_da").ToString()
                mtbNoProg.Text = dataR("pro_no").ToString()
                txtName.Text = dataR("etu_prenom").ToString()
                txtFamName.Text = dataR("etu_nom").ToString()

                If dataR("etu_sexe").ToString = "M" Then
                    rdoMale.Checked = True
                ElseIf dataR("etu_sexe").ToString = "F" Then
                    rdoFemale.Checked = True
                End If
                txtAddress.Text = dataR("etu_adresse").ToString()
                txtCity.Text = dataR("etu_ville").ToString()
                cboProvince.SelectedIndex =
                    Array.IndexOf(GetProvincesArray(), dataR("etu_province").ToString())
                mtbZip.Text = dataR("etu_codepostal").ToString()
                mtbPhone.Text = dataR("etu_telephone").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            dataR.Close()
        End Try
    End Sub

    Private Sub emptyForm() 'Controls As Control.ControlCollection
        'For Each ctrl As Control In Controls
        '    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
        '        ctrl.ResetText()
        '    ElseIf TypeOf ctrl Is RadioButton Then
        '        CType(ctrl, RadioButton).Checked = False
        '    ElseIf TypeOf ctrl Is ComboBox Then
        '        CType(ctrl, ComboBox).SelectedIndex = 0
        '    End If

        '    If ctrl.HasChildren Then
        '        For Each c In ctrl.Controls
        '            emptyForm(grpBoxStudents.Controls)
        '        Next
        '    End If
        'Next

        mtbNoProg.Text = ""
        txtName.Text = ""
        txtFamName.Text = ""
        rdoMale.Checked = False
        rdoFemale.Checked = False
        txtAddress.Text = ""
        txtCity.Text = ""
        cboProvince.SelectedIndex = 0
        mtbZip.Text = ""
        mtbPhone.Text = ""


    End Sub

    Private Sub createStudent()
        Try
            sqlCmd = New SqlCommand("INSERT INTO T_etudiants(etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, " &
                    " etu_ville, etu_province, etu_telephone, etu_codepostal) VALUES (@da, @pro, @fname, @name, @gender, @address, " &
                    "@city, @province, @phone, @zip)", con)

            sqlCmd.Parameters.AddWithValue("@da", mtbDa.Text)
            sqlCmd.Parameters.AddWithValue("@pro", mtbNoProg.Text)
            sqlCmd.Parameters.AddWithValue("@fname", txtFamName.Text.Trim())
            sqlCmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
            If rdoMale.Checked Then
                sqlCmd.Parameters.AddWithValue("@gender", "M")
            ElseIf rdoFemale.Checked Then
                sqlCmd.Parameters.AddWithValue("@gender", "F")
            End If
            sqlCmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim())
            sqlCmd.Parameters.AddWithValue("@province", cboProvince.SelectedItem.ToString) 'Here 
            sqlCmd.Parameters.AddWithValue("@city", txtCity.Text.Trim())
            sqlCmd.Parameters.AddWithValue("@phone", mtbPhone.Text)
            sqlCmd.Parameters.AddWithValue("@zip", mtbZip.Text)

            MessageBox.Show(sqlCmd.ExecuteNonQuery() & " new student was created")

        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        End Try
    End Sub

    Private Sub removeStudent(studentDa As Integer)
        Try
            sqlCmd = New SqlCommand("DELETE FROM T_etudiants WHERE etu_da = @da", con)
            sqlCmd.Parameters.AddWithValue("@da", studentDa)
            sqlCmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)
        Finally
            updateForm()
        End Try
    End Sub

    Private Sub modifyStudent(studentDa As Integer)
        Try
            sqlCmd = New SqlCommand("UPDATE T_etudiants Set pro_no=@pro, etu_nom=@fname, etu_prenom=@name, etu_sexe=@gender," +
                    "etu_adresse=@address, etu_ville=@city, etu_province=@province, etu_telephone=@phone, etu_codepostal=@zip " +
                    "WHERE etu_da=@da", con)

            sqlCmd.Parameters.AddWithValue("@da", studentDa)
            sqlCmd.Parameters.Add("@pro", SqlDbType.VarChar).Value = mtbNoProg.Text.ToString()
            sqlCmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = txtFamName.Text.Trim()
            sqlCmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.Trim()
            If rdoMale.Checked Then
                sqlCmd.Parameters.Add("@gender", SqlDbType.Char).Value = CChar("M")
            ElseIf rdoFemale.Checked Then
                sqlCmd.Parameters.Add("@gender", SqlDbType.Char).Value = CChar("F")
            End If
            sqlCmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text.Trim()
            sqlCmd.Parameters.Add("@city", SqlDbType.VarChar).Value = txtCity.Text.ToString().Trim()
            sqlCmd.Parameters.Add("@province", SqlDbType.VarChar).Value = cboProvince.SelectedItem.ToString()
            sqlCmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = mtbPhone.Text.ToString()
            sqlCmd.Parameters.Add("@zip", SqlDbType.VarChar).Value = mtbZip.Text.ToString()

            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Something went wrong see : " & ex.Message)

        End Try

    End Sub

    Private Sub updateForm()
        lvStudentsInfo.Items.Clear()
        loadDataToLvStudents()
        If lvStudentsInfo.Items.Count > 0 Then
            lvStudentsInfo.Items(studentIndex).Selected = True
        End If

        unlockControls(lvStudentsInfo, btnNew)
        lockControls(grpBoxStudents, btnOk, btnCancel)
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

    Private Function autoIncrement()
        Dim last As Integer
        last = lvStudentsInfo.Items(lvStudentsInfo.Items.Count - 1).Tag

        Return last + 1
    End Function

    Private Function validForm() As Boolean
        Dim valid = True
        errProv.Clear()

        If Not mtbDa.MaskFull Then
            valid = False
            errProv.SetError(mtbDa, "Da must be a number made out of 7 digits")
        End If
        If mtbNoProg.MaskFull And Not mtbNoProg.Text.Substring(0, 3) = "LEA" Then
            GoTo Line
        ElseIf Not programExist(mtbNoProg.Text) Then
            MessageBox.Show("Program " + mtbNoProg.Text + " curently do not exist")
            GoTo Line
        ElseIf Not mtbNoProg.MaskFull Then
Line:       valid = False
            errProv.SetError(mtbNoProg, "Program number must Start with 'LEA.' and include a number and a letter in that specific order ")
        End If
        If Not Regex.IsMatch(txtName.Text, namePattern) Or txtName.Text.Length < 2 Then
            valid = False
            errProv.SetError(txtName, "Name must contain at least 2 characters")
        End If
        If Not Regex.IsMatch(txtFamName.Text, namePattern) Or txtFamName.Text.Length < 2 Then
            valid = False
            errProv.SetError(txtFamName, "Family name must contain at least 2 characters")
        End If
        If Not rdoMale.Checked And Not rdoFemale.Checked Then
            valid = False
            errProv.SetError(grpBoxGender, "You must pick one")
        End If
        If Not Regex.IsMatch(txtAddress.Text, addressPattern) Or txtAddress.Text.Length < 4 Then
            valid = False
            errProv.SetError(txtAddress, "Invalid address")
        End If
        If Not Regex.IsMatch(txtCity.Text, cityPattern) Or txtCity.Text.Length < 2 Then
            valid = False
            errProv.SetError(txtCity, "Invalid city name")
        End If
        If cboProvince.SelectedIndex = 0 Then
            valid = False
            errProv.SetError(cboProvince, "You must select one of the following province")
        End If
        If Not mtbZip.MaskFull Then
            valid = False
            errProv.SetError(mtbZip, "must be set as follow L1L-1L1")
        End If
        If Not mtbPhone.MaskFull Then
            valid = False
            errProv.SetError(mtbPhone, "must be set as follow (111) 111-1111")
        End If

        Return valid
    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not validForm() Then Exit Sub
        If btnOk.Tag = Action.Create Then
            createStudent()
            studentIndex = lvStudentsInfo.Items.Count
        ElseIf btnOk.Tag = Action.Update Then
            modifyStudent(studentDa)
        End If

        updateForm()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        unlockControls(grpBoxStudents, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, lvStudentsInfo)
        lvStudentsInfo.SelectedItems.Clear() 'Remove focus when in creation 

        emptyForm()

        mtbDa.Text = autoIncrement()
        mtbNoProg.Focus()
        btnOk.Tag = Action.Create
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        updateForm()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim title As String = "You're about to remove student " + txtName.Text + " " + txtFamName.Text + " from the system." +
                " Would you like to continue ?"
        Dim ans = MessageBox.Show(title, "remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (ans = System.Windows.Forms.DialogResult.Yes) Then

            IIf(studentIndex > 0, studentIndex - 1, studentIndex)

            removeStudent(studentDa)
        End If

        updateForm()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        unlockControls(grpBoxStudents, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, lvStudentsInfo)

        txtName.Focus()
        btnOk.Tag = Action.Update
    End Sub

    Private Sub frmStudents_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        con.Close()
    End Sub

End Class