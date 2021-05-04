Public Class frmRecieptDisplay
    Dim grandTotal As Decimal
    Dim pizzaTotal, transTotal, pep, sau, mus, bac, oli As Integer
    Private Sub frmRecieptDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("F:\Prog\PizzaCalc\PizzaReciept" & frmPizza.dateStr & ".prcpt") Then
            frmPizza.read = IO.File.OpenText("F:\Prog\PizzaCalc\PizzaReciept" & frmPizza.dateStr & ".prcpt")
            Do Until frmPizza.read.Peek() = -1
                Dim tempStr As String
                tempStr = frmPizza.read.ReadLine()
                Console.WriteLine(tempStr)
                CheckStuff(tempStr)
                lboDisplay.Items.Add(tempStr)
            Loop
            lblPToDis.Text = pizzaTotal
            lblTransDis.Text = transTotal
            lblGToDis.Text = grandTotal.ToString("C")
            lblPep.Text = pep
            lblSau.Text = sau
            lblMus.Text = mus
            lblBac.Text = bac
            lblOli.Text = oli
            frmPizza.read.Close()
        End If
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
        frmPizza.Show()
    End Sub
    Sub CheckStuff(line As String)
        If line.IndexOf("Amount:") >= 0 Then
            pizzaTotal += Convert.ToInt32(line.Substring(11))
        ElseIf line.IndexOf("Order") >= 0 Then
            transTotal += 1
        ElseIf line.IndexOf("Total:") >= 0 Then
            grandTotal += Convert.ToDecimal(line.Substring(11))
        ElseIf line.IndexOf("-Pep") >= 0 Then
            pep += 1
        ElseIf line.IndexOf("-Sau") >= 0 Then
            sau += 1
        ElseIf line.IndexOf("-Mus") >= 0 Then
            mus += 1
        ElseIf line.IndexOf("-Bac") >= 0 Then
            bac += 1
        ElseIf line.IndexOf("-Oli") >= 0 Then
            oli += 1
        End If
    End Sub
End Class