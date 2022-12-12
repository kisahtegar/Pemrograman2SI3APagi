<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenghitungJarak
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtKecepatan = New System.Windows.Forms.TextBox()
        Me.txtWaktu = New System.Windows.Forms.TextBox()
        Me.txtJarak = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblJarak = New System.Windows.Forms.Label()
        Me.lblKecepatan = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENGHITUNG JARAK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kecepatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Waktu Tempuh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jarak"
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(205, 120)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnHitung.Size = New System.Drawing.Size(128, 49)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtKecepatan
        '
        Me.txtKecepatan.Location = New System.Drawing.Point(205, 94)
        Me.txtKecepatan.Name = "txtKecepatan"
        Me.txtKecepatan.Size = New System.Drawing.Size(265, 20)
        Me.txtKecepatan.TabIndex = 5
        '
        'txtWaktu
        '
        Me.txtWaktu.Location = New System.Drawing.Point(205, 175)
        Me.txtWaktu.Name = "txtWaktu"
        Me.txtWaktu.Size = New System.Drawing.Size(265, 20)
        Me.txtWaktu.TabIndex = 6
        '
        'txtJarak
        '
        Me.txtJarak.Location = New System.Drawing.Point(205, 68)
        Me.txtJarak.Name = "txtJarak"
        Me.txtJarak.Size = New System.Drawing.Size(265, 20)
        Me.txtJarak.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(60, 202)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(388, 121)
        Me.ListBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jarak ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Kecepatan ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Waktu Tempuh = "
        '
        'lblJarak
        '
        Me.lblJarak.AutoSize = True
        Me.lblJarak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJarak.Location = New System.Drawing.Point(95, 338)
        Me.lblJarak.Name = "lblJarak"
        Me.lblJarak.Size = New System.Drawing.Size(94, 24)
        Me.lblJarak.TabIndex = 12
        Me.lblJarak.Text = "S = V * T"
        '
        'lblKecepatan
        '
        Me.lblKecepatan.AutoSize = True
        Me.lblKecepatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKecepatan.Location = New System.Drawing.Point(145, 376)
        Me.lblKecepatan.Name = "lblKecepatan"
        Me.lblKecepatan.Size = New System.Drawing.Size(92, 24)
        Me.lblKecepatan.TabIndex = 13
        Me.lblKecepatan.Text = "V = S / T"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(193, 414)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(92, 24)
        Me.lblWaktu.TabIndex = 14
        Me.lblWaktu.Text = "T = S / V"
        '
        'MenghitungJarak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 499)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblKecepatan)
        Me.Controls.Add(Me.lblJarak)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtJarak)
        Me.Controls.Add(Me.txtWaktu)
        Me.Controls.Add(Me.txtKecepatan)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenghitungJarak"
        Me.Text = "MenghitungJarak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtKecepatan As TextBox
    Friend WithEvents txtWaktu As TextBox
    Friend WithEvents txtJarak As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblJarak As Label
    Friend WithEvents lblKecepatan As Label
    Friend WithEvents lblWaktu As Label
End Class
