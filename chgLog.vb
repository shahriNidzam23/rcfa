Public Class chgLog
    Private db As New DBConn
    Dim closePage As Boolean

    Private Sub chgLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        Dim temp As DataTable = db.getChg()

        If temp.Rows.Count > 0 Then
            populateTable(temp)
        End If

        DataGridView1.ClearSelection()
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height

    End Sub
    Private Sub populateTable(Data As DataTable)
        For i As Integer = (Data.Rows.Count - 1) To 0 Step -1
            Dim row As String() = New String() {Data.Rows(i).Item("ID"), Data.Rows(i).Item("staffid"), Data.Rows(i).Item("timestamp"), Data.Rows(i).Item("activity")}
            DataGridView1.Rows.Add(row)
        Next

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub chgLog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class