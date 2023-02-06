Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIceCream.SelectedIndexChanged
        If lstIceCream.SelectedIndex = 0 Then
            picBox.Image = My.Resources.vanilla_icecream
        ElseIf lstIceCream.SelectedIndex = 1 Then
            picBox.Image = My.Resources.chocolate_icecream
        ElseIf lstIceCream.SelectedIndex = 2 Then
            picBox.Image = My.Resources.strawberry_icecream
        ElseIf lstIceCream.SelectedIndex = 3 Then
            picBox.Image = My.Resources.mint_chocolate_chip
        ElseIf lstIceCream.SelectedIndex = 4 Then
            picBox.Image = My.Resources.cookie_dough
        End If
    End Sub
End Class
