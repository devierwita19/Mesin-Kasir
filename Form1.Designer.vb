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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmakanan = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtkode1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpesanan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WARUNG MAKAN SEDERHANA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "JL. Gajahmada No.12 Telp (021) 6735098"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Buka dari Pukul 08.00 - 20.00 WIB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Makanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Makanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah"
        '
        'txtmakanan
        '
        Me.txtmakanan.AutoSize = True
        Me.txtmakanan.Location = New System.Drawing.Point(203, 172)
        Me.txtmakanan.Name = "txtmakanan"
        Me.txtmakanan.Size = New System.Drawing.Size(0, 13)
        Me.txtmakanan.TabIndex = 7
        '
        'txtharga
        '
        Me.txtharga.AutoSize = True
        Me.txtharga.Location = New System.Drawing.Point(203, 206)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(0, 13)
        Me.txtharga.TabIndex = 8
        '
        'txttotal
        '
        Me.txttotal.AutoSize = True
        Me.txttotal.Location = New System.Drawing.Point(203, 305)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(31, 13)
        Me.txttotal.TabIndex = 9
        Me.txttotal.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 10
        '
        'txtkode1
        '
        Me.txtkode1.FormattingEnabled = True
        Me.txtkode1.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.txtkode1.Location = New System.Drawing.Point(206, 126)
        Me.txtkode1.Name = "txtkode1"
        Me.txtkode1.Size = New System.Drawing.Size(121, 21)
        Me.txtkode1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpesanan
        '
        Me.txtpesanan.Location = New System.Drawing.Point(206, 238)
        Me.txtpesanan.Name = "txtpesanan"
        Me.txtpesanan.Size = New System.Drawing.Size(100, 20)
        Me.txtpesanan.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Pesanan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 394)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpesanan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtkode1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtmakanan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmakanan As Label
    Friend WithEvents txtharga As Label
    Friend WithEvents txttotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtkode1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtpesanan As TextBox
    Friend WithEvents Label8 As Label
End Class
