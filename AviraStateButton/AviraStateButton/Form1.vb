Public Class Form1





    Private Sub Ctl_AviraStateButton1_ButtonClick(sender As Object, e As EventArgs) Handles Ctl_AviraStateButton1.ButtonClick
        If Ctl_AviraStateButton1.StateButton = ctl_AviraStateButton.StateButtonEnum.OFF Then
            Ctl_AviraStateButton1.StateButton = ctl_AviraStateButton.StateButtonEnum.ON
        Else
            Ctl_AviraStateButton1.StateButton = ctl_AviraStateButton.StateButtonEnum.OFF
        End If
    End Sub
End Class
