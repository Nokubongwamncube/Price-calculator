Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txtquantity.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declaring necessray varaibles
        Dim price As Decimal
        Dim quantity As Decimal
        Dim total As Decimal

        'getting the amount from the textboxes

        price = Txtprice.Text
        quantity = Txtquantity.Text

        'calculating the total

        total = price * quantity

        'Dsiplaying message on the screen

        MsgBox("total for customers is R" & total)

    End Sub
End Class
