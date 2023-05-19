Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Report2
    Private Sub Report2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTreeView2()
    End Sub

    Private Sub PopulateTreeView2()
        ' Clear the TreeView each time you populate it
        TreeView2.Nodes.Clear()

        ' Open a connection to the database
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            Dim query As String = "SELECT etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_ville, etu_telephone, etu_codepostal " &
                      "FROM T_etudiants ORDER BY etu_da"

            Using cmd As New SqlCommand(query, cn)
                cn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim currentEtuDa As String = ""
                    Dim etuDaNode As TreeNode = Nothing

                    While reader.Read()
                        Dim etuDa As String = reader("etu_da").ToString()

                        If currentEtuDa <> etuDa Then
                            If etuDaNode IsNot Nothing Then
                                TreeView2.Nodes.Add(etuDaNode)
                            End If

                            etuDaNode = New TreeNode(etuDa)
                            currentEtuDa = etuDa
                        End If

                        Dim proNo As String = reader("pro_no").ToString()
                        Dim etuNom As String = reader("etu_nom").ToString()
                        Dim etuPrenom As String = reader("etu_prenom").ToString()
                        Dim etuSexe As String = reader("etu_sexe").ToString()
                        Dim etuAdresse As String = reader("etu_adresse").ToString()
                        Dim etuVille As String = reader("etu_ville").ToString()
                        Dim etuTelephone As String = reader("etu_telephone").ToString()
                        Dim etuCodePostal As String = reader("etu_codepostal").ToString()

                        Dim proNoNode As New TreeNode($"pro_no: {proNo}")
                        Dim etuNomNode As New TreeNode($"etu_nom: {etuNom}")
                        Dim etuPrenomNode As New TreeNode($"etu_prenom: {etuPrenom}")
                        Dim etuSexeNode As New TreeNode($"etu_sexe: {etuSexe}")
                        Dim etuAdresseNode As New TreeNode($"etu_adresse: {etuAdresse}")
                        Dim etuVilleNode As New TreeNode($"etu_ville: {etuVille}")
                        Dim etuTelephoneNode As New TreeNode($"etu_telephone: {etuTelephone}")
                        Dim etuCodePostalNode As New TreeNode($"etu_codepostal: {etuCodePostal}")

                        etuDaNode.Nodes.Add(proNoNode)
                        etuDaNode.Nodes.Add(etuNomNode)
                        etuDaNode.Nodes.Add(etuPrenomNode)
                        etuDaNode.Nodes.Add(etuSexeNode)
                        etuDaNode.Nodes.Add(etuAdresseNode)
                        etuDaNode.Nodes.Add(etuVilleNode)
                        etuDaNode.Nodes.Add(etuTelephoneNode)
                        etuDaNode.Nodes.Add(etuCodePostalNode)
                    End While

                    If etuDaNode IsNot Nothing Then
                        TreeView2.Nodes.Add(etuDaNode)
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class