' ===================== SPLASH SCREEN =====================  
' Handles progress bar animation and application initialization  

' ===================== SplashScreen Class =====================

Public NotInheritable Class SplashScreen

    ' --- TIMER TICK EVENT ---  
    ' Updates progress bar value and manages splash-to-home transition  

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Progress bar increment logic (5% per tick)  
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5       ' Increment progress by 5%  
            Label3.Text = ProgressBar1.Value & " %"           ' Update percentage label  
        Else
            ' Transition to HomeForm when progress completes  
            Timer1.Enabled = False                            ' Stop timer  
            Hide()                                            ' Hide splash screen  
            HomeForm.Show()                                   ' Launch main home form  
            Close()                                           ' Close splash screen instance  
        End If

    End Sub

End Class