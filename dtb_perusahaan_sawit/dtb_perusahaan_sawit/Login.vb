Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("User Name & Password Harus Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
        Else
            If TextBox1.Text = "" Then
                MsgBox("User Name Belum Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
            Else
                If TextBox2.Text = "" Then
                    MsgBox("Password Belum Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
                Else
                    If TextBox1.Text = "gengs" And TextBox2.Text = "gengs123" Then
                        MsgBox("Welcome", MsgBoxStyle.OkOnly, "Sukses")
                        Beranda.Show()
                        Call kosong()
                        Me.Hide()
                    Else
                        MsgBox("User Name / Password yang Anda Masukkan Salah", MsgBoxStyle.OkOnly, "Perhatian")
                        Call kosong()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosong()
    End Sub
    Sub kosong()
        TextBox1.text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
