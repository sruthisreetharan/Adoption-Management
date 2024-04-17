Imports MySql.Data.MySqlClient

Public Class Adoption
    Dim Con As New MySqlConnection("Server=localhost;Database=streetdog;Uid=root;Pwd=root")

    Private Sub AdoptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDogs()
        LoadAdopters()
    End Sub

    Private Sub LoadDogs()
        Try
            Con.Open()

            Dim query As String = "SELECT Dname FROM Dog"
            Dim cmd As New MySqlCommand(query, Con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                DComboBox.Items.Add(reader("Dname").ToString())
            End While

            Panel2.BackColor = Color.FromArgb(128, Panel2.BackColor)
        Catch ex As Exception
            ShowError("Error loading dog.", ex)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub LoadAdopters()
        Try
            Con.Open()

            Dim query As String = "SELECT name FROM adopter"
            Dim cmd As New MySqlCommand(query, Con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                AComboBox.Items.Add(reader("name").ToString())
            End While

        Catch ex As Exception
            ShowError("Error loading adopter.", ex)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        DComboBox.SelectedIndex = -1
        AComboBox.SelectedIndex = -1
    End Sub

    Private Sub AdoptBtn_Click(sender As Object, e As EventArgs) Handles AdoptBtn.Click
        If DComboBox.SelectedIndex <> -1 AndAlso AComboBox.SelectedIndex <> -1 Then
            Try
                Con.Open()

                ' Remove the dog details
                Dim deleteDogQuery = "DELETE FROM dog WHERE Dname = @DogName"
                Dim deleteDogCmd As New MySqlCommand(deleteDogQuery, Con)
                deleteDogCmd.Parameters.AddWithValue("@DogName", DComboBox.SelectedItem.ToString())
                deleteDogCmd.ExecuteNonQuery()

                ' Update the adoption count
                Dim insertAdoptionQuery = "INSERT INTO Adoption(dname, aname) VALUES (@DogName, @AdopterName)"
                Dim insertAdoptionCmd As New MySqlCommand(insertAdoptionQuery, Con)
                insertAdoptionCmd.Parameters.AddWithValue("@DogName", DComboBox.SelectedItem.ToString())
                insertAdoptionCmd.Parameters.AddWithValue("@AdopterName", AComboBox.SelectedItem.ToString())
                insertAdoptionCmd.ExecuteNonQuery()

                MessageBox.Show("Adoption completed successfully.")

            Catch ex As Exception
                ShowError("Error adopting the dog.", ex)
            Finally
                Con.Close()
            End Try
        Else
            MessageBox.Show("Please select a dog and an adopter to proceed with adoption.")
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim form As New Adopters()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim form As New Dog()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim form As New Dashboard()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message} Error details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
