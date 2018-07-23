Public Class FnR
    Public Property dataFnR As Object
    Private db As New DBConn
    Dim closePage As Boolean

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub FnR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        Dim temp As DataTable = db.getFnR()

        If temp.Rows.Count > 0 Then
            populateTable(temp)
        End If

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DCS.stats = False
        DCS.CausesTextBox.Text = ""
        DCS.RecommendationsTextBox.Text = ""
        DCS.Action_byTextBox.Text = ""
        DCS.DatelineTextBox.Text = ""
        DCS.StatusTextBox.Text = ""
        DCS.RemarksTextBox.Text = ""
        DCS.Show()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DCS.stats = True
        Try
            If DataGridView1.CurrentRow.Cells(1).Value.ToString() Is Nothing Then
            Else
                DCS.id = DataGridView1.CurrentRow.Cells(0).Value
                DCS.CausesTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
                DCS.RecommendationsTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
                DCS.Action_byTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
                DCS.DatelineTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
                DCS.StatusTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
                DCS.RemarksTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
                DCS.index = DataGridView1.CurrentRow.Index()
                DCS.Show()
            End If
        Catch ex As Exception
            'do nothing
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim id As Integer = row.Cells(0).Value
            If db.deleteFnR(row.Cells(0).Value) Then
                DataGridView1.Rows.Remove(row)
                If Not (DataGridView1.Rows.Count() = 0) Then
                    DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height
                End If
            End If
        Next
    End Sub

    Private Sub populateTable(Data As DataTable)
        For i As Integer = 0 To (Data.Rows.Count - 1)
            Dim row As String() = New String() {Data.Rows(i).Item("ID"), Data.Rows(i).Item("cause"), Data.Rows(i).Item("recommendation"), Data.Rows(i).Item("actionBy"), Data.Rows(i).Item("dateline"), Data.Rows(i).Item("status"), Data.Rows(i).Item("remarks")}
            DataGridView1.Rows.Add(row)
        Next

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        closePage = False
        Me.Close()
        eSummary.Show()
    End Sub

    Private Sub FnR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class