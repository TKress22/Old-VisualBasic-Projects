Public Class Form1
    Const boxNum As Integer = 9
    Dim picList(boxNum) As PictureBox
    Dim incs(boxNum, 1) As Integer
    Dim locs(boxNum, 1) As Integer
    Dim rand As New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBoxes()
        For x = 0 To picList.Length - 1
            picList(x).Location = New Point(rand.Next(Me.Width - 50), rand.Next(Me.Height - 50))
        Next
        For x = 0 To picList.Length - 1
            Dim temp = rand.Next(2)
            If temp = 1 Then
                incs(x, 0) = 2
            Else
                incs(x, 0) = -2
            End If
            temp = rand.Next(2)
            If temp = 1 Then
                incs(x, 1) = 2
            Else
                incs(x, 1) = -2
            End If
        Next
        For x = 0 To picList.Length - 1
            locs(x, 0) = picList(x).Location.X
            locs(x, 1) = picList(x).Location.Y
        Next
        ticker.Start()
    End Sub
    Private Sub CheckCollision()
        For x = 0 To picList.Length - 1
            If locs(x, 0) >= Me.Width - 40 Then
                incs(x, 0) = -2
            ElseIf locs(x, 0) <= 0 Then
                incs(x, 0) = 2
            ElseIf locs(x, 1) >= Me.Height - 60 Then
                incs(x, 1) = -2
            ElseIf locs(x, 1) <= 0 Then
                incs(x, 1) = 2
            End If
            For y = 0 To picList.Length - 1
                If x <> y Then
                    If picList(x).Bounds.IntersectsWith(picList(y).Bounds) Then
                        'Dim dir = rand.Next(2)
                        'incs(x, dir) *= -1
                        incs(x, 0) *= -1
                        incs(x, 1) *= -1

                    End If
                End If
            Next
        Next
    End Sub
    Private Sub SetMove()
        For x = 0 To picList.Length - 1
            locs(x, 0) += incs(x, 0)
            locs(x, 1) += incs(x, 1)
            picList(x).Location = New Point(locs(x, 0), locs(x, 1))
        Next
    End Sub
    Private Sub ticker_Tick(sender As Object, e As EventArgs) Handles ticker.Tick
        For x = 0 To picList.Length - 1
            SetMove()
            CheckCollision()
        Next
    End Sub
    Private Sub LoadBoxes()
        Dim colList() As Color = {Color.Red, Color.Blue, Color.Lime, Color.Yellow, Color.Cyan, Color.HotPink, Color.Orange}
        For z = 0 To picList.Length - 1
            picList(z) = New PictureBox
            picList(z).Width = 25
            picList(z).Height = 25
            picList(z).BackColor = colList(rand.Next(colList.Length))
            Controls.Add(picList(z))
        Next
    End Sub
End Class