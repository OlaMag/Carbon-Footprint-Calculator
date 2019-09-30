Public Class Calculator
    'when user clicks on the box, the grey prompt to enter an integer disappears and font colour changes into black 
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Me.TextBox1.Text = ""
        TextBox1.ForeColor = Color.Black
    End Sub
    'sends the user to a website that calculates milage for them
    Private Sub lnklblMilage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblMilage.LinkClicked
        System.Diagnostics.Process.Start("http://www.webflyer.com/travel/mileage_calculator/")
    End Sub
    'resets all values to enable another calculation, enables button 'Calculate'
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TextBox1.Text = ""
        lblResult.Text = ""
        lblResultTxt.Text = ""
        btnKm.Checked = False
        btnMiles.Checked = False
        btnBusiness.Checked = False
        btnEconomy.Checked = False
        btnClass1.Checked = False
        Chart1.Visible = False
        Chart1.Series("CO2").Points.Clear()
        btnCalculate.Show()
        lblReset.Visible = False
    End Sub
    'button 'Calculate' activates a series of events: first checks if the user has input all necessary data
    'then depending on the user's choice, it performs calculations of the amount of CO2 released during the plane journey
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click, btnCalculate.Enter
        'variables behind the formula are declared as double for precision
        Dim a, x, b, c, s, plf, cf, cw, ef, m, p, bus, car, rail As Double
        'the result displayed to the user is declared as integer for clarity
        Dim y As Integer

        'if input isn't numerical prompt the user to enter a valid number, clear the invalid input:
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("Please enter a valid number.", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
        End If
        x = TextBox1.Text()
        ' if input is negative prompt the user to enter a valid number, clear the invalid input:
        If IsNumeric(TextBox1.Text) = True And x < 0 Then
            MsgBox("Please enter a valid number.", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
            'if neither button miles not kilometers are checked, prompt the user
        ElseIf btnKm.Checked = False And btnMiles.Checked = False Then
            MsgBox("Please choose kilometres or miles.", MsgBoxStyle.Exclamation)
            'if neither seat class buttons are checked, prompt the user
        ElseIf btnEconomy.Checked = False And btnBusiness.Checked = False And btnClass1.Checked = False Then
            MsgBox("Please choose seat class.", MsgBoxStyle.Exclamation)
        Else
            'convertion miles to kilometers
            If btnMiles.Checked = True Then
                x = TextBox1.Text / 0.62137
            ElseIf btnKm.Checked = True Then
                x = TextBox1.Text
            End If

            'universal variables  
            ef = 3.15
            p = 0.51
            m = 2
            a = 0.000134567
            b = 6.1798
            c = 3446.2
            s = 280.39
            plf = 0.77
            cf = 0.951
            'variables dependent on flight class
            If btnEconomy.Checked = True Then
                cw = 0.8
            ElseIf btnBusiness.Checked = True Then
                cw = 1.54
            ElseIf btnClass1.Checked = True Then
                cw = 2.4
            End If


            y = ((a * (x * x) + b * x + c) / (s * plf)) * cf * cw * (ef * m + p)
            lblReset.Visible = True
            lblResult.Text = y
            lblResultTxt.Text = "Kilograms of CO2 released per passenger during this journey: "

            'formulas for calculating emissions from other modes of transport from http://www.aef.org.uk/downloads/Grams_CO2_transportmodesUK.pdf
            bus = x * 0.0891 'Source: NAEI
            rail = x * 0.0602 'Source: DEFRA company reporting guidelines 
            car = x * 0.118  'European Commision 2015 average, whole car, 1 person https://ec.europa.eu/clima/policies/transport/vehicles/cars_en

            'draws a graph based on the above calculations
            Chart1.Visible = True
            Me.Chart1.Series("CO2").Points.AddXY("plane", y)
            Me.Chart1.Series("CO2").Points.AddXY("car", car)
            Me.Chart1.Series("CO2").Points.AddXY("bus", bus)
            Me.Chart1.Series("CO2").Points.AddXY("train", rail)
            btnCalculate.Hide()
        End If


    End Sub
    'shows methodology (about):
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub
    'closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    'goes back to start screen (intro):
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Intro.Show()
    End Sub
End Class
