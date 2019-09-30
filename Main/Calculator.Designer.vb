<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCalc1 = New System.Windows.Forms.Label()
        Me.lblCalc2 = New System.Windows.Forms.Label()
        Me.grpSeatClass = New System.Windows.Forms.GroupBox()
        Me.btnClass1 = New System.Windows.Forms.RadioButton()
        Me.btnBusiness = New System.Windows.Forms.RadioButton()
        Me.btnEconomy = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnKm = New System.Windows.Forms.RadioButton()
        Me.btnMiles = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblResultTxt = New System.Windows.Forms.Label()
        Me.lnklblMilage = New System.Windows.Forms.LinkLabel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.grpSeatClass.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(91, 603)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(244, 603)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 1
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(389, 603)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(158, 219)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCalc1
        '
        Me.lblCalc1.AutoSize = True
        Me.lblCalc1.Location = New System.Drawing.Point(46, 32)
        Me.lblCalc1.Name = "lblCalc1"
        Me.lblCalc1.Size = New System.Drawing.Size(401, 13)
        Me.lblCalc1.TabIndex = 4
        Me.lblCalc1.Text = "Enter the distance you are flying, either in miles or kilometers and choose seat " & _
    "class."
        '
        'lblCalc2
        '
        Me.lblCalc2.AutoSize = True
        Me.lblCalc2.Location = New System.Drawing.Point(46, 57)
        Me.lblCalc2.Name = "lblCalc2"
        Me.lblCalc2.Size = New System.Drawing.Size(250, 13)
        Me.lblCalc2.TabIndex = 5
        Me.lblCalc2.Text = "If you don't know the distance, you can calculate it " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpSeatClass
        '
        Me.grpSeatClass.Controls.Add(Me.btnClass1)
        Me.grpSeatClass.Controls.Add(Me.btnBusiness)
        Me.grpSeatClass.Controls.Add(Me.btnEconomy)
        Me.grpSeatClass.Location = New System.Drawing.Point(40, 129)
        Me.grpSeatClass.Name = "grpSeatClass"
        Me.grpSeatClass.Size = New System.Drawing.Size(486, 47)
        Me.grpSeatClass.TabIndex = 6
        Me.grpSeatClass.TabStop = False
        '
        'btnClass1
        '
        Me.btnClass1.AutoSize = True
        Me.btnClass1.Location = New System.Drawing.Point(390, 19)
        Me.btnClass1.Name = "btnClass1"
        Me.btnClass1.Size = New System.Drawing.Size(72, 17)
        Me.btnClass1.TabIndex = 2
        Me.btnClass1.TabStop = True
        Me.btnClass1.Text = "First Class"
        Me.btnClass1.UseVisualStyleBackColor = True
        '
        'btnBusiness
        '
        Me.btnBusiness.AutoSize = True
        Me.btnBusiness.Location = New System.Drawing.Point(199, 19)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(95, 17)
        Me.btnBusiness.TabIndex = 1
        Me.btnBusiness.TabStop = True
        Me.btnBusiness.Text = "Business Class"
        Me.btnBusiness.UseVisualStyleBackColor = True
        '
        'btnEconomy
        '
        Me.btnEconomy.AutoSize = True
        Me.btnEconomy.Location = New System.Drawing.Point(6, 19)
        Me.btnEconomy.Name = "btnEconomy"
        Me.btnEconomy.Size = New System.Drawing.Size(97, 17)
        Me.btnEconomy.TabIndex = 0
        Me.btnEconomy.TabStop = True
        Me.btnEconomy.Text = "Economy Class"
        Me.btnEconomy.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(49, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Enter a positive number"
        '
        'btnKm
        '
        Me.btnKm.AutoSize = True
        Me.btnKm.Location = New System.Drawing.Point(346, 91)
        Me.btnKm.Name = "btnKm"
        Me.btnKm.Size = New System.Drawing.Size(72, 17)
        Me.btnKm.TabIndex = 8
        Me.btnKm.TabStop = True
        Me.btnKm.Text = "kilometers"
        Me.btnKm.UseVisualStyleBackColor = True
        '
        'btnMiles
        '
        Me.btnMiles.AutoSize = True
        Me.btnMiles.Location = New System.Drawing.Point(463, 91)
        Me.btnMiles.Name = "btnMiles"
        Me.btnMiles.Size = New System.Drawing.Size(48, 17)
        Me.btnMiles.TabIndex = 9
        Me.btnMiles.TabStop = True
        Me.btnMiles.Text = "miles"
        Me.btnMiles.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(324, 219)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.SystemColors.Control
        Me.lblResult.Location = New System.Drawing.Point(376, 280)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 11
        '
        'lblResultTxt
        '
        Me.lblResultTxt.AutoSize = True
        Me.lblResultTxt.Location = New System.Drawing.Point(46, 280)
        Me.lblResultTxt.Name = "lblResultTxt"
        Me.lblResultTxt.Size = New System.Drawing.Size(0, 13)
        Me.lblResultTxt.TabIndex = 12
        '
        'lnklblMilage
        '
        Me.lnklblMilage.AutoSize = True
        Me.lnklblMilage.Location = New System.Drawing.Point(288, 57)
        Me.lnklblMilage.Name = "lnklblMilage"
        Me.lnklblMilage.Size = New System.Drawing.Size(31, 13)
        Me.lnklblMilage.TabIndex = 13
        Me.lnklblMilage.TabStop = True
        Me.lnklblMilage.Text = "here."
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Legend1.Title = "CO2 emissions in kg per passenger "
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(55, 344)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "CO2"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(456, 200)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.Color.Maroon
        Me.lblReset.Location = New System.Drawing.Point(37, 194)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(315, 13)
        Me.lblReset.TabIndex = 15
        Me.lblReset.Text = "To perform another calculation click the Reset button."
        Me.lblReset.Visible = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 668)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lnklblMilage)
        Me.Controls.Add(Me.lblResultTxt)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnMiles)
        Me.Controls.Add(Me.btnKm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.grpSeatClass)
        Me.Controls.Add(Me.lblCalc2)
        Me.Controls.Add(Me.lblCalc1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.grpSeatClass.ResumeLayout(False)
        Me.grpSeatClass.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCalc1 As System.Windows.Forms.Label
    Friend WithEvents lblCalc2 As System.Windows.Forms.Label
    Friend WithEvents grpSeatClass As System.Windows.Forms.GroupBox
    Friend WithEvents btnClass1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents btnEconomy As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnKm As System.Windows.Forms.RadioButton
    Friend WithEvents btnMiles As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblResultTxt As System.Windows.Forms.Label
    Friend WithEvents lnklblMilage As System.Windows.Forms.LinkLabel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblReset As System.Windows.Forms.Label
End Class
