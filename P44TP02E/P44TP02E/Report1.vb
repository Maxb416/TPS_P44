Imports Microsoft.Data.SqlClient

Public Class Report1

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTreeView1()
    End Sub

    Private Sub PopulateTreeView1()
        ' Clear the TreeView each time you populate it
        TreeView1.Nodes.Clear()

        ' Open a connection to the database
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            Dim query As String = "SELECT tp.pro_no, te.etu_da, te.etu_nom, te.etu_prenom, te.etu_telephone " &
                              "FROM T_programme AS tp " &
                              "JOIN T_etudiants AS te ON tp.pro_no = te.pro_no " &
                              "ORDER BY tp.pro_no"

            Using cmd As New SqlCommand(query, cn)
                cn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim parentNode As TreeNode = Nothing
                    Dim currentProgramNo As String = ""

                    While reader.Read()
                        Dim programNo As String = reader("pro_no").ToString()

                        If currentProgramNo <> programNo Then
                            parentNode = New TreeNode(programNo)
                            TreeView1.Nodes.Add(parentNode)
                            currentProgramNo = programNo
                        End If

                        Dim studentData As String = $"{reader("etu_da").ToString()} - {reader("etu_nom").ToString()} {reader("etu_prenom").ToString()} - " &
                                                $"Tel: {reader("etu_telephone")}"
                        parentNode.Nodes.Add(New TreeNode(studentData))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class