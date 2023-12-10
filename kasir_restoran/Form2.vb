Public Class Form2
    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        Dim oForm As New Form1

        invoice.Items().Clear()
        oForm.resetOrderList()

        Me.Hide()

    End Sub
End Class