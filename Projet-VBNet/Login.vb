Imports System.IO
Imports System.Data.SQLite

Public Class Login

    'Une variable pour la connection de la base de donnees
    Private connectionString = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'La connection de la base de donnees
        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "usersDb.db")


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        'Valider is le nom de l'utilisateur et le mot de passe est correct ou non
        If IsUserValid(txt_username.Text.Trim, txt_password.Text.Trim) = True Then
            MsgBox("Bienvenue.")

            'Si le mot de passe est corret, on va ouvrir la page principale
            Me.Hide()
            Dim frmMainForm As New PageConsulter
            frmMainForm.Show()

        Else
            MsgBox("Accès refusé, Veuillez Verifier Votre Nom d'Utilisatuer ou Votre Mot de Passe.")
        End If

    End Sub

    Private Function IsUserValid(username As String, password As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim userInfo As DataRow = Nothing
        Dim sql As String = "SELECT * FROM users WHERE user_name = @username;"

        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            userInfo = dt.Rows(0)
                            'Obtenir le mot de passe de la base de donnees
                            'Dim dbSalt As String = userInfo("user_salt")

                            ' get the hashed password from the database
                            Dim dbPass As String = userInfo("user_password")

                            ' Hash the password entered by user when login with same salt from database
                            'Dim passEntered As String = Utils.GetSaltedHash(password, dbSalt)

                            ' then compare the two hased password if they are the same then return valid password
                            If String.Compare(dbPass, password, False) = 0 Then
                                IsValidUser = True
                            End If

                        End If

                        'If userInfo("user_password").Equals(password) Then
                        '    IsValidUser = True
                        'End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return IsValidUser
    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class