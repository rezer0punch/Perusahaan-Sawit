<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PERUSAHAANSAWITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKeuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPergudanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPerusahaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataRelasiPerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStafPerusahaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERUSAHAANSAWITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERUSAHAANSAWITToolStripMenuItem
        '
        Me.PERUSAHAANSAWITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKeuanganToolStripMenuItem, Me.DataPergudanganToolStripMenuItem, Me.DataPerusahaanToolStripMenuItem, Me.DataRelasiPerToolStripMenuItem, Me.DataStafPerusahaanToolStripMenuItem})
        Me.PERUSAHAANSAWITToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PERUSAHAANSAWITToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PERUSAHAANSAWITToolStripMenuItem.Name = "PERUSAHAANSAWITToolStripMenuItem"
        Me.PERUSAHAANSAWITToolStripMenuItem.Size = New System.Drawing.Size(182, 23)
        Me.PERUSAHAANSAWITToolStripMenuItem.Text = "PERUSAHAAN SAWIT"
        '
        'DataKeuanganToolStripMenuItem
        '
        Me.DataKeuanganToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataKeuanganToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataKeuanganToolStripMenuItem.Name = "DataKeuanganToolStripMenuItem"
        Me.DataKeuanganToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DataKeuanganToolStripMenuItem.Text = "Data Keuangan"
        '
        'DataPergudanganToolStripMenuItem
        '
        Me.DataPergudanganToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataPergudanganToolStripMenuItem.Name = "DataPergudanganToolStripMenuItem"
        Me.DataPergudanganToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DataPergudanganToolStripMenuItem.Text = "Data Pergudangan"
        '
        'DataPerusahaanToolStripMenuItem
        '
        Me.DataPerusahaanToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataPerusahaanToolStripMenuItem.Name = "DataPerusahaanToolStripMenuItem"
        Me.DataPerusahaanToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DataPerusahaanToolStripMenuItem.Text = "Data Perusahaan"
        '
        'DataRelasiPerToolStripMenuItem
        '
        Me.DataRelasiPerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataRelasiPerToolStripMenuItem.Name = "DataRelasiPerToolStripMenuItem"
        Me.DataRelasiPerToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DataRelasiPerToolStripMenuItem.Text = "Data Relasi Perusahaan"
        '
        'DataStafPerusahaanToolStripMenuItem
        '
        Me.DataStafPerusahaanToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataStafPerusahaanToolStripMenuItem.Name = "DataStafPerusahaanToolStripMenuItem"
        Me.DataStafPerusahaanToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DataStafPerusahaanToolStripMenuItem.Text = "Data Staf Perusahaan"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dtb_perusahaan_sawit.My.Resources.Resources.babi
        Me.ClientSize = New System.Drawing.Size(797, 444)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Beranda"
        Me.Text = "Beranda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PERUSAHAANSAWITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKeuanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPergudanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPerusahaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataRelasiPerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStafPerusahaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
