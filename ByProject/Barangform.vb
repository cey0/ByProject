Imports System.Data.SqlClient

Public Class Barangform
    Private currentIdBarang As Integer = 0
    Private Sub Barangform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hexColor As String = "#B9FBFF"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Dim hexColor2 As String = "#FF3333"
        Dim warna2 As Color = ColorTranslator.FromHtml(hexColor2)
        Dim hexColor3 As String = "#E3E3E3"
        Dim warna3 As Color = ColorTranslator.FromHtml(hexColor3)
        Dim hexColor4 As String = "#87FF5C"
        Dim warna4 As Color = ColorTranslator.FromHtml(hexColor4)
        Dim hexColor5 As String = "#FFF962"
        Dim warna5 As Color = ColorTranslator.FromHtml(hexColor5)

        Panel1.BackColor = warna
        Panel8.BackColor = warna3
        BTNtambah.BackColor = warna4
        BTNedit.BackColor = warna5
        BTNhapus.BackColor = warna2
        BTNLogout.BackColor = warna2
        AddRoundedBorder(BTNLogout)
        AddRoundedBorder(BTNtambah)
        AddRoundedBorder(BTNedit)
        AddRoundedBorder(BTNhapus)
        AddRoundedBorderPANEL(Panel3)
        AddRoundedBorderPANEL(Panel4)
        AddRoundedBorderPANEL(Panel5)
        AddRoundedBorderPANEL(Panel7)
        AddRoundedBorderPANEL(Panel6)
        AddRoundedBorderPANEL(Panel9)
        AddRoundedBorderPANEL2(Panel8)
        AddRoundedBorderPANEL(Panel10)
        AddRoundedBorder2(Button1)
        AddRoundedBorder2(Button2)
        AddRoundedBorder2(Button3)
        AddRoundedBorder2(Button4)
        AddRoundedBorder2(Button5)
        AddRoundedBorder2(Button6)
        AddRoundedBorder2(Button7)
        AddRoundedBorder2(Button8)
        AddRoundedBorder2(Button9)

        Panel8.Visible = False
        PictureBox2.Visible = False
        MonthCalendar2.Visible = False
        getallbarang(DataGridView1)
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
    Private Sub AddRoundedBorder2(btn As Button)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 10, 10), 180, 90)
        p.AddLine(New Point(myRectangle.X + 10, myRectangle.Y), New Point(myRectangle.Width - 10, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 10, myRectangle.Y, 10, 10), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 10), New Point(myRectangle.Width, myRectangle.Height - 10))
        p.AddArc(New Rectangle(myRectangle.Width - 10, myRectangle.Height - 10, 10, 10), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 10, myRectangle.Height), New Point(myRectangle.X + 10, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 10, 10, 10), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub
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
    Private Sub AddRoundedBorderPANEL2(panel As Panel)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = panel.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 10, 10), 180, 90)
        p.AddLine(New Point(myRectangle.X + 10, myRectangle.Y), New Point(myRectangle.Width - 10, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 10, myRectangle.Y, 10, 10), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 10), New Point(myRectangle.Width, myRectangle.Height - 10))
        p.AddArc(New Rectangle(myRectangle.Width - 10, myRectangle.Height - 10, 10, 10), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 10, myRectangle.Height), New Point(myRectangle.X + 10, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 10, 10, 10), 90, 90)
        p.CloseFigure()
        panel.Region = New Region(p)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel8.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label13.Text = "lembar"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label13.Text = "Botol"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label13.Text = "Batang"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label13.Text = "Bungkus"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label13.Text = "Sachet"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label13.Text = "Kotak"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label13.Text = "Kaleng"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label13.Text = "Dus"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label13.Text = "Tabung"
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Function getallbarang(table As DataGridView, Optional filter As String = "")
        table.DefaultCellStyle.Font = New Font("Inter", 15)
        Dim query As String = "SELECT * FROM [dbo].[barang]"

        If Not String.IsNullOrEmpty(filter) Then
            query &= " WHERE nama_barang LIKE @filter"
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        getallbarang(DataGridView1, TextBox2.Text)
    End Sub

    Private Sub BTNtambah_Click(sender As Object, e As EventArgs) Handles BTNtambah.Click
        Dim jumlahBarang As Integer
        If Not Integer.TryParse(TBJumlahBarang.Text, jumlahBarang) Then
            MessageBox.Show("Jumlah barang harus berupa angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(TBKodeBarang.Text) OrElse
       String.IsNullOrWhiteSpace(TBNamaBarang.Text) OrElse
       String.IsNullOrWhiteSpace(TBExpiredData.Text) OrElse
       String.IsNullOrWhiteSpace(TBHargaSatuan.Text) Then

            MessageBox.Show("Semua field harus diisi sebelum menambahkan barang.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using c As New SqlConnection(CS)
            c.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM [dbo].[barang] WHERE kode_barang = @kd"
            Using checkCmd As New SqlCommand(checkQuery, c)
                checkCmd.Parameters.AddWithValue("@kd", TBKodeBarang.Text)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    Dim updateResponse As DialogResult = MessageBox.Show("Kode barang sudah ada. Apakah ingin memperbarui jumlah barang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If updateResponse = DialogResult.Yes Then
                        Dim updateQuery As String = "UPDATE [dbo].[barang] SET jumlah_barang = jumlah_barang + @jb WHERE kode_barang = @kd"
                        Using updateCmd As New SqlCommand(updateQuery, c)
                            updateCmd.Parameters.AddWithValue("@jb", Convert.ToInt32(TBJumlahBarang.Text))
                            updateCmd.Parameters.AddWithValue("@kd", TBKodeBarang.Text)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Else
                        MessageBox.Show("Operasi dibatalkan")
                    End If
                Else
                    Dim insertQuery As String = "INSERT INTO [dbo].[barang](kode_barang,nama_barang,expired_date,jumlah_barang,satuan,harga_satuan) VALUES (@kd,@nb,@expired,@jb,@satuan,@hs)"
                    Using insertCmd As New SqlCommand(insertQuery, c)
                        insertCmd.Parameters.AddWithValue("@kd", TBKodeBarang.Text)
                        insertCmd.Parameters.AddWithValue("@nb", TBNamaBarang.Text)
                        insertCmd.Parameters.AddWithValue("@expired", TBExpiredData.Text)
                        insertCmd.Parameters.AddWithValue("@jb", Convert.ToInt32(TBJumlahBarang.Text))
                        insertCmd.Parameters.AddWithValue("@satuan", Label13.Text)
                        insertCmd.Parameters.AddWithValue("@hs", Convert.ToDecimal(TBHargaSatuan.Text))
                        insertCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Using

        getallbarang(DataGridView1)
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MonthCalendar2.Visible = False Then
            MonthCalendar2.Visible = True
        Else
            MonthCalendar2.Visible = False
        End If
    End Sub
    Private Function calenderclick(calender As MonthCalendar, textboxt As TextBox)
        textboxt.Text = calender.SelectionStart.ToShortDateString
        calender.Hide()
    End Function

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        calenderclick(MonthCalendar2, TBExpiredData)
    End Sub

    Private Sub BTNedit_Click(sender As Object, e As EventArgs) Handles BTNedit.Click
        ' Check if a valid item is selected
        If currentIdBarang = -1 Then
            MessageBox.Show("Please select a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm the edit action
        Dim rs As DialogResult = MessageBox.Show("Are you sure you want to edit this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rs = DialogResult.Yes Then
            Dim query As String = "UPDATE [dbo].[barang] SET kode_barang = @kd, nama_barang = @nb, expired_date = @expired, jumlah_barang = @jb, satuan = @satuan, harga_satuan = @hs WHERE id_barang = @id"
            Using c As New SqlConnection(CS)
                Using cmd As New SqlCommand(query, c)
                    Try
                        c.Open()
                        cmd.Parameters.AddWithValue("@id", currentIdBarang)
                        cmd.Parameters.AddWithValue("@kd", TBKodeBarang.Text)
                        cmd.Parameters.AddWithValue("@nb", TBNamaBarang.Text)
                        cmd.Parameters.AddWithValue("@expired", TBExpiredData.Text)
                        cmd.Parameters.AddWithValue("@jb", TBJumlahBarang.Text)
                        cmd.Parameters.AddWithValue("@satuan", Label13.Text)
                        cmd.Parameters.AddWithValue("@hs", TBHargaSatuan.Text)
                        cmd.ExecuteNonQuery()
                        getallbarang(DataGridView1)
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error updating record: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Edit operation cancelled.")
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            currentIdBarang = Integer.Parse(selectedRow.Cells("id_barang").Value.ToString())
            TBKodeBarang.Text = selectedRow.Cells("kode_barang").Value.ToString()
            TBNamaBarang.Text = selectedRow.Cells("nama_barang").Value.ToString()
            TBExpiredData.Text = selectedRow.Cells("expired_date").Value.ToString()
            TBJumlahBarang.Text = selectedRow.Cells("jumlah_barang").Value.ToString()
            Label13.Text = selectedRow.Cells("satuan").Value.ToString()
            TBHargaSatuan.Text = selectedRow.Cells("harga_satuan").Value.ToString()
        End If
    End Sub

    Private Sub BTNhapus_Click(sender As Object, e As EventArgs) Handles BTNhapus.Click
        If currentIdBarang = -1 Then
            MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm the delete action
        Dim rs As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rs = DialogResult.Yes Then
            Dim query As String = "DELETE FROM [dbo].[barang] WHERE id_barang = @id"
            Using c As New SqlConnection(CS)
                Using cmd As New SqlCommand(query, c)
                    Try
                        c.Open()
                        cmd.Parameters.AddWithValue("@id", currentIdBarang)
                        cmd.ExecuteNonQuery()
                        getallbarang(DataGridView1)
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Clear input fields and reset currentIdBarang
                        ClearInputFields()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting record: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Delete operation cancelled.")
        End If
    End Sub

    Private Sub ClearInputFields()
        TBKodeBarang.Text = ""
        TBNamaBarang.Text = ""
        TBExpiredData.Text = ""
        TBJumlahBarang.Text = ""
        Label13.Text = ""
        TBHargaSatuan.Text = ""
        currentIdBarang = -1
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
        Form1.ResetTextBoxes()
        Form1.Show()
    End Sub
End Class
