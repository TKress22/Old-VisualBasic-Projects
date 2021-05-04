<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecieptDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lboDisplay = New System.Windows.Forms.ListBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblToTrans = New System.Windows.Forms.Label()
        Me.lblGTotal = New System.Windows.Forms.Label()
        Me.lblGToDis = New System.Windows.Forms.Label()
        Me.lblTransDis = New System.Windows.Forms.Label()
        Me.lblPToDis = New System.Windows.Forms.Label()
        Me.lblPTo = New System.Windows.Forms.Label()
        Me.lblToppings = New System.Windows.Forms.Label()
        Me.lblPep = New System.Windows.Forms.Label()
        Me.lblTiPep = New System.Windows.Forms.Label()
        Me.lblSau = New System.Windows.Forms.Label()
        Me.lblTiSau = New System.Windows.Forms.Label()
        Me.lblMus = New System.Windows.Forms.Label()
        Me.lblTiMus = New System.Windows.Forms.Label()
        Me.lblBac = New System.Windows.Forms.Label()
        Me.lblTiBac = New System.Windows.Forms.Label()
        Me.lblOli = New System.Windows.Forms.Label()
        Me.lblTiOli = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lboDisplay
        '
        Me.lboDisplay.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDisplay.FormattingEnabled = True
        Me.lboDisplay.ItemHeight = 15
        Me.lboDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lboDisplay.Name = "lboDisplay"
        Me.lboDisplay.Size = New System.Drawing.Size(279, 469)
        Me.lboDisplay.TabIndex = 0
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(467, 461)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblToTrans
        '
        Me.lblToTrans.AutoSize = True
        Me.lblToTrans.Location = New System.Drawing.Point(317, 84)
        Me.lblToTrans.Name = "lblToTrans"
        Me.lblToTrans.Size = New System.Drawing.Size(98, 13)
        Me.lblToTrans.TabIndex = 2
        Me.lblToTrans.Text = "Total Transactions:"
        '
        'lblGTotal
        '
        Me.lblGTotal.AutoSize = True
        Me.lblGTotal.Location = New System.Drawing.Point(318, 33)
        Me.lblGTotal.Name = "lblGTotal"
        Me.lblGTotal.Size = New System.Drawing.Size(66, 13)
        Me.lblGTotal.TabIndex = 4
        Me.lblGTotal.Text = "Grand Total:"
        '
        'lblGToDis
        '
        Me.lblGToDis.AutoSize = True
        Me.lblGToDis.Location = New System.Drawing.Point(436, 33)
        Me.lblGToDis.Name = "lblGToDis"
        Me.lblGToDis.Size = New System.Drawing.Size(16, 13)
        Me.lblGToDis.TabIndex = 6
        Me.lblGToDis.Text = "---"
        '
        'lblTransDis
        '
        Me.lblTransDis.AutoSize = True
        Me.lblTransDis.Location = New System.Drawing.Point(435, 84)
        Me.lblTransDis.Name = "lblTransDis"
        Me.lblTransDis.Size = New System.Drawing.Size(16, 13)
        Me.lblTransDis.TabIndex = 5
        Me.lblTransDis.Text = "---"
        '
        'lblPToDis
        '
        Me.lblPToDis.AutoSize = True
        Me.lblPToDis.Location = New System.Drawing.Point(435, 135)
        Me.lblPToDis.Name = "lblPToDis"
        Me.lblPToDis.Size = New System.Drawing.Size(16, 13)
        Me.lblPToDis.TabIndex = 8
        Me.lblPToDis.Text = "---"
        '
        'lblPTo
        '
        Me.lblPTo.AutoSize = True
        Me.lblPTo.Location = New System.Drawing.Point(317, 135)
        Me.lblPTo.Name = "lblPTo"
        Me.lblPTo.Size = New System.Drawing.Size(67, 13)
        Me.lblPTo.TabIndex = 7
        Me.lblPTo.Text = "Total Pizzas:"
        '
        'lblToppings
        '
        Me.lblToppings.AutoSize = True
        Me.lblToppings.Location = New System.Drawing.Point(317, 192)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.Size = New System.Drawing.Size(86, 13)
        Me.lblToppings.TabIndex = 9
        Me.lblToppings.Text = "Toppings Totals:"
        '
        'lblPep
        '
        Me.lblPep.AutoSize = True
        Me.lblPep.Location = New System.Drawing.Point(435, 232)
        Me.lblPep.Name = "lblPep"
        Me.lblPep.Size = New System.Drawing.Size(16, 13)
        Me.lblPep.TabIndex = 11
        Me.lblPep.Text = "---"
        '
        'lblTiPep
        '
        Me.lblTiPep.AutoSize = True
        Me.lblTiPep.Location = New System.Drawing.Point(336, 232)
        Me.lblTiPep.Name = "lblTiPep"
        Me.lblTiPep.Size = New System.Drawing.Size(61, 13)
        Me.lblTiPep.TabIndex = 10
        Me.lblTiPep.Text = "-Pepperoni:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSau
        '
        Me.lblSau.AutoSize = True
        Me.lblSau.Location = New System.Drawing.Point(435, 265)
        Me.lblSau.Name = "lblSau"
        Me.lblSau.Size = New System.Drawing.Size(16, 13)
        Me.lblSau.TabIndex = 13
        Me.lblSau.Text = "---"
        '
        'lblTiSau
        '
        Me.lblTiSau.AutoSize = True
        Me.lblTiSau.Location = New System.Drawing.Point(336, 265)
        Me.lblTiSau.Name = "lblTiSau"
        Me.lblTiSau.Size = New System.Drawing.Size(55, 13)
        Me.lblTiSau.TabIndex = 12
        Me.lblTiSau.Text = "-Sausage:"
        '
        'lblMus
        '
        Me.lblMus.AutoSize = True
        Me.lblMus.Location = New System.Drawing.Point(435, 298)
        Me.lblMus.Name = "lblMus"
        Me.lblMus.Size = New System.Drawing.Size(16, 13)
        Me.lblMus.TabIndex = 15
        Me.lblMus.Text = "---"
        '
        'lblTiMus
        '
        Me.lblTiMus.AutoSize = True
        Me.lblTiMus.Location = New System.Drawing.Point(336, 298)
        Me.lblTiMus.Name = "lblTiMus"
        Me.lblTiMus.Size = New System.Drawing.Size(67, 13)
        Me.lblTiMus.TabIndex = 14
        Me.lblTiMus.Text = "-Mushrooms:"
        '
        'lblBac
        '
        Me.lblBac.AutoSize = True
        Me.lblBac.Location = New System.Drawing.Point(435, 331)
        Me.lblBac.Name = "lblBac"
        Me.lblBac.Size = New System.Drawing.Size(16, 13)
        Me.lblBac.TabIndex = 17
        Me.lblBac.Text = "---"
        '
        'lblTiBac
        '
        Me.lblTiBac.AutoSize = True
        Me.lblTiBac.Location = New System.Drawing.Point(336, 331)
        Me.lblTiBac.Name = "lblTiBac"
        Me.lblTiBac.Size = New System.Drawing.Size(44, 13)
        Me.lblTiBac.TabIndex = 16
        Me.lblTiBac.Text = "-Bacon:"
        '
        'lblOli
        '
        Me.lblOli.AutoSize = True
        Me.lblOli.Location = New System.Drawing.Point(435, 364)
        Me.lblOli.Name = "lblOli"
        Me.lblOli.Size = New System.Drawing.Size(16, 13)
        Me.lblOli.TabIndex = 19
        Me.lblOli.Text = "---"
        '
        'lblTiOli
        '
        Me.lblTiOli.AutoSize = True
        Me.lblTiOli.Location = New System.Drawing.Point(336, 364)
        Me.lblTiOli.Name = "lblTiOli"
        Me.lblTiOli.Size = New System.Drawing.Size(42, 13)
        Me.lblTiOli.TabIndex = 18
        Me.lblTiOli.Text = "-Olives:"
        '
        'frmRecieptDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(554, 496)
        Me.Controls.Add(Me.lblOli)
        Me.Controls.Add(Me.lblTiOli)
        Me.Controls.Add(Me.lblBac)
        Me.Controls.Add(Me.lblTiBac)
        Me.Controls.Add(Me.lblMus)
        Me.Controls.Add(Me.lblTiMus)
        Me.Controls.Add(Me.lblSau)
        Me.Controls.Add(Me.lblTiSau)
        Me.Controls.Add(Me.lblPep)
        Me.Controls.Add(Me.lblTiPep)
        Me.Controls.Add(Me.lblToppings)
        Me.Controls.Add(Me.lblPToDis)
        Me.Controls.Add(Me.lblPTo)
        Me.Controls.Add(Me.lblGToDis)
        Me.Controls.Add(Me.lblTransDis)
        Me.Controls.Add(Me.lblGTotal)
        Me.Controls.Add(Me.lblToTrans)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lboDisplay)
        Me.Name = "frmRecieptDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lboDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblToTrans As System.Windows.Forms.Label
    Friend WithEvents lblGTotal As System.Windows.Forms.Label
    Friend WithEvents lblGToDis As System.Windows.Forms.Label
    Friend WithEvents lblTransDis As System.Windows.Forms.Label
    Friend WithEvents lblPToDis As System.Windows.Forms.Label
    Friend WithEvents lblPTo As System.Windows.Forms.Label
    Friend WithEvents lblToppings As System.Windows.Forms.Label
    Friend WithEvents lblPep As System.Windows.Forms.Label
    Friend WithEvents lblTiPep As System.Windows.Forms.Label
    Friend WithEvents lblSau As System.Windows.Forms.Label
    Friend WithEvents lblTiSau As System.Windows.Forms.Label
    Friend WithEvents lblMus As System.Windows.Forms.Label
    Friend WithEvents lblTiMus As System.Windows.Forms.Label
    Friend WithEvents lblBac As System.Windows.Forms.Label
    Friend WithEvents lblTiBac As System.Windows.Forms.Label
    Friend WithEvents lblOli As System.Windows.Forms.Label
    Friend WithEvents lblTiOli As System.Windows.Forms.Label
End Class
