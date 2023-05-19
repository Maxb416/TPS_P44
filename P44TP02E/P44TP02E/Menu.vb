
Public Class Menu

    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        OpenReportForm(Of FormPrograms)()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        OpenReportForm(Of FormStudents)()
    End Sub

    'Will exit program if yes is selected , ignore no 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msg As String = "You're about to exit the program, would you like to continue ? "
        Dim ansMsg = MessageBox.Show(msg, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If (ansMsg = DialogResult.Yes) Then
            MessageBox.Show("Good bye!")
            Close() 'Close app
        End If

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandsToolStripMenuItem.Click
        'about = New AboutBox
        'about.Show()
    End Sub

    Private Sub ListOfProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProgramsToolStripMenuItem.Click
        OpenReportForm(Of Report3)()
    End Sub

    Private Sub ListOfStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfStudentsToolStripMenuItem.Click
        OpenReportForm(Of Report2)()
    End Sub

    Private Sub ListOfStudentsByProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfStudentsByProgramsToolStripMenuItem.Click
        OpenReportForm(Of Report1)()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenReportForm(Of T As {Form, New})()
        Dim existingForm As T = Nothing

        For Each form As Form In Me.MdiChildren
            If TypeOf form Is T Then
                existingForm = DirectCast(form, T)
                Exit For
            End If
        Next

        If existingForm IsNot Nothing Then
            existingForm.Close() ' Close the existing report form
        End If

        Dim newForm As New T
        With newForm
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
End Class
