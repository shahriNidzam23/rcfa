Public Class Login
    Private cnn As New OleDb.OleDbConnection
    Private db As New DBConn
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If validateForm() Then
            If db.login(txtbxUsername.Text, txtbxPassword.Text) = "OK" Then
                clearForm()
                Me.Hide()
                openIncident.Show()
            Else
                MsgBox("User Not Exist", MsgBoxStyle.Information, "Error")
            End If
        Else
                MsgBox("Fill All Inputs", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoLogin()
        clearForm()
    End Sub

    Private Sub clearForm()
        txtbxUsername.Text = ""
        txtbxPassword.Text = ""
    End Sub

    Private Function validateForm() As Boolean
        If (txtbxUsername.Text = "" And txtbxPassword.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub autoLogin()
        Dim actInfo() As String
        Dim act As String = db.getInfoActiveUser()
        If Not act = "ERROR" Then
            actInfo = act.Split(",")
            If db.login(actInfo(0), actInfo(1)) = "OK" Then
                clearForm()
                Me.Hide()
                openIncident.Show()
            End If
            Dim temp As Integer = 1
        End If
    End Sub

End Class
