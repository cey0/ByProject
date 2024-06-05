Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class LaporanPenjualan
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MonthCalendar1.Visible = False Then
            MonthCalendar1.Visible = True
            MonthCalendar1.Location = New Point(486, 222)
        Else
            MonthCalendar1.Visible = False
        End If
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

    Private Sub LaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MonthCalendar1.Visible = False
        MonthCalendar2.Visible = False
        AddRoundedBorder(BTNkelolauser)
        AddRoundedBorder(BTNkelolalaporan)
        AddRoundedBorder(BTNLogout)
        AddRoundedBorder(BTNfilter)
        AddRoundedBorder(BTNgenerate)
        AddRoundedBorderPANEL(Panel4)
        AddRoundedBorderPANEL(Panel3)
        calenderclick(MonthCalendar2, TBtanggalakhir)

        Dim hexColor As String = "#B9FBFF"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Dim hexColor2 As String = "#22D3D3"
        Dim warna2 As Color = ColorTranslator.FromHtml(hexColor2)
        Dim hexColor3 As String = "#FF3333"
        Dim warna3 As Color = ColorTranslator.FromHtml(hexColor3)
        Panel1.BackColor = warna
        BTNkelolauser.BackColor = warna2
        BTNkelolalaporan.BackColor = warna2
        BTNLogout.BackColor = warna3
        BTNfilter.BackColor = warna2
        BTNgenerate.BackColor = warna2
        getalltransaksi(DataGridView1)
    End Sub



    Private Function calenderclick(calender As MonthCalendar, textboxt As TextBox)
        textboxt.Text = calender.SelectionStart.ToShortDateString
        calender.Hide()
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MonthCalendar2.Visible = False Then
            MonthCalendar2.Visible = True
            MonthCalendar2.Location = New Point(784, 220)
        Else
            MonthCalendar2.Visible = False
        End If
    End Sub
    Private Sub BTNkelolauser_Click(sender As Object, e As EventArgs) Handles BTNkelolauser.Click
        kelolaUser.Show()
        Me.Hide()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        calenderclick(MonthCalendar1, TBtanggalawal)
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        calenderclick(MonthCalendar2, TBtanggalakhir)
    End Sub
    Private Function getalltransaksi(table As DataGridView)
        table.DefaultCellStyle.Font = New Font("Inter", 13)
        Dim query As String = "SELECT id_transaksi AS [ID Transaksi], tgl_transaksi AS [Tanggal Transaksi], total_bayar AS [Total Pembayaran], nama AS [Nama Kasir] FROM [dbo].[transaksi] AS T LEFT JOIN [dbo].[user] AS u ON u.id_user = T.id_user "
        Using c As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, c)
                Try
                    c.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader)
                    table.DataSource = dt
                    For Each column As DataGridViewColumn In table.Columns
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.HeaderCell.Style.Font = New Font("Inter", 13, FontStyle.Bold)
                        column.HeaderCell.Style.BackColor = ColorTranslator.FromHtml("#D9D9D9")
                        table.Columns("ID Transaksi").Width = 150
                        table.Columns("Tanggal Transaksi").Width = 205
                        table.Columns("Total Pembayaran").Width = 205
                        table.Columns("Nama Kasir").Width = 150

                    Next
                Catch ex As Exception
                    MessageBox.Show("Error fetching user records: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Private Sub BTNfilter_Click(sender As Object, e As EventArgs) Handles BTNfilter.Click
        If Date.Compare(TBtanggalawal.Text, TBtanggalakhir.Text) <= 0 Then
            FilterData()
        Else
            MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir.")
        End If
    End Sub
    Private Sub BindChartFromDataGridView(chart As Chart, dgv As DataGridView)
        ' Clear existing series
        chart.Series.Clear()

        ' Create a new series
        Dim series As New Series("Omset")

        ' Add data points from the DataGridView to the series
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then ' Check if the row is not a new row
                Dim xValue As String = row.Cells("Tanggal Transaksi").Value.ToString() ' Assuming "Tanggal Transaksi" is the column name
                Dim yValue As Double = Convert.ToDouble(row.Cells("Total Pembayaran").Value) ' Assuming "Total Pembayaran" is the column name
                series.Points.AddXY(xValue, yValue) ' Add data points to the series
            End If
        Next

        ' Add series to the chart
        chart.Series.Add(series)

        ' Set chart type (optional, depending on the chart type you want)
        series.ChartType = SeriesChartType.Column

        ' Set axis labels
        chart.ChartAreas(0).AxisX.Title = "Tanggal Transaksi"
        chart.ChartAreas(0).AxisY.Title = "Total Pembayaran"
    End Sub


    Private Sub FilterData()
        Dim startDate As Date
        Dim endDate As Date
        If Date.TryParse(TBtanggalawal.Text, startDate) AndAlso Date.TryParse(TBtanggalakhir.Text, endDate) Then
            Dim query As String = "SELECT id_transaksi AS [ID Transaksi], tgl_transaksi AS [Tanggal Transaksi], total_bayar AS [Total Pembayaran], nama AS [Nama Kasir] FROM [dbo].[transaksi] AS T LEFT JOIN [dbo].[user] AS u ON u.id_user = T.id_user  " &
                              "WHERE CONVERT(date, tgl_transaksi) BETWEEN @startDate AND @endDate"

            Using connection As New SqlConnection(CS)
                Using command As New SqlCommand(query, connection)
                    Try
                        connection.Open()
                        command.Parameters.AddWithValue("@startDate", startDate)
                        command.Parameters.AddWithValue("@endDate", endDate)
                        Dim dataTable As New DataTable()
                        dataTable.Load(command.ExecuteReader())
                        DataGridView1.DataSource = dataTable
                    Catch ex As Exception
                        MessageBox.Show("Error filtering login records: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            ' Invalid date format entered in the TextBox
            MessageBox.Show("Please enter valid dates in the format MM/DD/YYYY for both start and end dates.")
        End If
    End Sub

    Private Sub BTNgenerate_Click(sender As Object, e As EventArgs) Handles BTNgenerate.Click
        Me.TransaksiTableAdapter1.Fill(Me.BYPROJECTDataSet1.transaksi)
        Me.TransaksiTableAdapter.Fill(Me.BYPROJECTDataSet.transaksi)
        BindChartFromDataGridView(Chart1, DataGridView1)

    End Sub

    Private Sub BTNkelolalaporan_Click(sender As Object, e As EventArgs) Handles BTNkelolalaporan.Click
        LoginActivity.Show()
        Me.Hide()
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
End Class