<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perusahaan
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
        Dim Id_KaryawanLabel As System.Windows.Forms.Label
        Dim Nama_KaryawanLabel As System.Windows.Forms.Label
        Dim Jabatan_KaryawanLabel As System.Windows.Forms.Label
        Dim Staf_Perusahaan_Id_StafLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perusahaan))
        Me.Perusahaan_sawitDataSet = New dtb_perusahaan_sawit.perusahaan_sawitDataSet()
        Me.PerusahaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerusahaanTableAdapter = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.perusahaanTableAdapter()
        Me.TableAdapterManager = New dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager()
        Me.PerusahaanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PerusahaanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PerusahaanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buttonkeluar = New System.Windows.Forms.Button()
        Me.Buttonrefresh = New System.Windows.Forms.Button()
        Me.Buttonbatal = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.Id_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Jabatan_KaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Staf_Perusahaan_Id_StafTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Id_KaryawanLabel = New System.Windows.Forms.Label()
        Nama_KaryawanLabel = New System.Windows.Forms.Label()
        Jabatan_KaryawanLabel = New System.Windows.Forms.Label()
        Staf_Perusahaan_Id_StafLabel = New System.Windows.Forms.Label()
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerusahaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerusahaanBindingNavigator.SuspendLayout()
        CType(Me.PerusahaanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_KaryawanLabel
        '
        Id_KaryawanLabel.AutoSize = True
        Id_KaryawanLabel.Location = New System.Drawing.Point(11, 101)
        Id_KaryawanLabel.Name = "Id_KaryawanLabel"
        Id_KaryawanLabel.Size = New System.Drawing.Size(89, 15)
        Id_KaryawanLabel.TabIndex = 0
        Id_KaryawanLabel.Text = "Id Karyawan:"
        '
        'Nama_KaryawanLabel
        '
        Nama_KaryawanLabel.AutoSize = True
        Nama_KaryawanLabel.Location = New System.Drawing.Point(8, 125)
        Nama_KaryawanLabel.Name = "Nama_KaryawanLabel"
        Nama_KaryawanLabel.Size = New System.Drawing.Size(114, 15)
        Nama_KaryawanLabel.TabIndex = 2
        Nama_KaryawanLabel.Text = "Nama Karyawan:"
        '
        'Jabatan_KaryawanLabel
        '
        Jabatan_KaryawanLabel.AutoSize = True
        Jabatan_KaryawanLabel.Location = New System.Drawing.Point(8, 153)
        Jabatan_KaryawanLabel.Name = "Jabatan_KaryawanLabel"
        Jabatan_KaryawanLabel.Size = New System.Drawing.Size(127, 15)
        Jabatan_KaryawanLabel.TabIndex = 4
        Jabatan_KaryawanLabel.Text = "Jabatan Karyawan:"
        '
        'Staf_Perusahaan_Id_StafLabel
        '
        Staf_Perusahaan_Id_StafLabel.AutoSize = True
        Staf_Perusahaan_Id_StafLabel.BackColor = System.Drawing.Color.White
        Staf_Perusahaan_Id_StafLabel.Location = New System.Drawing.Point(6, 181)
        Staf_Perusahaan_Id_StafLabel.Name = "Staf_Perusahaan_Id_StafLabel"
        Staf_Perusahaan_Id_StafLabel.Size = New System.Drawing.Size(159, 15)
        Staf_Perusahaan_Id_StafLabel.TabIndex = 6
        Staf_Perusahaan_Id_StafLabel.Text = "Staf Perusahaan Id Staf:"
        '
        'Perusahaan_sawitDataSet
        '
        Me.Perusahaan_sawitDataSet.DataSetName = "perusahaan_sawitDataSet"
        Me.Perusahaan_sawitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PerusahaanBindingSource
        '
        Me.PerusahaanBindingSource.DataMember = "perusahaan"
        Me.PerusahaanBindingSource.DataSource = Me.Perusahaan_sawitDataSet
        '
        'PerusahaanTableAdapter
        '
        Me.PerusahaanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.pergudanganTableAdapter = Nothing
        Me.TableAdapterManager.perusahaanTableAdapter = Me.PerusahaanTableAdapter
        Me.TableAdapterManager.relasi_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.staf_perusahaanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PerusahaanBindingNavigator
        '
        Me.PerusahaanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PerusahaanBindingNavigator.BindingSource = Me.PerusahaanBindingSource
        Me.PerusahaanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PerusahaanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PerusahaanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PerusahaanBindingNavigatorSaveItem})
        Me.PerusahaanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PerusahaanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PerusahaanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PerusahaanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PerusahaanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PerusahaanBindingNavigator.Name = "PerusahaanBindingNavigator"
        Me.PerusahaanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PerusahaanBindingNavigator.Size = New System.Drawing.Size(894, 25)
        Me.PerusahaanBindingNavigator.TabIndex = 0
        Me.PerusahaanBindingNavigator.Text = "BindingNavigator1"
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
        'PerusahaanBindingNavigatorSaveItem
        '
        Me.PerusahaanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PerusahaanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PerusahaanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PerusahaanBindingNavigatorSaveItem.Name = "PerusahaanBindingNavigatorSaveItem"
        Me.PerusahaanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PerusahaanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PerusahaanDataGridView
        '
        Me.PerusahaanDataGridView.AutoGenerateColumns = False
        Me.PerusahaanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PerusahaanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PerusahaanDataGridView.DataSource = Me.PerusahaanBindingSource
        Me.PerusahaanDataGridView.Location = New System.Drawing.Point(353, 85)
        Me.PerusahaanDataGridView.Name = "PerusahaanDataGridView"
        Me.PerusahaanDataGridView.Size = New System.Drawing.Size(499, 394)
        Me.PerusahaanDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Karyawan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Karyawan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Karyawan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Jabatan_Karyawan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jabatan_Karyawan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Staf_Perusahaan_Id_Staf"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Staf_Perusahaan_Id_Staf"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Buttonkeluar)
        Me.GroupBox1.Controls.Add(Me.Buttonrefresh)
        Me.GroupBox1.Controls.Add(Me.Buttonbatal)
        Me.GroupBox1.Controls.Add(Me.Buttonhapus)
        Me.GroupBox1.Controls.Add(Me.Buttonedit)
        Me.GroupBox1.Controls.Add(Me.Buttonsimpan)
        Me.GroupBox1.Controls.Add(Me.Buttontambah)
        Me.GroupBox1.Controls.Add(Id_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Id_KaryawanTextBox)
        Me.GroupBox1.Controls.Add(Nama_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_KaryawanTextBox)
        Me.GroupBox1.Controls.Add(Jabatan_KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.Jabatan_KaryawanTextBox)
        Me.GroupBox1.Controls.Add(Staf_Perusahaan_Id_StafLabel)
        Me.GroupBox1.Controls.Add(Me.Staf_Perusahaan_Id_StafTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 350)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PERUSAHAAN"
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Location = New System.Drawing.Point(106, 306)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(95, 32)
        Me.Buttonkeluar.TabIndex = 14
        Me.Buttonkeluar.Text = "KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonrefresh
        '
        Me.Buttonrefresh.Location = New System.Drawing.Point(207, 268)
        Me.Buttonrefresh.Name = "Buttonrefresh"
        Me.Buttonrefresh.Size = New System.Drawing.Size(87, 32)
        Me.Buttonrefresh.TabIndex = 13
        Me.Buttonrefresh.Text = "REFRESH"
        Me.Buttonrefresh.UseVisualStyleBackColor = True
        '
        'Buttonbatal
        '
        Me.Buttonbatal.Location = New System.Drawing.Point(106, 268)
        Me.Buttonbatal.Name = "Buttonbatal"
        Me.Buttonbatal.Size = New System.Drawing.Size(95, 32)
        Me.Buttonbatal.TabIndex = 12
        Me.Buttonbatal.Text = "BATAL"
        Me.Buttonbatal.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(6, 270)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(94, 32)
        Me.Buttonhapus.TabIndex = 11
        Me.Buttonhapus.Text = "HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonedit
        '
        Me.Buttonedit.Location = New System.Drawing.Point(207, 223)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(87, 32)
        Me.Buttonedit.TabIndex = 10
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Location = New System.Drawing.Point(106, 223)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(95, 32)
        Me.Buttonsimpan.TabIndex = 9
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(6, 223)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(94, 32)
        Me.Buttontambah.TabIndex = 8
        Me.Buttontambah.Text = "TAMBAH"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'Id_KaryawanTextBox
        '
        Me.Id_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PerusahaanBindingSource, "Id_Karyawan", True))
        Me.Id_KaryawanTextBox.Location = New System.Drawing.Point(171, 94)
        Me.Id_KaryawanTextBox.Name = "Id_KaryawanTextBox"
        Me.Id_KaryawanTextBox.Size = New System.Drawing.Size(123, 22)
        Me.Id_KaryawanTextBox.TabIndex = 1
        '
        'Nama_KaryawanTextBox
        '
        Me.Nama_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PerusahaanBindingSource, "Nama_Karyawan", True))
        Me.Nama_KaryawanTextBox.Location = New System.Drawing.Point(171, 122)
        Me.Nama_KaryawanTextBox.Name = "Nama_KaryawanTextBox"
        Me.Nama_KaryawanTextBox.Size = New System.Drawing.Size(123, 22)
        Me.Nama_KaryawanTextBox.TabIndex = 3
        '
        'Jabatan_KaryawanTextBox
        '
        Me.Jabatan_KaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PerusahaanBindingSource, "Jabatan_Karyawan", True))
        Me.Jabatan_KaryawanTextBox.Location = New System.Drawing.Point(171, 150)
        Me.Jabatan_KaryawanTextBox.Name = "Jabatan_KaryawanTextBox"
        Me.Jabatan_KaryawanTextBox.Size = New System.Drawing.Size(123, 22)
        Me.Jabatan_KaryawanTextBox.TabIndex = 5
        '
        'Staf_Perusahaan_Id_StafTextBox
        '
        Me.Staf_Perusahaan_Id_StafTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PerusahaanBindingSource, "Staf_Perusahaan_Id_Staf", True))
        Me.Staf_Perusahaan_Id_StafTextBox.Location = New System.Drawing.Point(171, 178)
        Me.Staf_Perusahaan_Id_StafTextBox.Name = "Staf_Perusahaan_Id_StafTextBox"
        Me.Staf_Perusahaan_Id_StafTextBox.Size = New System.Drawing.Size(123, 22)
        Me.Staf_Perusahaan_Id_StafTextBox.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(353, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(648, 37)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(74, 32)
        Me.Buttoncari.TabIndex = 15
        Me.Buttoncari.Text = "CARI"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'perusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(894, 509)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PerusahaanDataGridView)
        Me.Controls.Add(Me.PerusahaanBindingNavigator)
        Me.Name = "perusahaan"
        Me.Text = "PERUSAHAAN"
        CType(Me.Perusahaan_sawitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerusahaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerusahaanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerusahaanBindingNavigator.ResumeLayout(False)
        Me.PerusahaanBindingNavigator.PerformLayout()
        CType(Me.PerusahaanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Perusahaan_sawitDataSet As dtb_perusahaan_sawit.perusahaan_sawitDataSet
    Friend WithEvents PerusahaanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PerusahaanTableAdapter As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.perusahaanTableAdapter
    Friend WithEvents TableAdapterManager As dtb_perusahaan_sawit.perusahaan_sawitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PerusahaanBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PerusahaanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PerusahaanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jabatan_KaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Staf_Perusahaan_Id_StafTextBox As System.Windows.Forms.TextBox
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
