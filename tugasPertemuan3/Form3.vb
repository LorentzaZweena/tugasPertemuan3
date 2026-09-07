Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxBidang.Items.Clear()
        ComboBoxBidang.Items.Add("Artificial Intelligence")
        ComboBoxBidang.Items.Add("Web Development")
        ComboBoxBidang.Items.Add("Cyber Security")
        ComboBoxBidang.Items.Add("Data Science")

        ListViewPeserta.View = View.Details
        ListViewPeserta.Columns.Clear()
        ListViewPeserta.Items.Clear()

        ListViewPeserta.Columns.Add("Jenis Peserta", 150)

        ListViewPeserta.Items.Add("Mahasiswa")
        ListViewPeserta.Items.Add("Dosen")
        ListViewPeserta.Items.Add("Umum")

        TreeViewBidang.Nodes.Clear()

        Dim teknologi As TreeNode = TreeViewBidang.Nodes.Add("Teknologi")

        teknologi.Nodes.Add("Artificial Intelligence")
        teknologi.Nodes.Add("Web Development")
        teknologi.Nodes.Add("Cyber Security")

        LinkLabelSeminar.Text = "Informasi Seminar"
    End Sub

    Private Sub ButtonSimpanSeminar_Click(sender As Object, e As EventArgs) Handles ButtonSimpanSeminar.Click
        DataPendaftaran.TanggalSeminar =
            DateTimePickerSeminar.Value.ToString("dd/MM/yyyy")

        If ComboBoxBidang.SelectedItem IsNot Nothing Then
            DataPendaftaran.BidangSeminar =
                ComboBoxBidang.SelectedItem.ToString()
        Else
            DataPendaftaran.BidangSeminar = "Belum dipilih"
        End If

        If ListViewPeserta.SelectedItems.Count > 0 Then
            DataPendaftaran.JenisPeserta =
                ListViewPeserta.SelectedItems(0).Text
        Else
            DataPendaftaran.JenisPeserta = "Belum dipilih"
        End If

        If TreeViewBidang.SelectedNode IsNot Nothing Then
            DataPendaftaran.KategoriSeminar =
                TreeViewBidang.SelectedNode.Text
        Else
            DataPendaftaran.KategoriSeminar = "Belum dipilih"
        End If

        DataPendaftaran.CatatanSeminar = RichTextBoxCatatan.Text

        Form4.Show()

        Me.Hide()
    End Sub

    Private Sub LinkLabelSeminar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSeminar.LinkClicked
        Dim psi As New System.Diagnostics.ProcessStartInfo With {
        .FileName = "https://www.pnj.ac.id/",
        .UseShellExecute = True
    }

        System.Diagnostics.Process.Start(psi)
    End Sub
End Class