Public Class frmMain
    Private management As frmManagement
    Private student As frmStudents
    Private about As AboutBox




    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        management = New frmManagement
        With management
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        student = New frmStudents
        With student
            .MdiParent = Me
            .Show()
        End With
    End Sub

    'Will exit program if yes is selected , ignore no 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim text As String = "You're about to exit the program, would you like to continue ? "
        Dim title As String = "Exit"

        Dim ansMsg = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (ansMsg = System.Windows.Forms.DialogResult.Yes) Then ' Yes = 6 // No = 7 
            MessageBox.Show("Good bye!")
            Close() 'Close app
        End If

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandsToolStripMenuItem.Click
        about = New AboutBox
        about.Show()
    End Sub

End Class
