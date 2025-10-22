Imports System.Reflection.Emit

Public Class Form1
    Private Sub UpdateFontStyle()
        Dim style As FontStyle = FontStyle.Regular
        If CheckBox1.Checked Then
            style = style Or FontStyle.Italic
        End If
        If CheckBox2.Checked Then
            style = style Or FontStyle.Bold
        End If
        Label2.Font = New Font(Label2.Font, style)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = TextBox1.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.ForeColor = Color.Red

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label2.Font = New Font(Label2.Font, FontStyle.Bold)
        Else
            Label2.Font = New Font(Label2.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
