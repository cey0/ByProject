Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class LoginActivity
    Private calendarVisible As Boolean = False
    Private calendar As MonthCalendar
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddRoundedBorder(BTNkelolauser)
        AddRoundedBorder(BTNkelolalaporan)
        AddRoundedBorder(BTNLogout)
        AddRoundedBorder2(BTNfilter)

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

        getalllogin(DataGridView1)
        AddRoundedBorderPANEL(Panel3)
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
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 30, 30), 180, 90)
        p.AddLine(New Point(myRectangle.X + 30, myRectangle.Y), New Point(myRectangle.Width - 30, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 30, myRectangle.Y, 30, 30), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 30), New Point(myRectangle.Width, myRectangle.Height - 30))
        p.AddArc(New Rectangle(myRectangle.Width - 30, myRectangle.Height - 30, 30, 30), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 30, myRectangle.Height), New Point(myRectangle.X + 30, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 30, 30, 30), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub

    Private Sub getalllogin(table As DataGridView)
        table.DefaultCellStyle.Font = New Font("Inter", 15)
        Dim query As String = "SELECT id_log, username, waktu, aktivitas FROM [dbo].[login] as l LEFT JOIN [dbo].[user] as u ON u.id_user = l.id_user"
        Using c As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, c)
                Try
                    c.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    table.DataSource = dt
                    For Each column As DataGridViewColumn In table.Columns
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.HeaderCell.Style.Font = New Font("Inter", 15, FontStyle.Bold)
                        column.HeaderCell.Style.BackColor = ColorTranslator.FromHtml("#D9D9D9")
                        column.Width = 165
                    Next
                    table.RowTemplate.Height = 70
                Catch ex As Exception
                    MessageBox.Show("Error fetching login records: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
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


    Private Sub BTNkelolauser_Click(sender As Object, e As EventArgs) Handles BTNkelolauser.Click
        kelolaUser.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Calendar_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs)
        ' Get the selected date from the MonthCalendar
        Dim selectedDate As Date = CType(sender, MonthCalendar).SelectionStart

        ' Populate the selected date into the TextBox
        TBtanggal.Text = selectedDate.ToShortDateString()

        ' Remove the MonthCalendar after use
        Me.Controls.Remove(CType(sender, MonthCalendar))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Not calendarVisible Then
            calendar = New MonthCalendar
            calendar.Visible = True

            Dim pictureBoxLocationScreen As Point = PictureBox1.PointToScreen(New Point(0, PictureBox1.Height))
            calendar.Location = Me.PointToClient(pictureBoxLocationScreen)

            Me.Controls.Add(calendar)
            calendar.BringToFront()

            AddHandler calendar.DateSelected, AddressOf Calendar_DateSelected

            calendar.Focus()
        Else
            calendar.Visible = False
            Me.Controls.Remove(calendar)
            calendar.Dispose()
        End If

        calendarVisible = Not calendarVisible
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBtanggal.TextChanged

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

    Private Sub BTNfilter_Click(sender As Object, e As EventArgs) Handles BTNfilter.Click
        FilterData()
    End Sub
    Private Sub FilterData()
        Dim selectedDate As Date
        If Date.TryParse(TBtanggal.Text, selectedDate) Then
            Dim query As String = "SELECT id_log, username, waktu, aktivitas FROM [dbo].[login] as l " &
                                  "LEFT JOIN [dbo].[user] as u ON u.id_user = l.id_user " &
                                  "WHERE CONVERT(date, waktu) = @selectedDate"

            Using connection As New SqlConnection(CS)
                Using command As New SqlCommand(query, connection)
                    Try
                        connection.Open()
                        command.Parameters.AddWithValue("@selectedDate", selectedDate.Date)
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
            MessageBox.Show("Please enter a valid date in the format MM/DD/YYYY.")
        End If
    End Sub

    Private Sub BTNkelolalaporan_Click(sender As Object, e As EventArgs) Handles BTNkelolalaporan.Click
        LaporanPenjualan.Show()
        Me.Hide()
    End Sub
End Class