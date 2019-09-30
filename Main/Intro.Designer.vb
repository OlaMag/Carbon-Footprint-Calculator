<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.imgPlane = New System.Windows.Forms.PictureBox()
        Me.lblIntro2 = New System.Windows.Forms.Label()
        CType(Me.imgPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(36, 403)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(292, 403)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(165, 403)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(54, 26)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New System.Windows.Forms.Padding(2)
        Me.lbl1.Size = New System.Drawing.Size(313, 44)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "transport carbon emissions calculator"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgPlane
        '
        Me.imgPlane.Image = Global.WindowsApplication1.My.Resources.Resources.plane_resized
        Me.imgPlane.Location = New System.Drawing.Point(58, 100)
        Me.imgPlane.Name = "imgPlane"
        Me.imgPlane.Size = New System.Drawing.Size(309, 182)
        Me.imgPlane.TabIndex = 4
        Me.imgPlane.TabStop = False
        '
        'lblIntro2
        '
        Me.lblIntro2.AutoSize = True
        Me.lblIntro2.Location = New System.Drawing.Point(55, 316)
        Me.lblIntro2.Name = "lblIntro2"
        Me.lblIntro2.Size = New System.Drawing.Size(309, 65)
        Me.lblIntro2.TabIndex = 0
        Me.lblIntro2.Text = "This program will help you to calculate approximately how much " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CO2 will be prod" & _
    "uced if you travel by plane. Subsequently, it will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "compare the emissions to ot" & _
    "her modes of transport. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.lblIntro2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 462)
        Me.Controls.Add(Me.lblIntro2)
        Me.Controls.Add(Me.imgPlane)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(440, 500)
        Me.MinimumSize = New System.Drawing.Size(440, 500)
        Me.Name = "Intro"
        Me.Text = "Intro"
        CType(Me.imgPlane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents imgPlane As System.Windows.Forms.PictureBox
    Friend WithEvents lblIntro2 As System.Windows.Forms.Label
End Class
