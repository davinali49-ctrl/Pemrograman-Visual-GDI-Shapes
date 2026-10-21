<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPersegi = New System.Windows.Forms.Button()
        Me.btnSegitiga = New System.Windows.Forms.Button()
        Me.btnLingkaran = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnGaris = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(25, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(950, 524)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPersegi
        '
        Me.btnPersegi.BackColor = System.Drawing.Color.Red
        Me.btnPersegi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersegi.ForeColor = System.Drawing.Color.White
        Me.btnPersegi.Location = New System.Drawing.Point(512, 575)
        Me.btnPersegi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPersegi.Name = "btnPersegi"
        Me.btnPersegi.Size = New System.Drawing.Size(462, 79)
        Me.btnPersegi.TabIndex = 2
        Me.btnPersegi.Text = "Persegi"
        Me.btnPersegi.UseVisualStyleBackColor = False
        '
        'btnSegitiga
        '
        Me.btnSegitiga.BackColor = System.Drawing.Color.Green
        Me.btnSegitiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSegitiga.ForeColor = System.Drawing.Color.White
        Me.btnSegitiga.Location = New System.Drawing.Point(25, 666)
        Me.btnSegitiga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSegitiga.Name = "btnSegitiga"
        Me.btnSegitiga.Size = New System.Drawing.Size(462, 79)
        Me.btnSegitiga.TabIndex = 3
        Me.btnSegitiga.Text = "Segitiga"
        Me.btnSegitiga.UseVisualStyleBackColor = False
        '
        'btnLingkaran
        '
        Me.btnLingkaran.BackColor = System.Drawing.Color.Purple
        Me.btnLingkaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLingkaran.ForeColor = System.Drawing.Color.White
        Me.btnLingkaran.Location = New System.Drawing.Point(512, 666)
        Me.btnLingkaran.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLingkaran.Name = "btnLingkaran"
        Me.btnLingkaran.Size = New System.Drawing.Size(462, 79)
        Me.btnLingkaran.TabIndex = 4
        Me.btnLingkaran.Text = "Lingkaran"
        Me.btnLingkaran.UseVisualStyleBackColor = False
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBersihkan.Location = New System.Drawing.Point(25, 758)
        Me.btnBersihkan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(950, 79)
        Me.btnBersihkan.TabIndex = 5
        Me.btnBersihkan.Text = "Clear"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnGaris
        '
        Me.btnGaris.BackColor = System.Drawing.Color.Blue
        Me.btnGaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGaris.ForeColor = System.Drawing.Color.White
        Me.btnGaris.Location = New System.Drawing.Point(25, 575)
        Me.btnGaris.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGaris.Name = "btnGaris"
        Me.btnGaris.Size = New System.Drawing.Size(462, 79)
        Me.btnGaris.TabIndex = 1
        Me.btnGaris.Text = "Garis"
        Me.btnGaris.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1107, 862)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnLingkaran)
        Me.Controls.Add(Me.btnSegitiga)
        Me.Controls.Add(Me.btnPersegi)
        Me.Controls.Add(Me.btnGaris)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Pemrograman Grafis"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPersegi As Button
    Friend WithEvents btnSegitiga As Button
    Friend WithEvents btnLingkaran As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnGaris As Button
End Class
