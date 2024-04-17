Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class Adopters
    Dim Con As New MySqlConnection("Server=localhost;Database=streetdog;Uid=root;Pwd=root")

    Private Sub AdopterDisplay()
        Try
            Con.Open()

            Dim query As String = "SELECT * FROM Adopter"
            Dim adapter As New MySqlDataAdapter(query, Con)
            Dim builder = New MySqlCommandBuilder(adapter)

            Dim ds As New DataSet()
            adapter.Fill(ds, "Adopters")

            Adgv.DataSource = ds.Tables("Adopters")
            Panel2.BackColor = Color.FromArgb(128, Panel2.BackColor)

        Catch ex As Exception
            ShowError("Error fetching adopters.", ex)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub ExecuteNonQueryWithParams(query As String, params As Dictionary(Of String, Object))
        Try
            Con.Open()
            Using cmd As New MySqlCommand(query, Con)
                For Each param In params
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception($"Error executing query: {ex.Message}")
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If ValidateInput() Then
            Try
                Dim query = "INSERT INTO adopter(name, age, address, gender, experience) VALUES (@AName, @AAge, @AAdr, @AGen, @Aexperience)"
                Dim params As New Dictionary(Of String, Object) From {
                    {"@AName", TextBox1.Text},
                    {"@AAge", TextBox2.Text},
                    {"@AAdr", TextBox3.Text},
                    {"@AGen", ComboBox3.SelectedItem.ToString()},
                    {"@Aexperience", ComboBox1.SelectedItem.ToString()}
                }
                ExecuteNonQueryWithParams(query, params)
                MessageBox.Show("Adopter Saved")
                AdopterDisplay()

            Catch ex As Exception
                ShowError("Error adding adopter.", ex)
            End Try
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If ValidateInput() Then
            If MessageBox.Show("Are you sure you want to edit this adopter?", "Confirm Edit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Dim query = "UPDATE Adopter SET name = @Name, age = @Age, address = @Address, gender = @Gender, experience = @Experience WHERE adopter_id = @adopter_id"
                    Dim params As New Dictionary(Of String, Object) From {
                        {"@Name", TextBox1.Text},
                        {"@Age", TextBox2.Text},
                        {"@Address", TextBox3.Text},
                        {"@Gender", ComboBox3.SelectedItem.ToString()},
                        {"@Experience", ComboBox1.SelectedItem.ToString()},
                        {"@adopter_id", Adgv.SelectedRows(0).Cells("adopter_id").Value}
                    }
                    ExecuteNonQueryWithParams(query, params)
                    MessageBox.Show("Adopter Edited Successfully")
                    AdopterDisplay()

                Catch ex As Exception
                    ShowError("Error editing adopter.", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Adgv.SelectedRows.Count > 0 Then
            Dim selectedRow = Adgv.SelectedRows(0)
            Dim adopterId = selectedRow.Cells("adopter_id").Value
            If MessageBox.Show("Are you sure you want to delete this adopter?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM Adopter WHERE adopter_id = @adopter_id"
                    Dim params As New Dictionary(Of String, Object) From {
                        {"@adopter_id", adopterId}
                    }
                    ExecuteNonQueryWithParams(query, params)
                    MessageBox.Show("Adopter deleted successfully.")
                    AdopterDisplay()

                Catch ex As Exception
                    ShowError("Error deleting adopter.", ex)
                End Try
            End If
        Else
            MessageBox.Show("Please select an Adopter to delete.")
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) OrElse TextBox1.Text = "Adopter Name" Then
            MessageBox.Show("Please enter a valid Adopter name.")
            Return False
        ElseIf String.IsNullOrEmpty(TextBox2.Text) OrElse TextBox2.Text = "Age" Then
            MessageBox.Show("Please enter a valid age.")
            Return False
        ElseIf String.IsNullOrEmpty(TextBox3.Text) OrElse TextBox3.Text = "Address" Then
            MessageBox.Show("Please enter a valid address.")
            Return False
        ElseIf ComboBox3.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a gender.")
            Return False
        ElseIf ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select if the person has prior experience.")
            Return False
        End If
        Return True
    End Function

    Private Sub Adgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Adgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Adgv.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("name").Value.ToString()
            TextBox2.Text = row.Cells("age").Value.ToString()
            TextBox3.Text = row.Cells("address").Value.ToString()
            ComboBox3.SelectedItem = row.Cells("gender").Value.ToString()
            ComboBox1.SelectedItem = row.Cells("experience").Value.ToString()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim form2 As New Dog()
        Dim bounds = Me.Bounds
        AddHandler form2.Load, Sub() form2.Bounds = bounds
        Me.Hide()
        form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim form As New Adoption()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub

    Private Sub Adopters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdopterDisplay()
    End Sub

    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message} Error details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim form As New Dashboard()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub

End Class
