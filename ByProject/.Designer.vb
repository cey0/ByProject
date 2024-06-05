<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBUsername
        '
        Me.TBUsername.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBUsername.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.ForeColor = System.Drawing.Color.Gray
        Me.TBUsername.Location = New System.Drawing.Point(15, 5)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(513, 43)
        Me.TBUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Inter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Food Maniac"
        '
        'TBPassword
        '
        Me.TBPassword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBPassword.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPassword.ForeColor = System.Drawing.Color.Gray
        Me.TBPassword.Location = New System.Drawing.Point(340, 497)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(513, 43)
        Me.TBPassword.TabIndex = 3
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.White
        Me.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submit.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(323, 565)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(276, 69)
        Me.Submit.TabIndex = 4
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.SlateGray
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(605, 565)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(270, 69)
        Me.Reset.TabIndex = 5
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = Global.ByProject.My.Resources.Resources.logo
        Me.Label2.Location = New System.Drawing.Point(168, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Inter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.ByProject.My.Resources.Resources.logo
        Me.Label3.Location = New System.Drawing.Point(13, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 59)
        Me.Label3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ByProject.My.Resources.Resources.logo
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(429, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 307)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TBUsername)
        Me.Panel2.Location = New System.Drawing.Point(323, 420)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 62)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(323, 490)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 62)
        Me.Panel3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1185, 751)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
