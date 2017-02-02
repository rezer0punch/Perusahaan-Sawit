Public Class Beranda

    Private Sub DataKeuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKeuanganToolStripMenuItem.Click
        keuangan.ShowDialog()
    End Sub

    Private Sub DataPergudanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPergudanganToolStripMenuItem.Click
        Pergudangan.ShowDialog()
    End Sub

    Private Sub DataPerusahaanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPerusahaanToolStripMenuItem.Click
        perusahaan.ShowDialog()
    End Sub

    Private Sub DataRelasiPerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataRelasiPerToolStripMenuItem.Click
        relasi_perusahaan.ShowDialog()
    End Sub

    Private Sub DataStafPerusahaanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataStafPerusahaanToolStripMenuItem.Click
        staf_perusahaan.ShowDialog()
    End Sub
End Class