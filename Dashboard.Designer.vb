<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        DogCountLabel = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        AdopterCountLabel = New Label()
        PictureBox2 = New PictureBox()
        Panel4 = New Panel()
        AdoptionCountLabel = New Label()
        PictureBox4 = New PictureBox()
        DogDataGridView = New DataGridView()
        AdopterDataGridView = New DataGridView()
        AdoptionDataGridView = New DataGridView()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DogDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(AdopterDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(AdoptionDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Tan
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(78, 303)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 25)
        Label6.TabIndex = 35
        Label6.Text = "Available Dogs"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(770, 182)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 25)
        Label5.TabIndex = 31
        Label5.Text = "Adoption"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(28, 182)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 30
        Label4.Text = "Adopters"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Tan
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(370, 182)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 29
        Label3.Text = "Dogs"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SeaShell
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(1058, 180)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 27)
        Label2.TabIndex = 28
        Label2.Text = "Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Tan
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(500, 23)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 25)
        Label1.TabIndex = 27
        Label1.Text = "ANIMAL ADOPTION"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.ImeMode = ImeMode.NoControl
        PictureBox3.Location = New Point(500, 52)
        PictureBox3.Margin = New Padding(5, 4, 5, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(237, 92)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(2, -5)
        Panel1.Margin = New Padding(5, 4, 5, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1213, 221)
        Panel1.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Tan
        Label7.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        Label7.ForeColor = SystemColors.ControlText
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(502, 303)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(197, 25)
        Label7.TabIndex = 36
        Label7.Text = "Available Adopters"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Tan
        Label8.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        Label8.ForeColor = SystemColors.ControlText
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(935, 303)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(234, 25)
        Label8.TabIndex = 37
        Label8.Text = "Adoption's Completed"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Controls.Add(DogCountLabel)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(30, 393)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 169)
        Panel2.TabIndex = 39
        ' 
        ' DogCountLabel
        ' 
        DogCountLabel.AutoSize = True
        DogCountLabel.Location = New Point(167, 82)
        DogCountLabel.Name = "DogCountLabel"
        DogCountLabel.Size = New Size(53, 20)
        DogCountLabel.TabIndex = 42
        DogCountLabel.Text = "Label9"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.Controls.Add(AdopterCountLabel)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(478, 393)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 169)
        Panel3.TabIndex = 40
        ' 
        ' AdopterCountLabel
        ' 
        AdopterCountLabel.AutoSize = True
        AdopterCountLabel.Location = New Point(160, 82)
        AdopterCountLabel.Name = "AdopterCountLabel"
        AdopterCountLabel.Size = New Size(61, 20)
        AdopterCountLabel.TabIndex = 43
        AdopterCountLabel.Text = "Label10"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 55)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Tan
        Panel4.Controls.Add(AdoptionCountLabel)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(935, 393)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 169)
        Panel4.TabIndex = 41
        ' 
        ' AdoptionCountLabel
        ' 
        AdoptionCountLabel.AutoSize = True
        AdoptionCountLabel.Location = New Point(161, 82)
        AdoptionCountLabel.Name = "AdoptionCountLabel"
        AdoptionCountLabel.Size = New Size(61, 20)
        AdoptionCountLabel.TabIndex = 44
        AdoptionCountLabel.Text = "Label11"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(3, 55)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 62)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' DogDataGridView
        ' 
        DogDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DogDataGridView.Location = New Point(30, 692)
        DogDataGridView.Name = "DogDataGridView"
        DogDataGridView.RowHeadersWidth = 51
        DogDataGridView.Size = New Size(250, 204)
        DogDataGridView.TabIndex = 43
        ' 
        ' AdopterDataGridView
        ' 
        AdopterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdopterDataGridView.Location = New Point(478, 692)
        AdopterDataGridView.Name = "AdopterDataGridView"
        AdopterDataGridView.RowHeadersWidth = 51
        AdopterDataGridView.Size = New Size(250, 204)
        AdopterDataGridView.TabIndex = 44
        ' 
        ' AdoptionDataGridView
        ' 
        AdoptionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdoptionDataGridView.Location = New Point(938, 692)
        AdoptionDataGridView.Name = "AdoptionDataGridView"
        AdoptionDataGridView.RowHeadersWidth = 51
        AdoptionDataGridView.Size = New Size(250, 204)
        AdoptionDataGridView.TabIndex = 45
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1211, 1055)
        Controls.Add(AdoptionDataGridView)
        Controls.Add(AdopterDataGridView)
        Controls.Add(DogDataGridView)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form3"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DogDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(AdopterDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(AdoptionDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DogCountLabel As Label
    Friend WithEvents AdopterCountLabel As Label
    Friend WithEvents AdoptionCountLabel As Label
    Friend WithEvents DogDataGridView As DataGridView
    Friend WithEvents AdopterDataGridView As DataGridView
    Friend WithEvents AdoptionDataGridView As DataGridView
End Class
