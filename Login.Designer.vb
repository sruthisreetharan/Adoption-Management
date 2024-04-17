<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Button2 = New Button()
        Button1 = New Button()
        PasswordTb = New TextBox()
        UnameTb = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(467, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 31
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(184, 331)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 30
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(359, 254)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(202, 27)
        PasswordTb.TabIndex = 29
        ' 
        ' UnameTb
        ' 
        UnameTb.Location = New Point(359, 175)
        UnameTb.Name = "UnameTb"
        UnameTb.Size = New Size(202, 27)
        UnameTb.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(184, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 27
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(184, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 26
        Label2.Text = "USERNAME"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(324, 37)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Tan
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(271, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 25)
        Label1.TabIndex = 24
        Label1.Text = "ANIMAL ADOPTION"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Tan
        PictureBox2.Location = New Point(0, -17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(802, 128)
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(803, 455)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PasswordTb)
        Controls.Add(UnameTb)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Login"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
