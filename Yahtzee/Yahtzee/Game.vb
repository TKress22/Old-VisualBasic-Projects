Module Game
    Public DiceArr() As Button = {frmMain.btnDie0, frmMain.btnDie1, frmMain.btnDie2, frmMain.btnDie3, frmMain.btnDie4}
    Public DiceVal() As Integer = {1, 2, 3, 4, 5}
    Public DiceImage() As Image = {My.Resources.cl_1, My.Resources.cl_2, My.Resources.cl_3, My.Resources.cl_4, My.Resources.cl_5, My.Resources.cl_6}
    Public IsKept(4) As Boolean
    Public PlayerNames() As String = {"Player 1", "Player 2", "Player 3", "Player 4"}
    Public PlayerScores(3, 16) As Integer
    Public ConfirmedLabels(3, 12) As Boolean
    Public arrlbls() As Label = {frmMain.lblOnes, frmMain.lblTwos, frmMain.lblThrees, frmMain.lblFours, frmMain.lblFives, frmMain.lblSixes, frmMain.lbl3oK, frmMain.lbl4oK, frmMain.lblFH, frmMain.lblSmS, frmMain.lblLgS, frmMain.lblYah, frmMain.lblCha}
    Public CurrPlayer As Integer = 0
    Public NumPlayers As Integer = 0
    Public Turn As Integer = 0
    Public TempScore As Integer
    Public Ran As New Random
    Public Sub SetTxt()
        'Sets dice text
        For e = 0 To 4
            If IsKept(e) = False Then
                DiceArr(e).Text = DiceVal(e)
            End If
        Next
    End Sub
    Public Sub SetImg()
        'Sets dice images
        For e = 0 To 4 'BOOP
            DiceArr(e).BackgroundImage = DiceImage(DiceVal(e) - 1)
        Next
    End Sub
    Public Sub SetVal()
        'Sets dice value
        For e = 0 To 4
            If IsKept(e) = False Then
                DiceVal(e) = Ran.Next(6) + 1
            End If
        Next
    End Sub
    Public Sub PlayerTurn()
        'Changes label colours based on CurrPlayer value. Also updates running totals and fills labels with scores
        Select Case CurrPlayer
            Case 0
                frmMain.grpScoreTotals.ForeColor = Color.Red
            Case 1
                frmMain.grpScoreTotals.ForeColor = Color.Blue
            Case 2
                frmMain.grpScoreTotals.ForeColor = Color.FromArgb(0, 192, 0)
            Case 3
                frmMain.grpScoreTotals.ForeColor = Color.Yellow
        End Select
        frmMain.lblPName.Text = PlayerNames(CurrPlayer)
        frmMain.lblP1Total.Text = PlayerScores(0, 16)
        frmMain.lblP2Total.Text = PlayerScores(1, 16)
        frmMain.lblP3Total.Text = PlayerScores(2, 16)
        frmMain.lblP4Total.Text = PlayerScores(3, 16)
        frmMain.btnRoll.Enabled = True
        LoadScores()
    End Sub
    Public Sub Sort(arr() As Integer)
        'Sorts an integer array from smallest to largest
        Dim temp As Integer
        For x = 0 To arr.Length - 2
            For y = x To arr.Length - 1
                If arr(x) > arr(y) Then
                    temp = arr(x)
                    arr(x) = arr(y)
                    arr(y) = temp
                End If
            Next
        Next
    End Sub
    Public Sub RemoveDuplicates(arr() As Integer)
        'Removes duplicate numbers for small straight to work
        For x = 0 To arr.Length - 2
            If arr(x) = arr(x + 1) Then
                arr(x + 1) = 7
            End If
        Next
        Sort(arr)
    End Sub
    Public Function CheckScores(picked As Integer)
        'Creates temp array and checks scores
        Dim TempDiceVal() As Integer = {DiceVal(0), DiceVal(1), DiceVal(2), DiceVal(3), DiceVal(4)}
        Sort(TempDiceVal)
        Select Case picked
            Case 0
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 1
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 2
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 3
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 4
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 5
                'PlayerScores(CurrPlayer, picked) = AddSame(picked, TempDiceVal)
                TempScore = AddSame(picked, TempDiceVal)
            Case 6
                '3oK
                If (TempDiceVal(1) = TempDiceVal(0) And TempDiceVal(2) = TempDiceVal(0)) Or (TempDiceVal(2) = TempDiceVal(1) And TempDiceVal(3) = TempDiceVal(1)) Or (TempDiceVal(3) = TempDiceVal(2) And TempDiceVal(4) = TempDiceVal(2)) Then
                    'PlayerScores(CurrPlayer, picked) = AddAll(TempDiceVal)
                    TempScore = AddAll(TempDiceVal)
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 7
                '4oK
                If (TempDiceVal(1) = TempDiceVal(0) And TempDiceVal(2) = TempDiceVal(0) And TempDiceVal(3) = TempDiceVal(0)) Or (TempDiceVal(2) = TempDiceVal(1) And TempDiceVal(3) = TempDiceVal(1) And TempDiceVal(4) = TempDiceVal(1)) Then
                    'PlayerScores(CurrPlayer, picked) = AddAll(TempDiceVal)
                    TempScore = AddAll(TempDiceVal)
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 8
                'FH
                If ((TempDiceVal(1) = TempDiceVal(0) And TempDiceVal(2) = TempDiceVal(0)) And (TempDiceVal(3) = TempDiceVal(4))) Or (TempDiceVal(3) = TempDiceVal(2) And TempDiceVal(4) = TempDiceVal(2)) And (TempDiceVal(1) = TempDiceVal(0)) Then
                    'PlayerScores(CurrPlayer, picked) = 25
                    TempScore = 25
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 9
                'SmS
                RemoveDuplicates(TempDiceVal)
                If (TempDiceVal(1) = TempDiceVal(0) + 1 And TempDiceVal(2) = TempDiceVal(1) + 1 And TempDiceVal(3) = TempDiceVal(2) + 1) Or (TempDiceVal(2) = TempDiceVal(1) + 1 And TempDiceVal(3) = TempDiceVal(2) + 1 And TempDiceVal(4) = TempDiceVal(3) + 1) Then
                    'PlayerScores(CurrPlayer, picked) = 30
                    TempScore = 30
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 10
                'LgS
                If TempDiceVal(1) = TempDiceVal(0) + 1 And TempDiceVal(2) = TempDiceVal(1) + 1 And TempDiceVal(3) = TempDiceVal(2) + 1 And TempDiceVal(4) = TempDiceVal(3) + 1 Then
                    'PlayerScores(CurrPlayer, picked) = 40
                    TempScore = 40
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 11
                'Yah
                If TempDiceVal(0) = TempDiceVal(4) Then
                    'PlayerScores(CurrPlayer, picked) = 50
                    TempScore = 50
                Else
                    'PlayerScores(CurrPlayer, picked) = 0
                    TempScore = 0
                End If
            Case 12
                'Cha
                'PlayerScores(CurrPlayer, picked) = AddAll(TempDiceVal)
                TempScore = AddAll(TempDiceVal)

        End Select
        'Return PlayerScores(CurrPlayer, picked)
        Return TempScore
    End Function
    Public Function AddSame(cat As Integer, arr() As Integer)
        'Adds all matching values in dice value array
        Dim BLEH As Integer = 0
        For u = 0 To arr.Length - 1
            If arr(u) = cat + 1 Then
                BLEH += arr(u)
            End If
        Next
        Return BLEH
    End Function
    Public Function AddAll(arr() As Integer)
        'Adds all values in the dice values array
        Dim BLEH As Integer = 0
        For u = 0 To arr.Length - 1
            BLEH += arr(u)
        Next
        Return BLEH
    End Function
    Public Function FillLabel(ind As Integer)
        'Fills the labels based on whether there is a score for it or not
        If frmMain.hasRolled Then
            If ConfirmedLabels(CurrPlayer, ind) = True Then
                Return PlayerScores(CurrPlayer, ind)
            Else
                Return "-"
            End If
        Else
            Return "-"
        End If
    End Function
    Public Sub LoadScores()
        'Checks to see if a label has been clicked, if so, fills in the score and disables it
        For w = 0 To arrlbls.Length - 1
            If ConfirmedLabels(CurrPlayer, w) = True Then
                arrlbls(w).Text = PlayerScores(CurrPlayer, w)
                arrlbls(w).Enabled = False
            Else
                arrlbls(w).Text = "-"
                arrlbls(w).Enabled = True
            End If
        Next
        TotalUpper()
        TotalLower()
        frmMain.lblUpper.Text = PlayerScores(CurrPlayer, 13)
        frmMain.lblLower.Text = PlayerScores(CurrPlayer, 14)
    End Sub
    Public Sub TotalUpper()
        'Adds all scores in upper
        PlayerScores(CurrPlayer, 13) = 0
        For r = 0 To 5
            PlayerScores(CurrPlayer, 13) += PlayerScores(CurrPlayer, r)
        Next
        If PlayerScores(CurrPlayer, 13) >= 63 Then
            frmMain.lblUBo.Text = 35
            PlayerScores(CurrPlayer, 15) = 35
        Else
            frmMain.lblUBo.Text = 0
        End If
    End Sub
    Public Sub TotalLower()
        'Adds all scores in lower
        PlayerScores(CurrPlayer, 14) = 0
        For r = 6 To 12
            PlayerScores(CurrPlayer, 14) += PlayerScores(CurrPlayer, r)
        Next
    End Sub
    Public Sub ResetDice()
        'Moves all dice back to starting locations
        For t = 0 To DiceArr.Length - 1
            DiceArr(t).Location = frmMain.startPoints(t)
            IsKept(t) = False
        Next
    End Sub
    Public Sub ResetScores()
        'Clears all scores and resets form
        For p = 0 To 3
            For s = 0 To 16
                PlayerScores(p, s) = 0
                If s < 13 Then
                    ConfirmedLabels(p, s) = False
                End If
            Next
        Next
        CurrPlayer = 0
        Turn = 0
        LoadScores()
        TotalUpper()
        TotalLower()
        PlayerTurn()
        frmMain.btnRoll.Enabled = True
    End Sub
    Public Sub EndGame()
        'Checks for the highest score and index and displays the winner
        PlayerScores(0, 16) += PlayerScores(0, 15)
        PlayerScores(1, 16) += PlayerScores(1, 15)
        PlayerScores(2, 16) += PlayerScores(2, 15)
        PlayerScores(3, 16) += PlayerScores(3, 15)
        Dim highScore As Integer = PlayerScores(0, 16)
        Dim highInd As Integer = 0
        For w = 0 To NumPlayers
            If highScore < PlayerScores(w, 16) Then
                highScore = PlayerScores(w, 16)
                highInd = w
            End If
        Next
        Dim msgString As String = PlayerNames(highInd) & " is the winner with " & PlayerScores(highInd, 16) & " points!"
        MessageBox.Show(msgString, "WINNER!")
    End Sub
End Module