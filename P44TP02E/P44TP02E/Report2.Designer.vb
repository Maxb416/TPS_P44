<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report2
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
        TreeView2 = New TreeView()
        SuspendLayout()
        ' 
        ' TreeView2
        ' 
        TreeView2.Dock = DockStyle.Fill
        TreeView2.Location = New Point(0, 0)
        TreeView2.Name = "TreeView2"
        TreeView2.Size = New Size(2248, 1327)
        TreeView2.TabIndex = 0
        ' 
        ' Report2
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2248, 1327)
        Controls.Add(TreeView2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Report2"
        Text = "Report2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TreeView2 As TreeView
End Class
