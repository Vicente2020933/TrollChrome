Public Class EJtextbox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Complete con su nombre")
        Else
            MsgBox("hola " & TextBox1.Text)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDI_VICENTE.Show()
        Me.Close()
    End Sub
End Class
