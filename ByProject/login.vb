Imports System.Data.SqlClient
Module GlobalVariables
    Public loggedInUserID As Integer
    Public loggedInName As String
    Public CS = "Data Source=WINDOWS-O0DHNMP;Initial Catalog=BYPROJECT;Integrated Security=True;"
End Module

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBUsername.Text = "User Name"
        TBPassword.Text = "Password"
        TBUsername.ForeColor = Color.Gray
        TBPassword.ForeColor = Color.Gray
        AddRoundedBorderPANEL(Panel2)
        AddRoundedBorderPANEL(Panel3)
        AddRoundedBorderBTN(Submit)
        AddRoundedBorderBTN(Reset)
        Dim hexColor As String = "#22D3D3"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Submit.BackColor = warna
    End Sub

    Public Sub ResetTextBoxes()
        TBUsername.Text = "User Name"
        TBPassword.Text = "Password"
        TBUsername.ForeColor = Color.Gray
        TBPassword.ForeColor = Color.Gray
    End Sub

    Private Sub AddRoundedBorder(textBox As TextBox)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = textBox.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 50, 50), 180, 90)
        p.AddLine(New Point(myRectangle.X + 50, myRectangle.Y), New Point(myRectangle.Width - 50, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Y, 50, 50), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 50), New Point(myRectangle.Width, myRectangle.Height - 50))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Height - 50, 50, 50), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 50, myRectangle.Height), New Point(myRectangle.X + 50, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 50, 50, 50), 90, 90)
        p.CloseFigure()
        textBox.Region = New Region(p)
    End Sub
    Private Sub AddRoundedBorderPANEL(panel As Panel)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = panel.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 50, 50), 180, 90)
        p.AddLine(New Point(myRectangle.X + 50, myRectangle.Y), New Point(myRectangle.Width - 50, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Y, 50, 50), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 50), New Point(myRectangle.Width, myRectangle.Height - 50))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Height - 50, 50, 50), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 50, myRectangle.Height), New Point(myRectangle.X + 50, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 50, 50, 50), 90, 90)
        p.CloseFigure()
        panel.Region = New Region(p)
    End Sub

    Private Sub AddRoundedBorderBTN(btn As Button)
        Dim p As New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(-2, -2)
        p.StartFigure()
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Y, 50, 50), 180, 90)
        p.AddLine(New Point(myRectangle.X + 50, myRectangle.Y), New Point(myRectangle.Width - 50, myRectangle.Y))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Y, 50, 50), -90, 90)
        p.AddLine(New Point(myRectangle.Width, myRectangle.Y + 50), New Point(myRectangle.Width, myRectangle.Height - 50))
        p.AddArc(New Rectangle(myRectangle.Width - 50, myRectangle.Height - 50, 50, 50), 0, 90)
        p.AddLine(New Point(myRectangle.Width - 50, myRectangle.Height), New Point(myRectangle.X + 50, myRectangle.Height))
        p.AddArc(New Rectangle(myRectangle.X, myRectangle.Height - 50, 50, 50), 90, 90)
        p.CloseFigure()
        btn.Region = New Region(p)
    End Sub


    Private Sub TBUsername_Enter(sender As Object, e As EventArgs) Handles TBUsername.Enter
        If TBUsername.Text = "User Name" Then
            TBUsername.Text = ""
            TBUsername.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TBPassword_Enter(sender As Object, e As EventArgs) Handles TBPassword.Enter
        If TBPassword.Text = "Password" Then
            TBPassword.Text = ""
            TBPassword.ForeColor = Color.Black
            TBPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TBPassword_Leave(sender As Object, e As EventArgs) Handles TBPassword.Leave
        If TBPassword.Text = "" Then
            TBPassword.Text = "Password"
            TBPassword.ForeColor = Color.Gray
            TBPassword.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub TBUsername_Leave(sender As Object, e As EventArgs) Handles TBUsername.Leave
        If TBUsername.Text = "" Then
            TBUsername.Text = "User Name"
            TBUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim username As String = TBUsername.Text
        Dim password As String = TBPassword.Text

        If Auth(username, password) Then
            username = "User Name"
            password = "Password"
            MsgBox("succesfully login")
            Me.Hide()
        End If

    End Sub
    Private Sub Submit_enter(sender As Object, e As EventArgs) Handles Submit.Enter
        Dim username As String = TBUsername.Text
        Dim password As String = TBPassword.Text

        If Auth(username, password) Then
            username = "User Name"
            password = "Password"
            MsgBox("succesfully login")
            Me.Hide()
        End If

    End Sub

    Private Function Auth(username As String, password As String) As Boolean
        Dim query As String = "SELECT * FROM [dbo].[user] WHERE username = @username AND password = @password"
        Dim Qlog As String = "INSERT INTO [dbo].[login]([waktu],[aktivitas],[id_user]) VALUES (@waktu, @act, @user)"
        Using C As New SqlConnection(CS)
            Using cmd As New SqlCommand(query, C)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Try
                    C.Open()
                    Dim rd As SqlDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        Dim tipeUser As String = rd("tipe_user").ToString()
                        GlobalVariables.loggedInUserID = Convert.ToInt32(rd("id_user"))
                        GlobalVariables.loggedInName = Convert.ToString(rd("nama"))
                        Dim userid As Integer = GlobalVariables.loggedInUserID
                        rd.Close()

                        Using insert As New SqlCommand(Qlog, C)
                            insert.Parameters.AddWithValue("@waktu", DateTime.Now)
                            insert.Parameters.AddWithValue("@act", "login")
                            insert.Parameters.AddWithValue("@user", userid)
                            insert.ExecuteNonQuery()
                        End Using

                        If tipeUser.Equals("Admin") Then
                            LoginActivity.Show()
                            Me.Hide()
                            Return True
                        ElseIf tipeUser.Equals("Gudang") Then
                            Barangform.Show()
                            Me.Hide()
                            Return True
                        ElseIf tipeUser.Equals("Kasir") Then
                            KasirForm.Show()
                            Me.hide()
                            Return True
                        Else
                            MsgBox("You do not have permission. You have to be an admin or barang.")
                            Return False
                        End If
                    Else
                        MsgBox("Failed login check password or username")
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("An error has occurred while authenticating user: " & ex.Message)
                    Console.WriteLine(ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function


    Private Sub AddPaddingToTextBox(textBox As TextBox, padding As Integer)
        textBox.Location = New Point(textBox.Location.X + padding, textBox.Location.Y + padding)
        textBox.Size = New Size(textBox.Size.Width - (2 * padding), textBox.Size.Height - (2 * padding))
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TBPassword.Text = "Password"
        TBPassword.ForeColor = Color.Gray
        TBPassword.UseSystemPasswordChar = False
        TBUsername.Text = "User Name"
        TBUsername.ForeColor = Color.Gray
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
