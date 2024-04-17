Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging

Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Dim Percentage
        Percentage = ProgressBar1.Value.ToString()
        Dim Per As String
        Per = Percentage + "%"

        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim Obj As New Login
            Obj.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
