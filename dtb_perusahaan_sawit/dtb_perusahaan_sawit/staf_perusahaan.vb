Public Class staf_perusahaan

    Private Sub Staf_perusahaanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Staf_perusahaanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Staf_perusahaanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Perusahaan_sawitDataSet)

    End Sub

    Private Sub staf_perusahaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Perusahaan_sawitDataSet.staf_perusahaan' table. You can move, or remove it, as needed.
        Me.Staf_perusahaanTableAdapter.Fill(Me.Perusahaan_sawitDataSet.staf_perusahaan)

    End Sub

    Private Sub Buttontambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttontambah.Click
        Id_KaryawanTextBox.Enabled = True
        Id_StafTextBox.Enabled = True
        Nama_StafTextBox.Enabled = True
        Lokasi_LahanTextBox.Enabled = True
        Pergudangan_Id_StafTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True

        Staf_perusahaanBindingSource.AddNew()
    End Sub

    Private Sub Buttonsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsimpan.Click
        Me.Staf_perusahaanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_KaryawanTextBox.Enabled = False
        Id_StafTextBox.Enabled = False
        Nama_StafTextBox.Enabled = False
        Lokasi_LahanTextBox.Enabled = False
        Pergudangan_Id_StafTextBox.Enabled = False

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonsimpan.Enabled = False
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Nama_StafTextBox.Enabled = True
        Lokasi_LahanTextBox.Enabled = True
        Pergudangan_Id_StafTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True
    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Staf_perusahaanBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Staf_perusahaanBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

            MessageBox.Show("DATA TELAH DI HAPUS")
        End If
    End Sub

    Private Sub Buttonbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbatal.Click
        Staf_perusahaanBindingSource.CancelEdit()

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonrefresh.Enabled = True
        Buttonsimpan.Enabled = False
        Buttonbatal.Enabled = False
    End Sub

    Private Sub Buttonrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonrefresh.Click
        Me.Staf_perusahaanTableAdapter.Fill(Me.Perusahaan_sawitDataSet.staf_perusahaan)
    End Sub

    Private Sub Buttonkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkeluar.Click
        Me.Close()
    End Sub
End Class