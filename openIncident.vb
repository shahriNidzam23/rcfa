Public Class openIncident
    Private db As New DBConn
    Dim incidentName As New ArrayList()
    Private Sub openIncident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pickedIncident As String = ""
        Dim addedStr As String = ""
        Dim dash As Integer

        incidentName = db.getIncidentName()

        Dim id = incidentName.Count - 1
        For i As Integer = 0 To incidentName.Count - 1
            Dim tempo As String = incidentName(i).ToString()
            pickedIncident = tempo(0)

            If id = 0 Then
                addedStr = ""
            ElseIf id < 10 Then
                addedStr = "00" + id.ToString() + " - "
            ElseIf id < 100 Then
                addedStr = "0" + id.ToString() + " - "
            ElseIf id > 100 Then
                addedStr = id.ToString() + " - "
            End If

            For j As Integer = 0 To tempo.Count - 1
                If tempo(j).ToString() = "-" Then
                    dash = j + 1
                    Exit For
                End If
            Next
            Dim temp As String = incidentName(i).ToString().Remove(0, dash)

            ComboBox2.Items.Add(addedStr + temp)
            id = id - 1
        Next

        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pickedIncident As String = ""
        Dim tempo As String = incidentName(ComboBox2.SelectedIndex).ToString()
        For i As Integer = 0 To tempo.Count - 1
            If Not tempo(i).ToString() = "-" Then
                pickedIncident = pickedIncident + tempo(i)
            Else
                Exit For
            End If
        Next

        If db.setOpenIncidentID(pickedIncident) Then
            Homepage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If db.logout() Then
            Me.Close()
            Login.Show()
        Else
            MsgBox("Failed To Logout", MsgBoxStyle.Information, "Error")
        End If
    End Sub
End Class