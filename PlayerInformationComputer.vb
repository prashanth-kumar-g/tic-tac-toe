' ===================== PLAYER INFORMATION (COMPUTER) =====================  
' Handles player name input and initialization for human vs. computer gameplay  

' ===================== PlayerInformationComputer Class =====================

Public Class PlayerInformationComputer

    Public namPlayer1 As String   ' Stores player 1's name for game session  

    ' --- TEXTBOX TEXT CHANGED EVENT ---  
    ' Ensures text visibility by enforcing black font color  

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        TextBox1.ForeColor = ColorTranslator.FromWin32(RGB(0, 0, 0))   ' Force black text  

    End Sub

    ' --- START GAME BUTTON CLICK EVENT ---  
    ' Validates player name and initializes game against computer  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Assign player names to global varGridiables  
        variableModule.namPlayer1 = TextBox1.Text    ' Human player name from textbox  
        variableModule.namPlayer2 = "Computer"       ' Default computer name  

        ' Fallback to "User" if name field is empty  
        If TextBox1.Text = "" Then
            variableModule.namPlayer1 = "User"       ' Default human player name  
            variableModule.namPlayer2 = "Computer"   ' Ensure computer name remains set  
        End If

        PlayForm.LoadValues()          ' Initialize game board and state  
        Close()                        ' Close player info form  
        PlayForm.ComputerModulePlays()  ' Trigger computer's first move (if applicable)  

    End Sub

    ' --- BACK BUTTON CLICK EVENT ---  
    ' Returns to home screen and closes current play session  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        HomeForm.Show()           ' Navigate back to home screen  
        PlayForm.Close()          ' Terminate existing game session  
        Close()                   ' Close player info form  

    End Sub

End Class