Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles errlab5.Click

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim id As String = txt1.Text
        Dim err As String
        If Not IsNumeric(id) Then
            err = "votre id n'est pas un nombre"
            errlab1.Text = err
        Else
            errlab1.Text = ""
        End If
        Dim nom As String = txt2.TextLength
        Dim err1 As String
        If Not nom < 50 Then
            err1 = "votre nom depasse 50 caratere"
            errlab3.Text = err1
        Else
            errlab3.Text = ""
        End If
        Dim localisation As String = txt3.TextLength
        Dim err2 As String
        If Not localisation < 50 Then
            err2 = "votre nom depasse 50 caratere"
            errlab4.Text = err2
        Else
            errlab4.Text = ""
        End If
        Dim err3 As String
        If rad1.Checked Then
        ElseIf rad2.Checked Then
        Else
            err3 = " cocher une case"
            errlab2.Text = err3
            If err3 Then
                errlab2.Text = ""
            End If

        End If
        If errlab4.Text = "" And errlab1.Text = "" And errlab3.Text = "" And errlab2.Text = "" Then
            Dim frminfo As New Form2
            frminfo.Label1.Text = errlab1.Text
            frminfo.Label2.Text = errlab2.Text
            frminfo.Label3.Text = errlab3.Text
            frminfo.Label4.Text = errlab4.Text
            frminfo.Show()

        End If

    End Sub
    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class
