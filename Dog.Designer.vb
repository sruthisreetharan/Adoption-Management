<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dog))
        Adgv = New DataGridView()
        Label6 = New Label()
        Panel2 = New Panel()
        DeleteBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
        TextBox3 = New TextBox()
        ComboBox3 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        CType(Adgv, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Adgv
        ' 
        Adgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adgv.Location = New Point(29, 661)
        Adgv.Name = "Adgv"
        Adgv.RowHeadersWidth = 51
        Adgv.Size = New Size(1158, 345)
        Adgv.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Tan
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        Label6.ForeColor = SystemColors.ControlText
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(550, 584)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 25)
        Label6.TabIndex = 33
        Label6.Text = "Dog List"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(AddBtn)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(ComboBox3)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Font = New Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(29, 244)
        Panel2.Margin = New Padding(5, 4, 5, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1158, 308)
        Panel2.TabIndex = 32
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.ImeMode = ImeMode.NoControl
        DeleteBtn.Location = New Point(472, 221)
        DeleteBtn.Margin = New Padding(5, 4, 5, 4)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(124, 48)
        DeleteBtn.TabIndex = 13
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' EditBtn
        ' 
        EditBtn.ImeMode = ImeMode.NoControl
        EditBtn.Location = New Point(263, 221)
        EditBtn.Margin = New Padding(5, 4, 5, 4)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(124, 48)
        EditBtn.TabIndex = 12
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' AddBtn
        ' 
        AddBtn.ImeMode = ImeMode.NoControl
        AddBtn.Location = New Point(48, 221)
        AddBtn.Margin = New Padding(5, 4, 5, 4)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(124, 48)
        AddBtn.TabIndex = 11
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Times New Roman", 9F, FontStyle.Italic)
        TextBox3.Location = New Point(773, 54)
        TextBox3.Margin = New Padding(5, 4, 5, 4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(311, 124)
        TextBox3.TabIndex = 6
        TextBox3.Text = "Address"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Times New Roman", 9F, FontStyle.Italic)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Male", "Female", "Unknown"})
        ComboBox3.Location = New Point(48, 116)
        ComboBox3.Margin = New Padding(5, 4, 5, 4)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(261, 25)
        ComboBox3.TabIndex = 5
        ComboBox3.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Times New Roman", 9F, FontStyle.Italic)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Yes", "No", "Unknown"})
        ComboBox1.Location = New Point(452, 116)
        ComboBox1.Margin = New Padding(5, 4, 5, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(220, 25)
        ComboBox1.TabIndex = 3
        ComboBox1.Text = "Vaccinated"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Times New Roman", 9F, FontStyle.Italic)
        TextBox2.Location = New Point(452, 57)
        TextBox2.Margin = New Padding(5, 4, 5, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(216, 25)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Breed"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 9F, FontStyle.Italic)
        TextBox1.Location = New Point(48, 54)
        TextBox1.Margin = New Padding(5, 4, 5, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 25)
        TextBox1.TabIndex = 1
        TextBox1.Tag = ""
        TextBox1.Text = "Dog name"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(1063, 182)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 25)
        Label5.TabIndex = 31
        Label5.Text = "Dashboard"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(735, 182)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 25)
        Label4.TabIndex = 30
        Label4.Text = "Adoption "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SeaShell
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
        Label2.BackColor = Color.Tan
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(28, 182)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 28
        Label2.Text = "Adopters"
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
        Panel1.Location = New Point(1, 0)
        Panel1.Margin = New Padding(5, 4, 5, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1234, 226)
        Panel1.TabIndex = 31
        ' 
        ' Dog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1211, 1055)
        Controls.Add(Adgv)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dog"
        StartPosition = FormStartPosition.CenterParent
        CType(Adgv, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Adgv As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
