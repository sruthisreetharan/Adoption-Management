Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Dim connectionString As String = "Server=localhost;Database=streetdog;Uid=root;Pwd=root;"

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim username As String = UnameTb.Text
            Dim password As String = PasswordTb.Text

            If AuthenticateUser(username, password) Then
                MessageBox.Show("Login successful!")
            ' Open the main form or dashboard here
            Dim mainForm As New Adopters()
            mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password!")
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            UnameTb.Clear()
            PasswordTb.Clear()
        End Sub

        Private Function AuthenticateUser(username As String, password As String) As Boolean
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password"
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    connection.Open()

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return count > 0
                End Using
            End Using
        End Function

    End Class

