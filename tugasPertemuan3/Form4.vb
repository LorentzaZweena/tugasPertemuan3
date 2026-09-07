Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBarPendaftaran.Minimum = 0
        ProgressBarPendaftaran.Maximum = 100
        ProgressBarPendaftaran.Value = 100

        TextBoxRingkasan.Text =
            "RINGKASAN PENDAFTARAN SEMINAR" & vbCrLf & vbCrLf & "DATA PESERTA" & vbCrLf &
            "Nama              : " & DataPendaftaran.Nama & vbCrLf &
            "Email             : " & DataPendaftaran.Email & vbCrLf &
            "Nomor HP          : " & DataPendaftaran.NomorHP & vbCrLf &
            "Jenis Kelamin     : " & DataPendaftaran.JenisKelamin & vbCrLf &
            "Alamat            : " & DataPendaftaran.Alamat & vbCrLf &
            "Usia              : " & DataPendaftaran.Usia & " tahun" & vbCrLf &
            "Program Studi     : " & DataPendaftaran.Prodi & vbCrLf &
            "Bersedia Hadir    : " & DataPendaftaran.Bersedia & vbCrLf & vbCrLf & "DATA SEMINAR" & vbCrLf &
            "Tanggal Seminar   : " & DataPendaftaran.TanggalSeminar & vbCrLf &
            "Bidang Seminar    : " & DataPendaftaran.BidangSeminar & vbCrLf &
            "Jenis Peserta     : " & DataPendaftaran.JenisPeserta & vbCrLf &
            "Kategori Seminar  : " & DataPendaftaran.KategoriSeminar & vbCrLf &
            "Catatan           : " & DataPendaftaran.CatatanSeminar & vbCrLf & vbCrLf & "->" & vbCrLf &
            "Pendaftaran berhasil disimpan!"

    End Sub
End Class