Imports System.Data.SQLite
Imports System.IO
Public Class Login
    Private connectionString As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "SAGARI.db3"
                                         )
        'Ici pour affichier la base de donnees dans la liste des clients et les contrats
        ' Dim myconnection As New SQLiteConnection("Data Source=d:\SAGARI.db3;Version=3")
        '   myconnection.Open()

        ' Dim cmd As New SQLiteCommand
        ' cmd.Connection = myconnection
        ' cmd.CommandText = "Select * from SAGARI"

        ' Dim reader As SQLiteDataReader = cmd.ExecuteReader
        ' Dim datatable As New DataTable
        ' datatable.Load(reader)
        ' reader.Close()
        ' myconnection.Close()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If IsUserValid(txt_username.Text.Trim, txt_password.Text.Trim) Then
            MessageBox.Show("Bienvenue.")
        Else
            MessageBox.Show("Accès refusé, Veuillez Verifier Votre Nom d'Utilisatuer ou Votre Mot de Passe.")

        End If


    End Sub

    Private Function IsUserValid(username As String, pass As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim sql As String = "SELECT * FROM Employe where username = @username and pass = @pass "

        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@pass", pass)

                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim userInfo As DataRow = dt.Rows(0)
                            If userInfo("user_password").Equals(pass) Then
                                IsValidUser = True

                            End If
                        End If
                    End Using
                End Using

            End Using


        Catch ex As Exception

        End Try




        Return IsValidUser
    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class
