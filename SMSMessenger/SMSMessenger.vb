Public Class SMSMessenger

    Private messages As List(Of String) = New List(Of String)
    ' Tracks whether the form is in drag mode. If it is, mouse movements
    ' over the picturebox will be translated into form movements.
    Dim Dragging As Boolean

    ' Stores the offset where the picturebox is clicked.
    Dim PointClicked As Point

    Private Sub buttonClick(sender As Button, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnX.Click, btnY.Click, btnW.Click, btnZ.Click
        Dim c As Char = sender.Text
        txtMessage.Text &= c
    End Sub

    Private Sub buttonSpecialClick(sender As Object, e As EventArgs) Handles btnSpec1.Click, btnSpec2.Click, btnSpec3.Click, btnSpec4.Click, btnSpec5.Click, btnSpec6.Click, btnSpec7.Click, btnSpec9.Click, btnSpec10.Click, btnSpec11.Click, btnSpec12.Click, btnSpec14.Click
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


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub Bar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Bar1.MouseDown

        If e.Button = MouseButtons.Left Then
            Dragging = True
            PointClicked = New Point(e.X, e.Y)
        Else
            Dragging = False
        End If

    End Sub

    Private Sub Bar1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Bar1.MouseMove

        If Dragging Then
            Dim PointMoveTo As Point

            ' Find the current mouse position in screen coordinates.
            PointMoveTo = Me.PointToScreen(New Point(e.X, e.Y))

            ' Compensate for the position the control was clicked.
            PointMoveTo.Offset(-PointClicked.X, -PointClicked.Y - (Me.Height - Me.ClientRectangle.Height))
            ' Move the form.
            Me.Location = PointMoveTo
        End If

    End Sub

    Private Sub Bar1_MouseUp(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles Bar1.MouseUp

        Dragging = False

    End Sub
End Class
