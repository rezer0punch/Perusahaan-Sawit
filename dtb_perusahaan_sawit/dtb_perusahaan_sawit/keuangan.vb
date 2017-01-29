Public Class keuangan

    Private Sub KeuanganBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeuanganBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KeuanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Perusahaan_sawitDataSet)

    End Sub

    Private Sub keuangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Perusahaan_sawitDataSet.keuangan' table. You can move, or remove it, as needed.
        Me.KeuanganTableAdapter.Fill(Me.Perusahaan_sawitDataSet.keuangan)

    End Sub

    Private Sub Buttontambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttontambah.Click
        Id_KaryawanTextBox.Enabled = True
        Id_PerusahaanTextBox.Enabled = True
        Hasil_PanenTextBox.Enabled = True
        Nama_PerusahaanTextBox.Enabled = True
        PembayaranTextBox.Enabled = True
        Perusahaan_Id_KaryawanTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True

        KeuanganBindingSource.AddNew()
    End Sub

    Private Sub Buttonsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsimpan.Click
        Me.KeuanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_KaryawanTextBox.Enabled = False
        Id_PerusahaanTextBox.Enabled = False
        Hasil_PanenTextBox.Enabled = False
        Nama_PerusahaanTextBox.Enabled = False
        PembayaranTextBox.Enabled = False
        Perusahaan_Id_KaryawanTextBox.Enabled = False

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonsimpan.Enabled = False
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Hasil_PanenTextBox.Enabled = True
        Nama_PerusahaanTextBox.Enabled = True
        PembayaranTextBox.Enabled = True
        Perusahaan_Id_KaryawanTextBox.Enabled = True


        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True
    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            KeuanganBindingSource.RemoveCurrent()

            Me.Validate()
            Me.KeuanganBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

            MessageBox.Show("DATA TELAH DI HAPUS")
        End If
    End Sub

    Private Sub Buttonbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbatal.Click
        KeuanganBindingSource.CancelEdit()

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonrefresh.Enabled = True
        Buttonsimpan.Enabled = False
        Buttonbatal.Enabled = False
    End Sub

    Private Sub Buttonrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonrefresh.Click
        Me.KeuanganTableAdapter.Fill(Me.Perusahaan_sawitDataSet.keuangan)
    End Sub

    Private Sub Buttonkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkeluar.Click
        Me.Close()
    End Sub
End Class