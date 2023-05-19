Imports System.ComponentModel
Imports System.Data.Common
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient


Public Class FormPrograms
    Dim noPrograms As String
    Dim action As Action
    Dim errProv As New ErrorProvider()

    Dim ds As New DataSet("tp_p44")
    Dim cn As New SqlConnection(My.Settings.ConnectionString)



    'Queries Programs
    Dim tblProgSQlSelectCommand As New SqlCommand("SELECT * FROM T_programme", cn)
    Dim tblProgSQInsertCommand As New SqlCommand("INSERT INTO T_programme (pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures)
        VALUES (@No, @Name, @Units, @Hours)", cn)
    Dim tblProgSQlUpdateCommand As New SqlCommand("UPDATE T_programme Set pro_no=@No, pro_nom=@Name, pro_nbr_unites=@Units,
        pro_nbr_heures=@Hours WHERE pro_no=@No", cn)
    Dim tblProgSQlDeleteCommand As New SqlCommand("DELETE FROM T_programme WHERE pro_no=@No", cn)
    Dim daTblProg As New SqlDataAdapter(tblProgSQlSelectCommand)
    Dim bindSrcProg As New BindingSource()

    'Queries Students
    Dim tblStudSQlSelectCommand As New SqlCommand("SELECT * FROM T_etudiants", cn)
    Dim daTblStud As New SqlDataAdapter(tblStudSQlSelectCommand)
    Dim bindSrcStud As New BindingSource()



    Private Sub FormPrograms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblProgSQInsertCommand.Parameters.AddRange(New SqlParameter() _
           {
               New SqlParameter("@No", SqlDbType.VarChar, 0, "pro_no"),
               New SqlParameter("@Name", SqlDbType.VarChar, 50, "pro_nom"),
               New SqlParameter("@Units", SqlDbType.Float, 8, "pro_nbr_unites"),
               New SqlParameter("@Hours", SqlDbType.Int, 4, "pro_nbr_heures")
           })

        tblProgSQlUpdateCommand.Parameters.AddRange(New SqlParameter() _
           {
               New SqlParameter("@Name", SqlDbType.VarChar, 50, "pro_nom"),
               New SqlParameter("@Units", SqlDbType.Float, 8, "pro_nbr_unites"),
               New SqlParameter("@Hours", SqlDbType.Int, 4, "pro_nbr_heures"),
               New SqlParameter("@No", SqlDbType.VarChar, 0, "pro_no")
           })

        tblProgSQlDeleteCommand.Parameters.Add(New SqlParameter("@No", SqlDbType.VarChar, 0, "pro_no"))

        'Programs
        daTblProg.InsertCommand = tblProgSQInsertCommand
        daTblProg.UpdateCommand = tblProgSQlUpdateCommand
        daTblProg.DeleteCommand = tblProgSQlDeleteCommand
        daTblProg.Fill(ds, "T_programme")

        'Students
        daTblStud.Fill(ds, "T_etudiants")


        'Datagrid Programs 
        dgPrograms.AutoGenerateColumns = False

        dgPrograms.ColumnCount = 4

        dgPrograms.Columns(0).Name = "dgProgColNo"
        dgPrograms.Columns(0).HeaderText = "Program"
        dgPrograms.Columns(0).DataPropertyName = "pro_no"

        dgPrograms.Columns(1).Name = "dgProgColName"
        dgPrograms.Columns(1).HeaderText = "Name"
        dgPrograms.Columns(1).DataPropertyName = "pro_nom"

        dgPrograms.Columns(2).Name = "dgProgColUnits"
        dgPrograms.Columns(2).HeaderText = "Units"
        dgPrograms.Columns(2).DataPropertyName = "pro_nbr_unites"

        dgPrograms.Columns(3).Name = "dgProgColHours"
        dgPrograms.Columns(3).HeaderText = "Hours"
        dgPrograms.Columns(3).DataPropertyName = "pro_nbr_heures"

        dgPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Datagrid  ProgStud
        dgProgStud.AutoGenerateColumns = False

        dgProgStud.ColumnCount = 4

        dgProgStud.Columns(0).Name = "dgProgStudColDa"
        dgProgStud.Columns(0).HeaderText = "Da"
        dgProgStud.Columns(0).DataPropertyName = "etu_da"

        dgProgStud.Columns(1).Name = "dgProgStudColHours"
        dgProgStud.Columns(1).HeaderText = "Program"
        dgProgStud.Columns(1).DataPropertyName = "pro_no"

        dgProgStud.Columns(2).Name = "dgProgStudColFName"
        dgProgStud.Columns(2).HeaderText = "Family Name"
        dgProgStud.Columns(2).DataPropertyName = "etu_nom"

        dgProgStud.Columns(3).Name = "dgProgStudColName"
        dgProgStud.Columns(3).HeaderText = "Name"
        dgProgStud.Columns(3).DataPropertyName = "etu_prenom"

        dgProgStud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        bindSrcProg.DataSource = ds
        bindSrcProg.DataMember = "T_programme"

        bindSrcStud.DataSource = ds
        bindSrcStud.DataMember = "T_etudiants"

        mtbNo.DataBindings.Add(New Binding("Text", bindSrcProg, "pro_no", True))
        tbName.DataBindings.Add(New Binding("Text", bindSrcProg, "pro_nom", True))
        tbUnits.DataBindings.Add(New Binding("Text", bindSrcProg, "pro_nbr_unites", True))
        tbHours.DataBindings.Add(New Binding("Text", bindSrcProg, "pro_nbr_heures", True))


        dgPrograms.DataSource = bindSrcProg
        dgProgStud.DataSource = bindSrcStud


    End Sub

    Private Sub dgClients_SelectionChanged(sender As Object, e As EventArgs) Handles dgPrograms.SelectionChanged
        If dgPrograms.SelectedRows.Count > 0 Then
            If Not IsDBNull(dgPrograms.SelectedRows(0).Cells(0).Value) Then
                noPrograms = dgPrograms.SelectedRows(0).Cells(0).Value

                LoadStudents(noPrograms)
            End If
        End If
    End Sub

    Private Sub LoadStudents(no)
        bindSrcStud.Filter = String.Format("[pro_no] LIKE '%{0}%'", no)
    End Sub

    Private Function RowExists(proNo As String) As Boolean
        Dim rows() As DataRow = ds.Tables("T_programme").Select("pro_no = '" & proNo & "'")
        If rows.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Buttons Events
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        unlockControls(gbPrograms, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, dgPrograms, dgProgStud, btnFirst, btnLast, btnNext, btnPrev)
        btnOk.Tag = Action.Create

        bindSrcProg.AddNew()
        mtbNo.Focus()

        'bindSrcProg.RemoveFilter()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not validateForm() Then
            MessageBox.Show("One or many fields are wrong.")
            Exit Sub
        Else
            errProv.Clear()
        End If

        UpdateSource("T_programme")
        unlockControls(btnNew, btnRemove, btnModify, dgPrograms, dgProgStud, btnFirst, btnLast, btnNext, btnPrev)
        lockControls(gbPrograms, btnOk, btnCancel)
    End Sub

    Private Sub UpdateSource(tableName As String)
        Try
            bindSrcProg.EndEdit()
            daTblProg.Update(ds.Tables(tableName))
        Catch ex As Exception
            MsgBox("Something went wrong, see: " & ex.Message)
            bindSrcProg.CancelEdit()
            ds.Tables(tableName).RejectChanges()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bindSrcProg.CancelEdit()
        errProv.Clear()
        unlockControls(btnNew, btnRemove, btnModify, dgPrograms, dgProgStud, btnFirst, btnLast, btnNext, btnPrev)
        lockControls(gbPrograms, btnOk, btnCancel)
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        unlockControls(gbPrograms, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, dgPrograms, dgProgStud, btnFirst, btnLast, btnNext, btnPrev)
        btnOk.Tag = Action.Update
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg As String = "You're about to remove program " + mtbNo.Text + " " + tbName.Text + " from the system." +
                " Would you like to continue ?"
        Dim ans = MessageBox.Show(msg, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (ans = DialogResult.Yes) Then
            bindSrcProg.RemoveCurrent()


            UpdateSource("T_programme")
        End If
    End Sub

    'Buttons skips 
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        bindSrcProg.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        bindSrcProg.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bindSrcProg.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        bindSrcProg.MoveLast()
    End Sub

    'Validation - Server
    Private Function validateForm()
        Dim valid = True
        If RowExists(mtbNo.Text.Trim) Or Not mtbNo.MaskFull Or Not mtbNo.Text.Substring(0, 3) = "LEA" Then
            If Not btnOk.Tag = Action.Update Then
                valid = False
            End If
        End If
        If tbName.Text.Length < 4 Or tbName.Text.Length > 20 Then
            valid = False
        ElseIf Not Regex.IsMatch(tbName.Text, My.Settings.namePattern) Then
            valid = False
        End If
        If Not Regex.IsMatch(tbUnits.Text, My.Settings.unitsPattern) Then
            valid = False
        End If
        If Not Regex.IsMatch(tbHours.Text, My.Settings.hoursPattern) Then
            valid = False
        ElseIf CInt(tbHours.Text) > 3000 Or CInt(tbHours.Text) < 10 Then
            valid = False
        End If

        Return valid
    End Function




    'Validation - Client
    Private Sub mtbNo_Validated(sender As Object, e As EventArgs) Handles mtbNo.Validated
        If Not mtbNo.MaskFull Or Not mtbNo.Text.Substring(0, 3) = "LEA" Then
            errProv.SetError(mtbNo, "Program number must Start with 'LEA.' and include a number and a letter in that specific order ")
        ElseIf RowExists(mtbNo.Text.Trim) And Not btnOk.Tag = Action.Update Then
            errProv.SetError(mtbNo, mtbNo.Text + " Already exists")
        End If
    End Sub

    Private Sub mtbNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbNo.Validating
        If mtbNo.Text.Substring(0, 3) = "LEA" Then
            errProv.SetError(mtbNo, String.Empty)
        End If
    End Sub

    Private Sub tbName_Validated(sender As Object, e As EventArgs) Handles tbName.Validated
        If tbName.Text.Length < 4 Or tbName.Text.Length > 20 Then
            errProv.SetError(tbName, "Name must contain at between 4-20 characters.")
        ElseIf Not Regex.IsMatch(tbName.Text, My.Settings.namePattern) Then
            errProv.SetError(tbName, "Numbers and/or special characters are not being accepted as a valid program name.")
        End If
    End Sub

    Private Sub tbName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbName.Validating
        If Regex.IsMatch(tbName.Text, My.Settings.namePattern) Or tbName.Text.Length > 4 And tbName.Text.Length < 20 Then
            errProv.SetError(tbName, String.Empty)

        End If
    End Sub

    Private Sub tbUnits_Validated(sender As Object, e As EventArgs) Handles tbUnits.Validated
        If Not Regex.IsMatch(tbUnits.Text, My.Settings.unitsPattern) Then
            errProv.SetError(tbUnits, "Must follow a specific format 00.00 .Note that only .0, .00, .33, .66 are accepted as decimals.")
        End If
    End Sub

    Private Sub tbUnits_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbUnits.Validating
        If Regex.IsMatch(tbUnits.Text, My.Settings.unitsPattern) Then
            errProv.SetError(tbUnits, String.Empty)

        End If
    End Sub

    Private Sub tbHours_Validated(sender As Object, e As EventArgs) Handles tbHours.Validated
        If Not Regex.IsMatch(tbHours.Text, My.Settings.hoursPattern) Then
            errProv.SetError(tbHours, "Field format must include numbers of 1 to four digits. No '.', ',', '-', '`' allowed.")
        ElseIf CInt(tbHours.Text) > 3000 Or CInt(tbHours.Text) < 10 Then
            errProv.SetError(tbHours, "Duration must be between 10 and 3000 hours. No Decimals and/or special characters.")
        End If

    End Sub

    Private Sub tbHours_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbHours.Validating
        If Regex.IsMatch(tbUnits.Text, My.Settings.hoursPattern) Then
            errProv.SetError(tbName, String.Empty)

        End If
    End Sub


    'Private Function HasError() As Boolean
    '    Dim valid = False
    '    ' Check if any TextBox or MaskedTextBox has an error using the ErrorProvider control
    '    For Each textBox As Control In Me.Controls.OfType(Of TextBox)().Concat(Me.Controls.OfType(Of MaskedTextBox)())
    '        If errProv.GetError(textBox) <> "" Then
    '            valid = True
    '        ElseIf String.IsNullOrEmpty(textBox.Text) Then
    '            valid = True
    '        End If
    '    Next

    '    ' Return False if no errors are found
    '    Return valid
    'End Function

    ' Connection Close
    Private Sub FormPrograms_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        cn.Close()
    End Sub
End Class