Imports System.Drawing
Imports System.Windows.Forms

Public Class ronde
    Inherits TextBox

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim borderPen As New Pen(Color.Black)
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.DrawRectangle(borderPen, rect)
        MyBase.OnPaint(e)
    End Sub
End Class