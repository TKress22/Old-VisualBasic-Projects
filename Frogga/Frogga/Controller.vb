Module Controller
    Public input As String
    Public rowNum = 5
    Public mobNum = 1
    Public moveSpeed As Integer = 10
    Public carArr(rowNum, mobNum) As PictureBox
    Public incs(rowNum) As Integer
    Public Score, Lives As Integer
    Sub LoadMobs()
        'Sets the movement increments for each row
        incs(0) = 1
        incs(1) = -1
        incs(2) = 1
        incs(3) = -1
        incs(4) = 1
        incs(5) = -1
        'Loads controls into an array for easier use in collision checking and movement
        carArr(0, 0) = frmGame.C1R1R
        carArr(0, 1) = frmGame.C2R1R
        carArr(1, 0) = frmGame.C1R2L
        carArr(1, 1) = frmGame.C2R2L
        carArr(2, 0) = frmGame.C1R3R
        carArr(2, 1) = frmGame.C2R3R
        carArr(3, 0) = frmGame.C1R4L
        carArr(3, 1) = frmGame.C2R4L
        carArr(4, 0) = frmGame.LG1R5
        carArr(4, 1) = frmGame.LG2R5
        carArr(5, 0) = frmGame.LG1R6
        carArr(5, 1) = frmGame.LG2R6
    End Sub
    Sub CheckHits()
        'Checks for player collision with each car
        For x = 0 To 3
            For y = 0 To mobNum
                If frmGame.Player.Bounds.IntersectsWith(carArr(x, y).Bounds) Then
                    Lives -= 1
                    frmGame.Player.Location = New Point(317, 500)
                    If Lives <= 0 Then
                        Dim resp As DialogResult
                        resp = MessageBox.Show("Game over! Continue playing?", "Game Over", MessageBoxButtons.YesNo)
                        If resp = Windows.Forms.DialogResult.Yes Then
                            Lives = 5
                            Score = 0
                            moveSpeed = 10
                        Else
                            frmGame.Close()
                        End If
                    End If
                End If
            Next
        Next
    End Sub
    Sub MoveMobs()
        'Cycles through the array of objects and moves them based on the corresponding increment array
        For x = 0 To rowNum
            For y = 0 To mobNum
                carArr(x, y).Left += moveSpeed * incs(x)
                CheckEdge()
            Next
        Next
    End Sub
    Sub CheckEdge()
        'Cycles through and checks if each object is hitting the edge of the form
        For x = 0 To rowNum
            For y = 0 To mobNum
                If x > 3 Then
                    If carArr(x, y).Left >= 700 And x Mod 2 = 0 Then
                        carArr(x, y).Left = -125
                    ElseIf carArr(x, y).Left <= -125 And x Mod 2 = 1 Then
                        carArr(x, y).Left = 700
                    End If
                Else
                    If carArr(x, y).Left >= 700 And x Mod 2 = 0 Then
                        carArr(x, y).Left = -65
                    ElseIf carArr(x, y).Left <= -65 And x Mod 2 = 1 Then
                        carArr(x, y).Left = 765
                    End If
                End If
            Next
        Next
    End Sub
    Sub CheckLogTouch()
        'Checks if the player is touching a log and moves the player based on which log is touched
        For x = 4 To rowNum
            For y = 0 To mobNum
                If frmGame.Player.Bounds.IntersectsWith(carArr(x, y).Bounds) Then
                    frmGame.Player.Left += moveSpeed * incs(x)
                End If
            Next
        Next
    End Sub
    Sub CheckWater()
        'Checks if player is touching water and not log
        If (frmGame.Player.Bounds.IntersectsWith(frmGame.LG1R5.Bounds) = False And frmGame.Player.Bounds.IntersectsWith(frmGame.LG2R5.Bounds) = False And frmGame.Player.Bounds.IntersectsWith(frmGame.LG1R6.Bounds) = False And frmGame.Player.Bounds.IntersectsWith(frmGame.LG2R6.Bounds) = False) And frmGame.Player.Bounds.IntersectsWith(frmGame.River.Bounds) Then
            Lives -= 1
            frmGame.Player.Location = New Point(317, 500)
        End If
    End Sub
End Module