Imports MySql.Data.MySqlClient

Public Class Dog
    Dim Con As New MySqlConnection("Server=localhost;Database=streetdog;Uid=root;Pwd=root")
    Dim Key As Integer

    Private Sub DogDisplay()
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            Dim query As String = "SELECT * FROM dog"
            Dim adapter As New MySqlDataAdapter(query, Con)
            Dim builder = New MySqlCommandBuilder(adapter)

            Dim ds As New DataSet()
            adapter.Fill(ds, "dog")

            Adgv.DataSource = ds.Tables("dog")
            Panel2.BackColor = Color.FromArgb(128, Panel2.BackColor)

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If ValidateInput() Then
            Try
                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If

                Dim query = "INSERT INTO dog(Dname, Breed, Address, Gender, Vaccinated) VALUES (@Dname, @Dbreed, @AAdr, @AGen, @Vacc)"
                Dim cmd As New MySqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@Dname", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Dbreed", TextBox2.Text)
                cmd.Parameters.AddWithValue("@AAdr", TextBox3.Text)
                cmd.Parameters.AddWithValue("@AGen", ComboBox3.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Vacc", ComboBox1.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Dog Saved")
                DogDisplay()

            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If ValidateInput() Then
            If MessageBox.Show("Are you sure you want to edit this Dog?", "Confirm Edit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    If Con.State = ConnectionState.Closed Then
                        Con.Open()
                    End If

                    Dim query = "UPDATE dog SET Dname = @Name, Breed = @breed, Address = @Address, Gender = @Gender, Vaccinated = @Vacc WHERE Did = @Did"
                    Dim cmd As New MySqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@breed", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Gender", ComboBox3.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Vacc", ComboBox1.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Did", Key)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Dog Edited Successfully")
                    DogDisplay()

                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    If Con.State = ConnectionState.Open Then
                        Con.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) OrElse TextBox1.Text = "Dog name" Then
            MessageBox.Show("Please enter a valid Dog name.")
            Return False
        ElseIf String.IsNullOrEmpty(TextBox2.Text) OrElse TextBox2.Text = "Breed" Then
            MessageBox.Show("Please enter a valid breed.")
            Return False
        ElseIf String.IsNullOrEmpty(TextBox3.Text) OrElse TextBox3.Text = "Address" Then
            MessageBox.Show("Please enter a valid address.")
            Return False
        ElseIf ComboBox3.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Gender.")
            Return False
        ElseIf ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select if the dog has been vaccinated.")
            Return False
        End If
        Return True
    End Function

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Adgv.SelectedRows.Count > 0 Then
            Dim selectedRow = Adgv.SelectedRows(0)
            Dim id = selectedRow.Cells("Did").Value.ToString()
            If MessageBox.Show("Are you sure you want to delete this dog?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    If Con.State = ConnectionState.Closed Then
                        Con.Open()
                    End If

                    Dim cmd As New MySqlCommand("DELETE FROM dog WHERE Did = @Did", Con)
                    cmd.Parameters.AddWithValue("@Did", id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Dog deleted successfully.")
                    DogDisplay()

                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    If Con.State = ConnectionState.Open Then
                        Con.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a dog to delete.")
        End If
    End Sub

    Private Sub Adgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Adgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Adgv.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Dname").Value.ToString()
            TextBox2.Text = row.Cells("Breed").Value.ToString()
            TextBox3.Text = row.Cells("Address").Value.ToString()
            ComboBox3.SelectedItem = row.Cells("Gender").Value.ToString()
            ComboBox1.SelectedItem = row.Cells("Vaccinated").Value.ToString()
            Key = Convert.ToInt32(row.Cells("Did").Value.ToString())
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim form2 As New Adopters()
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
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim form As New Dashboard()
        Dim bounds = Me.Bounds
        AddHandler form.Load, Sub() form.Bounds = bounds
        Me.Hide()
        form.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DogDisplay()
    End Sub
End Class
