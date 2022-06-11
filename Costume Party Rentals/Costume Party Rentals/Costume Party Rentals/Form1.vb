' Program Name: Costume Rental Specials
' Developer:    Josh Nichols
' Date:         1/21/2022
' Purpose:      Program opens giving the user 4 options for costume rental specials.
'               User then selects the costume they would like pressing the purchase button
'               After a selection is made a confirmation message is displayed and the user can exit the program
Public Class frmCostumeRentalSpecials
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        Close()
    End Sub

    Private Sub btnRenaissanceFair_Click(sender As Object, e As EventArgs) Handles btnRenaissanceFair.Click
        ' This block tells the program when the Renaissance Fair button is sellected to display the Renaissance costume picture
        ' It keeps the remainging photos hidden and enables the Book Rental button
        picRenaissanceFair.Visible = True
        picBatmanBatgirl.Visible = False
        picPirate.Visible = False
        picStormtrooper.Visible = False
        btnBookRental.Enabled = True
    End Sub

    Private Sub btnStormtrooper_Click(sender As Object, e As EventArgs) Handles btnStormtrooper.Click
        ' This block tells the program when the Stormtrooper button is sellected to display the Stormtrooper costume picture
        ' It keeps the remainging photos hidden and enables the Book Rental button
        picRenaissanceFair.Visible = True
        picRenaissanceFair.Visible = False
        picBatmanBatgirl.Visible = False
        picPirate.Visible = False
        picStormtrooper.Visible = True
        btnBookRental.Enabled = True
    End Sub

    Private Sub btnBatmanBatgirl_Click(sender As Object, e As EventArgs) Handles btnBatmanBatgirl.Click
        ' This block tells the program when the Batman/Batgirl button is sellected to display the Batman/Batgirl costume picture
        ' It keeps the remainging photos hidden and enables the Book Rental button
        picRenaissanceFair.Visible = True
        picRenaissanceFair.Visible = False
        picBatmanBatgirl.Visible = True
        picPirate.Visible = False
        picStormtrooper.Visible = False
        btnBookRental.Enabled = True
    End Sub

    Private Sub btnPirate_Click(sender As Object, e As EventArgs) Handles btnPirate.Click
        ' This block tells the program when the Pirate button is sellected to display the Pirate costume picture
        ' It keeps the remainging photos hidden and enables the Book Rental button
        picRenaissanceFair.Visible = True
        picRenaissanceFair.Visible = False
        picBatmanBatgirl.Visible = False
        picPirate.Visible = True
        picStormtrooper.Visible = False
        btnBookRental.Enabled = True
    End Sub

    Private Sub btnBookRental_Click(sender As Object, e As EventArgs) Handles btnBookRental.Click
        ' This block displays the confirmation message and hides the instructions.
        ' it also disables all the buttons for the costumes and enables the Exit Program button. 
        lblConfirmation.Visible = True
        lblInstructions.Visible = False
        btnExit.Enabled = True
        btnBookRental.Visible = False
        btnRenaissanceFair.Enabled = False
        btnStormtrooper.Enabled = False
        btnPirate.Enabled = False
        btnBatmanBatgirl.Enabled = False

    End Sub
End Class
