<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnklblIcon = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For calculations of CO2 emissions of flights I used the formula and values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sugge" & _
    "sted  on the website www.myclimate.org. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "In aviation emission levels vary depending on the distance travelled. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depending" & _
    " on the class, we follow the rule of thumb that the more " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "expensive the ticket," & _
    " the more CO2 produced. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(31, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 91)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Icon made by Freekpik from "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(354, 52)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'lnklblIcon
        '
        Me.lnklblIcon.AutoSize = True
        Me.lnklblIcon.Location = New System.Drawing.Point(168, 329)
        Me.lnklblIcon.Name = "lnklblIcon"
        Me.lnklblIcon.Size = New System.Drawing.Size(94, 13)
        Me.lnklblIcon.TabIndex = 8
        Me.lnklblIcon.TabStop = True
        Me.lnklblIcon.Text = "www.flaticon.com."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(137, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "About this project"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(171, 403)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 462)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lnklblIcon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(440, 500)
        Me.MinimumSize = New System.Drawing.Size(440, 500)
        Me.Name = "About"
        Me.Text = "About this project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnklblIcon As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
