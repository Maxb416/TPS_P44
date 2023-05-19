<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnNew = New Button()
        btnOk = New Button()
        btnCancel = New Button()
        btnModify = New Button()
        btnRemove = New Button()
        lblNoProg = New Label()
        lblCity = New Label()
        gbStudent = New GroupBox()
        grpGender = New GroupBox()
        rdoFema = New RadioButton()
        rdoMale = New RadioButton()
        mtbPhone = New MaskedTextBox()
        mtbZip = New MaskedTextBox()
        ddProvince = New ComboBox()
        tbCity = New TextBox()
        tbAddress = New TextBox()
        lblPhone = New Label()
        lblZip = New Label()
        lblProvince = New Label()
        Label5 = New Label()
        lblAddress = New Label()
        ddProg = New ComboBox()
        tbFam = New TextBox()
        tbName = New TextBox()
        mtbDa = New MaskedTextBox()
        lblFamName = New Label()
        lblName = New Label()
        dgStudents = New DataGridView()
        gbStudent.SuspendLayout()
        grpGender.SuspendLayout()
        CType(dgStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(1994, 47)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(250, 69)
        btnNew.TabIndex = 1
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Enabled = False
        btnOk.Location = New Point(1994, 122)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(250, 69)
        btnOk.TabIndex = 2
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Enabled = False
        btnCancel.Location = New Point(1994, 197)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(250, 69)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Location = New Point(1994, 272)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(250, 69)
        btnModify.TabIndex = 4
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.IndianRed
        btnRemove.Location = New Point(1994, 347)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(250, 69)
        btnRemove.TabIndex = 5
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' lblNoProg
        ' 
        lblNoProg.Location = New Point(6, 131)
        lblNoProg.Name = "lblNoProg"
        lblNoProg.Size = New Size(229, 50)
        lblNoProg.TabIndex = 4
        lblNoProg.Text = "No program:"
        lblNoProg.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblCity
        ' 
        lblCity.Location = New Point(6, 69)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(229, 50)
        lblCity.TabIndex = 0
        lblCity.Text = "Da:"
        lblCity.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' gbStudent
        ' 
        gbStudent.BackColor = SystemColors.ButtonFace
        gbStudent.Controls.Add(grpGender)
        gbStudent.Controls.Add(mtbPhone)
        gbStudent.Controls.Add(mtbZip)
        gbStudent.Controls.Add(ddProvince)
        gbStudent.Controls.Add(tbCity)
        gbStudent.Controls.Add(tbAddress)
        gbStudent.Controls.Add(lblPhone)
        gbStudent.Controls.Add(lblZip)
        gbStudent.Controls.Add(lblProvince)
        gbStudent.Controls.Add(Label5)
        gbStudent.Controls.Add(lblAddress)
        gbStudent.Controls.Add(ddProg)
        gbStudent.Controls.Add(tbFam)
        gbStudent.Controls.Add(tbName)
        gbStudent.Controls.Add(mtbDa)
        gbStudent.Controls.Add(lblFamName)
        gbStudent.Controls.Add(lblName)
        gbStudent.Controls.Add(lblNoProg)
        gbStudent.Controls.Add(lblCity)
        gbStudent.Enabled = False
        gbStudent.ForeColor = SystemColors.ActiveCaptionText
        gbStudent.Location = New Point(37, 23)
        gbStudent.Name = "gbStudent"
        gbStudent.Size = New Size(1914, 605)
        gbStudent.TabIndex = 5
        gbStudent.TabStop = False
        gbStudent.Text = "Students"
        ' 
        ' grpGender
        ' 
        grpGender.BackColor = SystemColors.ButtonFace
        grpGender.Controls.Add(rdoFema)
        grpGender.Controls.Add(rdoMale)
        grpGender.Location = New Point(253, 341)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(381, 216)
        grpGender.TabIndex = 21
        grpGender.TabStop = False
        grpGender.Text = "Gender"
        ' 
        ' rdoFema
        ' 
        rdoFema.AutoSize = True
        rdoFema.Location = New Point(33, 123)
        rdoFema.Name = "rdoFema"
        rdoFema.Size = New Size(160, 45)
        rdoFema.TabIndex = 1
        rdoFema.TabStop = True
        rdoFema.Text = "Feminin"
        rdoFema.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(33, 64)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(188, 45)
        rdoMale.TabIndex = 0
        rdoMale.TabStop = True
        rdoMale.Text = "Masculine"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' mtbPhone
        ' 
        mtbPhone.Location = New Point(1172, 309)
        mtbPhone.Mask = "(999) 000-0000"
        mtbPhone.Name = "mtbPhone"
        mtbPhone.Size = New Size(374, 47)
        mtbPhone.TabIndex = 20
        ' 
        ' mtbZip
        ' 
        mtbZip.Location = New Point(1172, 252)
        mtbZip.Mask = ">L0L-0L0"
        mtbZip.Name = "mtbZip"
        mtbZip.Size = New Size(265, 47)
        mtbZip.TabIndex = 19
        ' 
        ' ddProvince
        ' 
        ddProvince.FormattingEnabled = True
        ddProvince.Location = New Point(1172, 190)
        ddProvince.Name = "ddProvince"
        ddProvince.Size = New Size(408, 49)
        ddProvince.TabIndex = 18
        ' 
        ' tbCity
        ' 
        tbCity.Location = New Point(1172, 130)
        tbCity.Name = "tbCity"
        tbCity.Size = New Size(525, 47)
        tbCity.TabIndex = 17
        ' 
        ' tbAddress
        ' 
        tbAddress.Location = New Point(1172, 69)
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New Size(686, 47)
        tbAddress.TabIndex = 16
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(961, 302)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(205, 50)
        lblPhone.TabIndex = 15
        lblPhone.Text = "Phone:"
        lblPhone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblZip
        ' 
        lblZip.Location = New Point(961, 247)
        lblZip.Name = "lblZip"
        lblZip.Size = New Size(205, 50)
        lblZip.TabIndex = 14
        lblZip.Text = "Zip:"
        lblZip.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProvince
        ' 
        lblProvince.Location = New Point(961, 184)
        lblProvince.Name = "lblProvince"
        lblProvince.Size = New Size(205, 50)
        lblProvince.TabIndex = 13
        lblProvince.Text = "Province:"
        lblProvince.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(961, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 50)
        Label5.TabIndex = 12
        Label5.Text = "City:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblAddress
        ' 
        lblAddress.Location = New Point(961, 63)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(205, 50)
        lblAddress.TabIndex = 11
        lblAddress.Text = "Address:"
        lblAddress.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ddProg
        ' 
        ddProg.FormattingEnabled = True
        ddProg.Location = New Point(252, 132)
        ddProg.Name = "ddProg"
        ddProg.Size = New Size(302, 49)
        ddProg.TabIndex = 10
        ' 
        ' tbFam
        ' 
        tbFam.Location = New Point(253, 251)
        tbFam.Name = "tbFam"
        tbFam.Size = New Size(686, 47)
        tbFam.TabIndex = 9
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(253, 192)
        tbName.Name = "tbName"
        tbName.Size = New Size(686, 47)
        tbName.TabIndex = 8
        ' 
        ' mtbDa
        ' 
        mtbDa.Enabled = False
        mtbDa.Location = New Point(253, 72)
        mtbDa.Name = "mtbDa"
        mtbDa.Size = New Size(369, 47)
        mtbDa.TabIndex = 7
        ' 
        ' lblFamName
        ' 
        lblFamName.Location = New Point(6, 247)
        lblFamName.Name = "lblFamName"
        lblFamName.Size = New Size(229, 50)
        lblFamName.TabIndex = 6
        lblFamName.Text = "Family Name:"
        lblFamName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(6, 189)
        lblName.Name = "lblName"
        lblName.Size = New Size(229, 50)
        lblName.TabIndex = 5
        lblName.Text = "Name:"
        lblName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dgStudents
        ' 
        dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStudents.Location = New Point(37, 655)
        dgStudents.Name = "dgStudents"
        dgStudents.RowHeadersWidth = 102
        dgStudents.RowTemplate.Height = 49
        dgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgStudents.Size = New Size(2207, 732)
        dgStudents.TabIndex = 6
        ' 
        ' FormStudents
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(2280, 1415)
        Controls.Add(gbStudent)
        Controls.Add(dgStudents)
        Controls.Add(btnRemove)
        Controls.Add(btnModify)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(btnNew)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormStudents"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormPrograms"
        gbStudent.ResumeLayout(False)
        gbStudent.PerformLayout()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        CType(dgStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnNew As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents gbStudent As GroupBox
    Friend WithEvents mtbDa As MaskedTextBox
    Friend WithEvents lblFamName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents ddProg As ComboBox
    Friend WithEvents tbFam As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rdoFema As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents mtbZip As MaskedTextBox
    Friend WithEvents ddProvince As ComboBox
    Friend WithEvents dgStudents As DataGridView
End Class
