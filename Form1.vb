Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first App 2023"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(800, 1000)
        Me.Opacity = 0.85 'makes it a bit transparent
        Me.CenterToParent() 'centers the execution box
    End Sub
End Class