<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pergudangan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pergudangan))
        Dim Id_StafLabel As System.Windows.Forms.Label
        Dim Nama_StafLabel As System.Windows.Forms.Label
        Dim Lokasi_LahanLabel As System.Windows.Forms.Label
        Dim Hasil_PanenLabel As System.Windows.Forms.Label
        Dim Relasi_Perusahaan_Id_PerusahaanLabel As System.Windows.Forms.Label
        Me.Perusahaan_sawitDataSet = New dtb_perusahaan_sawit.perusahaan_sawitDataSet()
        Me.PergudanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PergudanganTableAdapter = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.pergudanganTableAdapter()
        Me.TableAdapterManager = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager()
        Me.PergudanganBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PergudanganBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PergudanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_StafTextBox = New System.Windows.Forms.TextBox()
        Me.Lokasi_LahanTextBox = New System.Windows.Forms.TextBox()
        Me.Hasil_PanenTextBox = New System.Windows.Forms.TextBox()
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.Buttonkeluar = New System.Windows.Forms.Button()
        Me.Buttonrefresh = New System.Windows.Forms.Button()
        Me.Buttonbatal = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Id_StafLabel = New System.Windows.Forms.Label()
        Nama_StafLabel = New System.Windows.Forms.Label()
        Lokasi_LahanLabel = New System.Windows.Forms.Label()
        Hasil_PanenLabel = New System.Windows.Forms.Label()
        Relasi_Perusahaan_Id_PerusahaanLabel = New System.Windows.Forms.Label()
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PergudanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PergudanganBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PergudanganBindingNavigator.SuspendLayout()
        CType(Me.PergudanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Perusahaan_sawitDataSet
        '
        Me.Perusahaan_sawitDataSet.DataSetName = "perusahaan_sawitDataSet"
        Me.Perusahaan_sawitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PergudanganBindingSource
        '
        Me.PergudanganBindingSource.DataMember = "pergudangan"
        Me.PergudanganBindingSource.DataSource = Me.Perusahaan_sawitDataSet
        '
        'PergudanganTableAdapter
        '
        Me.PergudanganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.pergudanganTableAdapter = Me.PergudanganTableAdapter
        Me.TableAdapterManager.perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.relasi_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.staf_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PergudanganBindingNavigator
        '
        Me.PergudanganBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PergudanganBindingNavigator.BindingSource = Me.PergudanganBindingSource
        Me.PergudanganBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PergudanganBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PergudanganBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PergudanganBindingNavigatorSaveItem})
        Me.PergudanganBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PergudanganBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PergudanganBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PergudanganBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PergudanganBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PergudanganBindingNavigator.Name = "PergudanganBindingNavigator"
        Me.PergudanganBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PergudanganBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.PergudanganBindingNavigator.TabIndex = 0
        Me.PergudanganBindingNavigator.Text = "BindingNavigator1"
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
        'PergudanganBindingNavigatorSaveItem
        '
        Me.PergudanganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PergudanganBindingNavigatorSaveItem.Image = CType(resources.GetObject("PergudanganBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PergudanganBindingNavigatorSaveItem.Name = "PergudanganBindingNavigatorSaveItem"
        Me.PergudanganBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PergudanganBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PergudanganDataGridView
        '
        Me.PergudanganDataGridView.AutoGenerateColumns = False
        Me.PergudanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PergudanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PergudanganDataGridView.DataSource = Me.PergudanganBindingSource
        Me.PergudanganDataGridView.Location = New System.Drawing.Point(379, 92)
        Me.PergudanganDataGridView.Name = "PergudanganDataGridView"
        Me.PergudanganDataGridView.Size = New System.Drawing.Size(453, 338)
        Me.PergudanganDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Staf"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Staf"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Staf"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Staf"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Lokasi_Lahan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lokasi_Lahan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hasil_Panen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Relasi_Perusahaan_Id_Perusahaan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Relasi_Perusahaan_Id_Perusahaan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Buttonkeluar)
        Me.GroupBox1.Controls.Add(Me.Buttonrefresh)
        Me.GroupBox1.Controls.Add(Me.Buttonbatal)
        Me.GroupBox1.Controls.Add(Me.Buttonhapus)
        Me.GroupBox1.Controls.Add(Me.Buttonedit)
        Me.GroupBox1.Controls.Add(Me.Buttonsimpan)
        Me.GroupBox1.Controls.Add(Me.Buttontambah)
        Me.GroupBox1.Controls.Add(Id_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Id_StafTextBox)
        Me.GroupBox1.Controls.Add(Nama_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_StafTextBox)
        Me.GroupBox1.Controls.Add(Lokasi_LahanLabel)
        Me.GroupBox1.Controls.Add(Me.Lokasi_LahanTextBox)
        Me.GroupBox1.Controls.Add(Hasil_PanenLabel)
        Me.GroupBox1.Controls.Add(Me.Hasil_PanenTextBox)
        Me.GroupBox1.Controls.Add(Relasi_Perusahaan_Id_PerusahaanLabel)
        Me.GroupBox1.Controls.Add(Me.Relasi_Perusahaan_Id_PerusahaanTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 338)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PERGUDANGAN"
        '
        'Id_StafLabel
        '
        Id_StafLabel.AutoSize = True
        Id_StafLabel.Location = New System.Drawing.Point(16, 27)
        Id_StafLabel.Name = "Id_StafLabel"
        Id_StafLabel.Size = New System.Drawing.Size(56, 16)
        Id_StafLabel.TabIndex = 0
        Id_StafLabel.Text = "Id Staf:"
        '
        'Id_StafTextBox
        '
        Me.Id_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PergudanganBindingSource, "Id_Staf", True))
        Me.Id_StafTextBox.Location = New System.Drawing.Point(238, 19)
        Me.Id_StafTextBox.Name = "Id_StafTextBox"
        Me.Id_StafTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Id_StafTextBox.TabIndex = 1
        '
        'Nama_StafLabel
        '
        Nama_StafLabel.AutoSize = True
        Nama_StafLabel.Location = New System.Drawing.Point(16, 53)
        Nama_StafLabel.Name = "Nama_StafLabel"
        Nama_StafLabel.Size = New System.Drawing.Size(78, 16)
        Nama_StafLabel.TabIndex = 2
        Nama_StafLabel.Text = "Nama Staf:"
        '
        'Nama_StafTextBox
        '
        Me.Nama_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PergudanganBindingSource, "Nama_Staf", True))
        Me.Nama_StafTextBox.Location = New System.Drawing.Point(238, 47)
        Me.Nama_StafTextBox.Name = "Nama_StafTextBox"
        Me.Nama_StafTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nama_StafTextBox.TabIndex = 3
        '
        'Lokasi_LahanLabel
        '
        Lokasi_LahanLabel.AutoSize = True
        Lokasi_LahanLabel.Location = New System.Drawing.Point(16, 79)
        Lokasi_LahanLabel.Name = "Lokasi_LahanLabel"
        Lokasi_LahanLabel.Size = New System.Drawing.Size(96, 16)
        Lokasi_LahanLabel.TabIndex = 4
        Lokasi_LahanLabel.Text = "Lokasi Lahan:"
        '
        'Lokasi_LahanTextBox
        '
        Me.Lokasi_LahanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PergudanganBindingSource, "Lokasi_Lahan", True))
        Me.Lokasi_LahanTextBox.Location = New System.Drawing.Point(238, 73)
        Me.Lokasi_LahanTextBox.Name = "Lokasi_LahanTextBox"
        Me.Lokasi_LahanTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Lokasi_LahanTextBox.TabIndex = 5
        '
        'Hasil_PanenLabel
        '
        Hasil_PanenLabel.AutoSize = True
        Hasil_PanenLabel.Location = New System.Drawing.Point(16, 105)
        Hasil_PanenLabel.Name = "Hasil_PanenLabel"
        Hasil_PanenLabel.Size = New System.Drawing.Size(86, 16)
        Hasil_PanenLabel.TabIndex = 6
        Hasil_PanenLabel.Text = "Hasil Panen:"
        '
        'Hasil_PanenTextBox
        '
        Me.Hasil_PanenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PergudanganBindingSource, "Hasil_Panen", True))
        Me.Hasil_PanenTextBox.Location = New System.Drawing.Point(238, 99)
        Me.Hasil_PanenTextBox.Name = "Hasil_PanenTextBox"
        Me.Hasil_PanenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Hasil_PanenTextBox.TabIndex = 7
        '
        'Relasi_Perusahaan_Id_PerusahaanLabel
        '
        Relasi_Perusahaan_Id_PerusahaanLabel.AutoSize = True
        Relasi_Perusahaan_Id_PerusahaanLabel.Location = New System.Drawing.Point(16, 131)
        Relasi_Perusahaan_Id_PerusahaanLabel.Name = "Relasi_Perusahaan_Id_PerusahaanLabel"
        Relasi_Perusahaan_Id_PerusahaanLabel.Size = New System.Drawing.Size(220, 16)
        Relasi_Perusahaan_Id_PerusahaanLabel.TabIndex = 8
        Relasi_Perusahaan_Id_PerusahaanLabel.Text = "Relasi Perusahaan Id Perusahaan:"
        '
        'Relasi_Perusahaan_Id_PerusahaanTextBox
        '
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PergudanganBindingSource, "Relasi_Perusahaan_Id_Perusahaan", True))
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox.Location = New System.Drawing.Point(238, 128)
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox.Name = "Relasi_Perusahaan_Id_PerusahaanTextBox"
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Relasi_Perusahaan_Id_PerusahaanTextBox.TabIndex = 9
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Location = New System.Drawing.Point(106, 247)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(109, 32)
        Me.Buttonkeluar.TabIndex = 21
        Me.Buttonkeluar.Text = "KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonrefresh
        '
        Me.Buttonrefresh.Location = New System.Drawing.Point(212, 209)
        Me.Buttonrefresh.Name = "Buttonrefresh"
        Me.Buttonrefresh.Size = New System.Drawing.Size(90, 32)
        Me.Buttonrefresh.TabIndex = 20
        Me.Buttonrefresh.Text = "REFRESH"
        Me.Buttonrefresh.UseVisualStyleBackColor = True
        '
        'Buttonbatal
        '
        Me.Buttonbatal.Location = New System.Drawing.Point(118, 209)
        Me.Buttonbatal.Name = "Buttonbatal"
        Me.Buttonbatal.Size = New System.Drawing.Size(88, 32)
        Me.Buttonbatal.TabIndex = 19
        Me.Buttonbatal.Text = "BATAL"
        Me.Buttonbatal.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(19, 209)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(93, 32)
        Me.Buttonhapus.TabIndex = 18
        Me.Buttonhapus.Text = "HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonedit
        '
        Me.Buttonedit.Location = New System.Drawing.Point(212, 171)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(90, 32)
        Me.Buttonedit.TabIndex = 17
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Location = New System.Drawing.Point(118, 171)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 32)
        Me.Buttonsimpan.TabIndex = 16
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(19, 171)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(93, 32)
        Me.Buttontambah.TabIndex = 15
        Me.Buttontambah.Text = "TAMBAH"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(674, 55)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(74, 32)
        Me.Buttoncari.TabIndex = 17
        Me.Buttoncari.Text = "CARI"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Pergudangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 502)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PergudanganDataGridView)
        Me.Controls.Add(Me.PergudanganBindingNavigator)
        Me.Name = "Pergudangan"
        Me.Text = "PERGUDANGAN"
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PergudanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PergudanganBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PergudanganBindingNavigator.ResumeLayout(False)
        Me.PergudanganBindingNavigator.PerformLayout()
        CType(Me.PergudanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Perusahaan_sawitDataSet As dtb_perusahaan_sawit.perusahaan_sawitDataSet
    Friend WithEvents PergudanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PergudanganTableAdapter As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.pergudanganTableAdapter
    Friend WithEvents TableAdapterManager As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PergudanganBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PergudanganBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PergudanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_StafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lokasi_LahanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_PanenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Relasi_Perusahaan_Id_PerusahaanTextBox As System.Windows.Forms.TextBox
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
