Public Class DCS
    Public Property dataAddFnR As Object
    Public Property stats As Boolean
    Public Property index As Integer
    Public Property id As Integer
    Private db As New DBConn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If db.promptSaved("Finding and Recommendation") Then
            If stats Then
                'Edit
                updateDCS()
            Else
                'Save
                saveDCS()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub updateDCS()
        Dim insertId As Integer = db.insertFnR(getFnRObj(), id, stats)

        If Not insertId = -1 Then
            MsgBox("Finding and Recommendation Updated", MsgBoxStyle.Information, "Success")
            FnR.DataGridView1.Item(1, index).Value = CausesTextBox.Text
            FnR.DataGridView1.Item(2, index).Value = RecommendationsTextBox.Text
            FnR.DataGridView1.Item(3, index).Value = Action_byTextBox.Text
            FnR.DataGridView1.Item(4, index).Value = DatelineTextBox.Text
            FnR.DataGridView1.Item(5, index).Value = StatusTextBox.Text
            FnR.DataGridView1.Item(6, index).Value = RemarksTextBox.Text
        End If
    End Sub

    Private Sub saveDCS()
        Dim insertId As Integer = db.insertFnR(getFnRObj(), 0, stats)

        If Not insertId = -1 Then
            MsgBox("Finding and Recommendation Saved", MsgBoxStyle.Information, "Success")
            Dim row As String() = New String() {insertId, CausesTextBox.Text, RecommendationsTextBox.Text, Action_byTextBox.Text, DatelineTextBox.Text, StatusTextBox.Text, RemarksTextBox.Text}
            FnR.DataGridView1.Rows.Add(row)
            FnR.DataGridView1.Height = (FnR.DataGridView1.Rows.Count() + 1) * FnR.DataGridView1.Rows(0).Height
        End If
    End Sub

    Private Function getFnRObj() As Object
        Dim fnrObj(5) As Object
        fnrObj(0) = CausesTextBox.Text
        fnrObj(1) = RecommendationsTextBox.Text
        fnrObj(2) = Action_byTextBox.Text
        fnrObj(3) = DatelineTextBox.Text
        fnrObj(4) = StatusTextBox.Text
        fnrObj(5) = RemarksTextBox.Text
        Return fnrObj
    End Function

End Class