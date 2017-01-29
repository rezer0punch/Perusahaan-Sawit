Public Class perusahaan

    Private Sub PerusahaanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerusahaanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PerusahaanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Perusahaan_sawitDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Perusahaan_sawitDataSet.perusahaan' table. You can move, or remove it, as needed.
        Me.PerusahaanTableAdapter.Fill(Me.Perusahaan_sawitDataSet.perusahaan)

    End Sub

    Private Sub Buttontambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttontambah.Click
        Id_KaryawanTextBox.Enabled = True
        Nama_KaryawanTextBox.Enabled = True
        Jabatan_KaryawanTextBox.Enabled = True
        Staf_Perusahaan_Id_StafTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True

        PerusahaanBindingSource.AddNew()
    End Sub

    Private Sub Buttonsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsimpan.Click
        Me.Validate()
        Me.PerusahaanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

        MessageBox.Show("DATA TELAH TERSIMPAN")

        Id_KaryawanTextBox.Enabled = False
        Nama_KaryawanTextBox.Enabled = False
        Jabatan_KaryawanTextBox.Enabled = False
        Staf_Perusahaan_Id_StafTextBox.Enabled = False

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonsimpan.Enabled = False
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Nama_KaryawanTextBox.Enabled = True
        Jabatan_KaryawanTextBox.Enabled = True
        Staf_Perusahaan_Id_StafTextBox.Enabled = True

        Buttontambah.Enabled = False
        Buttonhapus.Enabled = False
        Buttonedit.Enabled = False
        Buttonrefresh.Enabled = False
        Buttonsimpan.Enabled = True
        Buttonbatal.Enabled = True
    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PerusahaanBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PerusahaanBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Perusahaan_sawitDataSet)

            MessageBox.Show("DATA TELAH DI HAPUS")
        End If
    End Sub

    Private Sub Buttonbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbatal.Click
        PerusahaanBindingSource.CancelEdit()

        Buttontambah.Enabled = True
        Buttonhapus.Enabled = True
        Buttonedit.Enabled = True
        Buttonrefresh.Enabled = True
        Buttonsimpan.Enabled = False
        Buttonbatal.Enabled = False
    End Sub

    Private Sub Buttonrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonrefresh.Click
        Me.PerusahaanTableAdapter.Fill(Me.Perusahaan_sawitDataSet.perusahaan)
    End Sub

    Private Sub Buttonkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkeluar.Click
        Me.Close()
    End Sub
End Class
