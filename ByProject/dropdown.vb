Public Class dropdown
    Private Sub dropdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hexColor As String = "#E3E3E3"
        Dim warna As Color = ColorTranslator.FromHtml(hexColor)
        Panel1.BackColor = warna
        Button1.BackColor = warna
        Button2.BackColor = warna
        Button3.BackColor = warna
        AddRoundedBorder2(Button1)
        AddRoundedBorder2(Button2)
        AddRoundedBorder2(Button3)

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

End Class
