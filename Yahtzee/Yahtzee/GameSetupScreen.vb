Public Class GameSetupScreen
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudPlayerNum.ValueChanged
        'Displays name textboxes depending on nudPlayer value
        Select Case nudPlayerNum.Value
            Case 1
                txtP2Name.Visible = False
                txtP3Name.Visible = False
                txtP4Name.Visible = False
                lblP2Ti.Visible = False
                lblP3Ti.Visible = False
                lblP4Ti.Visible = False
            Case 2
                txtP2Name.Visible = True
                txtP3Name.Visible = False
                txtP4Name.Visible = False
                lblP2Ti.Visible = True
                lblP3Ti.Visible = False
                lblP4Ti.Visible = False
            Case 3
                txtP3Name.Visible = True
                txtP4Name.Visible = False
                lblP3Ti.Visible = True
                lblP4Ti.Visible = False
            Case 4
                txtP4Name.Visible = True
                lblP4Ti.Visible = True
        End Select
        NumPlayers = nudPlayerNum.Value - 1
    End Sub
    Private Sub btnCommence_Click(sender As Object, e As EventArgs) Handles btnCommence.Click
        Select Case NumPlayers
            Case 0
                PlayerNames(0) = txtP1Name.Text
            Case 1
                PlayerNames(0) = txtP1Name.Text
                PlayerNames(1) = txtP2Name.Text
            Case 2
                PlayerNames(0) = txtP1Name.Text
                PlayerNames(1) = txtP2Name.Text
                PlayerNames(2) = txtP3Name.Text
            Case 3
                PlayerNames(0) = txtP1Name.Text
                PlayerNames(1) = txtP2Name.Text
                PlayerNames(2) = txtP3Name.Text
                PlayerNames(3) = txtP4Name.Text
        End Select
        frmMain.lblPName.Text = PlayerNames(CurrPlayer)
        frmMain.lblP1Ti.Text = PlayerNames(0)
        frmMain.lblP2Ti.Text = PlayerNames(1)
        frmMain.lblP3Ti.Text = PlayerNames(2)
        frmMain.lblP4Ti.Text = PlayerNames(3)
        ResetDice()
        ResetScores()
        frmMain.Show()
        Me.Close()
    End Sub
End Class