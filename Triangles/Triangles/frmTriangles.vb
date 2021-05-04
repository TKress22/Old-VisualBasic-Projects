Public Class frmTriClassifier
    Private IsPressed = False
    Private S1Val, S2Val, S3Val As Decimal
    Private SideType, AngleType As Char
    Private Sub frmTriClassifier_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If IsPressed Then
            Dim b As Graphics = e.Graphics
            Dim pA, pB, pC As New Point
            Select Case SideType
                Case "e"
                    pA = New Point(370, 150)
                    pB = New Point(300, 275)
                    pC = New Point(440, 275)
                    b.DrawLine(Pens.Black, New Point(330, 207), New Point(340, 215))
                    b.DrawLine(Pens.Black, New Point(410, 207), New Point(400, 215))
                    b.DrawLine(Pens.Black, New Point(370, 270), New Point(370, 280))
                Case "i"
                    Select Case AngleType
                        Case "r"
                            pA = New Point(350, 140)
                            pB = New Point(250, 230)
                            pC = New Point(450, 230)
                            b.DrawLine(Pens.Black, New Point(350, 160), New Point(340, 150))
                            b.DrawLine(Pens.Black, New Point(350, 160), New Point(360, 150))
                            b.DrawLine(Pens.Black, New Point(310, 190), New Point(290, 180))
                            b.DrawLine(Pens.Black, New Point(410, 180), New Point(390, 190))
                        Case "a"
                            pA = New Point(350, 140)
                            pB = New Point(290, 275)
                            pC = New Point(410, 275)
                            b.DrawLine(Pens.Black, New Point(330, 210), New Point(310, 200))
                            b.DrawLine(Pens.Black, New Point(390, 200), New Point(370, 210))
                        Case "o"
                            pA = New Point(350, 140)
                            pB = New Point(240, 275)
                            pC = New Point(460, 275)
                            b.DrawLine(Pens.Black, New Point(310, 210), New Point(290, 190))
                            b.DrawLine(Pens.Black, New Point(410, 190), New Point(390, 210))
                    End Select
                Case "s"
                    Select Case AngleType
                        Case "r"
                            pA = New Point(250, 140)
                            pB = New Point(250, 275)
                            pC = New Point(460, 275)
                            b.DrawLine(Pens.Black, New Point(250, 260), New Point(270, 260))
                            b.DrawLine(Pens.Black, New Point(270, 260), New Point(270, 275))
                        Case "a"
                            pA = New Point(280, 140)
                            pB = New Point(290, 275)
                            pC = New Point(460, 250)
                        Case "o"
                            pA = New Point(260, 140)
                            pB = New Point(290, 275)
                            pC = New Point(460, 280)
                    End Select
            End Select
            b.DrawLine(Pens.Black, pA, pB)
            b.DrawLine(Pens.Black, pB, pC)
            b.DrawLine(Pens.Black, pA, pC)
        End If
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If CheckInput() Then
            GetSideOrder()
            Refresh()
        End If
    End Sub
    Function CheckInput()
        If IsNumeric(txtS1.Text & txtS2.Text & txtS3.Text) Then
            Try
                S1Val = Convert.ToDecimal(txtS1.Text)
                S2Val = Convert.ToDecimal(txtS2.Text)
                S3Val = Convert.ToDecimal(txtS3.Text)
            Catch ex As OverflowException
                MsgBox("Please enter numbers less than " & Integer.MaxValue)
            End Try
            Return True
        Else
            MessageBox.Show("Please enter positive numbers only!")
            txtS1.Clear()
            txtS2.Clear()
            txtS3.Clear()
            Return False
        End If
    End Function
    Sub GetSideOrder()
        Dim a, b, c, temp As Decimal
        a = S1Val
        b = S2Val
        c = S3Val
        If a > b And a > c Then
            temp = c
            c = a
            a = temp
        ElseIf b > c And b > a Then
            temp = c
            c = b
            b = temp
        End If
        ClassifyTri(a, b, c)
    End Sub
    Sub ClassifyTri(A As Integer, B As Integer, C As Integer)
        If A + B > C Then
            If A = B And B = C And C = A Then
                lblSideClass.Text = "Equilateral"
                SideType = "e"
            ElseIf A = B Or B = C Or C = A Then
                lblSideClass.Text = "Isosceles"
                SideType = "i"
            Else
                lblSideClass.Text = "Scalene"
                SideType = "s"
            End If
            If (A ^ 2) + (B ^ 2) = C ^ 2 Then
                lblAngClass.Text = "Right"
                AngleType = "r"
            ElseIf (A ^ 2) + (B ^ 2) > C ^ 2 Then
                lblAngClass.Text = "Acute"
                AngleType = "a"
            ElseIf (A ^ 2) + (B ^ 2) < C ^ 2 Then
                lblAngClass.Text = "Obtuse"
                AngleType = "o"
            End If
            IsPressed = True
        Else
            MessageBox.Show("The values you entered do not make a triangle!")
            ClearScreen()
        End If
    End Sub
    Sub ClearScreen()
        txtS1.Clear()
        txtS2.Clear()
        txtS3.Clear()
        lblAngClass.Text = "---"
        lblSideClass.Text = "---"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        IsPressed = False
        ClearScreen()
        Refresh()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class