<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        lvStudentsInfo = New ListView()
        colDa = New ColumnHeader()
        colNoProg = New ColumnHeader()
        colName = New ColumnHeader()
        colFamName = New ColumnHeader()
        colGender = New ColumnHeader()
        colAddress = New ColumnHeader()
        colCity = New ColumnHeader()
        colProv = New ColumnHeader()
        colPhone = New ColumnHeader()
        colZip = New ColumnHeader()
        TableLayoutPanel2 = New TableLayoutPanel()
        grpBoxStudents = New GroupBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        lblAddress = New Label()
        lblCity = New Label()
        lblProvince = New Label()
        lblZip = New Label()
        lblPhone = New Label()
        txtAddress = New TextBox()
        TableLayoutPanel10 = New TableLayoutPanel()
        mtbZip = New MaskedTextBox()
        mtbPhone = New MaskedTextBox()
        txtCity = New TextBox()
        TableLayoutPanel11 = New TableLayoutPanel()
        cboProvince = New ComboBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblDa = New Label()
        lblNoProg = New Label()
        lblName = New Label()
        lblFName = New Label()
        txtFamName = New TextBox()
        txtName = New TextBox()
        grpBoxGender = New GroupBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        rdoMale = New RadioButton()
        rdoFemale = New RadioButton()
        TableLayoutPanel7 = New TableLayoutPanel()
        mtbDa = New MaskedTextBox()
        TableLayoutPanel8 = New TableLayoutPanel()
        mtbNoProg = New MaskedTextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnNew = New Button()
        btnOk = New Button()
        btnCancel = New Button()
        btnModify = New Button()
        btnRemove = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        grpBoxStudents.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        grpBoxGender.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(lvStudentsInfo, 1, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(2618, 1570)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lvStudentsInfo
        ' 
        lvStudentsInfo.Columns.AddRange(New ColumnHeader() {colDa, colNoProg, colName, colFamName, colGender, colAddress, colCity, colProv, colPhone, colZip})
        TableLayoutPanel1.SetColumnSpan(lvStudentsInfo, 2)
        lvStudentsInfo.Dock = DockStyle.Fill
        lvStudentsInfo.FullRowSelect = True
        lvStudentsInfo.GridLines = True
        lvStudentsInfo.Location = New Point(23, 635)
        lvStudentsInfo.MultiSelect = False
        lvStudentsInfo.Name = "lvStudentsInfo"
        lvStudentsInfo.Size = New Size(2572, 912)
        lvStudentsInfo.TabIndex = 0
        lvStudentsInfo.UseCompatibleStateImageBehavior = False
        lvStudentsInfo.View = View.Details
        ' 
        ' colDa
        ' 
        colDa.Text = "DA"' 
        ' colNoProg
        ' 
        colNoProg.Text = "No Prog."' 
        ' colName
        ' 
        colName.Text = "Name"' 
        ' colFamName
        ' 
        colFamName.Text = "Family name"' 
        ' colGender
        ' 
        colGender.Text = "Gender"' 
        ' colAddress
        ' 
        colAddress.Text = "Address"' 
        ' colCity
        ' 
        colCity.Text = "City"' 
        ' colProv
        ' 
        colProv.DisplayIndex = 9
        colProv.Text = "Province"' 
        ' colPhone
        ' 
        colPhone.Text = "Phone"' 
        ' colZip
        ' 
        colZip.DisplayIndex = 7
        colZip.Text = "Zip"' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel1.SetColumnSpan(TableLayoutPanel2, 2)
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel2.Controls.Add(grpBoxStudents, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(23, 23)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(2572, 606)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' grpBoxStudents
        ' 
        grpBoxStudents.Controls.Add(TableLayoutPanel4)
        grpBoxStudents.Dock = DockStyle.Fill
        grpBoxStudents.Enabled = False
        grpBoxStudents.Location = New Point(3, 3)
        grpBoxStudents.Name = "grpBoxStudents"
        grpBoxStudents.Size = New Size(2180, 600)
        grpBoxStudents.TabIndex = 0
        grpBoxStudents.TabStop = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel9, 1, 0)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 43)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(2174, 554)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 4
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 250F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 69.40063F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.59937F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 196F))
        TableLayoutPanel9.Controls.Add(lblAddress, 0, 0)
        TableLayoutPanel9.Controls.Add(lblCity, 0, 1)
        TableLayoutPanel9.Controls.Add(lblProvince, 0, 2)
        TableLayoutPanel9.Controls.Add(lblZip, 0, 3)
        TableLayoutPanel9.Controls.Add(lblPhone, 0, 4)
        TableLayoutPanel9.Controls.Add(txtAddress, 1, 0)
        TableLayoutPanel9.Controls.Add(TableLayoutPanel10, 1, 3)
        TableLayoutPanel9.Controls.Add(mtbPhone, 1, 4)
        TableLayoutPanel9.Controls.Add(txtCity, 1, 1)
        TableLayoutPanel9.Controls.Add(TableLayoutPanel11, 1, 2)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(1090, 3)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 6
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 13.7517786F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 13.7517786F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 13.7517786F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 13.7517786F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 13.747654F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 31.2452316F))
        TableLayoutPanel9.Size = New Size(1081, 548)
        TableLayoutPanel9.TabIndex = 1
        ' 
        ' lblAddress
        ' 
        lblAddress.Location = New Point(3, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(241, 50)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address :"
        lblAddress.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblCity
        ' 
        lblCity.Location = New Point(3, 75)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(241, 53)
        lblCity.TabIndex = 4
        lblCity.Text = "City :"
        lblCity.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblProvince
        ' 
        lblProvince.Location = New Point(3, 150)
        lblProvince.Name = "lblProvince"
        lblProvince.Size = New Size(241, 50)
        lblProvince.TabIndex = 5
        lblProvince.Text = "Province :"
        lblProvince.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblZip
        ' 
        lblZip.Location = New Point(3, 225)
        lblZip.Name = "lblZip"
        lblZip.Size = New Size(241, 48)
        lblZip.TabIndex = 6
        lblZip.Text = "Zip : "
        lblZip.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(3, 300)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(244, 55)
        lblPhone.TabIndex = 7
        lblPhone.Text = "Phone :"
        lblPhone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtAddress
        ' 
        TableLayoutPanel9.SetColumnSpan(txtAddress, 3)
        txtAddress.Dock = DockStyle.Left
        txtAddress.Location = New Point(253, 3)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(795, 47)
        txtAddress.TabIndex = 6
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.4746552F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 58.5253448F))
        TableLayoutPanel10.Controls.Add(mtbZip, 0, 0)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(253, 228)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel10.Size = New Size(434, 69)
        TableLayoutPanel10.TabIndex = 7
        ' 
        ' mtbZip
        ' 
        mtbZip.Dock = DockStyle.Fill
        mtbZip.Location = New Point(3, 3)
        mtbZip.Mask = ">L0L-0L0"
        mtbZip.Name = "mtbZip"
        mtbZip.Size = New Size(174, 47)
        mtbZip.TabIndex = 9
        ' 
        ' mtbPhone
        ' 
        mtbPhone.Dock = DockStyle.Fill
        mtbPhone.Location = New Point(253, 303)
        mtbPhone.Mask = "(999) 000-0000"
        mtbPhone.Name = "mtbPhone"
        mtbPhone.Size = New Size(434, 47)
        mtbPhone.TabIndex = 10
        ' 
        ' txtCity
        ' 
        TableLayoutPanel9.SetColumnSpan(txtCity, 2)
        txtCity.Dock = DockStyle.Fill
        txtCity.Location = New Point(253, 78)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(628, 47)
        txtCity.TabIndex = 7
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 2
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 98.1566849F))
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1.843318F))
        TableLayoutPanel11.Controls.Add(cboProvince, 0, 0)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(253, 153)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 1
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel11.Size = New Size(434, 69)
        TableLayoutPanel11.TabIndex = 6
        ' 
        ' cboProvince
        ' 
        cboProvince.Dock = DockStyle.Fill
        cboProvince.DropDownStyle = ComboBoxStyle.DropDownList
        cboProvince.Location = New Point(3, 3)
        cboProvince.Name = "cboProvince"
        cboProvince.Size = New Size(420, 49)
        cboProvince.TabIndex = 8
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 250F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.8353577F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 58.1646423F))
        TableLayoutPanel5.Controls.Add(lblDa, 0, 0)
        TableLayoutPanel5.Controls.Add(lblNoProg, 0, 1)
        TableLayoutPanel5.Controls.Add(lblName, 0, 2)
        TableLayoutPanel5.Controls.Add(lblFName, 0, 3)
        TableLayoutPanel5.Controls.Add(txtFamName, 1, 3)
        TableLayoutPanel5.Controls.Add(txtName, 1, 2)
        TableLayoutPanel5.Controls.Add(grpBoxGender, 1, 4)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel7, 1, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel8, 1, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 6
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2842894F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2842846F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2842846F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2842846F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 42.862854F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(1081, 548)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' lblDa
        ' 
        lblDa.Location = New Point(3, 0)
        lblDa.Name = "lblDa"
        lblDa.Size = New Size(241, 50)
        lblDa.TabIndex = 2
        lblDa.Text = "DA :"
        lblDa.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNoProg
        ' 
        lblNoProg.Location = New Point(3, 75)
        lblNoProg.Name = "lblNoProg"
        lblNoProg.Size = New Size(241, 53)
        lblNoProg.TabIndex = 3
        lblNoProg.Text = "No program :"
        lblNoProg.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(3, 150)
        lblName.Name = "lblName"
        lblName.Size = New Size(241, 50)
        lblName.TabIndex = 4
        lblName.Text = "Name :"
        lblName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFName
        ' 
        lblFName.Location = New Point(3, 225)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(241, 48)
        lblFName.TabIndex = 5
        lblFName.Text = "Family Name : "
        lblFName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtFamName
        ' 
        TableLayoutPanel5.SetColumnSpan(txtFamName, 2)
        txtFamName.Dock = DockStyle.Left
        txtFamName.Location = New Point(253, 228)
        txtFamName.Name = "txtFamName"
        txtFamName.Size = New Size(790, 47)
        txtFamName.TabIndex = 3
        ' 
        ' txtName
        ' 
        TableLayoutPanel5.SetColumnSpan(txtName, 2)
        txtName.Dock = DockStyle.Left
        txtName.Location = New Point(253, 153)
        txtName.Name = "txtName"
        txtName.Size = New Size(790, 47)
        txtName.TabIndex = 2
        ' 
        ' grpBoxGender
        ' 
        grpBoxGender.Controls.Add(TableLayoutPanel6)
        grpBoxGender.Dock = DockStyle.Fill
        grpBoxGender.Location = New Point(253, 303)
        grpBoxGender.Name = "grpBoxGender"
        grpBoxGender.Size = New Size(341, 220)
        grpBoxGender.TabIndex = 6
        grpBoxGender.TabStop = False
        grpBoxGender.Text = "Gender"' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(rdoMale, 0, 1)
        TableLayoutPanel6.Controls.Add(rdoFemale, 0, 2)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 43)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 4
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 5F))
        TableLayoutPanel6.Size = New Size(335, 174)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Dock = DockStyle.Fill
        rdoMale.Location = New Point(3, 8)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(329, 76)
        rdoMale.TabIndex = 4
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Dock = DockStyle.Fill
        rdoFemale.Location = New Point(3, 90)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(329, 76)
        rdoFemale.TabIndex = 5
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel7.Controls.Add(mtbDa, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(253, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(341, 69)
        TableLayoutPanel7.TabIndex = 7
        ' 
        ' mtbDa
        ' 
        mtbDa.Dock = DockStyle.Fill
        mtbDa.Enabled = False
        mtbDa.Location = New Point(3, 3)
        mtbDa.Mask = "0000000"
        mtbDa.Name = "mtbDa"
        mtbDa.Size = New Size(300, 47)
        mtbDa.TabIndex = 0
        mtbDa.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 73.02053F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.9794712F))
        TableLayoutPanel8.Controls.Add(mtbNoProg, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(253, 78)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel8.Size = New Size(341, 69)
        TableLayoutPanel8.TabIndex = 8
        ' 
        ' mtbNoProg
        ' 
        mtbNoProg.Dock = DockStyle.Fill
        mtbNoProg.Location = New Point(3, 3)
        mtbNoProg.Mask = "LLL.>0L"
        mtbNoProg.Name = "mtbNoProg"
        mtbNoProg.Size = New Size(243, 47)
        mtbNoProg.TabIndex = 1
        mtbNoProg.Text = "LEA"' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 73F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 71F))
        TableLayoutPanel3.Controls.Add(btnNew, 1, 1)
        TableLayoutPanel3.Controls.Add(btnOk, 1, 2)
        TableLayoutPanel3.Controls.Add(btnCancel, 1, 3)
        TableLayoutPanel3.Controls.Add(btnModify, 1, 4)
        TableLayoutPanel3.Controls.Add(btnRemove, 1, 5)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(2189, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 7
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 80F))
        TableLayoutPanel3.Size = New Size(380, 600)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' btnNew
        ' 
        TableLayoutPanel3.SetColumnSpan(btnNew, 2)
        btnNew.Dock = DockStyle.Fill
        btnNew.Location = New Point(76, 23)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(230, 94)
        btnNew.TabIndex = 11
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        TableLayoutPanel3.SetColumnSpan(btnOk, 2)
        btnOk.Dock = DockStyle.Fill
        btnOk.Enabled = False
        btnOk.Location = New Point(76, 123)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(230, 94)
        btnOk.TabIndex = 12
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        TableLayoutPanel3.SetColumnSpan(btnCancel, 2)
        btnCancel.Dock = DockStyle.Fill
        btnCancel.Enabled = False
        btnCancel.Location = New Point(76, 223)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(230, 94)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        TableLayoutPanel3.SetColumnSpan(btnModify, 2)
        btnModify.Dock = DockStyle.Fill
        btnModify.Enabled = False
        btnModify.Location = New Point(76, 323)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(230, 94)
        btnModify.TabIndex = 14
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        TableLayoutPanel3.SetColumnSpan(btnRemove, 2)
        btnRemove.Dock = DockStyle.Fill
        btnRemove.Enabled = False
        btnRemove.Location = New Point(76, 423)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(230, 94)
        btnRemove.TabIndex = 15
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' frmStudents
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2618, 1570)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        Name = "frmStudents"
        Text = "Students"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        grpBoxStudents.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        TableLayoutPanel11.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        grpBoxGender.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lvStudentsInfo As ListView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents grpBoxStudents As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblDa As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents txtFamName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpBoxGender As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents mtbDa As MaskedTextBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents mtbNoProg As MaskedTextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents colDa As ColumnHeader
    Friend WithEvents colNoProg As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colFamName As ColumnHeader
    Friend WithEvents colGender As ColumnHeader
    Friend WithEvents colAddress As ColumnHeader
    Friend WithEvents colCity As ColumnHeader
    Friend WithEvents colZip As ColumnHeader
    Friend WithEvents colPhone As ColumnHeader
    Friend WithEvents colProv As ColumnHeader
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents mtbZip As MaskedTextBox
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents cboProvince As ComboBox
End Class
