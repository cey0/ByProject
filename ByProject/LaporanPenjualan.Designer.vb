<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNLogout = New System.Windows.Forms.Button()
        Me.BTNkelolalaporan = New System.Windows.Forms.Button()
        Me.BTNkelolauser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBtanggalawal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TBtanggalakhir = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNfilter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TransaksiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BYPROJECTDataSet1 = New ByProject.BYPROJECTDataSet1()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BYPROJECTDataSet = New ByProject.BYPROJECTDataSet()
        Me.BYPROJECTDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransaksiTableAdapter = New ByProject.BYPROJECTDataSetTableAdapters.transaksiTableAdapter()
        Me.TransaksiTableAdapter1 = New ByProject.BYPROJECTDataSet1TableAdapters.transaksiTableAdapter()
        Me.BTNgenerate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BYPROJECTDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BYPROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BYPROJECTDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BTNLogout)
        Me.Panel1.Controls.Add(Me.BTNkelolalaporan)
        Me.Panel1.Controls.Add(Me.BTNkelolauser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 762)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.ByProject.My.Resources.Resources.logo__1_
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(42, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 276)
        Me.Panel2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Inter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = Global.ByProject.My.Resources.Resources.logo
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 59)
        Me.Label2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Image = Global.ByProject.My.Resources.Resources.logo
        Me.Label4.Location = New System.Drawing.Point(168, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 6
        '
        'BTNLogout
        '
        Me.BTNLogout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogout.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BTNLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogout.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNLogout.ForeColor = System.Drawing.Color.Black
        Me.BTNLogout.Location = New System.Drawing.Point(83, 520)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.Size = New System.Drawing.Size(238, 60)
        Me.BTNLogout.TabIndex = 10
        Me.BTNLogout.Text = "Log out"
        Me.BTNLogout.UseVisualStyleBackColor = False
        '
        'BTNkelolalaporan
        '
        Me.BTNkelolalaporan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNkelolalaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNkelolalaporan.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BTNkelolalaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNkelolalaporan.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNkelolalaporan.ForeColor = System.Drawing.Color.Black
        Me.BTNkelolalaporan.Location = New System.Drawing.Point(83, 444)
        Me.BTNkelolalaporan.Name = "BTNkelolalaporan"
        Me.BTNkelolalaporan.Size = New System.Drawing.Size(238, 60)
        Me.BTNkelolalaporan.TabIndex = 9
        Me.BTNkelolalaporan.Text = "Login Activity"
        Me.BTNkelolalaporan.UseVisualStyleBackColor = False
        '
        'BTNkelolauser
        '
        Me.BTNkelolauser.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNkelolauser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNkelolauser.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BTNkelolauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNkelolauser.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNkelolauser.ForeColor = System.Drawing.Color.Black
        Me.BTNkelolauser.Location = New System.Drawing.Point(83, 368)
        Me.BTNkelolauser.Name = "BTNkelolauser"
        Me.BTNkelolauser.Size = New System.Drawing.Size(238, 60)
        Me.BTNkelolauser.TabIndex = 8
        Me.BTNkelolauser.Text = "Kelola User"
        Me.BTNkelolauser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(920, -12)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 17
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(767, -23)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(661, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Laporan Penjualan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.TBtanggalawal)
        Me.Panel3.Location = New System.Drawing.Point(445, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 78)
        Me.Panel3.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ByProject.My.Resources.Resources.logo_kalender
        Me.PictureBox1.Location = New System.Drawing.Point(216, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TBtanggalawal
        '
        Me.TBtanggalawal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBtanggalawal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBtanggalawal.Font = New System.Drawing.Font("Inter Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBtanggalawal.Location = New System.Drawing.Point(18, 20)
        Me.TBtanggalawal.Name = "TBtanggalawal"
        Me.TBtanggalawal.Size = New System.Drawing.Size(167, 33)
        Me.TBtanggalawal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 33)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tanggal Awal"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.TBtanggalakhir)
        Me.Panel4.Location = New System.Drawing.Point(747, 140)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(285, 76)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ByProject.My.Resources.Resources.logo_kalender
        Me.PictureBox2.Location = New System.Drawing.Point(206, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'TBtanggalakhir
        '
        Me.TBtanggalakhir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBtanggalakhir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBtanggalakhir.Font = New System.Drawing.Font("Inter Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBtanggalakhir.Location = New System.Drawing.Point(18, 20)
        Me.TBtanggalakhir.Name = "TBtanggalakhir"
        Me.TBtanggalakhir.Size = New System.Drawing.Size(167, 33)
        Me.TBtanggalakhir.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(748, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 33)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tanggal Akhir"
        '
        'BTNfilter
        '
        Me.BTNfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNfilter.Font = New System.Drawing.Font("Inter", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNfilter.Location = New System.Drawing.Point(1058, 143)
        Me.BTNfilter.Name = "BTNfilter"
        Me.BTNfilter.Size = New System.Drawing.Size(128, 63)
        Me.BTNfilter.TabIndex = 15
        Me.BTNfilter.Text = "Filter"
        Me.BTNfilter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(445, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(753, 126)
        Me.DataGridView1.TabIndex = 16
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea6.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Me.Chart1.DataSource = Me.TransaksiBindingSource1
        Legend6.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend6)
        Me.Chart1.Location = New System.Drawing.Point(444, 391)
        Me.Chart1.Name = "Chart1"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Omset"
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(577, 300)
        Me.Chart1.TabIndex = 18
        '
        'TransaksiBindingSource1
        '
        Me.TransaksiBindingSource1.DataMember = "transaksi"
        Me.TransaksiBindingSource1.DataSource = Me.BYPROJECTDataSet1
        '
        'BYPROJECTDataSet1
        '
        Me.BYPROJECTDataSet1.DataSetName = "BYPROJECTDataSet1"
        Me.BYPROJECTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ByProject.My.Resources.Resources.Ellipse_1__1_
        Me.PictureBox3.Location = New System.Drawing.Point(929, 403)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'BYPROJECTDataSet
        '
        Me.BYPROJECTDataSet.DataSetName = "BYPROJECTDataSet"
        Me.BYPROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BYPROJECTDataSetBindingSource
        '
        Me.BYPROJECTDataSetBindingSource.DataSource = Me.BYPROJECTDataSet
        Me.BYPROJECTDataSetBindingSource.Position = 0
        '
        'TransaksiBindingSource
        '
        Me.TransaksiBindingSource.DataMember = "transaksi"
        Me.TransaksiBindingSource.DataSource = Me.BYPROJECTDataSet
        '
        'TransaksiTableAdapter
        '
        Me.TransaksiTableAdapter.ClearBeforeFill = True
        '
        'TransaksiTableAdapter1
        '
        Me.TransaksiTableAdapter1.ClearBeforeFill = True
        '
        'BTNgenerate
        '
        Me.BTNgenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNgenerate.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNgenerate.Location = New System.Drawing.Point(920, 444)
        Me.BTNgenerate.Name = "BTNgenerate"
        Me.BTNgenerate.Size = New System.Drawing.Size(142, 48)
        Me.BTNgenerate.TabIndex = 20
        Me.BTNgenerate.Text = "Generate"
        Me.BTNgenerate.UseVisualStyleBackColor = True
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1220, 733)
        Me.Controls.Add(Me.BTNgenerate)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNfilter)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LaporanPenjualan"
        Me.Text = "LaporanPenjualan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BYPROJECTDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BYPROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BYPROJECTDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNLogout As Button
    Friend WithEvents BTNkelolalaporan As Button
    Friend WithEvents BTNkelolauser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBtanggalawal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TBtanggalakhir As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNfilter As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BYPROJECTDataSetBindingSource As BindingSource
    Friend WithEvents BYPROJECTDataSet As BYPROJECTDataSet
    Friend WithEvents TransaksiBindingSource As BindingSource
    Friend WithEvents TransaksiTableAdapter As BYPROJECTDataSetTableAdapters.transaksiTableAdapter
    Friend WithEvents BYPROJECTDataSet1 As BYPROJECTDataSet1
    Friend WithEvents TransaksiBindingSource1 As BindingSource
    Friend WithEvents TransaksiTableAdapter1 As BYPROJECTDataSet1TableAdapters.transaksiTableAdapter
    Friend WithEvents BTNgenerate As Button
End Class
