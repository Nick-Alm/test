Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click

        Dim udpClient As New UdpClient()
        Dim byteMSG As Byte() = New Byte() {}
        byteMSG = Encoding.ASCII.GetBytes(textContent.Text)
        udpClient.Send(byteMSG, byteMSG.Length, "127.0.0.1", 1025)
        udpClient.Close()

    End Sub

    Private Sub textContent_TextChanged(sender As Object, e As EventArgs) Handles textContent.TextChanged

    End Sub
End Class
