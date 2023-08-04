Public Class Form1
    Dim email As String = "aaa"
    Dim mdp As String = "hathat"
    Dim b As Boolean = False

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If email = TextBox1.Text And mdp = TextBox2.Text Then
            b = True
            Button1.Location = New Point(117, 158)
            'Button1.Size = New Size(106, 27)
            ' Button1.Visible = True
        Else
            'Button1.Size = New Size(27, 27)
            'Button1.Visible = False
            b = False
        End If

    End Sub

    

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If email = TextBox1.Text And mdp = TextBox2.Text Then
            b = True
            Button1.Location = New Point(117, 158)
            'Button1.Size = New Size(106, 27)
            ' Button1.Visible = True
        Else
            'Button1.Visible = False
            'Button1.Size = New Size(27, 27)
            b = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MsgBox("La Connexion est terminer avec succees")
        Me.BackColor = Color.Chocolate
        ' Me.Close()
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        If b = False Then
            If Button1.Location = New Point(234, 158) Then

                Button1.Location = New Point(10, 158)
            ElseIf Button1.Location = New Point(117, 158) Then

                Button1.Location = New Point(234, 158)
            ElseIf Button1.Location = New Point(10, 158) Then

                Button1.Location = New Point(117, 158)
            End If

            'Button1.Size = New Size(27, 27)


        End If
    End Sub
End Class
