' ===================== MAIN GAME FORM =====================
' Manages core gameplay logic, player/computer moves, and win/draw states

' ===================== NAMESPACE IMPORTS =====================

Imports System.Threading    ' Allows use of threading functions like Thread.Sleep for delays

' ===================== PlayForm Class =====================

Public Class PlayForm

    ' ===================== GLOBAL VARIABLES =====================
    ' Tracks game settings, player states, and board positions

    ' --- Color Management ---
    Dim rColor1, color1 As Integer  ' Random and assigned color for Player 1 (1-4)
    Dim rColor2, color2 As Integer  ' Random and assigned color for Player 2/Computer (1-4)
    Dim ListColors = New List(Of Integer)({1, 2, 3, 4}) ' Available color options (R, G, B, Y)

    ' --- Turn Management ---
    Dim rPersonTurn, personTurn As Integer  ' Random/current player turn (1=Player1, 2=Player2/Computer)
    Dim rCompMove, compMove As Integer      ' Random/selected computer move index

    ' --- Game State ---
    Dim ListMoves = New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9}) ' Valid grid positions (1-9)
    Dim varGrid(10) As String  ' Stores board state (indices 1-9 for grid cells)
    Dim sigWinDraw As Integer = 0  ' 0=Game ongoing, 1=Win/Draw

    ' ===================== FORM INITIALIZATION =====================
    ' Sets up colors and starting player when the form loads

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GenerateRandomColor()  ' Assign distinct colors to players
        GenerateRandomTurn()   ' Randomize starting player

    End Sub


    ' ===================== RANDOM COLOR ASSIGNMENT =====================
    ' Assigns unique colors to Player 1 and Player 2/Computer

    Private Sub GenerateRandomColor()

        ' Select and assign Player 1's color
        rColor1 = New Random().Next(1, ListColors.Count + 1)  ' Random number (1-4)
        color1 = ListColors(rColor1 - 1)    ' Get color from ListColors (R, G, B, Y) using random index

        ListColors.Remove(color1)  ' Remove chosen color from pool

        ' Select and assign Player 2's color from remaining options
        rColor2 = New Random().Next(1, ListColors.Count + 1)  ' New Random number (1-3)
        color2 = ListColors(rColor2 - 1)    ' Get remaining color from ListColors using random index

    End Sub


    ' ===================== STARTING PLAYER SELECTION =====================
    ' Randomly determines who plays first 

    Private Sub GenerateRandomTurn()

        rPersonTurn = New Random().Next(1, 3)  ' Generates 1 or 2
        personTurn = rPersonTurn  ' 1 = Player1 starts, 2 = Player2/Computer starts

    End Sub

    ' ===================== PLAYER UI INITIALIZATION =====================
    ' Configures player avatars, names, and turn indicators when the game starts

    Public Sub LoadValues()

        ' Apply styles for Player 1 (X Symbol)
        LoadPlayerStyle(color1, "X", PictureBox1, Label1, variableModule.namPlayer1)

        ' Apply styles for Player 2/Computer (O Symbol) 
        LoadPlayerStyle(color2, "O", PictureBox2, Label2, variableModule.namPlayer2)

        ' Update visibility of turn indicator boxes
        TurnIndicatorVisible()

    End Sub

    ' ===================== PLAYER STYLE LOADER =====================
    ' Configures avatar images and label colors based on assigned player colors
    ' Parameters:
    '   - playerColor: 1=R, 2=G, 3=B, 4=Y
    '   - playerSymbol: "X" or "O"
    '   - avatarBox: PictureBox control to display avatar
    '   - namLabel: Label control to display player name
    '   - playerName: Name retrieved from global VariableModule

    Private Sub LoadPlayerStyle(playerColor As Integer, playerSymbol As String, avatarBox As PictureBox, namLabel As Label, playerName As String)

        Dim basePath As String = Application.StartupPath & "\images"    ' Base Image Directory
        Dim colorSuffix As String   ' Holds color suffix (R/G/B/Y) for image filename
        namLabel.Text = playerName  ' Set player name text in the label

        ' Assign color suffix and label color based on playerColor code
        If playerColor = 1 Then
            colorSuffix = "R"  ' Red
            Label2.ForeColor = ColorTranslator.FromWin32(RGB(255, 0, 0))  ' Set Label2 (Player 2) to red
        ElseIf playerColor = 2 Then
            colorSuffix = "G"  ' Green
            Label2.ForeColor = ColorTranslator.FromWin32(RGB(0, 255, 0))  ' Set Label2 (Player 2) to green
        ElseIf playerColor = 3 Then
            colorSuffix = "B"  ' Blue
            Label2.ForeColor = ColorTranslator.FromWin32(RGB(0, 0, 255))  ' Set Label2 (Player 2) to blue
        Else
            colorSuffix = "Y"  ' Yellow
            Label2.ForeColor = ColorTranslator.FromWin32(RGB(255, 255, 0))  ' Set Label2 (Player 2) to yellow
        End If

        ' Load avatar image from predefined path (Format: {colorCode}{symbol}{suffix}.jpg)
        avatarBox.BackgroundImage = Image.FromFile($"{basePath}\{playerColor}{playerSymbol}{colorSuffix}.jpg")

    End Sub

    ' ===================== TURN INDICATOR UPDATER =====================
    ' Toggles visibility of turn indicator boxes (Player1 vs Player2/Computer)

    Private Sub TurnIndicatorVisible()

        If personTurn = 1 Then
            PictureBox3.Visible = True   ' Show Player1's turn indicator (PictureBox3)
            PictureBox4.Visible = False  ' Hide Player2/Computer's indicator (PictureBox4)
        Else
            PictureBox3.Visible = False  ' Hide Player1's turn indicator (PictureBox3)
            PictureBox4.Visible = True   ' Show Player2/Computer's indicator (PictureBox4)
        End If

    End Sub

    ' ===================== TURN SWITCHERS =====================  
    ' Manages player turn transitions and updates UI indicators  

    Private Sub XTurn()

        personTurn = 1                ' Set current turn to Player1 (X Symbol)  
        TurnIndicatorVisible()        ' Update turn indicator boxes visibility  

    End Sub

    Private Sub OTurn()

        personTurn = 2                ' Set current turn to Player2/Computer (O Symbol)  
        TurnIndicatorVisible()        ' Update turn indicator boxes visibility  

    End Sub

    ' ===================== GRID BUTTON CLICK HANDLERS =====================  
    ' Processes player moves when clicking Grid Buttons (GridButton1, GridButton2, ... , GridButton9)  

    Private Sub GridButton1_Click(sender As Object, e As EventArgs) Handles GridButton1.Click

        HandleGridMove(1, GridButton1)  ' Process move for grid cell 1 (Top-Left)  

    End Sub

    Private Sub GridButton2_Click(sender As Object, e As EventArgs) Handles GridButton2.Click

        HandleGridMove(2, GridButton2)  ' Process move for grid cell 2 (Top-Center)  

    End Sub

    Private Sub GridButton3_Click(sender As Object, e As EventArgs) Handles GridButton3.Click

        HandleGridMove(3, GridButton3)  ' Process move for grid cell 3 (Top-Right)  

    End Sub

    Private Sub GridButton4_Click(sender As Object, e As EventArgs) Handles GridButton4.Click

        HandleGridMove(4, GridButton4)  ' Process move for grid cell 4 (Middle-Left)  

    End Sub

    Private Sub GridButton5_Click(sender As Object, e As EventArgs) Handles GridButton5.Click

        HandleGridMove(5, GridButton5)  ' Process move for grid cell 5 (Middle-Center)  

    End Sub

    Private Sub GridButton6_Click(sender As Object, e As EventArgs) Handles GridButton6.Click

        HandleGridMove(6, GridButton6)  ' Process move for grid cell 6 (Middle-Right)  

    End Sub

    Private Sub GridButton7_Click(sender As Object, e As EventArgs) Handles GridButton7.Click

        HandleGridMove(7, GridButton7)  ' Process move for grid cell 7 (Bottom-Left)  

    End Sub

    Private Sub GridButton8_Click(sender As Object, e As EventArgs) Handles GridButton8.Click

        HandleGridMove(8, GridButton8)  ' Process move for grid cell 8 (Bottom-Center)  

    End Sub

    Private Sub GridButton9_Click(sender As Object, e As EventArgs) Handles GridButton9.Click

        HandleGridMove(9, GridButton9)  ' Process move for grid cell 9 (Bottom-Right)  

    End Sub

    ' ===================== GRID MOVE HANDLER =====================  
    ' Processes player/computer moves and updates game state  
    ' Parameters:  
    '   - gridIndex: Grid cell index (1-9)  
    '   - gridButton: Button control for the selected cell (GridButton1, GridButton2, ... , GridButton9)

    Private Sub HandleGridMove(gridIndex As Integer, gridButton As Button)

        If variableModule.sigTwoPlayer = True Then
            ' --- Two-Player Mode Logic ---
            If personTurn = 1 Then
                XImageLoad(gridButton)    ' Load "X" image and disable button  
                varGrid(gridIndex) = "X"  ' Update board state for Player1  
                OTurn()                   ' Switch turn to Player2  
            Else
                OImageLoad(gridButton)    ' Load "O" image and disable button  
                varGrid(gridIndex) = "O"  ' Update board state for Player2  
                XTurn()                   ' Switch turn to Player1  
            End If
        Else
            ' --- Single-Player Mode Logic ---  
            If personTurn = 1 Then
                XImageLoad(gridButton)    ' Human move: Load "X" and disable button  
                varGrid(gridIndex) = "X"  ' Update board state  
                ListMoves.Remove(gridIndex)  ' Remove cell from available moves  
                OTurn()                   ' Switch turn indicator to Computer  
                WhoWins()                 ' Check if Player1 won  

                PictureBox4.Refresh()     ' Force UI update to show Computer's turn  
                Thread.Sleep(1000)        ' Pause for 1 second to display indicator  

                If sigWinDraw = 0 Then
                    ComputerModulePlays()  ' Trigger Computer's move  
                End If
            End If
        End If

        ' --- Post-Move Win/Draw Check ---  
        If sigWinDraw = 0 Then
            WhoWins()  ' Re-validate win/draw state  
        End If

    End Sub

    ' ===================== X IMAGE LOADER =====================  
    ' Loads "X" symbol image with Player1's assigned color into a grid button  
    ' Parameters:  
    '   - gridButton: Target button control (GridButton1, GridButton2, ... , GridButton9)

    Private Sub XImageLoad(gridButton As Button)

        Dim basePath As String = Application.StartupPath & "\images"    'Base Image directory  
        Dim colorSuffix As String  ' Suffix for image filename (R/G/B/Y)  

        ' Determine color suffix based on Player1's assigned color  
        If color1 = 1 Then
            colorSuffix = "R"  ' Red  
        ElseIf color1 = 2 Then
            colorSuffix = "G"  ' Green  
        ElseIf color1 = 3 Then
            colorSuffix = "B"  ' Blue  
        Else
            colorSuffix = "Y"  ' Yellow  
        End If

        gridButton.BackgroundImage = Image.FromFile($"{basePath}\{color1}X{colorSuffix}.jpg")  ' Load image for clicked gridButton(1-9)
        gridButton.Enabled = False  ' Disable clicked gridButton(1-9)

    End Sub

    ' ===================== O IMAGE LOADER =====================  
    ' Loads "O" symbol image with Player2/Computer's assigned color into a grid button  
    ' Parameters:  
    '   - gridButton: Target button control (GridButton1, GridButton2, ... , GridButton9)

    Private Sub OImageLoad(gridButton As Button)

        Dim basePath As String = Application.StartupPath & "\images"    ' Base Image directory  
        Dim colorSuffix As String  ' Suffix for image filename (R/G/B/Y)  

        ' Determine color suffix based on Player2/Computer's assigned color  
        If color2 = 1 Then
            colorSuffix = "R"  ' Red  
        ElseIf color2 = 2 Then
            colorSuffix = "G"  ' Green  
        ElseIf color2 = 3 Then
            colorSuffix = "B"  ' Blue  
        Else
            colorSuffix = "Y"  ' Yellow  
        End If

        gridButton.BackgroundImage = Image.FromFile($"{basePath}\{color2}O{colorSuffix}.jpg")  ' Load image for clicked gridButton(1-9)
        gridButton.Enabled = False  ' Disable clicked gridButton(1-9)

    End Sub

    ' ===================== COMPUTER MOVE MANAGER =====================  
    ' Orchestrates computer's turn sequence (move generation and execution)  

    Public Sub ComputerModulePlays()

        If personTurn = 2 Then
            GenerateComputerMove()      ' Select random valid grid position  
            ComputerPlays()             ' Place O symbol and update game state  
            ListMoves.Remove(compMove)  ' Remove chosen move from available options  
        End If

    End Sub

    ' ===================== COMPUTER MOVE GENERATOR =====================  
    ' Randomly selects an available grid position for computer's move  

    Private Sub GenerateComputerMove()

        On Error Resume Next  ' Basic error handling for empty ListMoves  
        rCompMove = New Random().Next(1, ListMoves.Count + 1)  ' Random number (1-9)  
        compMove = ListMoves(rCompMove - 1)  ' Get actual grid position from ListMoves using random index 

    End Sub

    ' ===================== COMPUTER MOVE EXECUTOR =====================  
    ' Places O symbol in selected grid cell and updates game state  

    Private Sub ComputerPlays()

        ' -------- Grid Position Handling --------  
        If compMove = 1 Then
            OImageLoad(GridButton1)  ' Load O image for cell 1 (Top-Left)  
            varGrid(1) = "O"         ' Update board state  
            ListMoves.Remove(1)      ' Remove position from available moves  
        ElseIf compMove = 2 Then
            OImageLoad(GridButton2)  ' Load O image for cell 2 (Top-Center)  
            varGrid(2) = "O"
            ListMoves.Remove(2)
        ElseIf compMove = 3 Then
            OImageLoad(GridButton3)  ' Load O image for cell 3 (Top-Right)  
            varGrid(3) = "O"
            ListMoves.Remove(3)
        ElseIf compMove = 4 Then
            OImageLoad(GridButton4)  ' Load O image for cell 4 (Middle-Left)  
            varGrid(4) = "O"
            ListMoves.Remove(4)
        ElseIf compMove = 5 Then
            OImageLoad(GridButton5)  ' Load O image for cell 5 (Middle-Center)  
            varGrid(5) = "O"
            ListMoves.Remove(5)
        ElseIf compMove = 6 Then
            OImageLoad(GridButton6)  ' Load O image for cell 6 (Middle-Right)  
            varGrid(6) = "O"
            ListMoves.Remove(6)
        ElseIf compMove = 7 Then
            OImageLoad(GridButton7)  ' Load O image for cell 7 (Bottom-Left)  
            varGrid(7) = "O"
            ListMoves.Remove(7)
        ElseIf compMove = 8 Then
            OImageLoad(GridButton8)  ' Load O image for cell 8 (Bottom-Center)  
            varGrid(8) = "O"
            ListMoves.Remove(8)
        ElseIf compMove = 9 Then
            OImageLoad(GridButton9)  ' Load O image for cell 9 (Bottom-Right)  
            varGrid(9) = "O"
            ListMoves.Remove(9)
        End If

        XTurn()  ' Switch turn back to human player  

    End Sub

    ' ===================== GRID BUTTON STATE MANAGEMENT =====================  
    ' Controls interactability of grid buttons during gameplay/resets  

    Private Sub EnableButton()

        ' Enable all 9 grid buttons for new round  
        GridButton1.Enabled = True
        GridButton2.Enabled = True
        GridButton3.Enabled = True
        GridButton4.Enabled = True
        GridButton5.Enabled = True
        GridButton6.Enabled = True
        GridButton7.Enabled = True
        GridButton8.Enabled = True
        GridButton9.Enabled = True

    End Sub

    Private Sub UnEnableButton()

        ' Disable all grid buttons (used when game ends)  
        GridButton1.Enabled = False
        GridButton2.Enabled = False
        GridButton3.Enabled = False
        GridButton4.Enabled = False
        GridButton5.Enabled = False
        GridButton6.Enabled = False
        GridButton7.Enabled = False
        GridButton8.Enabled = False
        GridButton9.Enabled = False

    End Sub

    ' ===================== WIN/DRAW CONDITION CHECKER =====================  
    ' Validates all possible winning combinations and draw states  

    Private Sub WhoWins()

        ' -------- X (Player1) Win Conditions --------  
        ' Check all 8 possible winning lines for X player  
        If (varGrid(1) = "X" And varGrid(2) = "X" And varGrid(3) = "X") _
           Or (varGrid(1) = "X" And varGrid(4) = "X" And varGrid(7) = "X") _
           Or (varGrid(1) = "X" And varGrid(5) = "X" And varGrid(9) = "X") _
           Or (varGrid(2) = "X" And varGrid(5) = "X" And varGrid(8) = "X") _
           Or (varGrid(3) = "X" And varGrid(6) = "X" And varGrid(9) = "X") _
           Or (varGrid(3) = "X" And varGrid(5) = "X" And varGrid(7) = "X") _
           Or (varGrid(4) = "X" And varGrid(5) = "X" And varGrid(6) = "X") _
           Or (varGrid(7) = "X" And varGrid(8) = "X" And varGrid(9) = "X") Then
            UnEnableButton()  ' Lock grid  
            sigWinDraw = 1    ' Set game end flag  
            MessageBox.Show($"Congratulations {variableModule.namPlayer1}!{vbCrLf}You're the Tic Tac Toe Champion! 🏆", "🏁 Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' -------- O (Player2/Computer) Win Conditions --------  
        ' Check all 8 possible winning lines for O player  
        If (varGrid(1) = "O" And varGrid(2) = "O" And varGrid(3) = "O") _
           Or (varGrid(1) = "O" And varGrid(4) = "O" And varGrid(7) = "O") _
           Or (varGrid(1) = "O" And varGrid(5) = "O" And varGrid(9) = "O") _
           Or (varGrid(2) = "O" And varGrid(5) = "O" And varGrid(8) = "O") _
           Or (varGrid(3) = "O" And varGrid(6) = "O" And varGrid(9) = "O") _
           Or (varGrid(3) = "O" And varGrid(5) = "O" And varGrid(7) = "O") _
           Or (varGrid(4) = "O" And varGrid(5) = "O" And varGrid(6) = "O") _
           Or (varGrid(7) = "O" And varGrid(8) = "O" And varGrid(9) = "O") Then
            UnEnableButton()  ' Lock grid  
            sigWinDraw = 1    ' Set game end flag  
            MessageBox.Show($"Congratulations {variableModule.namPlayer2}!{vbCrLf}You're the Tic Tac Toe Champion! 🏆", "🏁 Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' -------- Draw Condition Check --------  
        ' Validate all grid cells filled with no winner  
        If (sigWinDraw = 0 And varGrid(1) <> "" And varGrid(2) <> "" And varGrid(3) <> "") _
           And (varGrid(4) <> "" And varGrid(5) <> "" And varGrid(6) <> "") _
           And (varGrid(7) <> "" And varGrid(8) <> "" And varGrid(9) <> "") Then
            UnEnableButton()  ' Lock grid  
            sigWinDraw = 1    ' Set game end flag  
            MessageBox.Show($"All moves exhausted!{vbCrLf}It's a Draw Match! 😐", "🏁 Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ' ===================== GAME RESET HANDLER =====================  
    ' Restores all game components to initial state for a new round  

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click

        ' -------- UI Reset --------  
        ' Clear all grid button images  
        GridButton1.BackgroundImage = Nothing
        GridButton2.BackgroundImage = Nothing
        GridButton3.BackgroundImage = Nothing
        GridButton4.BackgroundImage = Nothing
        GridButton5.BackgroundImage = Nothing
        GridButton6.BackgroundImage = Nothing
        GridButton7.BackgroundImage = Nothing
        GridButton8.BackgroundImage = Nothing
        GridButton9.BackgroundImage = Nothing

        ' -------- Color Management Reset --------  
        ListColors.Clear()     ' Reset available color pool  
        For i = 1 To 4
            ListColors.Add(i)  ' Repopulate with original colors (1-4)  
        Next

        ' -------- Game Settings Reinitialization --------  
        GenerateRandomColor()   ' Assign new distinct player colors  
        GenerateRandomTurn()    ' Randomize starting player  
        LoadValues()            ' Reload player avatars/names  
        TurnIndicatorVisible()  ' Update turn UI indicators  
        EnableButton()          ' Re-activate grid buttons  

        ' -------- Game State Reset --------  
        For i = 1 To 9
            varGrid(i) = ""   ' Clear board state (1-9 grid positions)  
        Next

        sigWinDraw = 0        ' Reset win/draw flag  

        ' -------- Computer Mode Special Handling --------  
        If variableModule.sigTwoPlayer = False Then
            ListMoves.Clear()      ' Reset available moves for Computer 
            For i = 1 To 9
                ListMoves.Add(i)   ' Repopulate move options (1-9)  
            Next
            ComputerModulePlays()  ' Trigger computer's first move (if applicable)  
        End If

    End Sub

    ' ===================== NAVIGATION HANDLERS =====================  
    ' Manages form transitions and application exit  

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        HomeForm.Show()  ' Return to main menu  
        Close()          ' Terminate current game session  

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        End  ' Terminate application completely  

    End Sub

End Class