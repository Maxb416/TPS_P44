<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        MenuStrip1 = New MenuStrip()
        ManagementToolStripMenuItem = New ToolStripMenuItem()
        ProgramsToolStripMenuItem = New ToolStripMenuItem()
        StudentsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        ListOfProgramsToolStripMenuItem = New ToolStripMenuItem()
        ListOfStudentsToolStripMenuItem = New ToolStripMenuItem()
        ListOfStudentsByProgramsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        CommandsToolStripMenuItem = New ToolStripMenuItem()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(40, 40)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManagementToolStripMenuItem, ReportsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(2593, 49)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' ManagementToolStripMenuItem
        ' 
        ManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProgramsToolStripMenuItem, StudentsToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem})
        ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        ManagementToolStripMenuItem.ShortcutKeys = Keys.F1
        ManagementToolStripMenuItem.Size = New Size(219, 45)
        ManagementToolStripMenuItem.Text = "Management"' 
        ' ProgramsToolStripMenuItem
        ' 
        ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        ProgramsToolStripMenuItem.ShortcutKeyDisplayString = ""
        ProgramsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        ProgramsToolStripMenuItem.Size = New Size(413, 54)
        ProgramsToolStripMenuItem.Text = "Programs"' 
        ' StudentsToolStripMenuItem
        ' 
        StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        StudentsToolStripMenuItem.ShortcutKeyDisplayString = ""
        StudentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        StudentsToolStripMenuItem.Size = New Size(413, 54)
        StudentsToolStripMenuItem.Text = "Students"' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(410, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeyDisplayString = ""
        ExitToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        ExitToolStripMenuItem.Size = New Size(413, 54)
        ExitToolStripMenuItem.Text = "Exit"' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListOfProgramsToolStripMenuItem, ListOfStudentsToolStripMenuItem, ListOfStudentsByProgramsToolStripMenuItem})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.ShortcutKeys = Keys.F2
        ReportsToolStripMenuItem.Size = New Size(144, 45)
        ReportsToolStripMenuItem.Text = "Reports"' 
        ' ListOfProgramsToolStripMenuItem
        ' 
        ListOfProgramsToolStripMenuItem.Name = "ListOfProgramsToolStripMenuItem"
        ListOfProgramsToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.P
        ListOfProgramsToolStripMenuItem.Size = New Size(665, 54)
        ListOfProgramsToolStripMenuItem.Text = "List of programs"' 
        ' ListOfStudentsToolStripMenuItem
        ' 
        ListOfStudentsToolStripMenuItem.Name = "ListOfStudentsToolStripMenuItem"
        ListOfStudentsToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.S
        ListOfStudentsToolStripMenuItem.Size = New Size(665, 54)
        ListOfStudentsToolStripMenuItem.Text = "List of Students"' 
        ' ListOfStudentsByProgramsToolStripMenuItem
        ' 
        ListOfStudentsByProgramsToolStripMenuItem.Name = "ListOfStudentsByProgramsToolStripMenuItem"
        ListOfStudentsByProgramsToolStripMenuItem.ShortcutKeyDisplayString = ""
        ListOfStudentsByProgramsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.R
        ListOfStudentsByProgramsToolStripMenuItem.Size = New Size(665, 54)
        ListOfStudentsByProgramsToolStripMenuItem.Text = "List of students by programs"' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CommandsToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.ShortcutKeys = Keys.F3
        HelpToolStripMenuItem.Size = New Size(104, 45)
        HelpToolStripMenuItem.Text = "Help"' 
        ' CommandsToolStripMenuItem
        ' 
        CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        CommandsToolStripMenuItem.ShortcutKeyDisplayString = ""
        CommandsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.I
        CommandsToolStripMenuItem.Size = New Size(337, 54)
        CommandsToolStripMenuItem.Text = "Info "' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2593, 1362)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(1400, 900)
        Name = "frmMain"
        Text = "Main"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfStudentsByProgramsToolStripMenuItem As ToolStripMenuItem
End Class
