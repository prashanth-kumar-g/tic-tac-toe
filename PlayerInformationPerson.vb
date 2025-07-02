' ===================== PLAYER INFORMATION (PERSON) =====================  
' Handles dual player name input and initialization for human vs. human gameplay  

' ===================== PlayerInformationPerson Class =====================

Public Class PlayerInformationPerson

    ' --- PLAYER 1 TEXTBOX TEXT CHANGED EVENT ---  
    ' Ensures text visibility by enforcing black font color 

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        TextBox1.ForeColor = ColorTranslator.FromWin32(RGB(0, 0, 0))  ' Force black text  

    End Sub

    ' --- PLAYER 2 TEXTBOX TEXT CHANGED EVENT ---  
    ' Ensures text visibility by enforcing black font color  

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        TextBox2.ForeColor = ColorTranslator.FromWin32(RGB(0, 0, 0))  ' Force black text  

    End Sub

    ' --- START GAME BUTTON CLICK EVENT ---  
    ' Validates player names and initializes two-player gameplay

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Assign player names to global varGridiables  
        variableModule.namPlayer1 = TextBox1.Text    ' Player 1 name from textbox  
        variableModule.namPlayer2 = TextBox2.Text    ' Player 2 name from textbox  

        ' Fallback to "Player 1" and "Player 2" if names are empty  
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            variableModule.namPlayer1 = "Player 1"       ' Default player 1 name  
            variableModule.namPlayer2 = "Player 2"       ' Default player 2 name  
        End If

        PlayForm.LoadValues()       ' Initialize game board and state  
        Close()                     ' Close player info form  

    End Sub

    ' --- BACK BUTTON CLICK EVENT ---  
    ' Returns to home screen and closes current play session 

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        HomeForm.Show()           ' Navigate back to home screen  
        PlayForm.Close()          ' Terminate existing game session  
        Close()                   ' Close player info form  

    End Sub

End Class