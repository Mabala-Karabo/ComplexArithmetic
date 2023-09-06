Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Price As Integer
        Dim Quantity As Integer
        Dim Discount As Integer
        Dim VAT As Decimal
        Dim Total As Decimal
        Dim Total_Cost As Decimal

        '
        Price = 10
        Quantity = 10
        Discount = 2
        VAT = 0.15
        Total = Quantity * (Price - Discount)
        MsgBox("The total cost without VAT is R" & Total)
        Total_Cost = Total * VAT
        MsgBox("The total cost with VAT is R" & Total_Cost + Total)
    End Sub
End Class
