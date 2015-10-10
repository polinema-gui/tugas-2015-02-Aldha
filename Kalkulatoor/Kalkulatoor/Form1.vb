Public Class Form1

    Dim x As Integer
    Dim cek As Byte

    Private Function outputIsi()
        If (TextBox1.Text.Equals("0") Or Me.cek > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (outputIsi()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (outputIsi()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (outputIsi()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (outputIsi()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (outputIsi()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (outputIsi()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (outputIsi()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (outputIsi()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (outputIsi()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (outputIsi()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = "0"
        Me.x = "0"
        Me.cek = "0"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        If (Me.x = 0 Or Me.cek = 2) Then
            Me.x += Convert.ToInt32(TextBox1.Text)
        Else
            Me.x -= Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.x.ToString
        Me.cek = 1
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If (Me.cek = 1) Then
            Me.x -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.x += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.x.ToString
        Me.cek = 2
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles ButtonSamaDengan.Click
        Select Case Me.cek
            Case 1
                TextBox1.Text = Convert.ToString(Me.x - Convert.ToInt32(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.x + Convert.ToInt32(TextBox1.Text))
        End Select
        Me.x = 0
    End Sub

End Class
