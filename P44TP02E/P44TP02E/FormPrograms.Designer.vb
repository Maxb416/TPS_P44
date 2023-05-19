<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrograms
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
        btnRemove = New Button()
        btnModify = New Button()
        btnCancel = New Button()
        btnOk = New Button()
        btnNew = New Button()
        gbPrograms = New GroupBox()
        mtbNo = New MaskedTextBox()
        lblUnits = New Label()
        lblHours = New Label()
        tbUnits = New TextBox()
        tbHours = New TextBox()
        Button1 = New Button()
        lblNo = New Label()
        Button2 = New Button()
        lblName = New Label()
        Button3 = New Button()
        Button4 = New Button()
        tbName = New TextBox()
        Button5 = New Button()
        dgProgStud = New DataGridView()
        dgPrograms = New DataGridView()
        btnFirst = New Button()
        btnPrev = New Button()
        btnNext = New Button()
        btnLast = New Button()
        lblOneOf = New Label()
        gbPrograms.SuspendLayout()
        CType(dgProgStud, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPrograms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.IndianRed
        btnRemove.Location = New Point(1068, 361)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(250, 69)
        btnRemove.TabIndex = 10
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnModify
        ' 
        btnModify.Location = New Point(1068, 286)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(250, 69)
        btnModify.TabIndex = 9
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Enabled = False
        btnCancel.Location = New Point(1068, 211)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(250, 69)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Enabled = False
        btnOk.Location = New Point(1068, 136)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(250, 69)
        btnOk.TabIndex = 7
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(1068, 61)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(250, 69)
        btnNew.TabIndex = 6
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' gbPrograms
        ' 
        gbPrograms.Controls.Add(mtbNo)
        gbPrograms.Controls.Add(lblUnits)
        gbPrograms.Controls.Add(lblHours)
        gbPrograms.Controls.Add(tbUnits)
        gbPrograms.Controls.Add(tbHours)
        gbPrograms.Controls.Add(Button1)
        gbPrograms.Controls.Add(lblNo)
        gbPrograms.Controls.Add(Button2)
        gbPrograms.Controls.Add(lblName)
        gbPrograms.Controls.Add(Button3)
        gbPrograms.Controls.Add(Button4)
        gbPrograms.Controls.Add(tbName)
        gbPrograms.Controls.Add(Button5)
        gbPrograms.Enabled = False
        gbPrograms.Location = New Point(40, 123)
        gbPrograms.Name = "gbPrograms"
        gbPrograms.Size = New Size(979, 443)
        gbPrograms.TabIndex = 11
        gbPrograms.TabStop = False
        gbPrograms.Text = "Programs"
        ' 
        ' mtbNo
        ' 
        mtbNo.Location = New Point(316, 64)
        mtbNo.Mask = "LLL.>0L"
        mtbNo.Name = "mtbNo"
        mtbNo.Size = New Size(250, 47)
        mtbNo.TabIndex = 25
        mtbNo.Text = "LEA"
        ' 
        ' lblUnits
        ' 
        lblUnits.Location = New Point(27, 180)
        lblUnits.Name = "lblUnits"
        lblUnits.Size = New Size(268, 50)
        lblUnits.TabIndex = 21
        lblUnits.Text = "Number of units:"
        lblUnits.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblHours
        ' 
        lblHours.Location = New Point(27, 238)
        lblHours.Name = "lblHours"
        lblHours.Size = New Size(268, 50)
        lblHours.TabIndex = 22
        lblHours.Text = "Number of hours:"
        lblHours.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tbUnits
        ' 
        tbUnits.Location = New Point(316, 183)
        tbUnits.Name = "tbUnits"
        tbUnits.Size = New Size(338, 47)
        tbUnits.TabIndex = 23
        ' 
        ' tbHours
        ' 
        tbHours.Location = New Point(316, 242)
        tbHours.Name = "tbHours"
        tbHours.Size = New Size(338, 47)
        tbHours.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(2009, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 69)
        Button1.TabIndex = 16
        Button1.Text = "Remove"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblNo
        ' 
        lblNo.Location = New Point(38, 60)
        lblNo.Name = "lblNo"
        lblNo.Size = New Size(256, 50)
        lblNo.TabIndex = 17
        lblNo.Text = "No:"
        lblNo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(2009, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 69)
        Button2.TabIndex = 15
        Button2.Text = "Modify"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(39, 118)
        lblName.Name = "lblName"
        lblName.Size = New Size(256, 50)
        lblName.TabIndex = 18
        lblName.Text = "Name:"
        lblName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(2009, 77)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 69)
        Button3.TabIndex = 14
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(2009, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(250, 69)
        Button4.TabIndex = 13
        Button4.Text = "Ok"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(316, 122)
        tbName.Name = "tbName"
        tbName.Size = New Size(557, 47)
        tbName.TabIndex = 20
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(2009, -73)
        Button5.Name = "Button5"
        Button5.Size = New Size(250, 69)
        Button5.TabIndex = 12
        Button5.Text = "New"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' dgProgStud
        ' 
        dgProgStud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProgStud.Location = New Point(1365, 55)
        dgProgStud.Name = "dgProgStud"
        dgProgStud.RowHeadersWidth = 102
        dgProgStud.RowTemplate.Height = 49
        dgProgStud.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgProgStud.Size = New Size(871, 1221)
        dgProgStud.TabIndex = 12
        ' 
        ' dgPrograms
        ' 
        dgPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPrograms.Location = New Point(40, 614)
        dgPrograms.Name = "dgPrograms"
        dgPrograms.RowHeadersWidth = 102
        dgPrograms.RowTemplate.Height = 49
        dgPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgPrograms.Size = New Size(1278, 662)
        dgPrograms.TabIndex = 13
        ' 
        ' btnFirst
        ' 
        btnFirst.BackColor = Color.AntiqueWhite
        btnFirst.Location = New Point(40, 55)
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(138, 54)
        btnFirst.TabIndex = 26
        btnFirst.Text = "<<"
        btnFirst.UseVisualStyleBackColor = False
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = SystemColors.ActiveCaption
        btnPrev.Location = New Point(185, 55)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(138, 54)
        btnPrev.TabIndex = 27
        btnPrev.Text = "< "
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(737, 55)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(138, 54)
        btnNext.TabIndex = 28
        btnNext.Text = ">"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnLast
        ' 
        btnLast.BackColor = Color.AntiqueWhite
        btnLast.Location = New Point(881, 55)
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(138, 54)
        btnLast.TabIndex = 29
        btnLast.Text = ">>"
        btnLast.UseVisualStyleBackColor = False
        ' 
        ' lblOneOf
        ' 
        lblOneOf.AutoSize = True
        lblOneOf.Location = New Point(479, 62)
        lblOneOf.Name = "lblOneOf"
        lblOneOf.Size = New Size(98, 41)
        lblOneOf.TabIndex = 30
        lblOneOf.Text = "1 of ..."
        ' 
        ' FormPrograms
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(2268, 1327)
        Controls.Add(lblOneOf)
        Controls.Add(btnFirst)
        Controls.Add(btnPrev)
        Controls.Add(btnLast)
        Controls.Add(dgPrograms)
        Controls.Add(btnNext)
        Controls.Add(dgProgStud)
        Controls.Add(gbPrograms)
        Controls.Add(btnRemove)
        Controls.Add(btnModify)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(btnNew)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPrograms"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormStudents"
        gbPrograms.ResumeLayout(False)
        gbPrograms.PerformLayout()
        CType(dgProgStud, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPrograms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents gbPrograms As GroupBox
    Friend WithEvents mtbNo As MaskedTextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents tbHours As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNo As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbName As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents dgProgStud As DataGridView
    Friend WithEvents dgPrograms As DataGridView
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents lblOneOf As Label
End Class
