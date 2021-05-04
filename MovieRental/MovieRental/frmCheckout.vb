Public Class frmCheckout
    Public Titlelbls(4) As Label
    Public Genrelbls(4) As Label
    Public Duelbls(4) As Label
    Public Costlbls(4) As Label
    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titlelbls = {lblT1, lblT2, lblT3, lblT4, lblT5}
        Genrelbls = {lblG1, lblG2, lblG3, lblG4, lblG5}
        Duelbls = {lblD1, lblD2, lblD3, lblD4, lblD5}
        Costlbls = {lblC1, lblC2, lblC3, lblC4, lblC5}
        FindTotal()
        LoadLabels()
    End Sub
    Sub LoadLabels()
        For x = 0 To Titlelbls.Length - 1
            If cartList(x).Title <> "BLANK" Then
                'Console.WriteLine("ITEM " & x)
                'Console.WriteLine(cartList(x).Title)
                Titlelbls(x).Text = cartList(x).Title
                'Console.WriteLine(cartList(x).Genre)
                Genrelbls(x).Text = cartList(x).Genre
                'Console.WriteLine(cartList(x).DueDate.Date)
                Duelbls(x).Text = cartList(x).DueDate.Date
                'Console.WriteLine(cartList(x).Price)
                Costlbls(x).Text = cartList(x).Price.ToString("F")
            End If
        Next
        lblSub.Text = "$" & Total.ToString("F2")
        lblTot.Text = "$" & (Total + CalcTax()).ToString("F2")
    End Sub
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        frmMain.Close()
        Me.Close()
    End Sub
End Class