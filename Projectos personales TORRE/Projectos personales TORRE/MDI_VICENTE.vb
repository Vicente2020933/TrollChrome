Public Class MDI_VICENTE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Ejemplo textbox

        If ComboBox1.Text = "Ejemplo_textbox" Then

            EJtextbox.Show()
            Me.Hide()
        End If

        'chrome chino
        If ComboBox1.Text = "Chrome Chino" Then
            Form_Chrome_Chino.Show()
            Me.Hide()
        End If






    End Sub
End Class