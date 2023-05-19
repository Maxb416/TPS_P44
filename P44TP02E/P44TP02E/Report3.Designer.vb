<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report3
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
        TreeView3 = New TreeView()
        SuspendLayout()
        ' 
        ' TreeView3
        ' 
        TreeView3.Dock = DockStyle.Fill
        TreeView3.Location = New Point(0, 0)
        TreeView3.Name = "TreeView3"
        TreeView3.Size = New Size(2248, 1327)
        TreeView3.TabIndex = 1
        ' 
        ' Report3
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2248, 1327)
        Controls.Add(TreeView3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Report3"
        Text = "Report3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TreeView3 As TreeView
End Class
