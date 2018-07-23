Public Class Homepage
    Private db As New DBConn
    Dim oID As Integer
    Dim closePage As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_IR.Click
        closePage = False
        Me.Close()
        Incident_Report.Show()
    End Sub

    Private Sub Button_DCD_Click(sender As Object, e As EventArgs) Handles Button_DCD.Click
        If Not oID = 0 Then
            closePage = False
            Me.Close()
            Data_Collection.Show()
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button_Team_Click(sender As Object, e As EventArgs) Handles Button_Team.Click
        If Not oID = 0 Then
            closePage = False
            Me.Close()
            Team.Show()
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button_ES_Click(sender As Object, e As EventArgs) Handles Button_ES.Click
        If Not oID = 0 Then
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
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button_RC_Click(sender As Object, e As EventArgs) Handles Button_RC.Click
        If Not oID = 0 Then
            closePage = False
            Me.Close()
            FnR.Show()
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles AlTool.Click
        If Not oID = 0 Then
            closePage = False
            Me.Close()
            Tools.Show()
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        oID = db.getIncidentID()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        closePage = False
        Me.Close()
        openIncident.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        closePage = False
        Me.Close()
        chgLog.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Not oID = 0 Then
            Dim tempTeam As DataTable = db.getTeam()
            If tempTeam.Rows.Count > 0 Then
                If Not (tempTeam.Rows(0).Item("TMteam") = "" Or tempTeam.Rows(0).Item("TMleader") = "") Then
                    Dim tempFnR As DataTable = db.getFnR()
                    If tempFnR.Rows.Count > 0 Then
                        closePage = False
                        Me.Close()
                        eSummary.Show()
                    Else
                        MsgBox("Please Complete Finding and Recommendation Form", MsgBoxStyle.Information, "Error")
                    End If
                Else
                    MsgBox("Please Complete RCFA Team Form", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("Please Complete RCFA Team Form", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Homepage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class