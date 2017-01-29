<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staf_perusahaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staf_perusahaan))
        Dim Id_KaryawanLabel As System.Windows.Forms.Label
        Dim Id_StafLabel As System.Windows.Forms.Label
        Dim Nama_StafLabel As System.Windows.Forms.Label
        Dim Lokasi_LahanLabel As System.Windows.Forms.Label
        Dim Pergudangan_Id_StafLabel As System.Windows.Forms.Label
        Me.Perusahaan_sawitDataSet = New dtb_perusahaan_sawit.perusahaan_sawitDataSet()
        Me.Staf_perusahaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staf_perusahaanTableAdapter = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.staf_perusahaanTableAdapter()
        Me.TableAdapterManager = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager()
        Me.Staf_perusahaanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Staf_perusahaanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Staf_perusahaanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Id_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Lokasi_LahanTextBox = New System.Windows.Forms.TextBox()
        Me.Pergudangan_Id_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Buttonkeluar = New System.Windows.Forms.Button()
        Me.Buttonrefresh = New System.Windows.Forms.Button()
        Me.Buttonbatal = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Id_KaryawanLabel = New System.Windows.Forms.Label()
        Id_StafLabel = New System.Windows.Forms.Label()
        Nama_StafLabel = New System.Windows.Forms.Label()
        Lokasi_LahanLabel = New System.Windows.Forms.Label()
        Pergudangan_Id_StafLabel = New System.Windows.Forms.Label()
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staf_perusahaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staf_perusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Staf_perusahaanBindingNavigator.SuspendLayout()
        CType(Me.Staf_perusahaanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Perusahaan_sawitDataSet
        '
        Me.Perusahaan_sawitDataSet.DataSetName = "perusahaan_sawitDataSet"
        Me.Perusahaan_sawitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staf_perusahaanBindingSource
        '
        Me.Staf_perusahaanBindingSource.DataMember = "staf_perusahaan"
        Me.Staf_perusahaanBindingSource.DataSource = Me.Perusahaan_sawitDataSet
        '
        'Staf_perusahaanTableAdapter
        '
        Me.Staf_perusahaanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.pergudanganTableAdapter = Nothing
        Me.TableAdapterManager.perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.relasi_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.staf_perusahaanTableAdapter = Me.Staf_perusahaanTableAdapter
        Me.TableAdapterManager.UpdateOrder = dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Staf_perusahaanBindingNavigator
        '
        Me.Staf_perusahaanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Staf_perusahaanBindingNavigator.BindingSource = Me.Staf_perusahaanBindingSource
        Me.Staf_perusahaanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Staf_perusahaanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Staf_perusahaanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Staf_perusahaanBindingNavigatorSaveItem})
        Me.Staf_perusahaanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Staf_perusahaanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Staf_perusahaanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Staf_perusahaanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Staf_perusahaanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Staf_perusahaanBindingNavigator.Name = "Staf_perusahaanBindingNavigator"
        Me.Staf_perusahaanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Staf_perusahaanBindingNavigator.Size = New System.Drawing.Size(869, 25)
        Me.Staf_perusahaanBindingNavigator.TabIndex = 0
        Me.Staf_perusahaanBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Staf_perusahaanBindingNavigatorSaveItem
        '
        Me.Staf_perusahaanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Staf_perusahaanBindingNavigatorSaveItem.Image = CType(resources.GetObject("Staf_perusahaanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Staf_perusahaanBindingNavigatorSaveItem.Name = "Staf_perusahaanBindingNavigatorSaveItem"
        Me.Staf_perusahaanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Staf_perusahaanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Staf_perusahaanDataGridView
        '
        Me.Staf_perusahaanDataGridView.AutoGenerateColumns = False
        Me.Staf_perusahaanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Staf_perusahaanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Staf_perusahaanDataGridView.DataSource = Me.Staf_perusahaanBindingSource
        Me.Staf_perusahaanDataGridView.Location = New System.Drawing.Point(356, 67)
        Me.Staf_perusahaanDataGridView.Name = "Staf_perusahaanDataGridView"
        Me.Staf_perusahaanDataGridView.Size = New System.Drawing.Size(501, 405)
        Me.Staf_perusahaanDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Staf"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Staf"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nama_Staf"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama_Staf"
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pergudangan_Id_Staf"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pergudangan_Id_Staf"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
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
        Me.GroupBox1.Controls.Add(Id_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Id_StafTextBox)
        Me.GroupBox1.Controls.Add(Nama_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_StafTextBox)
        Me.GroupBox1.Controls.Add(Lokasi_LahanLabel)
        Me.GroupBox1.Controls.Add(Me.Lokasi_LahanTextBox)
        Me.GroupBox1.Controls.Add(Pergudangan_Id_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Pergudangan_Id_StafTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 406)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA STAF PERUSAHAAN"
        '
        'Id_KaryawanLabel
        '
        Id_KaryawanLabel.AutoSize = True
        Id_KaryawanLabel.Location = New System.Drawing.Point(6, 44)
        Id_KaryawanLabel.Name = "Id_KaryawanLabel"
        Id_KaryawanLabel.Size = New System.Drawing.Size(69, 13)
        Id_KaryawanLabel.TabIndex = 0
        Id_KaryawanLabel.Text = "Id Karyawan:"
        '
        'Id_KaryawanTextBox
        '
        Me.Id_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Staf_perusahaanBindingSource, "Id_Karyawan", True))
        Me.Id_KaryawanTextBox.Location = New System.Drawing.Point(120, 41)
        Me.Id_KaryawanTextBox.Name = "Id_KaryawanTextBox"
        Me.Id_KaryawanTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Id_KaryawanTextBox.TabIndex = 1
        '
        'Id_StafLabel
        '
        Id_StafLabel.AutoSize = True
        Id_StafLabel.Location = New System.Drawing.Point(6, 70)
        Id_StafLabel.Name = "Id_StafLabel"
        Id_StafLabel.Size = New System.Drawing.Size(41, 13)
        Id_StafLabel.TabIndex = 2
        Id_StafLabel.Text = "Id Staf:"
        '
        'Id_StafTextBox
        '
        Me.Id_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Staf_perusahaanBindingSource, "Id_Staf", True))
        Me.Id_StafTextBox.Location = New System.Drawing.Point(120, 67)
        Me.Id_StafTextBox.Name = "Id_StafTextBox"
        Me.Id_StafTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Id_StafTextBox.TabIndex = 3
        '
        'Nama_StafLabel
        '
        Nama_StafLabel.AutoSize = True
        Nama_StafLabel.Location = New System.Drawing.Point(6, 96)
        Nama_StafLabel.Name = "Nama_StafLabel"
        Nama_StafLabel.Size = New System.Drawing.Size(60, 13)
        Nama_StafLabel.TabIndex = 4
        Nama_StafLabel.Text = "Nama Staf:"
        '
        'Nama_StafTextBox
        '
        Me.Nama_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Staf_perusahaanBindingSource, "Nama_Staf", True))
        Me.Nama_StafTextBox.Location = New System.Drawing.Point(120, 93)
        Me.Nama_StafTextBox.Name = "Nama_StafTextBox"
        Me.Nama_StafTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Nama_StafTextBox.TabIndex = 5
        '
        'Lokasi_LahanLabel
        '
        Lokasi_LahanLabel.AutoSize = True
        Lokasi_LahanLabel.Location = New System.Drawing.Point(6, 122)
        Lokasi_LahanLabel.Name = "Lokasi_LahanLabel"
        Lokasi_LahanLabel.Size = New System.Drawing.Size(74, 13)
        Lokasi_LahanLabel.TabIndex = 6
        Lokasi_LahanLabel.Text = "Lokasi Lahan:"
        '
        'Lokasi_LahanTextBox
        '
        Me.Lokasi_LahanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Staf_perusahaanBindingSource, "Lokasi_Lahan", True))
        Me.Lokasi_LahanTextBox.Location = New System.Drawing.Point(120, 119)
        Me.Lokasi_LahanTextBox.Name = "Lokasi_LahanTextBox"
        Me.Lokasi_LahanTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Lokasi_LahanTextBox.TabIndex = 7
        '
        'Pergudangan_Id_StafLabel
        '
        Pergudangan_Id_StafLabel.AutoSize = True
        Pergudangan_Id_StafLabel.Location = New System.Drawing.Point(6, 148)
        Pergudangan_Id_StafLabel.Name = "Pergudangan_Id_StafLabel"
        Pergudangan_Id_StafLabel.Size = New System.Drawing.Size(108, 13)
        Pergudangan_Id_StafLabel.TabIndex = 8
        Pergudangan_Id_StafLabel.Text = "Pergudangan Id Staf:"
        '
        'Pergudangan_Id_StafTextBox
        '
        Me.Pergudangan_Id_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Staf_perusahaanBindingSource, "Pergudangan_Id_Staf", True))
        Me.Pergudangan_Id_StafTextBox.Location = New System.Drawing.Point(120, 145)
        Me.Pergudangan_Id_StafTextBox.Name = "Pergudangan_Id_StafTextBox"
        Me.Pergudangan_Id_StafTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Pergudangan_Id_StafTextBox.TabIndex = 9
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Location = New System.Drawing.Point(96, 264)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(109, 32)
        Me.Buttonkeluar.TabIndex = 35
        Me.Buttonkeluar.Text = "KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonrefresh
        '
        Me.Buttonrefresh.Location = New System.Drawing.Point(202, 226)
        Me.Buttonrefresh.Name = "Buttonrefresh"
        Me.Buttonrefresh.Size = New System.Drawing.Size(90, 32)
        Me.Buttonrefresh.TabIndex = 34
        Me.Buttonrefresh.Text = "REFRESH"
        Me.Buttonrefresh.UseVisualStyleBackColor = True
        '
        'Buttonbatal
        '
        Me.Buttonbatal.Location = New System.Drawing.Point(108, 226)
        Me.Buttonbatal.Name = "Buttonbatal"
        Me.Buttonbatal.Size = New System.Drawing.Size(88, 32)
        Me.Buttonbatal.TabIndex = 33
        Me.Buttonbatal.Text = "BATAL"
        Me.Buttonbatal.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(9, 226)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(93, 32)
        Me.Buttonhapus.TabIndex = 32
        Me.Buttonhapus.Text = "HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonedit
        '
        Me.Buttonedit.Location = New System.Drawing.Point(202, 188)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(90, 32)
        Me.Buttonedit.TabIndex = 31
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Location = New System.Drawing.Point(108, 188)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 32)
        Me.Buttonsimpan.TabIndex = 30
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(9, 188)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(93, 32)
        Me.Buttontambah.TabIndex = 29
        Me.Buttontambah.Text = "TAMBAH"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(356, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(732, 21)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(74, 32)
        Me.Buttoncari.TabIndex = 21
        Me.Buttoncari.Text = "CARI"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'staf_perusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 541)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Staf_perusahaanDataGridView)
        Me.Controls.Add(Me.Staf_perusahaanBindingNavigator)
        Me.Name = "staf_perusahaan"
        Me.Text = "STAF PERUSAHAAN"
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staf_perusahaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staf_perusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Staf_perusahaanBindingNavigator.ResumeLayout(False)
        Me.Staf_perusahaanBindingNavigator.PerformLayout()
        CType(Me.Staf_perusahaanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Perusahaan_sawitDataSet As dtb_perusahaan_sawit.perusahaan_sawitDataSet
    Friend WithEvents Staf_perusahaanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Staf_perusahaanTableAdapter As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.staf_perusahaanTableAdapter
    Friend WithEvents TableAdapterManager As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staf_perusahaanBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Staf_perusahaanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Staf_perusahaanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lokasi_LahanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pergudangan_Id_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Buttonkeluar As System.Windows.Forms.Button
    Friend WithEvents Buttonrefresh As System.Windows.Forms.Button
    Friend WithEvents Buttonbatal As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
    Friend WithEvents Buttonedit As System.Windows.Forms.Button
    Friend WithEvents Buttonsimpan As System.Windows.Forms.Button
    Friend WithEvents Buttontambah As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Buttoncari As System.Windows.Forms.Button
End Class
