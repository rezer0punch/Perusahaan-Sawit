<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relasi_perusahaan
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
        Dim Id_StafLabel As System.Windows.Forms.Label
        Dim Id_PerusahaanLabel As System.Windows.Forms.Label
        Dim Nama_PerusahaanLabel As System.Windows.Forms.Label
        Dim Lokasi_LahanLabel As System.Windows.Forms.Label
        Dim Hasil_PanenLabel As System.Windows.Forms.Label
        Dim Keuangan_Id_KaryawanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relasi_perusahaan))
        Me.Perusahaan_sawitDataSet = New dtb_perusahaan_sawit.perusahaan_sawitDataSet()
        Me.Relasi_perusahaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Relasi_perusahaanTableAdapter = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.relasi_perusahaanTableAdapter()
        Me.TableAdapterManager = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager()
        Me.Relasi_perusahaanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Relasi_perusahaanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Relasi_perusahaanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buttonkeluar = New System.Windows.Forms.Button()
        Me.Buttonrefresh = New System.Windows.Forms.Button()
        Me.Buttonbatal = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.Id_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_PerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.Lokasi_LahanTextBox = New System.Windows.Forms.TextBox()
        Me.Hasil_PanenTextBox = New System.Windows.Forms.TextBox()
        Me.Keuangan_Id_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Id_StafLabel = New System.Windows.Forms.Label()
        Id_PerusahaanLabel = New System.Windows.Forms.Label()
        Nama_PerusahaanLabel = New System.Windows.Forms.Label()
        Lokasi_LahanLabel = New System.Windows.Forms.Label()
        Hasil_PanenLabel = New System.Windows.Forms.Label()
        Keuangan_Id_KaryawanLabel = New System.Windows.Forms.Label()
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Relasi_perusahaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Relasi_perusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Relasi_perusahaanBindingNavigator.SuspendLayout()
        CType(Me.Relasi_perusahaanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_StafLabel
        '
        Id_StafLabel.AutoSize = True
        Id_StafLabel.Location = New System.Drawing.Point(6, 40)
        Id_StafLabel.Name = "Id_StafLabel"
        Id_StafLabel.Size = New System.Drawing.Size(41, 13)
        Id_StafLabel.TabIndex = 0
        Id_StafLabel.Text = "Id Staf:"
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
        'Nama_PerusahaanLabel
        '
        Nama_PerusahaanLabel.AutoSize = True
        Nama_PerusahaanLabel.Location = New System.Drawing.Point(6, 92)
        Nama_PerusahaanLabel.Name = "Nama_PerusahaanLabel"
        Nama_PerusahaanLabel.Size = New System.Drawing.Size(98, 13)
        Nama_PerusahaanLabel.TabIndex = 4
        Nama_PerusahaanLabel.Text = "Nama Perusahaan:"
        '
        'Lokasi_LahanLabel
        '
        Lokasi_LahanLabel.AutoSize = True
        Lokasi_LahanLabel.Location = New System.Drawing.Point(6, 118)
        Lokasi_LahanLabel.Name = "Lokasi_LahanLabel"
        Lokasi_LahanLabel.Size = New System.Drawing.Size(74, 13)
        Lokasi_LahanLabel.TabIndex = 6
        Lokasi_LahanLabel.Text = "Lokasi Lahan:"
        '
        'Hasil_PanenLabel
        '
        Hasil_PanenLabel.AutoSize = True
        Hasil_PanenLabel.Location = New System.Drawing.Point(6, 144)
        Hasil_PanenLabel.Name = "Hasil_PanenLabel"
        Hasil_PanenLabel.Size = New System.Drawing.Size(67, 13)
        Hasil_PanenLabel.TabIndex = 8
        Hasil_PanenLabel.Text = "Hasil Panen:"
        '
        'Keuangan_Id_KaryawanLabel
        '
        Keuangan_Id_KaryawanLabel.AutoSize = True
        Keuangan_Id_KaryawanLabel.Location = New System.Drawing.Point(6, 170)
        Keuangan_Id_KaryawanLabel.Name = "Keuangan_Id_KaryawanLabel"
        Keuangan_Id_KaryawanLabel.Size = New System.Drawing.Size(121, 13)
        Keuangan_Id_KaryawanLabel.TabIndex = 10
        Keuangan_Id_KaryawanLabel.Text = "Keuangan Id Karyawan:"
        '
        'Perusahaan_sawitDataSet
        '
        Me.Perusahaan_sawitDataSet.DataSetName = "perusahaan_sawitDataSet"
        Me.Perusahaan_sawitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Relasi_perusahaanBindingSource
        '
        Me.Relasi_perusahaanBindingSource.DataMember = "relasi_perusahaan"
        Me.Relasi_perusahaanBindingSource.DataSource = Me.Perusahaan_sawitDataSet
        '
        'Relasi_perusahaanTableAdapter
        '
        Me.Relasi_perusahaanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.pergudanganTableAdapter = Nothing
        Me.TableAdapterManager.perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.relasi_perusahaanTableAdapter = Me.Relasi_perusahaanTableAdapter
        Me.TableAdapterManager.staf_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Relasi_perusahaanBindingNavigator
        '
        Me.Relasi_perusahaanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Relasi_perusahaanBindingNavigator.BindingSource = Me.Relasi_perusahaanBindingSource
        Me.Relasi_perusahaanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Relasi_perusahaanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Relasi_perusahaanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Relasi_perusahaanBindingNavigatorSaveItem})
        Me.Relasi_perusahaanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Relasi_perusahaanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Relasi_perusahaanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Relasi_perusahaanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Relasi_perusahaanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Relasi_perusahaanBindingNavigator.Name = "Relasi_perusahaanBindingNavigator"
        Me.Relasi_perusahaanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Relasi_perusahaanBindingNavigator.Size = New System.Drawing.Size(1032, 25)
        Me.Relasi_perusahaanBindingNavigator.TabIndex = 0
        Me.Relasi_perusahaanBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Relasi_perusahaanBindingNavigatorSaveItem
        '
        Me.Relasi_perusahaanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Relasi_perusahaanBindingNavigatorSaveItem.Image = CType(resources.GetObject("Relasi_perusahaanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Relasi_perusahaanBindingNavigatorSaveItem.Name = "Relasi_perusahaanBindingNavigatorSaveItem"
        Me.Relasi_perusahaanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Relasi_perusahaanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Relasi_perusahaanDataGridView
        '
        Me.Relasi_perusahaanDataGridView.AutoGenerateColumns = False
        Me.Relasi_perusahaanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Relasi_perusahaanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Relasi_perusahaanDataGridView.DataSource = Me.Relasi_perusahaanBindingSource
        Me.Relasi_perusahaanDataGridView.Location = New System.Drawing.Point(394, 57)
        Me.Relasi_perusahaanDataGridView.Name = "Relasi_perusahaanDataGridView"
        Me.Relasi_perusahaanDataGridView.Size = New System.Drawing.Size(638, 431)
        Me.Relasi_perusahaanDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Staf"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Staf"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nama_Perusahaan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama_Perusahaan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lokasi_Lahan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lokasi_Lahan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Keuangan_Id_Karyawan"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Keuangan_Id_Karyawan"
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
        Me.GroupBox1.Controls.Add(Id_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Id_StafTextBox)
        Me.GroupBox1.Controls.Add(Id_PerusahaanLabel)
        Me.GroupBox1.Controls.Add(Me.Id_PerusahaanTextBox)
        Me.GroupBox1.Controls.Add(Nama_PerusahaanLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_PerusahaanTextBox)
        Me.GroupBox1.Controls.Add(Lokasi_LahanLabel)
        Me.GroupBox1.Controls.Add(Me.Lokasi_LahanTextBox)
        Me.GroupBox1.Controls.Add(Hasil_PanenLabel)
        Me.GroupBox1.Controls.Add(Me.Hasil_PanenTextBox)
        Me.GroupBox1.Controls.Add(Keuangan_Id_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Keuangan_Id_KaryawanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 420)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA RELASI PERUSAHAAN"
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Location = New System.Drawing.Point(135, 290)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(109, 32)
        Me.Buttonkeluar.TabIndex = 28
        Me.Buttonkeluar.Text = "KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonrefresh
        '
        Me.Buttonrefresh.Location = New System.Drawing.Point(241, 252)
        Me.Buttonrefresh.Name = "Buttonrefresh"
        Me.Buttonrefresh.Size = New System.Drawing.Size(90, 32)
        Me.Buttonrefresh.TabIndex = 27
        Me.Buttonrefresh.Text = "REFRESH"
        Me.Buttonrefresh.UseVisualStyleBackColor = True
        '
        'Buttonbatal
        '
        Me.Buttonbatal.Location = New System.Drawing.Point(147, 252)
        Me.Buttonbatal.Name = "Buttonbatal"
        Me.Buttonbatal.Size = New System.Drawing.Size(88, 32)
        Me.Buttonbatal.TabIndex = 26
        Me.Buttonbatal.Text = "BATAL"
        Me.Buttonbatal.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(48, 252)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(93, 32)
        Me.Buttonhapus.TabIndex = 25
        Me.Buttonhapus.Text = "HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonedit
        '
        Me.Buttonedit.Location = New System.Drawing.Point(241, 214)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(90, 32)
        Me.Buttonedit.TabIndex = 24
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Location = New System.Drawing.Point(147, 214)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 32)
        Me.Buttonsimpan.TabIndex = 23
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(48, 214)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(93, 32)
        Me.Buttontambah.TabIndex = 22
        Me.Buttontambah.Text = "TAMBAH"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'Id_StafTextBox
        '
        Me.Id_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Id_Staf", True))
        Me.Id_StafTextBox.Location = New System.Drawing.Point(133, 37)
        Me.Id_StafTextBox.Name = "Id_StafTextBox"
        Me.Id_StafTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Id_StafTextBox.TabIndex = 1
        '
        'Id_PerusahaanTextBox
        '
        Me.Id_PerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Id_Perusahaan", True))
        Me.Id_PerusahaanTextBox.Location = New System.Drawing.Point(133, 63)
        Me.Id_PerusahaanTextBox.Name = "Id_PerusahaanTextBox"
        Me.Id_PerusahaanTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Id_PerusahaanTextBox.TabIndex = 3
        '
        'Nama_PerusahaanTextBox
        '
        Me.Nama_PerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Nama_Perusahaan", True))
        Me.Nama_PerusahaanTextBox.Location = New System.Drawing.Point(133, 89)
        Me.Nama_PerusahaanTextBox.Name = "Nama_PerusahaanTextBox"
        Me.Nama_PerusahaanTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Nama_PerusahaanTextBox.TabIndex = 5
        '
        'Lokasi_LahanTextBox
        '
        Me.Lokasi_LahanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Lokasi_Lahan", True))
        Me.Lokasi_LahanTextBox.Location = New System.Drawing.Point(133, 115)
        Me.Lokasi_LahanTextBox.Name = "Lokasi_LahanTextBox"
        Me.Lokasi_LahanTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Lokasi_LahanTextBox.TabIndex = 7
        '
        'Hasil_PanenTextBox
        '
        Me.Hasil_PanenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Hasil_Panen", True))
        Me.Hasil_PanenTextBox.Location = New System.Drawing.Point(133, 141)
        Me.Hasil_PanenTextBox.Name = "Hasil_PanenTextBox"
        Me.Hasil_PanenTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Hasil_PanenTextBox.TabIndex = 9
        '
        'Keuangan_Id_KaryawanTextBox
        '
        Me.Keuangan_Id_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Relasi_perusahaanBindingSource, "Keuangan_Id_Karyawan", True))
        Me.Keuangan_Id_KaryawanTextBox.Location = New System.Drawing.Point(133, 167)
        Me.Keuangan_Id_KaryawanTextBox.Name = "Keuangan_Id_KaryawanTextBox"
        Me.Keuangan_Id_KaryawanTextBox.Size = New System.Drawing.Size(237, 20)
        Me.Keuangan_Id_KaryawanTextBox.TabIndex = 11
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(770, 21)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(74, 32)
        Me.Buttoncari.TabIndex = 19
        Me.Buttoncari.Text = "CARI"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(394, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 20)
        Me.TextBox1.TabIndex = 18
        '
        'relasi_perusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 520)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Relasi_perusahaanDataGridView)
        Me.Controls.Add(Me.Relasi_perusahaanBindingNavigator)
        Me.Name = "relasi_perusahaan"
        Me.Text = "RELASI PERUSAHAAN"
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Relasi_perusahaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Relasi_perusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Relasi_perusahaanBindingNavigator.ResumeLayout(False)
        Me.Relasi_perusahaanBindingNavigator.PerformLayout()
        CType(Me.Relasi_perusahaanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Perusahaan_sawitDataSet As dtb_perusahaan_sawit.perusahaan_sawitDataSet
    Friend WithEvents Relasi_perusahaanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Relasi_perusahaanTableAdapter As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.relasi_perusahaanTableAdapter
    Friend WithEvents TableAdapterManager As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Relasi_perusahaanBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Relasi_perusahaanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Relasi_perusahaanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_PerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_PerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lokasi_LahanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_PanenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Keuangan_Id_KaryawanTextBox As System.Windows.Forms.TextBox
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
