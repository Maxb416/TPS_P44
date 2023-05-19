Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient


Public Class FormStudents
    Private studentDa As Integer
    Dim action As Action
    Private sqlCmd As SqlCommand
    Dim errProv As New ErrorProvider()


    Dim ds As New DataSet("tp_p44")
    Dim cn As New SqlConnection(My.Settings.ConnectionString)

    'Queries Students
    Dim tblStudSQlSelectCommand As New SqlCommand("SELECT * FROM T_etudiants", cn)
    Dim tblStudSQInsertCommand As New SqlCommand("INSERT INTO T_etudiants (etu_da, pro_no, etu_nom, etu_prenom, etu_sexe,
        etu_adresse, etu_ville, etu_province, etu_telephone, etu_codepostal) VALUES (@Da, @No, @FName, @Name, @Gender,
        @Address, @City, @Province, @Phone, @Zip)", cn)
    Dim tblStudSQlUpdateCommand As New SqlCommand("UPDATE T_etudiants Set pro_no=@No, etu_nom=@Fname, etu_prenom=@Name, 
        etu_sexe=@Gender, etu_adresse=@Address, etu_ville=@City, etu_province=@Province, etu_telephone=@Phone, 
        etu_codepostal=@Zip WHERE etu_da=@Da", cn)
    Dim tblStudSQlDeleteCommand As New SqlCommand("DELETE FROM T_etudiants WHERE etu_da = @Da", cn)
    Dim daTblStudent As New SqlDataAdapter(tblStudSQlSelectCommand)
    Dim bindSrcStudent As New BindingSource()



    Dim tblProgSQlSelectCommand As New SqlCommand("SELECT * FROM T_programme", cn)
    Dim daTblProg As New SqlDataAdapter(tblProgSQlSelectCommand)
    Dim bindSrcProg As New BindingSource()


    Private Sub FormStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tblStudSQInsertCommand.Parameters.AddRange(New SqlParameter() _
           {
               New SqlParameter("@Da", SqlDbType.VarChar, 0, "etu_da"),
               New SqlParameter("@No", SqlDbType.VarChar, 0, "pro_no"),
               New SqlParameter("@FName", SqlDbType.VarChar, 0, "etu_nom"),
               New SqlParameter("@Name", SqlDbType.NChar, 0, "etu_prenom"),
               New SqlParameter("@Gender", IIf(rdoMale.Checked, "M", "F")),
               New SqlParameter("@Address", SqlDbType.VarChar, 0, "etu_adresse"),
               New SqlParameter("@City", SqlDbType.VarChar, 0, "etu_ville"),
               New SqlParameter("@Province", SqlDbType.NChar, 0, "etu_province"),
               New SqlParameter("@Phone", SqlDbType.VarChar, 0, "etu_telephone"),
               New SqlParameter("@Zip", SqlDbType.VarChar, 0, "etu_codepostal")
           })

        tblStudSQlUpdateCommand.Parameters.AddRange(New SqlParameter() _
           {
               New SqlParameter("@No", SqlDbType.VarChar, 0, "pro_no"),
               New SqlParameter("@FName", SqlDbType.VarChar, 0, "etu_nom"),
               New SqlParameter("@Name", SqlDbType.NChar, 0, "etu_prenom"),
               New SqlParameter("@Gender", SqlDbType.VarChar, 0, "etu_sexe"),
               New SqlParameter("@Address", SqlDbType.VarChar, 0, "etu_adresse"),
               New SqlParameter("@City", SqlDbType.VarChar, 0, "etu_ville"),
               New SqlParameter("@Province", SqlDbType.NChar, 0, "etu_province"),
               New SqlParameter("@Phone", SqlDbType.VarChar, 0, "etu_telephone"),
               New SqlParameter("@Zip", SqlDbType.VarChar, 0, "etu_codepostal"),
               New SqlParameter("@Da", SqlDbType.VarChar, 0, "etu_da")
           })

        tblStudSQlDeleteCommand.Parameters.Add(New SqlParameter("@Da", SqlDbType.VarChar, 0, "etu_da"))

        daTblStudent.InsertCommand = tblStudSQInsertCommand
        daTblStudent.DeleteCommand = tblStudSQlDeleteCommand
        daTblStudent.UpdateCommand = tblStudSQlUpdateCommand

        daTblStudent.Fill(ds, "T_etudiants")
        daTblProg.Fill(ds, "T_programme")

        'Datagrid Students
        dgStudents.AutoGenerateColumns = False

        dgStudents.ColumnCount = 10

        dgStudents.Columns(0).Name = "dgStudentColDa"
        dgStudents.Columns(0).HeaderText = "Da"
        dgStudents.Columns(0).DataPropertyName = "etu_da"

        dgStudents.Columns(1).Name = "dgStudentColPro"
        dgStudents.Columns(1).HeaderText = "Program"
        dgStudents.Columns(1).DataPropertyName = "pro_no"

        dgStudents.Columns(2).Name = "dgStudentColFName"
        dgStudents.Columns(2).HeaderText = "Family Name"
        dgStudents.Columns(2).DataPropertyName = "etu_nom"

        dgStudents.Columns(3).Name = "dgStudentColName"
        dgStudents.Columns(3).HeaderText = "Name"
        dgStudents.Columns(3).DataPropertyName = "etu_prenom"

        dgStudents.Columns(4).Name = "dgStudentColGender"
        dgStudents.Columns(4).HeaderText = "Gender"
        dgStudents.Columns(4).DataPropertyName = "etu_sexe"

        dgStudents.Columns(5).Name = "dgStudentColAddress"
        dgStudents.Columns(5).HeaderText = "Address"
        dgStudents.Columns(5).DataPropertyName = "etu_adresse"

        dgStudents.Columns(6).Name = "dgStudentColCity"
        dgStudents.Columns(6).HeaderText = "City"
        dgStudents.Columns(6).DataPropertyName = "etu_ville"

        dgStudents.Columns(7).Name = "dgStudentColProvince"
        dgStudents.Columns(7).HeaderText = "Province/Teritory"
        dgStudents.Columns(7).DataPropertyName = "etu_province"

        dgStudents.Columns(8).Name = "dgStudentColPhone"
        dgStudents.Columns(8).HeaderText = "Phone"
        dgStudents.Columns(8).DataPropertyName = "etu_telephone"

        dgStudents.Columns(9).Name = "dgStudentColZip"
        dgStudents.Columns(9).HeaderText = "Zip"
        dgStudents.Columns(9).DataPropertyName = "etu_codepostal"


        bindSrcStudent.DataSource = ds
        bindSrcStudent.DataMember = "T_etudiants"

        bindSrcProg.DataSource = ds
        bindSrcProg.DataMember = "T_programme"


        mtbDa.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_da", True))
        tbName.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_nom", True))
        tbFam.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_prenom", True))
        tbAddress.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_adresse", True))
        tbCity.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_ville", True))
        mtbZip.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_codepostal", True))
        mtbPhone.DataBindings.Add(New Binding("Text", bindSrcStudent, "etu_telephone", True))

        ' Combo 
        Dim bindSrcProvinces As New BindingSource()
        bindSrcProvinces.DataSource = provinces

        ' Set the properties for the province combo box
        ddProvince.DataSource = bindSrcProvinces

        ' Bind the SelectedValue property of the second combo box
        ddProvince.DataBindings.Add(New Binding("SelectedValue", bindSrcStudent, "etu_province", True))

        'Combo
        ddProg.DisplayMember = "pro_no" 'pro_no
        ddProg.ValueMember = "pro_no"
        ddProg.DataSource = bindSrcProg
        ddProg.DataBindings.Add(New Binding("SelectedValue", bindSrcStudent, "pro_no", True))

        ' Radio
        ' Subscribe to the PositionChanged event of the BindingSource
        AddHandler bindSrcStudent.PositionChanged, AddressOf bindSrcStudent_PositionChanged
        bindSrcStudent_PositionChanged(sender, e)

        dgStudents.DataSource = bindSrcStudent

    End Sub

    Dim provinces As New List(Of String) From {
        "-- Select one --",
        "Québec",
        "Ontario",
        "Terre-Neuve-et-Labrador",
        "Alberta",
        "Saskatchewan",
        "Manitoba",
        "Colombie-Britannique",
        "Nouvelle-Écosse",
        "Nouveau-Brunswick",
        "Île-du-Prince-Édouard"
    }

    ' Handle positionChanged of the DataGridView
    Private Sub bindSrcStudent_PositionChanged(sender As Object, e As EventArgs)
        Dim currentRow As DataRowView = DirectCast(bindSrcStudent.Current, DataRowView)
        Dim gender As String = currentRow("etu_sexe").ToString()


        ' Update the radio buttons based on the gender value
        If gender = "M" Then
            rdoMale.Checked = True
        ElseIf gender = "F" Then
            rdoFema.Checked = True
        End If

        ' Update the selected value of the ComboBox
        Dim province As String = currentRow("etu_province").ToString()
        ddProvince.SelectedItem = province
    End Sub

    ' Handle the CheckedChanged event of rdoMale
    Private Sub rdoMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMale.CheckedChanged
        If rdoMale.Checked Then
            UpdateGenderInDataRow("M")
        End If
    End Sub

    ' Handle the CheckedChanged event of rdoFemale
    Private Sub rdoFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFema.CheckedChanged
        If rdoFema.Checked Then
            UpdateGenderInDataRow("F")
        End If
    End Sub

    ' Update the "etu_sexe" column in the data row of the current item in the BindingSource
    Private Sub UpdateGenderInDataRow(gender As String)
        Dim currentRow As DataRowView = DirectCast(bindSrcStudent.Current, DataRowView)
        currentRow("etu_sexe") = gender
    End Sub



    Private Sub dataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        If dgStudents.SelectedRows.Count > 0 Then
            Dim selectedProvince As String = dgStudents.SelectedRows(0).Cells("etu_province").Value.ToString()
            ddProvince.SelectedItem = selectedProvince
        End If
    End Sub


    Private Sub dgStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgStudents.SelectionChanged
        If dgStudents.SelectedRows.Count > 0 Then
            If Not IsDBNull(dgStudents.SelectedRows(0).Cells(0).Value) Then
                studentDa = dgStudents.SelectedRows(0).Cells(0).Value

            End If
        End If
    End Sub


    'Buttons Event
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        unlockControls(gbStudent, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, dgStudents)


        bindSrcStudent.AddNew()
        mtbDa.Text = GetIncrementedValue()
        rdoFema.Checked = False
        rdoMale.Checked = False

        ddProg.Focus()
    End Sub

    Function GetIncrementedValue() As Integer
        Try
            cn.Open()
            sqlCmd = New SqlCommand("SELECT TOP 1 etu_da FROM T_etudiants ORDER BY etu_da DESC", cn)
            Dim result As Object = sqlCmd.ExecuteScalar()

            Return CInt(result) + 1
        Catch ex As Exception
            MessageBox.Show("Something went wrong, please try again later..")
        Finally
            cn.Close()
        End Try

    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not validateForm() Then
            MessageBox.Show("One or many fields are wrong.")
            Exit Sub
        Else
            errProv.Clear()
        End If

        UpdateSource("T_etudiants")
        unlockControls(btnNew, btnRemove, btnModify, dgStudents)
        lockControls(btnOk, btnCancel, gbStudent)
    End Sub

    Private Sub UpdateSource(tableName As String)
        Try
            bindSrcStudent.EndEdit()
            daTblStudent.Update(ds.Tables(tableName))
        Catch ex As Exception
            MsgBox("Something went wrong, see: " & ex.Message)
            bindSrcStudent.CancelEdit()
            ds.Tables(tableName).RejectChanges()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bindSrcStudent.CancelEdit()
        errProv.Clear()
        unlockControls(btnNew, btnRemove, btnModify, dgStudents)
        lockControls(gbStudent, btnOk, btnCancel)
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        unlockControls(gbStudent, btnOk, btnCancel)
        lockControls(btnNew, btnRemove, btnModify, dgStudents)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim msg As String = "You're about to remove student " + tbFam.Text + " " + tbName.Text + " from the system." +
                " Would you like to continue ?"
        Dim ans = MessageBox.Show(msg, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (ans = DialogResult.Yes) Then
            bindSrcStudent.RemoveCurrent()
            UpdateSource("T_etudiants")
        End If
    End Sub



    'Validation  - Server 
    Private Function validateForm() As Boolean
        Dim valid = True

        If ddProg.SelectedIndex = -1 Then
            valid = False
        End If
        If tbName.Text.Length < 2 Or tbName.Text.Length > 20 Then
            valid = False
        ElseIf Not Regex.IsMatch(tbName.Text, My.Settings.namePattern) Then
            valid = False
        End If
        If tbFam.Text.Length < 2 Or tbFam.Text.Length > 20 Then
            valid = False
        ElseIf Not Regex.IsMatch(tbFam.Text, My.Settings.namePattern) Then
            valid = False
        End If
        If Not rdoMale.Checked And Not rdoFema.Checked Then
            valid = False
        End If
        If tbAddress.Text.Length < 4 Or tbAddress.Text.Length > 100 Then
            valid = False
        ElseIf Not Regex.IsMatch(tbAddress.Text, My.Settings.addressPattern) Then
            valid = False
        End If
        If tbCity.Text.Length < 2 Or tbCity.Text.Length > 50 Then
            valid = False
        ElseIf Not Regex.IsMatch(tbCity.Text, My.Settings.cityPattern) Then
            valid = False
        End If
        If ddProvince.SelectedIndex = 0 Then
            valid = False
        End If
        If Not mtbZip.MaskFull Then
            valid = False
        End If
        If Not mtbPhone.MaskFull Then
            valid = False
        End If

        Return valid
    End Function

    'Validation - Client
    Private Sub ddProg_Validated(sender As Object, e As EventArgs) Handles ddProg.Validated
        If ddProg.SelectedIndex = -1 Then
            errProv.SetError(ddProg, "You must select one of the following options")
        End If
    End Sub

    Private Sub ddProg_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ddProg.Validating
        If ddProg.SelectedIndex >= 0 Then
            errProv.SetError(ddProg, String.Empty)
        End If
    End Sub

    Private Sub tbName_Validated(sender As Object, e As EventArgs) Handles tbName.Validated
        If tbName.Text.Length < 2 Or tbName.Text.Length > 20 Then
            errProv.SetError(tbName, "Name must contain between 2-20 characters")
        ElseIf Not Regex.IsMatch(tbName.Text, My.Settings.namePattern) Then
            errProv.SetError(tbName, "Numbers and/or special characters are not being accepted as a valid option.")
        End If
    End Sub

    Private Sub tbName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbName.Validating
        If tbName.Text.Length > 2 Or tbName.Text.Length < 20 And Regex.IsMatch(tbName.Text, My.Settings.namePattern) Then
            errProv.SetError(tbName, String.Empty)
        End If
    End Sub

    Private Sub tbFam_Validated(sender As Object, e As EventArgs) Handles tbFam.Validated
        If tbFam.Text.Length < 2 Or tbFam.Text.Length > 20 Then
            errProv.SetError(tbFam, "Name must contain between 2-20 characters")
        ElseIf Not Regex.IsMatch(tbFam.Text, My.Settings.namePattern) Then
            errProv.SetError(tbFam, "Numbers and/or special characters are not being accepted as a valid option.")
        End If
    End Sub

    Private Sub tbFam_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbFam.Validating
        If tbFam.Text.Length > 2 Or tbFam.Text.Length < 20 And Regex.IsMatch(tbFam.Text, My.Settings.namePattern) Then
            errProv.SetError(tbFam, String.Empty)
        End If
    End Sub
    Private Sub grpGender_Validated(sender As Object, e As EventArgs) Handles grpGender.Validated
        If Not rdoMale.Checked And Not rdoFema.Checked Then
            errProv.SetError(grpGender, "You must pick one of two gender")
        End If
    End Sub
    Private Sub grpGender_Validating(sender As Object, e As CancelEventArgs) Handles grpGender.Validating
        If rdoMale.Checked Or rdoFema.Checked Then
            errProv.SetError(grpGender, String.Empty)
        End If
    End Sub
    Private Sub tbAddress_Validated(sender As Object, e As EventArgs) Handles tbAddress.Validated
        If tbAddress.Text.Length < 4 Or tbAddress.Text.Length > 100 Then
            errProv.SetError(tbAddress, "Address must be between 2-100 characters long.")
        ElseIf Not Regex.IsMatch(tbAddress.Text, My.Settings.addressPattern) Then
            errProv.SetError(tbAddress, "Numbers and/or special characters are not being accepted as a valid option.")
        End If
    End Sub

    Private Sub tbAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbAddress.Validating
        If tbAddress.Text.Length > 4 Or tbAddress.Text.Length < 100 And Regex.IsMatch(tbAddress.Text, My.Settings.addressPattern) Then
            errProv.SetError(tbAddress, String.Empty)
        End If
    End Sub

    Private Sub tbCity_Validated(sender As Object, e As EventArgs) Handles tbCity.Validated
        If tbCity.Text.Length < 2 Or tbCity.Text.Length > 50 Then
            errProv.SetError(tbCity, "City must be between 2-50 characters long.")
        ElseIf Not Regex.IsMatch(tbCity.Text, My.Settings.cityPattern) Then
            errProv.SetError(tbCity, "Numbers and/or special characters are not being accepted as a valid option.")
        End If
    End Sub

    Private Sub tbCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCity.Validating
        If tbCity.Text.Length > 2 Or tbCity.Text.Length < 50 And Regex.IsMatch(tbCity.Text, My.Settings.cityPattern) Then
            errProv.SetError(tbCity, String.Empty)
        End If
    End Sub

    Private Sub ddProvince_Validated(sender As Object, e As EventArgs) Handles ddProvince.Validated
        If ddProvince.SelectedIndex = 0 Then
            errProv.SetError(ddProvince, "You must select one of the following options.")
        End If
    End Sub

    Private Sub ddProvince_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ddProvince.Validating
        If ddProvince.SelectedIndex > 0 Then
            errProv.SetError(ddProvince, String.Empty)
        End If
    End Sub

    Private Sub mtbZip_Validated(sender As Object, e As EventArgs) Handles mtbZip.Validated
        If Not mtbZip.MaskFull Then
            errProv.SetError(mtbZip, "must be set as follow L1L-1L1.")
        End If
    End Sub

    Private Sub mtbZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbZip.Validating
        If mtbZip.MaskFull Then
            errProv.SetError(mtbZip, String.Empty)
        End If
    End Sub

    Private Sub mtbPhone_Validated(sender As Object, e As EventArgs) Handles mtbPhone.Validated
        If Not mtbPhone.MaskFull Then
            errProv.SetError(mtbPhone, "must be set as follow (111) 111-1111.")
        End If
    End Sub

    Private Sub mtbPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbPhone.Validating
        If mtbPhone.MaskFull Then
            errProv.SetError(mtbPhone, String.Empty)
        End If
    End Sub

    ' Connection Close
    Private Sub FormStudents_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        cn.Close()
    End Sub

End Class