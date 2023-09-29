<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chkCocaCola = New System.Windows.Forms.CheckBox()
        Me.chkPrime = New System.Windows.Forms.CheckBox()
        Me.chkWater = New System.Windows.Forms.CheckBox()
        Me.chkSprite = New System.Windows.Forms.CheckBox()
        Me.chkTango = New System.Windows.Forms.CheckBox()
        Me.numCoke = New System.Windows.Forms.NumericUpDown()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.numPrime = New System.Windows.Forms.NumericUpDown()
        Me.numSprite = New System.Windows.Forms.NumericUpDown()
        Me.numWater = New System.Windows.Forms.NumericUpDown()
        Me.numTango = New System.Windows.Forms.NumericUpDown()
        Me.chkAqua = New System.Windows.Forms.CheckBox()
        Me.chkPepsi = New System.Windows.Forms.CheckBox()
        Me.chkRedBull = New System.Windows.Forms.CheckBox()
        Me.numAqua = New System.Windows.Forms.NumericUpDown()
        Me.numPepsi = New System.Windows.Forms.NumericUpDown()
        Me.numRebBull = New System.Windows.Forms.NumericUpDown()
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAqua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPepsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRebBull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(117, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Vending Machine"
        '
        'chkCocaCola
        '
        Me.chkCocaCola.Location = New System.Drawing.Point(67, 106)
        Me.chkCocaCola.Name = "chkCocaCola"
        Me.chkCocaCola.Size = New System.Drawing.Size(128, 32)
        Me.chkCocaCola.TabIndex = 1
        Me.chkCocaCola.Text = "CocaCola £2.00"
        Me.chkCocaCola.UseVisualStyleBackColor = True
        '
        'chkPrime
        '
        Me.chkPrime.Location = New System.Drawing.Point(67, 144)
        Me.chkPrime.Name = "chkPrime"
        Me.chkPrime.Size = New System.Drawing.Size(128, 32)
        Me.chkPrime.TabIndex = 2
        Me.chkPrime.Text = "Prime £2.50"
        Me.chkPrime.UseVisualStyleBackColor = True
        '
        'chkWater
        '
        Me.chkWater.Location = New System.Drawing.Point(67, 220)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(128, 32)
        Me.chkWater.TabIndex = 3
        Me.chkWater.Text = "Water £1.00"
        Me.chkWater.UseVisualStyleBackColor = True
        '
        'chkSprite
        '
        Me.chkSprite.Location = New System.Drawing.Point(67, 182)
        Me.chkSprite.Name = "chkSprite"
        Me.chkSprite.Size = New System.Drawing.Size(128, 32)
        Me.chkSprite.TabIndex = 4
        Me.chkSprite.Text = "Sprite £2.50"
        Me.chkSprite.UseVisualStyleBackColor = True
        '
        'chkTango
        '
        Me.chkTango.Location = New System.Drawing.Point(67, 258)
        Me.chkTango.Name = "chkTango"
        Me.chkTango.Size = New System.Drawing.Size(128, 32)
        Me.chkTango.TabIndex = 5
        Me.chkTango.Text = "Tango £2.50"
        Me.chkTango.UseVisualStyleBackColor = True
        '
        'numCoke
        '
        Me.numCoke.Location = New System.Drawing.Point(218, 113)
        Me.numCoke.Name = "numCoke"
        Me.numCoke.Size = New System.Drawing.Size(29, 20)
        Me.numCoke.TabIndex = 6
        Me.numCoke.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(33, 455)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(347, 23)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Cost of Order £0"
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(36, 492)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(159, 35)
        Me.btnFinish.TabIndex = 8
        Me.btnFinish.Text = "Finish and Pay"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lstOrders
        '
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.Location = New System.Drawing.Point(307, 113)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(134, 303)
        Me.lstOrders.TabIndex = 9
        '
        'numPrime
        '
        Me.numPrime.Location = New System.Drawing.Point(218, 151)
        Me.numPrime.Name = "numPrime"
        Me.numPrime.Size = New System.Drawing.Size(29, 20)
        Me.numPrime.TabIndex = 10
        Me.numPrime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numSprite
        '
        Me.numSprite.Location = New System.Drawing.Point(218, 189)
        Me.numSprite.Name = "numSprite"
        Me.numSprite.Size = New System.Drawing.Size(29, 20)
        Me.numSprite.TabIndex = 11
        Me.numSprite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numWater
        '
        Me.numWater.Location = New System.Drawing.Point(218, 227)
        Me.numWater.Name = "numWater"
        Me.numWater.Size = New System.Drawing.Size(29, 20)
        Me.numWater.TabIndex = 12
        Me.numWater.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numTango
        '
        Me.numTango.Location = New System.Drawing.Point(218, 265)
        Me.numTango.Name = "numTango"
        Me.numTango.Size = New System.Drawing.Size(29, 20)
        Me.numTango.TabIndex = 13
        Me.numTango.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkAqua
        '
        Me.chkAqua.Location = New System.Drawing.Point(67, 296)
        Me.chkAqua.Name = "chkAqua"
        Me.chkAqua.Size = New System.Drawing.Size(128, 32)
        Me.chkAqua.TabIndex = 14
        Me.chkAqua.Text = "Aqua £1.50"
        Me.chkAqua.UseVisualStyleBackColor = True
        '
        'chkPepsi
        '
        Me.chkPepsi.Location = New System.Drawing.Point(67, 334)
        Me.chkPepsi.Name = "chkPepsi"
        Me.chkPepsi.Size = New System.Drawing.Size(128, 32)
        Me.chkPepsi.TabIndex = 15
        Me.chkPepsi.Text = "Pepsi £2.00"
        Me.chkPepsi.UseVisualStyleBackColor = True
        '
        'chkRedBull
        '
        Me.chkRedBull.Location = New System.Drawing.Point(67, 372)
        Me.chkRedBull.Name = "chkRedBull"
        Me.chkRedBull.Size = New System.Drawing.Size(128, 32)
        Me.chkRedBull.TabIndex = 16
        Me.chkRedBull.Text = "RedBull £3.00"
        Me.chkRedBull.UseVisualStyleBackColor = True
        '
        'numAqua
        '
        Me.numAqua.Location = New System.Drawing.Point(218, 303)
        Me.numAqua.Name = "numAqua"
        Me.numAqua.Size = New System.Drawing.Size(29, 20)
        Me.numAqua.TabIndex = 17
        Me.numAqua.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numPepsi
        '
        Me.numPepsi.Location = New System.Drawing.Point(218, 341)
        Me.numPepsi.Name = "numPepsi"
        Me.numPepsi.Size = New System.Drawing.Size(29, 20)
        Me.numPepsi.TabIndex = 18
        Me.numPepsi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numRebBull
        '
        Me.numRebBull.Location = New System.Drawing.Point(218, 379)
        Me.numRebBull.Name = "numRebBull"
        Me.numRebBull.Size = New System.Drawing.Size(29, 20)
        Me.numRebBull.TabIndex = 19
        Me.numRebBull.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 556)
        Me.Controls.Add(Me.numRebBull)
        Me.Controls.Add(Me.numPepsi)
        Me.Controls.Add(Me.numAqua)
        Me.Controls.Add(Me.chkRedBull)
        Me.Controls.Add(Me.chkPepsi)
        Me.Controls.Add(Me.chkAqua)
        Me.Controls.Add(Me.numTango)
        Me.Controls.Add(Me.numWater)
        Me.Controls.Add(Me.numSprite)
        Me.Controls.Add(Me.numPrime)
        Me.Controls.Add(Me.lstOrders)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.numCoke)
        Me.Controls.Add(Me.chkTango)
        Me.Controls.Add(Me.chkSprite)
        Me.Controls.Add(Me.chkWater)
        Me.Controls.Add(Me.chkPrime)
        Me.Controls.Add(Me.chkCocaCola)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAqua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPepsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRebBull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents chkCocaCola As CheckBox
    Friend WithEvents chkPrime As CheckBox
    Friend WithEvents chkWater As CheckBox
    Friend WithEvents chkSprite As CheckBox
    Friend WithEvents chkTango As CheckBox
    Friend WithEvents numCoke As NumericUpDown
    Friend WithEvents lblCost As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents lstOrders As ListBox
    Friend WithEvents numPrime As NumericUpDown
    Friend WithEvents numSprite As NumericUpDown
    Friend WithEvents numWater As NumericUpDown
    Friend WithEvents numTango As NumericUpDown
    Friend WithEvents chkAqua As CheckBox
    Friend WithEvents chkPepsi As CheckBox
    Friend WithEvents chkRedBull As CheckBox
    Friend WithEvents numAqua As NumericUpDown
    Friend WithEvents numPepsi As NumericUpDown
    Friend WithEvents numRebBull As NumericUpDown
End Class
