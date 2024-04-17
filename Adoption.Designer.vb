<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adoption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adoption))
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        DComboBox = New ComboBox()
        AComboBox = New ComboBox()
        ClearBtn = New Button()
        AdoptBtn = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        Panel1.Location = New Point(2, 1)
        Panel1.Margin = New Padding(5, 4, 5, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1234, 226)
        Panel1.TabIndex = 35
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
        Label4.BackColor = Color.SeaShell
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(735, 182)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 27)
        Label4.TabIndex = 30
        Label4.Text = "Adoption "
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
        ' DComboBox
        ' 
        DComboBox.FormattingEnabled = True
        DComboBox.Location = New Point(82, 75)
        DComboBox.Name = "DComboBox"
        DComboBox.Size = New Size(169, 28)
        DComboBox.TabIndex = 36
        DComboBox.Text = "Choose a Dog"
        ' 
        ' AComboBox
        ' 
        AComboBox.FormattingEnabled = True
        AComboBox.Location = New Point(315, 75)
        AComboBox.Name = "AComboBox"
        AComboBox.Size = New Size(169, 28)
        AComboBox.TabIndex = 37
        AComboBox.Text = "Choose an Adopter"
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(297, 186)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(145, 43)
        ClearBtn.TabIndex = 38
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' AdoptBtn
        ' 
        AdoptBtn.Location = New Point(123, 186)
        AdoptBtn.Name = "AdoptBtn"
        AdoptBtn.Size = New Size(145, 43)
        AdoptBtn.TabIndex = 39
        AdoptBtn.Text = "Adopt"
        AdoptBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Tan
        Panel2.Controls.Add(AdoptBtn)
        Panel2.Controls.Add(ClearBtn)
        Panel2.Controls.Add(AComboBox)
        Panel2.Controls.Add(DComboBox)
        Panel2.Location = New Point(319, 359)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(588, 298)
        Panel2.TabIndex = 40
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(526, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 25)
        Label6.TabIndex = 41
        Label6.Text = "Adoption Panel"
        ' 
        ' Adoption
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1211, 1055)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Cursor = Cursors.IBeam
        Name = "Adoption"
        StartPosition = FormStartPosition.CenterParent
        Text = "Adoption1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DComboBox As ComboBox
    Friend WithEvents AComboBox As ComboBox
    Friend WithEvents ClearBtn As Button
    Friend WithEvents AdoptBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
End Class
