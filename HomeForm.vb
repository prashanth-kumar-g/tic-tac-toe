' ===================== HOME SCREEN =====================  
' Serves as the main navigation hub for selecting gameplay mode  

' ===================== HomeForm Class =====================

Public Class HomeForm

    ' --- FORM LOAD EVENT ---  
    ' Initializes UI focus on launch  

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Focus()  ' Set focus to prevent textbox cursor blinking  

    End Sub

    ' --- PLAYER VS PLAYER BUTTON CLICK EVENT ---  
    ' Starts a human vs human game session  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        VariableModule.sigTwoPlayer = True    ' Flag for two-player mode (Signal)
        PlayForm.Show()                    ' Launch game board  
        PlayerInformationPerson.Show()     ' Open player name input form  
        Close()                            ' Close home screen  

    End Sub

    ' --- PLAYER VS COMPUTER BUTTON CLICK EVENT ---  
    ' Starts a human vs AI game session  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        VariableModule.sigTwoPlayer = False   ' Flag for single-player mode (Signal)
        PlayForm.Show()                    ' Launch game board  
        PlayerInformationComputer.Show()   ' Open player/computer setup form  
        Close()                            ' Close home screen  

    End Sub

End Class