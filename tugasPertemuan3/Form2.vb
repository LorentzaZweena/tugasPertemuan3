Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxProdi.Items.Clear()
        ListBoxProdi.Items.Add("Teknik Informatika")
        ListBoxProdi.Items.Add("Teknik Multimedia")
        ListBoxProdi.Items.Add("Teknik Elektro")
        ListBoxProdi.Items.Add("Teknik Mesin")

        NumericUpDownUsia.Minimum = 17
        NumericUpDownUsia.Maximum = 100
    End Sub

    Private Sub ListBoxProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProdi.SelectedIndexChanged

    End Sub

    Private Sub ButtonLanjut_Click(sender As Object, e As EventArgs) Handles ButtonLanjut.Click

        DataPendaftaran.Nama = TextBoxNama.Text
        DataPendaftaran.Email = TextBoxEmail.Text
        DataPendaftaran.NomorHP = MaskedTextBoxHP.Text
        DataPendaftaran.Alamat = TextBoxAlamat.Text
        DataPendaftaran.Usia = NumericUpDownUsia.Value

        If RadioLaki.Checked Then
            DataPendaftaran.JenisKelamin = "Laki-laki"
        ElseIf RadioPerempuan.Checked Then
            DataPendaftaran.JenisKelamin = "Perempuan"
        Else
            DataPendaftaran.JenisKelamin = "Belum dipilih"
        End If

        If ListBoxProdi.SelectedItem IsNot Nothing Then
            DataPendaftaran.Prodi = ListBoxProdi.SelectedItem.ToString()
        Else
            DataPendaftaran.Prodi = "Belum dipilih"
        End If

        If CheckBoxSeminar.Checked Then
            DataPendaftaran.Bersedia = "Ya"
        Else
            DataPendaftaran.Bersedia = "Tidak"
        End If

        Form3.Show()
        Me.Hide()
    End Sub
End Class