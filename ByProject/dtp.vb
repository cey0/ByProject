Public Class dtp
    Inherits UserControl

    Private WithEvents dateTimePicker As New DateTimePicker
    Private WithEvents pictureBoxCalendar As New PictureBox

    Public Sub New()
        ' Atur properti DateTimePicker
        dateTimePicker.Dock = DockStyle.Left
        dateTimePicker.Width = 150 ' Sesuaikan dengan kebutuhan Anda
        dateTimePicker.Format = DateTimePickerFormat.Short

        ' Atur properti PictureBox
        pictureBoxCalendar.Dock = DockStyle.Right
        pictureBoxCalendar.Image = My.Resources.calendar_icon_for_graphic_design_logo_website_social_media_mobile_app_ui_illustration_vector_removebg_preview
        ' Ganti dengan path ke gambar ikon kalender Anda
        pictureBoxCalendar.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxCalendar.Width = 30 ' Sesuaikan dengan kebutuhan Anda

        ' Tambahkan kontrol ke UserControl
        Me.Controls.Add(dateTimePicker)
        Me.Controls.Add(pictureBoxCalendar)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.Name = "dtp"
        Me.ResumeLayout(False)

    End Sub


End Class