Public Class Pergudangan

    Private Sub PergudanganBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PergudanganBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PergudanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Perusahaan_sawitDataSet)

    End Sub

    Private Sub Pergudangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Perusahaan_sawitDataSet.pergudangan' table. You can move, or remove it, as needed.
        Me.PergudanganTableAdapter.Fill(Me.Perusahaan_sawitDataSet.pergudangan)

    End Sub

    Private Sub Buttontambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttontambah.Click
        Id_StafTextBox.Enabled = True
        Nama_StafTextBox.Enabled = True
        Lokasi_LahanTextBox.Enabled = True
        Hasil_PanenTextBox.Enabled = True
        Relasi_Perusahaan_Id_PerusahaanTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True

        PergudanganBindingSource.AddNew()
    End Sub

    Private Sub Buttonsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsimpan.Click
        Me.Validate()
        Me.PergudanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_StafTextBox.Enabled = False
        Nama_StafTextBox.Enabled = False
        Lokasi_LahanTextBox.Enabled = False
        Hasil_PanenTextBox.Enabled = False
        Relasi_Perusahaan_Id_PerusahaanTextBox.Enabled = False

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonsimpan.Enabled = False
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Nama_StafTextBox.Enabled = True
        Lokasi_LahanTextBox.Enabled = True
        Hasil_PanenTextBox.Enabled = True
        Relasi_Perusahaan_Id_PerusahaanTextBox.Enabled = True


        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True
    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PergudanganBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PergudanganBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

            MessageBox.Show("DATA TELAH DI HAPUS")
        End If
    End Sub

    Private Sub Buttonbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbatal.Click
        PergudanganBindingSource.CancelEdit()

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonrefresh.Enabled = True
        Buttonsimpan.Enabled = False
        Buttonbatal.Enabled = False
    End Sub

    Private Sub Buttonrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonrefresh.Click
        Me.PergudanganTableAdapter.Fill(Me.Perusahaan_sawitDataSet.pergudangan)
    End Sub

    Private Sub Buttonkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkeluar.Click
        Me.Close()
    End Sub
End Class