<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        TextBoxNama = New TextBox()
        Label2 = New Label()
        TextBoxEmail = New TextBox()
        Label3 = New Label()
        MaskedTextBoxHP = New MaskedTextBox()
        Label4 = New Label()
        RadioLaki = New RadioButton()
        RadioPerempuan = New RadioButton()
        Label5 = New Label()
        TextBoxAlamat = New TextBox()
        Label6 = New Label()
        NumericUpDownUsia = New NumericUpDown()
        CheckBoxSeminar = New CheckBox()
        ListBoxProdi = New ListBox()
        ButtonLanjut = New Button()
        CType(NumericUpDownUsia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(135, 27)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(320, 31)
        TextBoxNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(135, 92)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(320, 31)
        TextBoxEmail.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 4
        Label3.Text = "Nomor HP"
        ' 
        ' MaskedTextBoxHP
        ' 
        MaskedTextBoxHP.Location = New Point(156, 161)
        MaskedTextBoxHP.Mask = "(999) 000-0000"
        MaskedTextBoxHP.Name = "MaskedTextBoxHP"
        MaskedTextBoxHP.Size = New Size(299, 31)
        MaskedTextBoxHP.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 6
        Label4.Text = "Jenis Kelamin"
        ' 
        ' RadioLaki
        ' 
        RadioLaki.AutoSize = True
        RadioLaki.Location = New Point(177, 225)
        RadioLaki.Name = "RadioLaki"
        RadioLaki.Size = New Size(66, 29)
        RadioLaki.TabIndex = 7
        RadioLaki.TabStop = True
        RadioLaki.Text = "Pria"
        RadioLaki.UseVisualStyleBackColor = True
        ' 
        ' RadioPerempuan
        ' 
        RadioPerempuan.AutoSize = True
        RadioPerempuan.Location = New Point(290, 225)
        RadioPerempuan.Name = "RadioPerempuan"
        RadioPerempuan.Size = New Size(126, 29)
        RadioPerempuan.TabIndex = 8
        RadioPerempuan.TabStop = True
        RadioPerempuan.Text = "Perempuan"
        RadioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 9
        Label5.Text = "Alamat"
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Location = New Point(135, 285)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(320, 31)
        TextBoxAlamat.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(498, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 25)
        Label6.TabIndex = 11
        Label6.Text = "Usia"
        ' 
        ' NumericUpDownUsia
        ' 
        NumericUpDownUsia.Location = New Point(562, 27)
        NumericUpDownUsia.Minimum = New Decimal(New Integer() {17, 0, 0, 0})
        NumericUpDownUsia.Name = "NumericUpDownUsia"
        NumericUpDownUsia.Size = New Size(180, 31)
        NumericUpDownUsia.TabIndex = 12
        NumericUpDownUsia.Value = New Decimal(New Integer() {17, 0, 0, 0})
        ' 
        ' CheckBoxSeminar
        ' 
        CheckBoxSeminar.AutoSize = True
        CheckBoxSeminar.Location = New Point(498, 88)
        CheckBoxSeminar.Name = "CheckBoxSeminar"
        CheckBoxSeminar.Size = New Size(255, 29)
        CheckBoxSeminar.TabIndex = 13
        CheckBoxSeminar.Text = "Bersedia mengikuti seminar"
        CheckBoxSeminar.UseVisualStyleBackColor = True
        ' 
        ' ListBoxProdi
        ' 
        ListBoxProdi.FormattingEnabled = True
        ListBoxProdi.ItemHeight = 25
        ListBoxProdi.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Multimedia", "Teknik Elektro", "Teknik Mesin"})
        ListBoxProdi.Location = New Point(498, 136)
        ListBoxProdi.Name = "ListBoxProdi"
        ListBoxProdi.Size = New Size(180, 129)
        ListBoxProdi.TabIndex = 14
        ' 
        ' ButtonLanjut
        ' 
        ButtonLanjut.Location = New Point(498, 285)
        ButtonLanjut.Name = "ButtonLanjut"
        ButtonLanjut.Size = New Size(112, 34)
        ButtonLanjut.TabIndex = 15
        ButtonLanjut.Text = "LANJUT"
        ButtonLanjut.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 376)
        Controls.Add(ButtonLanjut)
        Controls.Add(ListBoxProdi)
        Controls.Add(CheckBoxSeminar)
        Controls.Add(NumericUpDownUsia)
        Controls.Add(Label6)
        Controls.Add(TextBoxAlamat)
        Controls.Add(Label5)
        Controls.Add(RadioPerempuan)
        Controls.Add(RadioLaki)
        Controls.Add(Label4)
        Controls.Add(MaskedTextBoxHP)
        Controls.Add(Label3)
        Controls.Add(TextBoxEmail)
        Controls.Add(Label2)
        Controls.Add(TextBoxNama)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Data Peserta"
        CType(NumericUpDownUsia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBoxHP As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioLaki As RadioButton
    Friend WithEvents RadioPerempuan As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDownUsia As NumericUpDown
    Friend WithEvents CheckBoxSeminar As CheckBox
    Friend WithEvents ListBoxProdi As ListBox
    Friend WithEvents ButtonLanjut As Button
End Class
