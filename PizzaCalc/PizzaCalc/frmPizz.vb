Imports System.IO
Public Class frmPizza
    Dim Total, SizePrice As Decimal
    Dim orderNum As Integer = 1
    Dim toppingList(5) As String
    Dim SizeString As String
    Public write As StreamWriter
    Public read As StreamReader
    Public dateStr As String
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnRecord.Click, btnCalc.Click, btnExit.Click
        If sender.Equals(btnCalc) Then
            Calc()
        ElseIf sender.Equals(btnRecord) Then
            RecordTransaction()
        ElseIf sender.Equals(btnExit) Then
            Me.Close()
        End If
    End Sub
    Sub RecordTransaction()
        lboTransactions.Items.Add("-Order Number " & orderNum & ", " & txtName.Text)
        lboTransactions.Items.Add("    Size: " & SizeString & ".....+ $" & SizePrice.ToString("F"))
        lboTransactions.Items.Add("    Amount: " & txtPizzaNum.Text)
        lboTransactions.Items.Add("    Subtotal: $" & (SizePrice * Convert.ToDecimal(txtPizzaNum.Text)))
        Dim r As Integer
        For r = 0 To (toppingList.Count() - 1)
            If toppingList(r) <> Nothing Then
                lboTransactions.Items.Add(toppingList(r))
            End If
        Next
        lboTransactions.Items.Add("   Total: $" & Total.ToString("F"))
        lboTransactions.Items.Add("")
        orderNum += 1
        btnRecord.Enabled = False
        WriteToReciept()
    End Sub
    Sub WriteToReciept()
        If IO.File.Exists("F:\Prog\PizzaCalc\PizzaReciept" & dateStr & ".prcpt") = False Then
            write = IO.File.CreateText("F:\Prog\PizzaCalc\PizzaReciept" & dateStr & ".prcpt")
            write.Close()
        End If
        write = IO.File.AppendText("F:\Prog\PizzaCalc\PizzaReciept" & dateStr & ".prcpt")
        write.WriteLine("-Order Number " & orderNum & ", " & txtName.Text)
        write.WriteLine("    Size: " & SizeString & ".....+ $" & SizePrice.ToString("F"))
        write.WriteLine("    Amount: " & txtPizzaNum.Text)
        write.WriteLine("    Subtotal: $" & (SizePrice * Convert.ToDecimal(txtPizzaNum.Text)))
        Dim r As Integer
        For r = 0 To (toppingList.Count() - 1)
            If toppingList(r) <> Nothing Then
                write.WriteLine(toppingList(r))
            End If
        Next
        write.WriteLine("   Total: $" & Total.ToString("F"))
        write.WriteLine("")
        write.Close()
    End Sub
    Function SetupDate()
        Dim dates, datestub As String
        dates = Date.Today
        datestub = ""
        For e = 0 To dates.Length - 1
            'Console.WriteLine(dates.Substring(e, 1))
            If dates.Substring(e, 1) = "/" Then
                datestub += "-"
            Else
                datestub += dates.Substring(e, 1)
            End If
        Next
        Return datestub
    End Function
    Sub Calc()
        Total = 0
        If IsNumeric(txtPizzaNum.Text) Then
            btnRecord.Enabled = True
            Total += SizePrice * Convert.ToDecimal(txtPizzaNum.Text)
            Dim t As Integer
            For t = 0 To (toppingList.Count() - 1)
                If toppingList(t) <> Nothing Then
                    Total += 0.5
                End If
            Next
            txtTotal.Text = "$" & Total.ToString("F")
        Else
            txtPizzaNum.Clear()
            txtPizzaNum.Focus()
        End If
    End Sub
    Private Sub ckb_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPepperoni.CheckedChanged, ckbSausage.CheckedChanged, ckbMushroom.CheckedChanged, ckbBacon.CheckedChanged, ckbOlives.CheckedChanged
        If sender.Equals(ckbPepperoni) And sender.Checked = True Then
            toppingList(0) = "      -Pepperoni..........+ 0.50"
        ElseIf sender.Equals(ckbSausage) And sender.Checked = True Then
            toppingList(1) = "      -Sausage............+ 0.50"
        ElseIf sender.Equals(ckbMushroom) And sender.Checked = True Then
            toppingList(2) = "      -Mushrooms..........+ 0.50"
        ElseIf sender.Equals(ckbBacon) And sender.Checked = True Then
            toppingList(3) = "      -Bacon..............+ 0.50"
        ElseIf sender.Equals(ckbOlives) And sender.Checked = True Then
            toppingList(4) = "      -Olives.............+ 0.50"
        End If
        If sender.Equals(ckbPepperoni) And sender.Checked = False Then
            toppingList(0) = Nothing
        ElseIf sender.Equals(ckbSausage) And sender.Checked = False Then
            toppingList(1) = Nothing
        ElseIf sender.Equals(ckbMushroom) And sender.Checked = False Then
            toppingList(2) = Nothing
        ElseIf sender.Equals(ckbBacon) And sender.Checked = False Then
            toppingList(3) = Nothing
        ElseIf sender.Equals(ckbOlives) And sender.Checked = False Then
            toppingList(4) = Nothing
        End If
    End Sub
    Private Sub rdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSmall.CheckedChanged, rdbMed.CheckedChanged, rdbLarge.CheckedChanged
        If sender.Equals(rdbSmall) And sender.Checked = True Then
            SizeString = "Small"
            SizePrice = 8
        ElseIf sender.Equals(rdbMed) And sender.Checked = True Then
            SizeString = "Medium"
            SizePrice = 10
        ElseIf sender.Equals(rdbLarge) And sender.Checked = True Then
            SizeString = "Large"
            SizePrice = 12
        End If
    End Sub
    Private Sub MenuItem_Click(sender As Object, e As EventArgs) Handles CalculateStripMenuItem.Click, RecordTransactionToolStripMenuItem.Click, ExitToolStripMenuItem.Click
        If sender.Equals(CalculateStripMenuItem) Then
            Calc()
        ElseIf sender.Equals(RecordTransactionToolStripMenuItem) Then
            RecordTransaction()
        ElseIf sender.Equals(ExitToolStripMenuItem) Then
            Me.Close()
        End If
    End Sub
    Private Sub DisplayRecieptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayRecieptToolStripMenuItem.Click
        Me.Hide()
        frmRecieptDisplay.Show()
    End Sub
    Private Sub frmPizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateStr = SetupDate()
    End Sub
End Class