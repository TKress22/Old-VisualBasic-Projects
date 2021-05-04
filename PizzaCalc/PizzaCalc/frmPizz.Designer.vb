<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lboTransactions = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gpbTops = New System.Windows.Forms.GroupBox()
        Me.ckbOlives = New System.Windows.Forms.CheckBox()
        Me.ckbBacon = New System.Windows.Forms.CheckBox()
        Me.ckbMushroom = New System.Windows.Forms.CheckBox()
        Me.ckbSausage = New System.Windows.Forms.CheckBox()
        Me.ckbPepperoni = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpbSizes = New System.Windows.Forms.GroupBox()
        Me.rdbLarge = New System.Windows.Forms.RadioButton()
        Me.rdbMed = New System.Windows.Forms.RadioButton()
        Me.rdbSmall = New System.Windows.Forms.RadioButton()
        Me.txtPizzaNum = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumPizza = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayRecieptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbTops.SuspendLayout()
        Me.gpbSizes.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(203, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(304, 42)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Pizza Calculator"
        '
        'lboTransactions
        '
        Me.lboTransactions.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboTransactions.FormattingEnabled = True
        Me.lboTransactions.ItemHeight = 15
        Me.lboTransactions.Location = New System.Drawing.Point(159, 308)
        Me.lboTransactions.Name = "lboTransactions"
        Me.lboTransactions.Size = New System.Drawing.Size(294, 169)
        Me.lboTransactions.TabIndex = 13
        Me.lboTransactions.TabStop = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(542, 91)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(145, 40)
        Me.txtName.TabIndex = 12
        '
        'gpbTops
        '
        Me.gpbTops.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpbTops.Controls.Add(Me.ckbOlives)
        Me.gpbTops.Controls.Add(Me.ckbBacon)
        Me.gpbTops.Controls.Add(Me.ckbMushroom)
        Me.gpbTops.Controls.Add(Me.ckbSausage)
        Me.gpbTops.Controls.Add(Me.ckbPepperoni)
        Me.gpbTops.Location = New System.Drawing.Point(223, 91)
        Me.gpbTops.Name = "gpbTops"
        Me.gpbTops.Size = New System.Drawing.Size(163, 184)
        Me.gpbTops.TabIndex = 8
        Me.gpbTops.TabStop = False
        Me.gpbTops.Text = "Toppings"
        '
        'ckbOlives
        '
        Me.ckbOlives.AutoSize = True
        Me.ckbOlives.Location = New System.Drawing.Point(7, 154)
        Me.ckbOlives.Name = "ckbOlives"
        Me.ckbOlives.Size = New System.Drawing.Size(55, 17)
        Me.ckbOlives.TabIndex = 4
        Me.ckbOlives.Text = "Olives"
        Me.ckbOlives.UseVisualStyleBackColor = True
        '
        'ckbBacon
        '
        Me.ckbBacon.AutoSize = True
        Me.ckbBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbBacon.Location = New System.Drawing.Point(7, 121)
        Me.ckbBacon.Name = "ckbBacon"
        Me.ckbBacon.Size = New System.Drawing.Size(57, 17)
        Me.ckbBacon.TabIndex = 3
        Me.ckbBacon.Text = "Bacon"
        Me.ckbBacon.UseVisualStyleBackColor = True
        '
        'ckbMushroom
        '
        Me.ckbMushroom.AutoSize = True
        Me.ckbMushroom.Location = New System.Drawing.Point(7, 88)
        Me.ckbMushroom.Name = "ckbMushroom"
        Me.ckbMushroom.Size = New System.Drawing.Size(80, 17)
        Me.ckbMushroom.TabIndex = 2
        Me.ckbMushroom.Text = "Mushrooms"
        Me.ckbMushroom.UseVisualStyleBackColor = True
        '
        'ckbSausage
        '
        Me.ckbSausage.AutoSize = True
        Me.ckbSausage.Location = New System.Drawing.Point(7, 55)
        Me.ckbSausage.Name = "ckbSausage"
        Me.ckbSausage.Size = New System.Drawing.Size(68, 17)
        Me.ckbSausage.TabIndex = 1
        Me.ckbSausage.Text = "Sausage"
        Me.ckbSausage.UseVisualStyleBackColor = True
        '
        'ckbPepperoni
        '
        Me.ckbPepperoni.AutoSize = True
        Me.ckbPepperoni.Location = New System.Drawing.Point(7, 22)
        Me.ckbPepperoni.Name = "ckbPepperoni"
        Me.ckbPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.ckbPepperoni.TabIndex = 0
        Me.ckbPepperoni.Text = "Pepperoni"
        Me.ckbPepperoni.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(556, 282)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(134, 53)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Enabled = False
        Me.btnRecord.Location = New System.Drawing.Point(556, 362)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(134, 56)
        Me.btnRecord.TabIndex = 10
        Me.btnRecord.Text = "Record Transaction"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(556, 447)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 46)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gpbSizes
        '
        Me.gpbSizes.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpbSizes.Controls.Add(Me.rdbLarge)
        Me.gpbSizes.Controls.Add(Me.rdbMed)
        Me.gpbSizes.Controls.Add(Me.rdbSmall)
        Me.gpbSizes.Location = New System.Drawing.Point(21, 91)
        Me.gpbSizes.Name = "gpbSizes"
        Me.gpbSizes.Size = New System.Drawing.Size(163, 159)
        Me.gpbSizes.TabIndex = 7
        Me.gpbSizes.TabStop = False
        Me.gpbSizes.Text = "Sizes"
        '
        'rdbLarge
        '
        Me.rdbLarge.AutoSize = True
        Me.rdbLarge.Location = New System.Drawing.Point(16, 102)
        Me.rdbLarge.Name = "rdbLarge"
        Me.rdbLarge.Size = New System.Drawing.Size(52, 17)
        Me.rdbLarge.TabIndex = 2
        Me.rdbLarge.TabStop = True
        Me.rdbLarge.Text = "Large"
        Me.rdbLarge.UseVisualStyleBackColor = True
        '
        'rdbMed
        '
        Me.rdbMed.AutoSize = True
        Me.rdbMed.Location = New System.Drawing.Point(16, 68)
        Me.rdbMed.Name = "rdbMed"
        Me.rdbMed.Size = New System.Drawing.Size(62, 17)
        Me.rdbMed.TabIndex = 1
        Me.rdbMed.TabStop = True
        Me.rdbMed.Text = "Medium"
        Me.rdbMed.UseVisualStyleBackColor = True
        '
        'rdbSmall
        '
        Me.rdbSmall.AutoSize = True
        Me.rdbSmall.Location = New System.Drawing.Point(16, 34)
        Me.rdbSmall.Name = "rdbSmall"
        Me.rdbSmall.Size = New System.Drawing.Size(50, 17)
        Me.rdbSmall.TabIndex = 0
        Me.rdbSmall.TabStop = True
        Me.rdbSmall.Text = "Small"
        Me.rdbSmall.UseVisualStyleBackColor = True
        '
        'txtPizzaNum
        '
        Me.txtPizzaNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPizzaNum.Location = New System.Drawing.Point(624, 146)
        Me.txtPizzaNum.Multiline = True
        Me.txtPizzaNum.Name = "txtPizzaNum"
        Me.txtPizzaNum.Size = New System.Drawing.Size(46, 36)
        Me.txtPizzaNum.TabIndex = 15
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(542, 212)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(145, 40)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.TabStop = False
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(17, 315)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(123, 20)
        Me.lblTransaction.TabIndex = 17
        Me.lblTransaction.Text = "Transaction Log"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblName.Location = New System.Drawing.Point(415, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Name:"
        '
        'lblNumPizza
        '
        Me.lblNumPizza.AutoSize = True
        Me.lblNumPizza.Location = New System.Drawing.Point(415, 151)
        Me.lblNumPizza.Name = "lblNumPizza"
        Me.lblNumPizza.Size = New System.Drawing.Size(92, 13)
        Me.lblNumPizza.TabIndex = 19
        Me.lblNumPizza.Text = "Number of Pizzas:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(415, 217)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Total:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DisplayRecieptToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "msp1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateStripMenuItem, Me.RecordTransactionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateStripMenuItem
        '
        Me.CalculateStripMenuItem.Name = "CalculateStripMenuItem"
        Me.CalculateStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CalculateStripMenuItem.Text = "&Calculate"
        '
        'RecordTransactionToolStripMenuItem
        '
        Me.RecordTransactionToolStripMenuItem.Name = "RecordTransactionToolStripMenuItem"
        Me.RecordTransactionToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RecordTransactionToolStripMenuItem.Text = "&Record Transaction"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DisplayRecieptToolStripMenuItem
        '
        Me.DisplayRecieptToolStripMenuItem.Name = "DisplayRecieptToolStripMenuItem"
        Me.DisplayRecieptToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.DisplayRecieptToolStripMenuItem.Text = "Display Reciept"
        '
        'frmPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(699, 496)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNumPizza)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPizzaNum)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lboTransactions)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.gpbTops)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpbSizes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPizza"
        Me.Text = "Pizza Calculator"
        Me.gpbTops.ResumeLayout(False)
        Me.gpbTops.PerformLayout()
        Me.gpbSizes.ResumeLayout(False)
        Me.gpbSizes.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lboTransactions As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents gpbTops As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gpbSizes As System.Windows.Forms.GroupBox
    Friend WithEvents ckbOlives As System.Windows.Forms.CheckBox
    Friend WithEvents ckbBacon As System.Windows.Forms.CheckBox
    Friend WithEvents ckbMushroom As System.Windows.Forms.CheckBox
    Friend WithEvents ckbSausage As System.Windows.Forms.CheckBox
    Friend WithEvents ckbPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents rdbLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMed As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSmall As System.Windows.Forms.RadioButton
    Friend WithEvents txtPizzaNum As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNumPizza As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayRecieptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
