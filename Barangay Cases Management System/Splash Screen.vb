﻿Public Class Splash_Screen
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Initialize()
    End Sub
End Class