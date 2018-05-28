
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plain.Text = ""
        chiper.Text = ""
        number.Value = 3

    End Sub

    Private Sub btnenkripsi_Click(sender As Object, e As EventArgs) Handles btnenkripsi.Click
        Dim x As String = ""
        Dim xkalimat As String = ""
        For i = 1 To Len(plain.Text)
            x = Mid(plain.Text, i, i)
            x = Chr(Asc(x) + 3)
            xkalimat = xkalimat + x
        Next
        chiper.Text = xkalimat

    End Sub
    Private Sub btndeskripsi_Click(sender As Object, e As EventArgs) Handles btndeskripsi.Click
        Dim X As String = ""
        Dim XKALIMAT As String = ""
        For i = 1 To Len(chiper2.Text)
            X = Mid(chiper.Text, i, i)
            X = Chr(Asc(X) - 3)
            XKALIMAT = XKALIMAT + X
        Next
        plain2.Text = XKALIMAT
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        plain.Text = ""
        chiper.Text = ""
        plain2.Text = ""
        chiper2.Text = ""
        plain.Focus()
    End Sub
    Dim a
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = MsgBox("Apakah Anda Ingin Keluar ?", vbOK + vbQuestion, "Terima Kasih")
        If a = vbOK Then
            Me.Close()
        End If
    End Sub

End Class
