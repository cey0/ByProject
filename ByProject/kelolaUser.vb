Imports System.Data.SqlClient

Public Class kelolaUser
    Private userid As Integer
    Private isRowSelected As Boolean = False
    Private Sub AddRoundedBorderPANEL(panel As Panel)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = panel.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 40, 40), 180, 90)
        p.AddLine(New Point(myRectangle.X + 40, myRectangle.Y), New Point(myRectangle.Width - 40, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 40, myRectangle.Y, 40, 40), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 40), New Point(myRectangle.Width, myRectangle.Height - 40))
        p.AddArc(New Rectangle(myRectangle.Width - 40, myRectangle.Height - 40, 40, 40), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 40, myRectangle.Height), New Point(myRectangle.X + 40, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        panel.Region = New Region(p)
    End Sub
    Private Sub AddRoundedBorder(btn As Button)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 40, 40), 180, 90)
        p.AddLine(New Point(myRectangle.X + 40, myRectangle.Y), New Point(myRectangle.Width - 40, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 40, myRectangle.Y, 40, 40), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 40), New Point(myRectangle.Width, myRectangle.Height - 40))
        p.AddArc(New Rectangle(myRectangle.Width - 40, myRectangle.Height - 40, 40, 40), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 40, myRectangle.Height), New Point(myRectangle.X + 40, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub


    Private Sub kelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddRoundedBorderPANEL(Panel3)
        AddRoundedBorderPANEL(Panel4)
        AddRoundedBorderPANEL(Panel5)
        AddRoundedBorderPANEL(Panel6)
        AddRoundedBorderPANEL(Panel7)
        AddRoundedBorderPANEL(Panel8)
        AddRoundedBorderPANEL(Panel9)
        AddRoundedBorderPANEL(Panel10)
        AddRoundedBorder2(DDadmin)
        AddRoundedBorder2(DDgudang)
        AddRoundedBorder2(DDkasir)
        AddRoundedBorder2(BTNedit)
        AddRoundedBorder2(BTNhapus)
        AddRoundedBorder2(BTNtambah)
        AddRoundedBorder(BTNkelolauser)
        AddRoundedBorder(BTNkelolalaporan)
        AddRoundedBorder(BTNLogout)
        getalluser(DataGridView1)
        Panel4.Visible = False
        PictureBox2.Visible = False

        Dim hexColor As String = "#B9FBFF"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Dim hexColor2 As String = "#22D3D3"
        Dim warna2 As Color = ColorTranslator.FromHtml(hexColor2)
        Dim hexColor3 As String = "#87FF5C"
        Dim warna3 As Color = ColorTranslator.FromHtml(hexColor3)
        Dim hexColor4 As String = "#FFF962"
        Dim warna4 As Color = ColorTranslator.FromHtml(hexColor4)
        Dim hexColor5 As String = "#FF3333"
        Dim warna5 As Color = ColorTranslator.FromHtml(hexColor5)

        Panel1.BackColor = warna
        BTNkelolauser.BackColor = warna2
        BTNkelolalaporan.BackColor = warna2
        BTNLogout.BackColor = warna5
        BTNtambah.BackColor = warna3
        BTNedit.BackColor = warna4
        BTNhapus.BackColor = warna5

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Visible = True
        Panel4.Visible = True
        Panel4.Location = New Point(423, 171)
        Panel4.BringToFront()
    End Sub
    Private Sub AddRoundedBorder2(btn As Button)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 20, 20), 180, 90)
        p.AddLine(New Point(myRectangle.X + 20, myRectangle.Y), New Point(myRectangle.Width - 20, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 20, myRectangle.Y, 20, 20), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 20), New Point(myRectangle.Width, myRectangle.Height - 20))
        p.AddArc(New Rectangle(myRectangle.Width - 20, myRectangle.Height - 20, 20, 20), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 20, myRectangle.Height), New Point(myRectangle.X + 20, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub

    Private Sub DDgudang_Click(sender As Object, e As EventArgs) Handles DDgudang.Click
        LBTipeUser.Text = "Gudang"
        PictureBox2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub DDkasir_Click(sender As Object, e As EventArgs) Handles DDkasir.Click
        LBTipeUser.Text = "Kasir"
        PictureBox2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub DDadmin_Click(sender As Object, e As EventArgs) Handles DDadmin.Click
        LBTipeUser.Text = "Admin"
        PictureBox2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Dim query As String = "INSERT INTO [dbo].[login]([waktu],[aktivitas],[id_user]) VALUES (@waktu, @act, @user)"
        Using C As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, C)
                Try
                    C.Open()
                    Dim userid As Integer = GlobalVariables.loggedInUserID
                    cmd.Parameters.AddWithValue("@waktu", DateTime.Now) ' Adding the current time for the login time
                    cmd.Parameters.AddWithValue("@act", "logout") ' Indicating the activity as "logout"
                    cmd.Parameters.AddWithValue("@user", userid)
                    cmd.ExecuteNonQuery()
                    ' Clear the loggedInUserID after logging out
                    GlobalVariables.loggedInUserID = 0 ' or any other appropriate value to indicate no user is logged in
                Catch ex As Exception
                    MsgBox("Error logging out: " & ex.Message)
                End Try
            End Using
        End Using

        Me.Hide()
        Form1.StartPosition = FormStartPosition.CenterScreen
        Form1.ResetTextBoxes()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel4.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Function getalluser(table As DataGridView, Optional filter As String = "")
        table.DefaultCellStyle.Font = New Font("Inter", 15)
        Dim query As String = "SELECT id_user, tipe_user AS [tipe user], nama AS [nama user], alamat, telpon FROM [dbo].[user]"

        If Not String.IsNullOrEmpty(filter) Then
            query &= " WHERE nama LIKE @filter"
        End If

        Using c As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, c)
                Try
                    c.Open()

                    ' Tambahkan parameter filter jika ada
                    If Not String.IsNullOrEmpty(filter) Then
                        cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
                    End If

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader)
                    table.DataSource = dt

                    For Each column As DataGridViewColumn In table.Columns
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.HeaderCell.Style.Font = New Font("Inter", 15, FontStyle.Bold)
                        column.HeaderCell.Style.BackColor = ColorTranslator.FromHtml("#D9D9D9")
                        column.Width = 165
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error fetching user records: " & ex.Message)
                End Try
            End Using
        End Using
    End Function
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim query As String = "SELECT * FROM [dbo].[user] WHERE id_user = @iduser"
            Using c As New SqlConnection(CS)
                Using cmd As New SqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@iduser", row.Cells("id_user").Value.ToString)
                    Try
                        c.Open()
                        Dim rd As SqlDataReader = cmd.ExecuteReader
                        If rd.HasRows Then
                            rd.Read()
                            userid = CInt(rd("id_user"))
                            isRowSelected = True
                            TBnama.Text = rd("nama").ToString()
                            TBalamat.Text = rd("alamat").ToString()
                            TBtelepon.Text = rd("telpon").ToString()
                            TBusername.Text = rd("username").ToString()
                            TBpassword.Text = rd("password").ToString()
                            LBTipeUser.Text = rd("tipe_user").ToString()
                        End If
                    Catch ex As Exception

                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub BTNtambah_Click(sender As Object, e As EventArgs) Handles BTNtambah.Click
        ' Check if any required fields are empty
        If String.IsNullOrWhiteSpace(LBTipeUser.Text) OrElse
       String.IsNullOrWhiteSpace(TBnama.Text) OrElse
       String.IsNullOrWhiteSpace(TBalamat.Text) OrElse
       String.IsNullOrWhiteSpace(TBtelepon.Text) OrElse
       String.IsNullOrWhiteSpace(TBusername.Text) OrElse
       String.IsNullOrWhiteSpace(TBpassword.Text) Then

            MessageBox.Show("Semua field harus diisi sebelum menambahkan user.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm the addition of the new user
        Dim rs As DialogResult = MessageBox.Show("Apakah yakin menambahkan user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rs = DialogResult.Yes Then
            Dim query As String = "INSERT INTO [dbo].[user]([tipe_user],[nama],[alamat],[telpon],[username],[password]) VALUES (@tipe,@nama,@alamat,@telpon,@username,@password)"
            Using c As New SqlConnection(CS)
                Using cmd As New SqlCommand(query, c)
                    Try
                        c.Open()
                        cmd.Parameters.AddWithValue("@tipe", LBTipeUser.Text)
                        cmd.Parameters.AddWithValue("@nama", TBnama.Text)
                        cmd.Parameters.AddWithValue("@alamat", TBalamat.Text)
                        cmd.Parameters.AddWithValue("@telpon", TBtelepon.Text)
                        cmd.Parameters.AddWithValue("@username", TBusername.Text)
                        cmd.Parameters.AddWithValue("@password", TBpassword.Text)
                        cmd.ExecuteNonQuery()
                        getalluser(DataGridView1)

                        ' Show a success message
                        MessageBox.Show("User berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error creating user records: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Operasi dibatalkan.")
        End If
    End Sub


    Private Sub BTNkelolalaporan_Click(sender As Object, e As EventArgs) Handles BTNkelolalaporan.Click
        LaporanPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        getalluser(DataGridView1, TextBox2.Text)
    End Sub

    Private Sub BTNedit_Click(sender As Object, e As EventArgs) Handles BTNedit.Click



        If String.IsNullOrWhiteSpace(TBnama.Text) OrElse
           String.IsNullOrWhiteSpace(TBalamat.Text) OrElse
           String.IsNullOrWhiteSpace(TBtelepon.Text) OrElse
           String.IsNullOrWhiteSpace(TBusername.Text) OrElse
           String.IsNullOrWhiteSpace(TBpassword.Text) Then

            MessageBox.Show("Isi data terlebih dahulu atau klik tabel di bawah.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE [dbo].[user] SET tipe_user = @tipe, nama = @nama, alamat = @alamat, telpon = @telpon, username = @username, password = @password WHERE id_user = @iduser"
        Using c As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, c)
                Try
                    c.Open()
                    cmd.Parameters.AddWithValue("@iduser", userid)
                    cmd.Parameters.AddWithValue("@tipe", LBTipeUser.Text)
                    cmd.Parameters.AddWithValue("@nama", TBnama.Text)
                    cmd.Parameters.AddWithValue("@alamat", TBalamat.Text)
                    cmd.Parameters.AddWithValue("@telpon", TBtelepon.Text)
                    cmd.Parameters.AddWithValue("@username", TBusername.Text)
                    cmd.Parameters.AddWithValue("@password", TBpassword.Text)
                    cmd.ExecuteNonQuery()

                    getalluser(DataGridView1)


                    ' Show a success message
                    MessageBox.Show("User berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error updating user records: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BTNhapus_Click(sender As Object, e As EventArgs) Handles BTNhapus.Click
        If Not isRowSelected Then
            MessageBox.Show("Pilih pengguna dari tabel terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rs As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rs = DialogResult.Yes Then
            Dim query As String = "DELETE FROM [dbo].[user] WHERE id_user = @iduser"
            Using c As New SqlConnection(CS)
                Using cmd As New SqlCommand(query, c)
                    Try
                        c.Open()
                        cmd.Parameters.AddWithValue("@iduser", userid)
                        cmd.ExecuteNonQuery()

                        getalluser(DataGridView1)

                        TBnama.Clear()
                        TBalamat.Clear()
                        TBtelepon.Clear()
                        TBusername.Clear()
                        TBpassword.Clear()
                        LBTipeUser.Text = ""

                        isRowSelected = False
                        userid = 0

                        MessageBox.Show("User berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error deleting user records: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MsgBox("Operasi dibatalkan")
        End If
    End Sub

    Private Sub BTNkelolauser_Click(sender As Object, e As EventArgs) Handles BTNkelolauser.Click
        LoginActivity.Show()
        Me.Hide()
    End Sub
End Class