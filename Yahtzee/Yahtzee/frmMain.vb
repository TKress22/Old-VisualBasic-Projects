Public Class frmMain
    Dim clockinc, backinc As Integer
    Public hasRolled As Boolean = False
    Public numRolls As Integer = 0
    Public sentIndex As Integer
    Public startPoints(4) As Point
    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ClassicToolStripMenuItem.Click, RainbowToolStripMenuItem.Click, InvertedToolStripMenuItem.Click, RealisticDiceToolStripMenuItem.Click, NewGameToolStripMenuItem.Click, RestartToolStripMenuItem.Click
        'Handles all menuItem clicks
        If sender.Equals(ExitToolStripMenuItem) Then
            Dim result As DialogResult
            result = MessageBox.Show("End the game and close?", "Close?", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf sender.Equals(RealisticDiceToolStripMenuItem) Then
            If RealisticDiceToolStripMenuItem.Checked = False Then
                Dim blank As Image
                For r = 0 To DiceArr.Length - 1
                    DiceArr(r).BackgroundImage = blank
                    DiceArr(r).Text = DiceVal(r)
                Next
            Else
                For r = 0 To DiceArr.Length - 1
                    DiceArr(r).BackgroundImage = DiceImage(DiceVal(r) - 1)
                    DiceArr(r).Text = ""
                Next
            End If
        ElseIf sender.Equals(ClassicToolStripMenuItem) Then
            'Loads classic images into dice
            DiceImage = {My.Resources.cl_1, My.Resources.cl_2, My.Resources.cl_3, My.Resources.cl_4, My.Resources.cl_5, My.Resources.cl_6}
            RainbowToolStripMenuItem.Checked = False
            InvertedToolStripMenuItem.Checked = False
            SetImg()
        ElseIf sender.Equals(RainbowToolStripMenuItem) Then
            'Loads rainbow images into dice
            DiceImage = {My.Resources.rb_1, My.Resources.rb_2, My.Resources.rb_3, My.Resources.rb_4, My.Resources.rb_5, My.Resources.rb_6}
            InvertedToolStripMenuItem.Checked = False
            ClassicToolStripMenuItem.Checked = False
            SetImg()
        ElseIf sender.Equals(InvertedToolStripMenuItem) Then
            'Loads inverted images into dice
            DiceImage = {My.Resources.in_1, My.Resources.in_2, My.Resources.in_3, My.Resources.in_4, My.Resources.in_5, My.Resources.in_6}
            RainbowToolStripMenuItem.Checked = False
            ClassicToolStripMenuItem.Checked = False
            SetImg()
        ElseIf sender.Equals(RestartToolStripMenuItem) Then
            Dim res As DialogResult
            res = MessageBox.Show("Keep current players?", "Keep Players?", MessageBoxButtons.YesNoCancel)
            If res = Windows.Forms.DialogResult.Yes Then
                ResetDice()
                ResetScores()
                Refresh()
            ElseIf res = Windows.Forms.DialogResult.No Then
                Me.Hide()
                GameSetupScreen.Show()
            End If
        ElseIf sender.Equals(NewGameToolStripMenuItem) Then
            'Starts a new game
            Dim res As DialogResult
            res = MessageBox.Show("Start a new game?", "New Game?", MessageBoxButtons.YesNoCancel)
            If res = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                GameSetupScreen.Show()
            End If
        End If
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnRoll.Click, btnDie0.Click, btnDie1.Click, btnDie2.Click, btnDie3.Click, btnDie4.Click, btnNewGame.Click
        'Handles all button clicks
        If sender.Equals(btnDie0) Or sender.Equals(btnDie1) Or sender.Equals(btnDie2) Or sender.Equals(btnDie3) Or sender.Equals(btnDie4) Then
            'Checks which button was clicked, then moves and holds it
            If sender.Equals(btnDie0) And hasRolled Then
                'DIE 0
                If IsKept(0) = False Then
                    IsKept(0) = True
                    btnDie0.Location = New Point(startPoints(0).X + 129, 41)
                Else
                    IsKept(0) = False
                    btnDie0.Location = startPoints(0)
                End If
            ElseIf sender.Equals(btnDie1) And hasRolled Then
                'DIE 1
                If IsKept(1) = False Then
                    IsKept(1) = True
                    btnDie1.Location = New Point(startPoints(1).X + 129, 122)
                Else
                    IsKept(1) = False
                    btnDie1.Location = startPoints(1)
                End If
            ElseIf sender.Equals(btnDie2) And hasRolled Then
                'DIE 2
                If IsKept(2) = False Then
                    IsKept(2) = True
                    btnDie2.Location = New Point(startPoints(2).X + 129, 203)
                Else
                    IsKept(2) = False
                    btnDie2.Location = startPoints(2)
                End If
            ElseIf sender.Equals(btnDie3) And hasRolled Then
                'DIE 3
                If IsKept(3) = False Then
                    IsKept(3) = True
                    btnDie3.Location = New Point(startPoints(3).X + 129, 284)
                Else
                    IsKept(3) = False
                    btnDie3.Location = startPoints(3)
                End If
            ElseIf sender.Equals(btnDie4) And hasRolled Then
                'DIE 4
                If IsKept(4) = False Then
                    IsKept(4) = True
                    btnDie4.Location = New Point(startPoints(4).X + 129, 365)
                Else
                    IsKept(4) = False
                    btnDie4.Location = startPoints(4)
                End If
            End If
        ElseIf sender.Equals(btnRoll) Then
            'Calls dice roll if rolls is less than 3
            hasRolled = True
            enableButtons()
            If AnimateDiceRollToolStripMenuItem.Checked = True Then
                tRollClock.Start()
                tRollClock.Enabled = True
            Else
                If RealisticDiceToolStripMenuItem.Checked = True Then
                    SetVal()
                    SetImg()
                Else
                    SetVal()
                    SetTxt()
                End If
            End If
            numRolls += 1
            If numRolls = 3 Then
                btnRoll.Enabled = False
                enableButtons()
            End If
        ElseIf sender.Equals(btnNewGame) Then
            btnNewGame.Visible = False
            btnNewGame.Location = New Point(1000, 1000)
            GameSetupScreen.Show()
            Me.Hide()
        End If
    End Sub
    Public Sub enableButtons()
        'enables dice if user has rolled, disables if not
        If hasRolled Then
            For w = 0 To DiceArr.Length - 1
                DiceArr(w).Enabled = True
            Next
        Else
            For w = 0 To DiceArr.Length - 1
                DiceArr(w).Enabled = False
            Next
        End If
    End Sub
    Private Sub lbls_MouseEnter(sender As Object, e As EventArgs) Handles lblOnes.MouseEnter, lblTwos.MouseEnter, lblThrees.MouseEnter, lblFours.MouseEnter, lblFives.MouseEnter, lblSixes.MouseEnter, lbl3oK.MouseEnter, lbl4oK.MouseEnter, lblFH.MouseEnter, lblSmS.MouseEnter, lblLgS.MouseEnter, lblYah.MouseEnter, lblCha.MouseEnter
        'Sends a value, 0-12 to CheckScores() based on which label is entered
        If hasRolled Then
            If sender.Equals(lblOnes) Then
                sentIndex = 0
                sender.Text = CheckScores(0)
            ElseIf sender.Equals(lblTwos) Then
                sentIndex = 1
                sender.Text = CheckScores(1)
            ElseIf sender.Equals(lblThrees) Then
                sentIndex = 2
                sender.Text = CheckScores(2)
            ElseIf sender.Equals(lblFours) Then
                sentIndex = 3
                sender.Text = CheckScores(3)
            ElseIf sender.Equals(lblFives) Then
                sentIndex = 4
                sender.Text = CheckScores(4)
            ElseIf sender.Equals(lblSixes) Then
                sentIndex = 5
                sender.Text = CheckScores(5)
            ElseIf sender.Equals(lbl3oK) Then
                sentIndex = 6
                sender.Text = CheckScores(6)
            ElseIf sender.Equals(lbl4oK) Then
                sentIndex = 7
                sender.Text = CheckScores(7)
            ElseIf sender.Equals(lblFH) Then
                sentIndex = 8
                sender.Text = CheckScores(8)
            ElseIf sender.Equals(lblSmS) Then
                sentIndex = 9
                sender.Text = CheckScores(9)
            ElseIf sender.Equals(lblLgS) Then
                sentIndex = 10
                sender.Text = CheckScores(10)
            ElseIf sender.Equals(lblYah) Then
                sentIndex = 11
                sender.Text = CheckScores(11)
            ElseIf sender.Equals(lblCha) Then
                sentIndex = 12
                sender.Text = CheckScores(12)
            End If
        Else
            sender.Text = "X"
        End If
    End Sub
    Private Sub lbls_MouseLeave(sender As Object, e As EventArgs) Handles lblOnes.MouseLeave, lblTwos.MouseLeave, lblThrees.MouseLeave, lblFours.MouseLeave, lblFives.MouseLeave, lblSixes.MouseLeave, lbl3oK.MouseLeave, lbl4oK.MouseLeave, lblFH.MouseLeave, lblSmS.MouseLeave, lblLgS.MouseLeave, lblYah.MouseLeave, lblCha.MouseLeave
        'Replaces the label with a - or fills in the score if one exists
        sender.Text = FillLabel(sentIndex)
    End Sub
    Private Sub lbls_Click(sender As Object, e As EventArgs) Handles lblOnes.Click, lblTwos.Click, lblThrees.Click, lblFours.Click, lblFives.Click, lblSixes.Click, lbl3oK.Click, lbl4oK.Click, lblFH.Click, lblSmS.Click, lblLgS.Click, lblYah.Click, lblCha.Click
        If hasRolled Then
            ConfirmedLabels(CurrPlayer, sentIndex) = True
            PlayerScores(CurrPlayer, sentIndex) = TempScore
            sender.Text = PlayerScores(CurrPlayer, sentIndex)
            PlayerScores(CurrPlayer, 16) += TempScore
            Threading.Thread.Sleep(500)
            If CurrPlayer = NumPlayers Then
                If Turn = 12 Then
                    EndGame()
                Else
                    CurrPlayer = 0
                    Turn += 1
                End If
            Else
                CurrPlayer += 1
            End If
            hasRolled = False
            TempScore = 0
            PlayerTurn()
            ResetDice()
            numRolls = 0
        Else
            MsgBox("Roll at least once before trying to score!")
        End If
    End Sub
    Private Sub tRollClock_Tick(sender As Object, e As EventArgs) Handles tRollClock.Tick
        'Dice animation timer
        If clockinc >= 12 Then
            clockinc = 0
            tRollClock.Enabled = False
            tRollClock.Stop()
        Else
            If AnimateDiceRollToolStripMenuItem.Checked = True Then
                If RealisticDiceToolStripMenuItem.Checked = True Then
                    SetVal()
                    SetImg()
                    If RainbowToolStripMenuItem.Checked = True And ToolStripMenuItem2.Checked = True Then
                        BackgroundRainbow()
                    End If
                Else
                    SetVal()
                    SetTxt()
                End If
                clockinc += 1
            End If
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets the location of all five dice buttons
        startPoints(0) = btnDie0.Location
        startPoints(1) = btnDie1.Location
        startPoints(2) = btnDie2.Location
        startPoints(3) = btnDie3.Location
        startPoints(4) = btnDie4.Location
        SetVal()
        SetImg()
    End Sub
    Sub BackgroundRainbow()
        'Shhhhhh its a secret feature
        Select Case backinc
            Case 0
                Me.BackColor = Color.Red
                backinc += 1
            Case 1
                Me.BackColor = Color.Blue
                backinc += 1
            Case 2
                Me.BackColor = Color.Cyan
                backinc += 1
            Case 3
                Me.BackColor = Color.Magenta
                backinc += 1
            Case 4
                Me.BackColor = Color.Lime
                backinc += 1
            Case 5
                Me.BackColor = Color.Silver
                backinc = 0
        End Select
    End Sub
    'jajajajajajajajaja
End Class