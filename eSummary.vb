Public Class eSummary
    Dim db As New DBConn
    Dim id As Integer
    Dim closePage As Boolean

    Private Function validateText(p1 As String) As Boolean
        Dim res As Boolean
        Try
            If (p1.Length = 0 OrElse p1.Length = 1) Then
                res = False
            Else
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function
    Private Sub addText(text As String, type As String)
        Dim addedAs As String = text + " added as " + type
        If (validateText(text)) Then
            Select Case type
                Case "Failure Mechanism"
                    cBxFM.Items.Add(text)
                    cBxFM.Text = text
                    txtBxFM.Text = ""
                Case "Contributory Cause"
                    cBxCC.Items.Add(text)
                    cBxCC.Text = text
                    txtBxCC.Text = ""
                Case "Underlying/Basic Cause"
                    cBxUB.Items.Add(text)
                    cBxUB.Text = text
                    txtBxUB.Text = ""
                Case "Main Recommendation"
                    cBxMR.Items.Add(text)
                    cBxMR.Text = text
                    txtBxMR.Text = ""
            End Select

            MsgBox(addedAs, , "Success")
        Else
            MsgBox("Insert " + type, , "Error")
        End If
    End Sub
    Private Sub removeText(text As String, type As String)
        If (validateText(text)) Then
            Dim result As Integer = MessageBox.Show("Are You Sure to Remove " + text + "?", "Remove " + type, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Select Case type
                    Case "Failure Mechanism"
                        cBxFM.Items.Remove(text)
                        If (cBxFM.Items.Count = 0) Then
                            cBxFM.Text = ""
                        Else
                            cBxFM.Text = cBxFM.Items(0)
                        End If
                    Case "Contributory Cause"
                        cBxCC.Items.Remove(text)
                        If (cBxCC.Items.Count = 0) Then
                            cBxCC.Text = ""
                        Else
                            cBxCC.Text = cBxCC.Items(0)
                        End If
                    Case "Underlying/Basic Cause"
                        cBxUB.Items.Remove(text)
                        If (cBxUB.Items.Count = 0) Then
                            cBxUB.Text = ""
                        Else
                            cBxUB.Text = cBxUB.Items(0)
                        End If
                    Case "Main Recommendation"
                        cBxMR.Items.Remove(text)
                        If (cBxMR.Items.Count = 0) Then
                            cBxMR.Text = ""
                        Else
                            cBxMR.Text = cBxUB.Items(0)
                        End If
                End Select

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddFM.Click
        addText(txtBxFM.Text, "Failure Mechanism")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddCC.Click
        addText(txtBxCC.Text, "Contributory Cause")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnAddUB.Click
        addText(txtBxUB.Text, "Underlying/Basic Cause")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnAddMR.Click
        addText(txtBxMR.Text, "Main Recommendation")

    End Sub

    Private Sub btnRmFM_Click(sender As Object, e As EventArgs) Handles btnRmFM.Click
        removeText(cBxFM.SelectedItem, "Failure Mechanism")
    End Sub

    Private Sub btnRmCC_Click(sender As Object, e As EventArgs) Handles btnRmCC.Click
        removeText(cBxCC.SelectedItem, "Contributory Cause")

    End Sub

    Private Sub btnRmUB_Click(sender As Object, e As EventArgs) Handles btnRmUB.Click
        removeText(cBxUB.SelectedItem, "Underlying/Basic Cause")

    End Sub

    Private Sub btnRmMR_Click(sender As Object, e As EventArgs) Handles btnRmMR.Click
        removeText(cBxMR.SelectedItem, "Main Recommendation")

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tempTeam As DataTable = db.getTeam()
        If tempTeam.Rows.Count > 0 Then
            If Not (tempTeam.Rows(0).Item("TMteam") = "" Or tempTeam.Rows(0).Item("TMleader") = "") Then
                Dim tempFnR As DataTable = db.getFnR()
                If tempFnR.Rows.Count > 0 Then
                    closePage = False
                    Me.Close()
                    Exec.Show()
                Else
                    MsgBox("Please Complete Finding and Recommendation Form", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("Please Complete RCFA Team Form", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Please Complete RCFA Team Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtBxFM.Text = ""
        txtBxCC.Text = ""
        txtBxUB.Text = ""
        txtBxMR.Text = ""

        cBxFM.Items.Clear()
        cBxCC.Items.Clear()
        cBxUB.Items.Clear()
        cBxMR.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If db.promptSaved("Executive Summary") Then
            id = db.insertExec(getExecObject(), Convert.ToInt32(id))
            If Not id = -1 Then
                If id = 0 Then
                    MsgBox("Executive Summary Saved", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Executive Summary Updated", MsgBoxStyle.Information, "Success")
                End If
            End If
        End If
    End Sub

    Private Function getExecObject() As Object
        Dim obj(3) As Object

        For i As Integer = 0 To 3
            obj(i) = ""
        Next

        For i As Integer = 0 To (cBxFM.Items.Count - 1)
            obj(0) = obj(0) + cBxFM.Items(i)
            If Not i = (cBxFM.Items.Count - 1) Then
                obj(0) = obj(0) + ","
            End If
        Next

        For i As Integer = 0 To (cBxCC.Items.Count - 1)
            obj(1) = obj(1) + cBxCC.Items(i)
            If Not i = (cBxCC.Items.Count - 1) Then
                obj(1) = obj(1) + ","
            End If
        Next

        For i As Integer = 0 To (cBxUB.Items.Count - 1)
            obj(2) = obj(2) + cBxUB.Items(i)
            If Not i = (cBxUB.Items.Count - 1) Then
                obj(2) = obj(2) + ","
            End If
        Next

        For i As Integer = 0 To (cBxMR.Items.Count - 1)
            obj(3) = obj(3) + cBxMR.Items(i)
            If Not i = (cBxMR.Items.Count - 1) Then
                obj(3) = obj(3) + ","
            End If
        Next

        Return obj
    End Function

    Private Sub eSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = 0
        Dim temp As DataTable = db.getExec()

        If temp.Rows.Count > 0 Then
            populateForm(temp)
        End If
    End Sub

    Private Sub populateForm(Data As DataTable)
        id = Convert.ToInt32(Data.Rows(0).Item("ID"))
        Dim fMecha() As String
        Dim contCause() As String
        Dim uBasic() As String
        Dim mRecomm() As String


        fMecha = Data.Rows(0).Item("fMecha").Split(",")
        For i As Integer = 0 To (fMecha.Count - 1)
            If (validateText(fMecha(i))) Then
                cBxFM.Items.Add(fMecha(i))
            End If

        Next

        contCause = Data.Rows(0).Item("contCause").Split(",")
        For i As Integer = 0 To (contCause.Count - 1)
            If (validateText(contCause(i))) Then
                cBxCC.Items.Add(contCause(i))
            End If
        Next

        uBasic = Data.Rows(0).Item("uBasic").Split(",")
        For i As Integer = 0 To (uBasic.Count - 1)
            If (validateText(uBasic(i))) Then
                cBxUB.Items.Add(uBasic(i))
            End If
        Next

        mRecomm = Data.Rows(0).Item("mRecomm").Split(",")
        For i As Integer = 0 To (mRecomm.Count - 1)
            If (validateText(mRecomm(i))) Then
                cBxMR.Items.Add(mRecomm(i))
            End If
        Next
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub eSummary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class