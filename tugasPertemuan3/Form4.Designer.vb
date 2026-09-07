<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        TextBoxRingkasan = New TextBox()
        PictureBoxFoto = New PictureBox()
        ProgressBarPendaftaran = New ProgressBar()
        Label2 = New Label()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(265, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 25)
        Label1.TabIndex = 0
        Label1.Text = "RINGKASAN PENDAFTARAN"
        ' 
        ' TextBoxRingkasan
        ' 
        TextBoxRingkasan.Location = New Point(265, 63)
        TextBoxRingkasan.Multiline = True
        TextBoxRingkasan.Name = "TextBoxRingkasan"
        TextBoxRingkasan.ReadOnly = True
        TextBoxRingkasan.ScrollBars = ScrollBars.Vertical
        TextBoxRingkasan.Size = New Size(285, 187)
        TextBoxRingkasan.TabIndex = 1
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.Image = CType(resources.GetObject("PictureBoxFoto.Image"), Image)
        PictureBoxFoto.Location = New Point(592, 63)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(173, 187)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFoto.TabIndex = 2
        PictureBoxFoto.TabStop = False
        ' 
        ' ProgressBarPendaftaran
        ' 
        ProgressBarPendaftaran.Location = New Point(265, 276)
        ProgressBarPendaftaran.Name = "ProgressBarPendaftaran"
        ProgressBarPendaftaran.Size = New Size(285, 34)
        ProgressBarPendaftaran.TabIndex = 3
        ProgressBarPendaftaran.Value = 100
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 4
        Label2.Text = "Data"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(ProgressBarPendaftaran)
        Controls.Add(PictureBoxFoto)
        Controls.Add(TextBoxRingkasan)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Ringkasan Data"
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRingkasan As TextBox
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents ProgressBarPendaftaran As ProgressBar
    Friend WithEvents Label2 As Label
End Class
