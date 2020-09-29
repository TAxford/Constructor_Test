Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Class is about to be created")
        Dim newClass As New myTestClass()
    End Sub
End Class
