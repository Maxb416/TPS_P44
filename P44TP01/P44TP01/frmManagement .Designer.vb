<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagement
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
        lvStudentsPerPrograms = New ListView()
        colDa = New ColumnHeader()
        colNoProg = New ColumnHeader()
        colStudentName = New ColumnHeader()
        colStudentFamily = New ColumnHeader()
        lvPrograms = New ListView()
        colNo = New ColumnHeader()
        colName = New ColumnHeader()
        colUnits = New ColumnHeader()
        colHour = New ColumnHeader()
        TableLayoutPanel2 = New TableLayoutPanel()
        grpBoxPrograms = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        txtHours = New TextBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        txtUnits = New TextBox()
        TableLayoutPanel8 = New TableLayoutPanel()
        mtbNo = New MaskedTextBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        txtName = New TextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnNew = New Button()
        btnOk = New Button()
        btnCancel = New Button()
        btnModify = New Button()
        btnRemove = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        grpBoxPrograms.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.4804535F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1.03908956F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.4804535F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(lvStudentsPerPrograms, 3, 1)
        TableLayoutPanel1.Controls.Add(lvPrograms, 1, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(2353, 1309)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lvStudentsPerPrograms
        ' 
        lvStudentsPerPrograms.Columns.AddRange(New ColumnHeader() {colDa, colNoProg, colStudentName, colStudentFamily})
        lvStudentsPerPrograms.Dock = DockStyle.Fill
        lvStudentsPerPrograms.FullRowSelect = True
        lvStudentsPerPrograms.GridLines = True
        lvStudentsPerPrograms.Location = New Point(1191, 23)
        lvStudentsPerPrograms.MultiSelect = False
        lvStudentsPerPrograms.Name = "lvStudentsPerPrograms"
        TableLayoutPanel1.SetRowSpan(lvStudentsPerPrograms, 3)
        lvStudentsPerPrograms.Size = New Size(1138, 1262)
        lvStudentsPerPrograms.TabIndex = 10
        lvStudentsPerPrograms.UseCompatibleStateImageBehavior = False
        lvStudentsPerPrograms.View = View.Details
        ' 
        ' colDa
        ' 
        colDa.Text = "DA"' 
        ' colNoProg
        ' 
        colNoProg.Text = "No.Prog"' 
        ' colStudentName
        ' 
        colStudentName.Text = "Name"' 
        ' colStudentFamily
        ' 
        colStudentFamily.Text = "Family name"' 
        ' lvPrograms
        ' 
        lvPrograms.Columns.AddRange(New ColumnHeader() {colNo, colName, colUnits, colHour})
        lvPrograms.Dock = DockStyle.Fill
        lvPrograms.FullRowSelect = True
        lvPrograms.GridLines = True
        lvPrograms.Location = New Point(23, 667)
        lvPrograms.MultiSelect = False
        lvPrograms.Name = "lvPrograms"
        lvPrograms.Size = New Size(1138, 618)
        lvPrograms.TabIndex = 9
        lvPrograms.UseCompatibleStateImageBehavior = False
        lvPrograms.View = View.Details
        ' 
        ' colNo
        ' 
        colNo.Text = "No"' 
        ' colName
        ' 
        colName.Text = "Name"' 
        ' colUnits
        ' 
        colUnits.Text = "Nbr units"' 
        ' colHour
        ' 
        colHour.Text = "Nbr hours"' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Controls.Add(grpBoxPrograms, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 3, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(23, 23)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1138, 618)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' grpBoxPrograms
        ' 
        TableLayoutPanel2.SetColumnSpan(grpBoxPrograms, 2)
        grpBoxPrograms.Controls.Add(TableLayoutPanel5)
        grpBoxPrograms.Dock = DockStyle.Fill
        grpBoxPrograms.Enabled = False
        grpBoxPrograms.Location = New Point(3, 3)
        grpBoxPrograms.Name = "grpBoxPrograms"
        TableLayoutPanel2.SetRowSpan(grpBoxPrograms, 2)
        grpBoxPrograms.Size = New Size(888, 612)
        grpBoxPrograms.TabIndex = 0
        grpBoxPrograms.TabStop = False
        grpBoxPrograms.Text = "Programs"' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.381642F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 300F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 96.6183548F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Controls.Add(Label1, 1, 1)
        TableLayoutPanel5.Controls.Add(Label3, 1, 3)
        TableLayoutPanel5.Controls.Add(Label4, 1, 4)
        TableLayoutPanel5.Controls.Add(Label2, 1, 2)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel4, 2, 4)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 2, 3)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel8, 2, 1)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel7, 2, 2)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 43)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 6
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9314566F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9314566F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9314566F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9314566F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 44.27417F))
        TableLayoutPanel5.Size = New Size(882, 566)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(22, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 47)
        Label1.TabIndex = 0
        Label1.Text = "No :"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(22, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(294, 47)
        Label3.TabIndex = 4
        Label3.Text = "Number of units :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(22, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(294, 47)
        Label4.TabIndex = 5
        Label4.Text = "Number of hours :"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(22, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 47)
        Label2.TabIndex = 2
        Label2.Text = "Name :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel4.Controls.Add(txtHours, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(322, 251)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(536, 70)
        TableLayoutPanel4.TabIndex = 7
        ' 
        ' txtHours
        ' 
        txtHours.Dock = DockStyle.Fill
        txtHours.Location = New Point(3, 3)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(342, 47)
        txtHours.TabIndex = 3
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel6.Controls.Add(txtUnits, 0, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(322, 175)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel6.Size = New Size(536, 70)
        TableLayoutPanel6.TabIndex = 8
        ' 
        ' txtUnits
        ' 
        txtUnits.Dock = DockStyle.Fill
        txtUnits.Location = New Point(3, 3)
        txtUnits.Name = "txtUnits"
        txtUnits.Size = New Size(342, 47)
        txtUnits.TabIndex = 2
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel8.Controls.Add(mtbNo, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(322, 23)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel8.Size = New Size(536, 70)
        TableLayoutPanel8.TabIndex = 10
        ' 
        ' mtbNo
        ' 
        mtbNo.Dock = DockStyle.Fill
        mtbNo.Location = New Point(3, 3)
        mtbNo.Mask = "LLL.>0L"
        mtbNo.Name = "mtbNo"
        mtbNo.Size = New Size(342, 47)
        mtbNo.TabIndex = 0
        mtbNo.Text = "LEA"' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Controls.Add(txtName, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(322, 99)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Size = New Size(536, 70)
        TableLayoutPanel7.TabIndex = 11
        ' 
        ' txtName
        ' 
        txtName.Dock = DockStyle.Left
        txtName.Location = New Point(3, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(530, 47)
        txtName.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(btnNew, 0, 1)
        TableLayoutPanel3.Controls.Add(btnOk, 0, 2)
        TableLayoutPanel3.Controls.Add(btnCancel, 0, 3)
        TableLayoutPanel3.Controls.Add(btnModify, 0, 4)
        TableLayoutPanel3.Controls.Add(btnRemove, 0, 5)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(917, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 7
        TableLayoutPanel2.SetRowSpan(TableLayoutPanel3, 2)
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 28.5714283F))
        TableLayoutPanel3.Size = New Size(218, 612)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' btnNew
        ' 
        btnNew.Dock = DockStyle.Fill
        btnNew.Location = New Point(3, 23)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(212, 78)
        btnNew.TabIndex = 4
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Dock = DockStyle.Fill
        btnOk.Enabled = False
        btnOk.Location = New Point(3, 107)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(212, 78)
        btnOk.TabIndex = 5
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Dock = DockStyle.Fill
        btnCancel.Enabled = False
        btnCancel.Location = New Point(3, 191)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(212, 78)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Dock = DockStyle.Fill
        btnModify.Enabled = False
        btnModify.Location = New Point(3, 275)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(212, 78)
        btnModify.TabIndex = 7
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Dock = DockStyle.Fill
        btnRemove.Enabled = False
        btnRemove.Location = New Point(3, 359)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(212, 78)
        btnRemove.TabIndex = 8
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' frmManagement
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2353, 1309)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        MaximizeBox = False
        Name = "frmManagement"
        Text = "Management"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        grpBoxPrograms.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lvStudentsPerPrograms As ListView
    Friend WithEvents lvPrograms As ListView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents grpBoxPrograms As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents colNo As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colUnits As ColumnHeader
    Friend WithEvents colHour As ColumnHeader
    Friend WithEvents colDa As ColumnHeader
    Friend WithEvents colNoProg As ColumnHeader
    Friend WithEvents colStudentName As ColumnHeader
    Friend WithEvents colStudentFamily As ColumnHeader
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents mtbNo As MaskedTextBox
End Class
