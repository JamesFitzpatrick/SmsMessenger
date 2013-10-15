Public Class SMSMessenger

    Private messages As List(Of String) = New List(Of String)

    Private Sub buttonClick(sender As Button, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnX.Click, btnY.Click, btnW.Click, btnZ.Click
        Dim c As Char = sender.Text
        txtMessage.Text &= c
    End Sub

    Private Sub btnBackspaceClick(sender As Button, e As EventArgs) Handles btnBckSpace.Click
        If (txtMessage.Text.Length > 0) Then
            txtMessage.Text = txtMessage.Text.Substring(0, txtMessage.Text.Length - 1)
        End If
    End Sub

    Private Sub btnSpaceClick(sender As Button, e As EventArgs) Handles btnSpace.Click
        txtMessage.Text &= " "
    End Sub

    Private Sub btnSendClick(sender As Object, e As EventArgs) Handles btnSend.Click
        messages.Add(txtMessage.Text)
        txtMessage.Clear()
    End Sub
End Class
