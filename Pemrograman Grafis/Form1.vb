Public Class Form1

    ' Variabel untuk fitur gambar bebas pakai Mouse
    Private isDrawing As Boolean = False
    Private startPoint As Point
    Private bmp As Bitmap

    ' Inisialisasi kanvas Bitmap saat Form dibuka
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)

        ' Buat latarnya putih bersih
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using

        PictureBox1.Image = bmp
    End Sub

    ' =======================================================
    ' FITUR TAMBAHAN: GAMBAR BEBAS PAKAI MOUSE (FREEHAND)
    ' =======================================================
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            isDrawing = True
            startPoint = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If isDrawing Then
            Using g As Graphics = Graphics.FromImage(PictureBox1.Image),
                  p As New Pen(Color.Black, 2)

                g.DrawLine(p, startPoint, e.Location)
                startPoint = e.Location
            End Using
            PictureBox1.Invalidate() ' Refresh tampilan PictureBox
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            isDrawing = False
        End If
    End Sub

    ' =======================================================
    ' FITUR UTAMA: 4 TOMBOL BENTUK (TETAP DIPERTAHANKAN)
    ' =======================================================

    ' 1. Tombol Garis Lurus
    Private Sub btnGaris_Click(sender As Object, e As EventArgs) Handles btnGaris.Click
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image),
              p As New Pen(Color.Blue, 3)

            g.DrawLine(p, 20, 70, 120, 70)
        End Using
        PictureBox1.Invalidate()
    End Sub

    ' 2. Tombol Persegi
    Private Sub btnPersegi_Click(sender As Object, e As EventArgs) Handles btnPersegi.Click
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image),
              p As New Pen(Color.Red, 3)

            g.DrawRectangle(p, 150, 30, 80, 80)
        End Using
        PictureBox1.Invalidate()
    End Sub

    ' 3. Tombol Segitiga
    Private Sub btnSegitiga_Click(sender As Object, e As EventArgs) Handles btnSegitiga.Click
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image),
              p As New Pen(Color.Green, 3)

            Dim p1 As New Point(290, 30)
            Dim p2 As New Point(250, 110)
            Dim p3 As New Point(330, 110)
            Dim titikSegitiga As Point() = {p1, p2, p3}

            g.DrawPolygon(p, titikSegitiga)
        End Using
        PictureBox1.Invalidate()
    End Sub

    ' 4. Tombol Lingkaran
    Private Sub btnLingkaran_Click(sender As Object, e As EventArgs) Handles btnLingkaran.Click
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image),
              p As New Pen(Color.Purple, 3)

            g.DrawEllipse(p, 360, 30, 80, 80)
        End Using
        PictureBox1.Invalidate()
    End Sub

    ' 5. Tombol Bersihkan Area Gambar
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
            g.Clear(Color.White)
        End Using
        PictureBox1.Invalidate()
    End Sub

End Class