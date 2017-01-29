<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class keuangan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(keuangan))
        Dim Id_KaryawanLabel As System.Windows.Forms.Label
        Dim Id_PerusahaanLabel As System.Windows.Forms.Label
        Dim Hasil_PanenLabel As System.Windows.Forms.Label
        Dim Nama_PerusahaanLabel As System.Windows.Forms.Label
        Dim PembayaranLabel As System.Windows.Forms.Label
        Dim Perusahaan_Id_KaryawanLabel As System.Windows.Forms.Label
        Me.Perusahaan_sawitDataSet = New dtb_perusahaan_sawit.perusahaan_sawitDataSet()
        Me.KeuanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KeuanganTableAdapter = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.keuanganTableAdapter()
        Me.TableAdapterManager = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager()
        Me.KeuanganBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.KeuanganBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KeuanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.Hasil_PanenTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_PerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.PembayaranTextBox = New System.Windows.Forms.TextBox()
        Me.Perusahaan_Id_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Buttonkeluar = New System.Windows.Forms.Button()
        Me.Buttonrefresh = New System.Windows.Forms.Button()
        Me.Buttonbatal = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Id_KaryawanLabel = New System.Windows.Forms.Label()
        Id_PerusahaanLabel = New System.Windows.Forms.Label()
        Hasil_PanenLabel = New System.Windows.Forms.Label()
        Nama_PerusahaanLabel = New System.Windows.Forms.Label()
        PembayaranLabel = New System.Windows.Forms.Label()
        Perusahaan_Id_KaryawanLabel = New System.Windows.Forms.Label()
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeuanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeuanganBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KeuanganBindingNavigator.SuspendLayout()
        CType(Me.KeuanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Perusahaan_sawitDataSet
        '
        Me.Perusahaan_sawitDataSet.DataSetName = "perusahaan_sawitDataSet"
        Me.Perusahaan_sawitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KeuanganBindingSource
        '
        Me.KeuanganBindingSource.DataMember = "keuangan"
        Me.KeuanganBindingSource.DataSource = Me.Perusahaan_sawitDataSet
        '
        'KeuanganTableAdapter
        '
        Me.KeuanganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.keuanganTableAdapter = Me.KeuanganTableAdapter
        Me.TableAdapterManager.pergudanganTableAdapter = Nothing
        Me.TableAdapterManager.perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.relasi_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.staf_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KeuanganBindingNavigator
        '
        Me.KeuanganBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KeuanganBindingNavigator.BindingSource = Me.KeuanganBindingSource
        Me.KeuanganBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KeuanganBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KeuanganBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KeuanganBindingNavigatorSaveItem})
        Me.KeuanganBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KeuanganBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KeuanganBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KeuanganBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KeuanganBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KeuanganBindingNavigator.Name = "KeuanganBindingNavigator"
        Me.KeuanganBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KeuanganBindingNavigator.Size = New System.Drawing.Size(871, 25)
        Me.KeuanganBindingNavigator.TabIndex = 0
        Me.KeuanganBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'KeuanganBindingNavigatorSaveItem
        '
        Me.KeuanganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KeuanganBindingNavigatorSaveItem.Image = CType(resources.GetObject("KeuanganBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KeuanganBindingNavigatorSaveItem.Name = "KeuanganBindingNavigatorSaveItem"
        Me.KeuanganBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.KeuanganBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KeuanganDataGridView
        '
        Me.KeuanganDataGridView.AutoGenerateColumns = False
        Me.KeuanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KeuanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.KeuanganDataGridView.DataSource = Me.KeuanganBindingSource
        Me.KeuanganDataGridView.Location = New System.Drawing.Point(404, 62)
        Me.KeuanganDataGridView.Name = "KeuanganDataGridView"
        Me.KeuanganDataGridView.Size = New System.Drawing.Size(455, 416)
        Me.KeuanganDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Perusahaan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Perusahaan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nama_Perusahaan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama_Perusahaan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pembayaran"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pembayaran"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Perusahaan_Id_Karyawan"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Perusahaan_Id_Karyawan"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buttonkeluar)
        Me.GroupBox1.Controls.Add(Me.Buttonrefresh)
        Me.GroupBox1.Controls.Add(Me.Buttonbatal)
        Me.GroupBox1.Controls.Add(Me.Buttonhapus)
        Me.GroupBox1.Controls.Add(Me.Buttonedit)
        Me.GroupBox1.Controls.Add(Me.Buttonsimpan)
        Me.GroupBox1.Controls.Add(Me.Buttontambah)
        Me.GroupBox1.Controls.Add(Id_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Id_KaryawanTextBox)
        Me.GroupBox1.Controls.Add(Id_PerusahaanLabel)
        Me.GroupBox1.Controls.Add(Me.Id_PerusahaanTextBox)
        Me.GroupBox1.Controls.Add(Hasil_PanenLabel)
        Me.GroupBox1.Controls.Add(Me.Hasil_PanenTextBox)
        Me.GroupBox1.Controls.Add(Nama_PerusahaanLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_PerusahaanTextBox)
        Me.GroupBox1.Controls.Add(PembayaranLabel)
        Me.GroupBox1.Controls.Add(Me.PembayaranTextBox)
        Me.GroupBox1.Controls.Add(Perusahaan_Id_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Perusahaan_Id_KaryawanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 415)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA KEUANGAN"
        '
        'Id_KaryawanLabel
        '
        Id_KaryawanLabel.AutoSize = True
        Id_KaryawanLabel.Location = New System.Drawing.Point(6, 40)
        Id_KaryawanLabel.Name = "Id_KaryawanLabel"
        Id_KaryawanLabel.Size = New System.Drawing.Size(69, 13)
        Id_KaryawanLabel.TabIndex = 0
        Id_KaryawanLabel.Text = "Id Karyawan:"
        '
        'Id_KaryawanTextBox
        '
        Me.Id_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Id_Karyawan", True))
        Me.Id_KaryawanTextBox.Location = New System.Drawing.Point(141, 37)
        Me.Id_KaryawanTextBox.Name = "Id_KaryawanTextBox"
        Me.Id_KaryawanTextBox.Size = New System.Drawing.Size(405, 20)
        Me.Id_KaryawanTextBox.TabIndex = 1
        '
        'Id_PerusahaanLabel
        '
        Id_PerusahaanLabel.AutoSize = True
        Id_PerusahaanLabel.Location = New System.Drawing.Point(6, 66)
        Id_PerusahaanLabel.Name = "Id_PerusahaanLabel"
        Id_PerusahaanLabel.Size = New System.Drawing.Size(79, 13)
        Id_PerusahaanLabel.TabIndex = 2
        Id_PerusahaanLabel.Text = "Id Perusahaan:"
        '
        'Id_PerusahaanTextBox
        '
        Me.Id_PerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Id_Perusahaan", True))
        Me.Id_PerusahaanTextBox.Location = New System.Drawing.Point(141, 63)
        Me.Id_PerusahaanTextBox.Name = "Id_PerusahaanTextBox"
        Me.Id_PerusahaanTextBox.Size = New System.Drawing.Size(405, 20)
        Me.Id_PerusahaanTextBox.TabIndex = 3
        '
        'Hasil_PanenLabel
        '
        Hasil_PanenLabel.AutoSize = True
        Hasil_PanenLabel.Location = New System.Drawing.Point(6, 92)
        Hasil_PanenLabel.Name = "Hasil_PanenLabel"
        Hasil_PanenLabel.Size = New System.Drawing.Size(67, 13)
        Hasil_PanenLabel.TabIndex = 4
        Hasil_PanenLabel.Text = "Hasil Panen:"
        '
        'Hasil_PanenTextBox
        '
        Me.Hasil_PanenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Hasil_Panen", True))
        Me.Hasil_PanenTextBox.Location = New System.Drawing.Point(141, 89)
        Me.Hasil_PanenTextBox.Name = "Hasil_PanenTextBox"
        Me.Hasil_PanenTextBox.Size = New System.Drawing.Size(405, 20)
        Me.Hasil_PanenTextBox.TabIndex = 5
        '
        'Nama_PerusahaanLabel
        '
        Nama_PerusahaanLabel.AutoSize = True
        Nama_PerusahaanLabel.Location = New System.Drawing.Point(6, 118)
        Nama_PerusahaanLabel.Name = "Nama_PerusahaanLabel"
        Nama_PerusahaanLabel.Size = New System.Drawing.Size(98, 13)
        Nama_PerusahaanLabel.TabIndex = 6
        Nama_PerusahaanLabel.Text = "Nama Perusahaan:"
        '
        'Nama_PerusahaanTextBox
        '
        Me.Nama_PerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Nama_Perusahaan", True))
        Me.Nama_PerusahaanTextBox.Location = New System.Drawing.Point(141, 115)
        Me.Nama_PerusahaanTextBox.Name = "Nama_PerusahaanTextBox"
        Me.Nama_PerusahaanTextBox.Size = New System.Drawing.Size(405, 20)
        Me.Nama_PerusahaanTextBox.TabIndex = 7
        '
        'PembayaranLabel
        '
        PembayaranLabel.AutoSize = True
        PembayaranLabel.Location = New System.Drawing.Point(6, 144)
        PembayaranLabel.Name = "PembayaranLabel"
        PembayaranLabel.Size = New System.Drawing.Size(69, 13)
        PembayaranLabel.TabIndex = 8
        PembayaranLabel.Text = "Pembayaran:"
        '
        'PembayaranTextBox
        '
        Me.PembayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Pembayaran", True))
        Me.PembayaranTextBox.Location = New System.Drawing.Point(141, 141)
        Me.PembayaranTextBox.Name = "PembayaranTextBox"
        Me.PembayaranTextBox.Size = New System.Drawing.Size(405, 20)
        Me.PembayaranTextBox.TabIndex = 9
        '
        'Perusahaan_Id_KaryawanLabel
        '
        Perusahaan_Id_KaryawanLabel.AutoSize = True
        Perusahaan_Id_KaryawanLabel.Location = New System.Drawing.Point(6, 170)
        Perusahaan_Id_KaryawanLabel.Name = "Perusahaan_Id_KaryawanLabel"
        Perusahaan_Id_KaryawanLabel.Size = New System.Drawing.Size(129, 13)
        Perusahaan_Id_KaryawanLabel.TabIndex = 10
        Perusahaan_Id_KaryawanLabel.Text = "Perusahaan Id Karyawan:"
        '
        'Perusahaan_Id_KaryawanTextBox
        '
        Me.Perusahaan_Id_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "Perusahaan_Id_Karyawan", True))
        Me.Perusahaan_Id_KaryawanTextBox.Location = New System.Drawing.Point(141, 167)
        Me.Perusahaan_Id_KaryawanTextBox.Name = "Perusahaan_Id_KaryawanTextBox"
        Me.Perusahaan_Id_KaryawanTextBox.Size = New System.Drawing.Size(405, 20)
        Me.Perusahaan_Id_KaryawanTextBox.TabIndex = 11
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Location = New System.Drawing.Point(154, 289)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(109, 32)
        Me.Buttonkeluar.TabIndex = 42
        Me.Buttonkeluar.Text = "KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonrefresh
        '
        Me.Buttonrefresh.Location = New System.Drawing.Point(260, 251)
        Me.Buttonrefresh.Name = "Buttonrefresh"
        Me.Buttonrefresh.Size = New System.Drawing.Size(90, 32)
        Me.Buttonrefresh.TabIndex = 41
        Me.Buttonrefresh.Text = "REFRESH"
        Me.Buttonrefresh.UseVisualStyleBackColor = True
        '
        'Buttonbatal
        '
        Me.Buttonbatal.Location = New System.Drawing.Point(166, 251)
        Me.Buttonbatal.Name = "Buttonbatal"
        Me.Buttonbatal.Size = New System.Drawing.Size(88, 32)
        Me.Buttonbatal.TabIndex = 40
        Me.Buttonbatal.Text = "BATAL"
        Me.Buttonbatal.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(67, 251)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(93, 32)
        Me.Buttonhapus.TabIndex = 39
        Me.Buttonhapus.Text = "HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonedit
        '
        Me.Buttonedit.Location = New System.Drawing.Point(260, 213)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(90, 32)
        Me.Buttonedit.TabIndex = 38
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Location = New System.Drawing.Point(166, 213)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 32)
        Me.Buttonsimpan.TabIndex = 37
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(67, 213)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(93, 32)
        Me.Buttontambah.TabIndex = 36
        Me.Buttontambah.Text = "TAMBAH"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(780, 21)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(74, 32)
        Me.Buttoncari.TabIndex = 23
        Me.Buttoncari.Text = "CARI"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(404, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 20)
        Me.TextBox1.TabIndex = 22
        '
        'keuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 564)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KeuanganDataGridView)
        Me.Controls.Add(Me.KeuanganBindingNavigator)
        Me.Name = "keuangan"
        Me.Text = "KEUANGAN"
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeuanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeuanganBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KeuanganBindingNavigator.ResumeLayout(False)
        Me.KeuanganBindingNavigator.PerformLayout()
        CType(Me.KeuanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Perusahaan_sawitDataSet As dtb_perusahaan_sawit.perusahaan_sawitDataSet
    Friend WithEvents KeuanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KeuanganTableAdapter As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.keuanganTableAdapter
    Friend WithEvents TableAdapterManager As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KeuanganBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeuanganBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KeuanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_PerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_PanenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_PerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PembayaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Perusahaan_Id_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Buttonkeluar As System.Windows.Forms.Button
    Friend WithEvents Buttonrefresh As System.Windows.Forms.Button
    Friend WithEvents Buttonbatal As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
    Friend WithEvents Buttonedit As System.Windows.Forms.Button
    Friend WithEvents Buttonsimpan As System.Windows.Forms.Button
    Friend WithEvents Buttontambah As System.Windows.Forms.Button
    Friend WithEvents Buttoncari As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
