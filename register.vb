Imports rcfars.DBConn
Public Class Register
    Private cnn As New OleDb.OleDbConnection
    Dim errorText As String
    Private db As New DBConn
    Dim closePage As Boolean

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        clearForm()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If validateForm() Then
            If Label_wright.Text = ("✓") Then
                If db.register(txtbxUsername.Text, txtbxPassword.Text) Then
                    MsgBox(txtbxUsername.Text & " Has Been Created", MsgBoxStyle.Information, "Success")
                    closePage = False
                    Login.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Password did not match", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Fill All Inputs", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub txtbxRetype_TextChanged(sender As Object, e As EventArgs) Handles txtbxRetype.TextChanged
        If txtbxPassword.Text = txtbxRetype.Text Then
            Label_wright.Text = ("✓")
        Else
            Label_wright.Text = ("X")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        closePage = False
        Login.Show()
        Me.Close()
    End Sub

    Private Sub clearForm()
        txtbxUsername.Text = ""
        txtbxRetype.Text = ""
        txtbxPassword.Text = ""
    End Sub

    Private Function validateForm() As Boolean
        If (txtbxUsername.Text = "" And txtbxPassword.Text = "" And txtbxRetype.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class