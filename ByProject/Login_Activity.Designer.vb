<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginActivity
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNLogout = New System.Windows.Forms.Button()
        Me.BTNkelolalaporan = New System.Windows.Forms.Button()
        Me.BTNkelolauser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBtanggal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNfilter = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 762)
        Me.Panel1.TabIndex = 0
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
        Me.BTNkelolalaporan.Text = "Kelola Laporan"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(431, 286)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(710, 307)
        Me.DataGridView1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(677, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login Activity"
        '
        'TBtanggal
        '
        Me.TBtanggal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBtanggal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBtanggal.Font = New System.Drawing.Font("Inter Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBtanggal.Location = New System.Drawing.Point(8, 20)
        Me.TBtanggal.Name = "TBtanggal"
        Me.TBtanggal.Size = New System.Drawing.Size(167, 33)
        Me.TBtanggal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pilih Tanggal"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.TBtanggal)
        Me.Panel3.Location = New System.Drawing.Point(451, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 76)
        Me.Panel3.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ByProject.My.Resources.Resources.logo_kalender
        Me.PictureBox1.Location = New System.Drawing.Point(231, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BTNfilter
        '
        Me.BTNfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNfilter.Font = New System.Drawing.Font("Inter", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNfilter.Location = New System.Drawing.Point(773, 166)
        Me.BTNfilter.Name = "BTNfilter"
        Me.BTNfilter.Size = New System.Drawing.Size(170, 63)
        Me.BTNfilter.TabIndex = 11
        Me.BTNfilter.Text = "Filter"
        Me.BTNfilter.UseVisualStyleBackColor = True
        '
        'LoginActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1185, 705)
        Me.Controls.Add(Me.BTNfilter)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginActivity"
        Me.RightToLeftLayout = True
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNkelolauser As Button
    Friend WithEvents BTNLogout As Button
    Friend WithEvents BTNkelolalaporan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBtanggal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNfilter As Button
End Class
