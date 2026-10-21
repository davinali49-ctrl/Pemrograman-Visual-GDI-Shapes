Public Class Form1

    ' 1. Tombol Gambar Garis Lurus (Posisi Paling Kiri)
    Private Sub btnGaris_Click(sender As Object, e As EventArgs) Handles btnGaris.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Blue, 3)

        ' Garis lurus horizontal dari X=20 ke X=120 (Y=70)
        g.DrawLine(p, 20, 70, 120, 70)

        p.Dispose()
        g.Dispose()
    End Sub

    ' 2. Tombol Gambar Persegi 4 (Di Sebelah Garis)
    Private Sub btnPersegi_Click(sender As Object, e As EventArgs) Handles btnPersegi.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Red, 3)

        ' Digeser ke kanan: X=150, Y=30 (Ukuran 80x80)
        g.DrawRectangle(p, 150, 30, 80, 80)

        p.Dispose()
        g.Dispose()
    End Sub

    ' 3. Tombol Gambar Segitiga (Di Sebelah Persegi)
    Private Sub btnSegitiga_Click(sender As Object, e As EventArgs) Handles btnSegitiga.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Green, 3)

        ' Digeser ke kanan: kisaran X=250 sampai X=330
        Dim p1 As New Point(290, 30)  ' Titik Puncak Atas
        Dim p2 As New Point(250, 110) ' Titik Kiri Bawah
        Dim p3 As New Point(330, 110) ' Titik Kanan Bawah

        Dim titikSegitiga As Point() = {p1, p2, p3}
        g.DrawPolygon(p, titikSegitiga)

        p.Dispose()
        g.Dispose()
    End Sub

    ' 4. Tombol Gambar Lingkaran (Di Sebelah Segitiga / Paling Kanan)
    Private Sub btnLingkaran_Click(sender As Object, e As EventArgs) Handles btnLingkaran.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Purple, 3)

        ' Digeser ke paling kanan: X=360, Y=30 (Ukuran 80x80)
        g.DrawEllipse(p, 360, 30, 80, 80)

        p.Dispose()
        g.Dispose()
    End Sub

    ' 5. Tombol Bersihkan Area Gambar
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        PictureBox1.Refresh()
    End Sub

End Class