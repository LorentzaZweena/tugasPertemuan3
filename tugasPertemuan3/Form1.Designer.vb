<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        ButtonPeserta = New Button()
        ButtonSeminar = New Button()
        ButtonRingkasan = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(542, 36)
        Label1.TabIndex = 0
        Label1.Text = "SISTEM PENDAFTARAN SEMINAR"
        ' 
        ' ButtonPeserta
        ' 
        ButtonPeserta.Location = New Point(301, 88)
        ButtonPeserta.Name = "ButtonPeserta"
        ButtonPeserta.Size = New Size(160, 34)
        ButtonPeserta.TabIndex = 1
        ButtonPeserta.Text = "DATA PESERTA"
        ButtonPeserta.UseVisualStyleBackColor = True
        ' 
        ' ButtonSeminar
        ' 
        ButtonSeminar.Location = New Point(301, 155)
        ButtonSeminar.Name = "ButtonSeminar"
        ButtonSeminar.Size = New Size(148, 34)
        ButtonSeminar.TabIndex = 2
        ButtonSeminar.Text = "DATA SEMINAR"
        ButtonSeminar.UseVisualStyleBackColor = True
        ' 
        ' ButtonRingkasan
        ' 
        ButtonRingkasan.Location = New Point(301, 225)
        ButtonRingkasan.Name = "ButtonRingkasan"
        ButtonRingkasan.Size = New Size(173, 34)
        ButtonRingkasan.TabIndex = 3
        ButtonRingkasan.Text = "RINGKASAN DATA"
        ButtonRingkasan.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonRingkasan)
        Controls.Add(ButtonSeminar)
        Controls.Add(ButtonPeserta)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Pendaftaran Seminar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonPeserta As Button
    Friend WithEvents ButtonSeminar As Button
    Friend WithEvents ButtonRingkasan As Button

End Class
