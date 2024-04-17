Imports MySql.Data.MySqlClient

Public Class Dashboard

    Dim Con As New MySqlConnection("Server=localhost;Database=streetdog;Uid=root;Pwd=root")

    Private Sub Dashboard(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDogs()
        LoadAdopters()
        LoadAdoptionCount()
        LoadDogData()
        LoadAdopterData()
        LoadAdoptionData()
    End Sub

    Private Sub LoadDogs()
        Try
            Con.Open()

            Dim query As String = "SELECT COUNT(*) FROM dog"
            Dim cmd As New MySqlCommand(query, Con)
            Dim dogCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            DogCountLabel.Text = $"{dogCount}"

        Catch ex As Exception
            ShowError("Error loading dog count.", ex)
        Finally
            Con.Close()
        End Try
        Panel2.BackColor = Color.FromArgb(128, Panel2.BackColor)
    End Sub

    Private Sub LoadAdopters()
        Try
            Con.Open()

            Dim query As String = "SELECT COUNT(*) FROM adopter"
            Dim cmd As New MySqlCommand(query, Con)
            Dim adopterCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            AdopterCountLabel.Text = $"{adopterCount}"

        Catch ex As Exception
            ShowError("Error loading adopter count.", ex)
        Finally
            Con.Close()
        End Try
        Panel3.BackColor = Color.FromArgb(128, Panel2.BackColor)
    End Sub

    Private Sub LoadAdoptionCount()
        Try
            Con.Open()

            Dim query As String = "SELECT COUNT(*) FROM Adoption"
            Dim cmd As New MySqlCommand(query, Con)
            Dim adoptionCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            AdoptionCountLabel.Text = $"{adoptionCount}"

        Catch ex As Exception
            ShowError("Error loading adoption count.", ex)
        Finally
            Con.Close()
        End Try
        Panel4.BackColor = Color.FromArgb(128, Panel2.BackColor)
    End Sub

    Private Sub LoadDogData()
        Try
            Con.Open()

            Dim query As String = "SELECT Dname FROM Dog"
            Dim adapter As New MySqlDataAdapter(query, Con)
            Dim ds As New DataSet()
            adapter.Fill(ds, "Dogs")

            DogDataGridView.DataSource = ds.Tables("Dogs")

        Catch ex As Exception
            ShowError("Error loading dog data.", ex)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub LoadAdopterData()
        Try
            Con.Open()

            Dim query As String = "SELECT name FROM adopter"
            Dim adapter As New MySqlDataAdapter(query, Con)
            Dim ds As New DataSet()
            adapter.Fill(ds, "Adopters")

            AdopterDataGridView.DataSource = ds.Tables("Adopters")

        Catch ex As Exception
            ShowError("Error loading adopter data.", ex)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub LoadAdoptionData()
        Try
            Con.Open()

            Dim query As String = "SELECT dname, aname FROM Adoption"
            Dim adapter As New MySqlDataAdapter(query, Con)
            Dim ds As New DataSet()
            adapter.Fill(ds, "Adoptions")

            AdoptionDataGridView.DataSource = ds.Tables("Adoptions")

        Catch ex As Exception
            ShowError("Error loading adoption data.", ex)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message} Error details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
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
        Dim form As New Adoption()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub
End Class
