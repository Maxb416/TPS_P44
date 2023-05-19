<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report1
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
        TreeView1 = New TreeView()
        SuspendLayout()
        ' 
        ' TreeView1
        ' 
        TreeView1.Dock = DockStyle.Fill
        TreeView1.Location = New Point(0, 0)
        TreeView1.Margin = New Padding(7, 8, 7, 8)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(2248, 1327)
        TreeView1.TabIndex = 1
        ' 
        ' Report1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2248, 1327)
        Controls.Add(TreeView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Report1"
        Text = "Report"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TreeView1 As TreeView
End Class
