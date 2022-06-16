Public Class Form1
    Private Sub txtkode1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtkode1.SelectedIndexChanged
        If txtkode1.Text = "a" Then
            txtmakanan.Text = "Pecel Lele"
            txtharga.Text = "7000"
        ElseIf txtkode1.Text = "b" Then
            txtmakanan.Text = "Tempe Penyet"
            txtharga.Text = "6000"
        ElseIf txtkode1.Text = "c" Then
            txtmakanan.Text = "Bebek Goreng"
            txtharga.Text = "18000"
        ElseIf txtkode1.Text = "d" Then
            txtmakanan.Text = "Ayam Bakar"
            txtharga.Text = "12000"
        ElseIf txtkode1.Text = "e" Then
            txtmakanan.Text = "Nasi Goreng"
            txtharga.Text = "10000"
        End If
    End Sub

    Private Sub txtpesanan_TextChanged(sender As Object, e As EventArgs) Handles txtpesanan.TextChanged
        txttotal.Text = Val(txtpesanan.Text) * Val(txtharga.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtharga.Text = ""
        txtkode1.Text = ""
        txtmakanan.Text = ""
        txtpesanan.Text = ""
        txttotal.Text = ""
    End Sub
End Class
