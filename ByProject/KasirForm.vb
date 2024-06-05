Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class KasirForm
    Private Sub KasirForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim namakasir As String = GlobalVariables.loggedInName
        LBkembalian.Text = 0
        LBNamaKasir.Text = namakasir
        PictureBox2.Visible = False
        Panel8.Visible = False

        Dim hexColor As String = "#FFCD4E"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Dim hexColor2 As String = "#FF3333"
        Dim warna2 As Color = ColorTranslator.FromHtml(hexColor2)
        Dim hexColor3 As String = "#FFF962"
        Dim warna3 As Color = ColorTranslator.FromHtml(hexColor3)
        Dim hexColor4 As String = "#2269D3"
        Dim warna4 As Color = ColorTranslator.FromHtml(hexColor4)
        Dim hexColor5 As String = "#52FF00"
        Dim warna5 As Color = ColorTranslator.FromHtml(hexColor5)

        Panel7.BackColor = warna
        BTNLogout.BackColor = warna2
        Button2.BackColor = warna3
        Button3.BackColor = warna2
        Button5.BackColor = warna4
        Button6.BackColor = warna5
        Button4.BackColor = warna5

        dropdown()
        SetupDataGridView()
        CalculateTotalHarga()


        AddRoundedBorderPANEL(Panel7)
        AddRoundedBorderPANEL(Panel6)
        AddRoundedBorderPANEL(Panel8)


        AddRoundedBorder(BTNLogout)
        AddRoundedBorder(Button2)
        AddRoundedBorder(Button3)
        AddRoundedBorder(Button4)
        AddRoundedBorder(Button5)
        AddRoundedBorder(Button6)
        AddRoundedBorderPANEL(Panel9)
        AddRoundedBorderPANEL(Panel5)
        AddRoundedBorderPANEL(Panel4)
        AddRoundedBorderPANEL(Panel3)

    End Sub
    Private Sub AddRoundedBorder(btn As Button)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As System.Drawing.Rectangle = btn.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New System.Drawing.Rectangle(myRectangle.X, myRectangle.Y, 20, 20), 180, 90)
        p.AddLine(New Point(myRectangle.X + 20, myRectangle.Y), New Point(myRectangle.Width - 20, myRectangle.Y))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.Width - 20, myRectangle.Y, 20, 20), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 20), New Point(myRectangle.Width, myRectangle.Height - 20))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.Width - 20, myRectangle.Height - 20, 20, 20), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 20, myRectangle.Height), New Point(myRectangle.X + 20, myRectangle.Height))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.X, myRectangle.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub

    Private Sub AddRoundedBorderPANEL(panel As Panel)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As System.Drawing.Rectangle = panel.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New System.Drawing.Rectangle(myRectangle.X, myRectangle.Y, 20, 20), 180, 90)
        p.AddLine(New Point(myRectangle.X + 20, myRectangle.Y), New Point(myRectangle.Width - 20, myRectangle.Y))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.Width - 20, myRectangle.Y, 20, 20), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 20), New Point(myRectangle.Width, myRectangle.Height - 20))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.Width - 20, myRectangle.Height - 20, 20, 20), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 20, myRectangle.Height), New Point(myRectangle.X + 20, myRectangle.Height))
        p.AddArc(New System.Drawing.Rectangle(myRectangle.X, myRectangle.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        panel.Region = New Region(p)
    End Sub

    Private Sub dropdown()
        Dim query As String = "SELECT * FROM [dbo].[barang]"
        Using c As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, c)
                c.Open()
                Dim rd As SqlDataReader = cmd.ExecuteReader()
                Dim buttonHeight As Integer = 45
                Dim totalButtonHeight As Integer = 0

                While rd.Read()
                    Dim idBarang As Integer = Convert.ToInt32(rd("id_barang"))
                    Dim kodeBarang As String = rd("kode_barang").ToString()
                    Dim namaBarang As String = rd("nama_barang").ToString()
                    Dim hargaSatuan As Integer = Convert.ToInt32(rd("harga_satuan"))

                    Dim button As New Button()
                    button.Text = $"{kodeBarang} - {namaBarang}"
                    button.Width = Panel8.Width - SystemInformation.VerticalScrollBarWidth
                    button.Height = buttonHeight
                    button.Top = totalButtonHeight
                    button.Left = 0
                    button.Tag = New Dictionary(Of String, Object) From {
                    {"IdBarang", idBarang},
                    {"KodeBarang", kodeBarang},
                    {"NamaBarang", namaBarang},
                    {"HargaSatuan", hargaSatuan}
                }

                    button.FlatStyle = FlatStyle.Flat
                    button.FlatAppearance.BorderSize = 0
                    button.BackColor = SystemColors.ScrollBar
                    button.Font = New System.Drawing.Font("Inter", 12, FontStyle.Bold)

                    AddHandler button.Click, AddressOf DynamicButton_Click

                    Panel8.Controls.Add(button)
                    totalButtonHeight += buttonHeight
                End While

                Panel8.Height = Math.Min(totalButtonHeight, 193)
                Panel8.AutoScroll = totalButtonHeight > 193
            End Using
        End Using
    End Sub


    Private Sub CalculateTotalPrice()
        If Not String.IsNullOrEmpty(TBkuantitas.Text) AndAlso Not String.IsNullOrEmpty(LBHargasatu.Text) Then
            Try
                Dim unitPrice As Integer = Convert.ToInt32(LBHargasatu.Text.Replace("Rp", "").Trim())
                Dim quantity As Integer = Convert.ToInt32(TBkuantitas.Text)

                Dim totalPrice As Integer = unitPrice * quantity
                LBtotalharga.Text = totalPrice.ToString()
            Catch ex As Exception
                MessageBox.Show("Error in calculation: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Quantity and unit price must not be empty.")
        End If
    End Sub
    Private Sub DynamicButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Try
            ' Ensure the button tag contains the expected Dictionary
            Dim buttonData As Dictionary(Of String, Object) = CType(button.Tag, Dictionary(Of String, Object))

            ' Parse the required values from the dictionary
            Dim idBarang As Integer
            If Not Integer.TryParse(buttonData("IdBarang").ToString(), idBarang) Then
                Throw New InvalidCastException("IdBarang is not a valid integer.")
            End If

            Dim kodeBarang As String = buttonData("KodeBarang").ToString()
            Dim namaBarang As String = buttonData("NamaBarang").ToString()

            Dim hargaSatuan As Integer
            If Not Integer.TryParse(buttonData("HargaSatuan").ToString(), hargaSatuan) Then
                Throw New InvalidCastException("HargaSatuan is not a valid integer.")
            End If

            LBMenu.Text = $"{idBarang} - {kodeBarang} - {namaBarang}"
            LBHargasatu.Text = hargaSatuan.ToString()
            Panel8.Visible = False

        Catch ex As InvalidCastException
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        Me.Close()
        Form1.ResetTextBoxes()
        Form1.Show()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Notransaksi As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim kodeBarang As String = LBMenu.Text.Split(" - ")(0)
            Dim namaBarang As String = LBMenu.Text.Split(" - ")(2)
            Dim hargaSatuan As Integer = Convert.ToInt32(LBHargasatu.Text)
            Dim jumlahBarang As Integer = Convert.ToInt32(TBkuantitas.Text)
            Dim totalHarga As Integer = hargaSatuan * jumlahBarang

            Dim itemExists As Boolean = False

            ' Iterate through DataGridView rows to check if the item already exists
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Ensure the cell is not null or empty
                If row.Cells("KodeBarang").Value IsNot Nothing AndAlso row.Cells("KodeBarang").Value.ToString() = kodeBarang Then
                    ' Update the existing row
                    row.Cells("JumlahBarang").Value = Convert.ToInt32(row.Cells("JumlahBarang").Value) + jumlahBarang
                    row.Cells("TotalHarga").Value = Convert.ToInt32(row.Cells("TotalHarga").Value) + totalHarga
                    itemExists = True
                    Exit For
                End If
            Next

            ' If the item does not exist, add a new row
            If Not itemExists Then
                DataGridView1.Rows.Add(Notransaksi, kodeBarang, namaBarang, hargaSatuan, jumlahBarang, totalHarga)
            End If

            ' Recalculate the total harga
            CalculateTotalHarga()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateTotalHarga()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Ensure the cell is not null or empty before accessing its value
            If row.Cells("TotalHarga").Value IsNot Nothing Then
                total += Convert.ToInt32(row.Cells("TotalHarga").Value)
            End If
        Next
        LBtotalsemua.Text = total.ToString()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel8.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel8.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub SetupDataGridView()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("NoTransaksi", "No Transaksi")
        DataGridView1.Columns.Add("KodeBarang", "Kode Barang")
        DataGridView1.Columns.Add("NamaBarang", "Nama Barang")
        DataGridView1.Columns.Add("HargaSatuan", "Harga Satuan")
        DataGridView1.Columns.Add("JumlahBarang", "Jumlah Barang")
        DataGridView1.Columns.Add("TotalHarga", "Total Harga")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.MinimumWidth = 100
        Next
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LBHargasatu.Text = ""
        TBkuantitas.Text = ""
        LBtotalharga.Text = ""
        LBMenu.Text = ""
        DataGridView1.Rows.Clear()
        CalculateTotalHarga()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim totalsemua As Integer
        Dim bayar As Integer

        If Not Integer.TryParse(LBtotalsemua.Text, totalsemua) Then
            MessageBox.Show("Total semua harus berupa angka yang valid.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Integer.TryParse(TBUangTunai.Text, bayar) Then
            MessageBox.Show("Uang tunai harus berupa angka yang valid.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If totalsemua > Integer.MaxValue Or bayar > Integer.MaxValue Then
            MessageBox.Show("Nilai yang dimasukkan terlalu besar.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim kembalian As Integer = bayar - totalsemua

        LBkembalian.Text = kembalian.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Configure the SaveFileDialog
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "PDF Files|*.pdf"
        saveFileDialog1.Title = "Save PDF File"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Create the PDF document
            Dim document As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(saveFileDialog1.FileName, FileMode.Create))
            document.Open()

            ' Add the title
            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim title As New Paragraph("Food Mania", titleFont)
            title.Alignment = Element.ALIGN_CENTER
            document.Add(title)
            document.Add(New Paragraph(" "))

            ' Add kasir information
            Dim kasirInfo As New Paragraph("Kasir: " & LBNamaKasir.Text)
            kasirInfo.Alignment = Element.ALIGN_LEFT
            document.Add(kasirInfo)
            document.Add(New Paragraph(" "))

            ' Add items
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim itemName As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), String.Empty)
                    Dim quantity As String = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), String.Empty)
                    Dim price As String = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), String.Empty)

                    ' Create a paragraph for item details with horizontal alignment
                    Dim itemDetails As New Paragraph()
                    itemDetails.Alignment = Element.ALIGN_LEFT

                    ' Add item name
                    Dim itemNameChunk As New Chunk(itemName)
                    itemDetails.Add(itemNameChunk)

                    ' Add quantity and price horizontally
                    Dim quantityPriceChunk As New Chunk($"     Quantity: {quantity}     Price: {price}")
                    itemDetails.Add(quantityPriceChunk)

                    document.Add(itemDetails)

                    document.Add(New Paragraph(" "))
                End If
            Next

            ' Add horizontal line separator
            Dim line As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
            document.Add(line)

            ' Add totals and change
            Dim totalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
            Dim total As New Paragraph("Total: " & LBtotalsemua.Text, totalFont)
            total.Alignment = Element.ALIGN_RIGHT
            document.Add(total)

            Dim cashReceived As New Paragraph("Cash Received: " & TBUangTunai.Text)
            cashReceived.Alignment = Element.ALIGN_RIGHT
            document.Add(cashReceived)

            Dim change As New Paragraph("Change: " & LBkembalian.Text)
            change.Alignment = Element.ALIGN_RIGHT
            document.Add(change)

            document.Add(New Paragraph(" "))

            ' Add footer
            Dim footer As New Paragraph("Thank you for shopping with us!")
            footer.Alignment = Element.ALIGN_CENTER
            document.Add(footer)

            ' Close the document
            document.Close()

            MessageBox.Show("PDF created successfully!")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String = "INSERT INTO [dbo].[transaksi] (no_transaksi, tgl_transaksi, total_bayar, id_user, id_barang) VALUES (@no_transaksi, @tgl_transaksi, @total_bayar, @id_user, @id_barang)"
        Using c As New SqlConnection(CS)
            c.Open()

            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Using cmd As New SqlCommand(query, c)
                        Dim noTransaksi As String = row.Cells("NoTransaksi").Value.ToString()
                        Dim tglTransaksi As DateTime = DateTime.Now
                        Dim totalBayar As Integer = Convert.ToInt32(row.Cells("TotalHarga").Value)
                        Dim idUser As Integer = GlobalVariables.loggedInUserID
                        Dim idBarang As Integer = Convert.ToInt32(row.Cells("KodeBarang").Value)
                        Dim jumlahBarang As Integer = Convert.ToInt32(row.Cells("JumlahBarang").Value)

                        cmd.Parameters.AddWithValue("@no_transaksi", noTransaksi)
                        cmd.Parameters.AddWithValue("@tgl_transaksi", tglTransaksi)
                        cmd.Parameters.AddWithValue("@total_bayar", totalBayar)
                        cmd.Parameters.AddWithValue("@id_user", idUser)
                        cmd.Parameters.AddWithValue("@id_barang", idBarang)

                        cmd.ExecuteNonQuery()

                        Dim updateQuery As String = "UPDATE barang SET jumlah_barang = jumlah_barang - @jumlahBarang WHERE id_barang = @id_barang"
                        Using updateCmd As New SqlCommand(updateQuery, c)
                            updateCmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarang)
                            updateCmd.Parameters.AddWithValue("@id_barang", idBarang)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    End Using
                End If
            Next
        End Using

        MessageBox.Show("Data has been saved to the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub TBkuantitas_ValueChanged(sender As Object, e As EventArgs) Handles TBkuantitas.ValueChanged
        Dim hargasatuan As Integer = LBHargasatu.Text
        Dim qty As Integer = TBkuantitas.Value
        Dim total As Int64 = hargasatuan * qty

        LBtotalharga.Text = total
    End Sub
End Class