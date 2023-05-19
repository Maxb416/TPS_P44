Imports Microsoft.Data.SqlClient

Public Class Report3
    Private Sub Report3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTreeView3()
    End Sub

    Private Sub PopulateTreeView3()
        ' Clear the TreeView each time you populate it
        TreeView3.Nodes.Clear()

        ' Open a connection to the database
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            Dim query As String = "SELECT pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures FROM T_programme " &
                                  "ORDER BY pro_no"

            Using cmd As New SqlCommand(query, cn)
                cn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim currentProNo As String = ""
                    Dim proNoNode As TreeNode = Nothing

                    While reader.Read()
                        Dim proNo As String = reader("pro_no").ToString()

                        If currentProNo <> proNo Then
                            If proNoNode IsNot Nothing Then
                                TreeView3.Nodes.Add(proNoNode)
                            End If

                            proNoNode = New TreeNode(proNo)
                            currentProNo = proNo
                        End If

                        Dim proNom As String = reader("pro_nom").ToString()
                        Dim proNbrUnites As String = reader("pro_nbr_unites").ToString()
                        Dim proNbrHeures As String = reader("pro_nbr_heures").ToString()

                        Dim proNomNode As New TreeNode($"pro_nom: {proNom}")
                        Dim proNbrUnitesNode As New TreeNode($"pro_nbr_unites: {proNbrUnites}")
                        Dim proNbrHeuresNode As New TreeNode($"pro_nbr_heures: {proNbrHeures}")

                        proNoNode.Nodes.Add(proNomNode)
                        proNoNode.Nodes.Add(proNbrUnitesNode)
                        proNoNode.Nodes.Add(proNbrHeuresNode)
                    End While

                    If proNoNode IsNot Nothing Then
                        TreeView3.Nodes.Add(proNoNode)
                    End If
                End Using
            End Using
        End Using
    End Sub

End Class