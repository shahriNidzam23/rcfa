'update incident db
Public Class Incident_Report
    Private cnn As New OleDb.OleDbConnection
    Private db As New DBConn
    Dim oID As Integer
    Dim closePage As Boolean

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        oID = db.getIncidentID()
        If Convert.ToInt32(oID) = 0 Then
            clearForm()
        Else
            populateForm(db.getIncident(Convert.ToInt32(oID)))
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        closePage = False
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Not oID = 0 Then
            closePage = False
            Me.Close()
            Team.Show()
        Else
            MsgBox("Please Complete Incident Report Form", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Home4.Click
        closePage = False
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub Button_Clr1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm()
    End Sub


    Private Function validateForm() As Boolean
        If (txtbxTitle.Text = "" And txtbxLoc.Text = "" And txtbxSummary.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If db.promptSaved("Incident Report") Then
            If validateForm() Then
                If db.incidentReport(getIncidentObject(), Convert.ToInt32(oID)) Then
                    If oID = 0 Then
                        db.updateNewChgLog()
                        MsgBox("Incident Report Saved", MsgBoxStyle.Information, "Success")
                    Else
                        MsgBox("Incident Report Updated", MsgBoxStyle.Information, "Success")
                    End If
                    oID = db.getIncidentID()
                End If
            Else
                MsgBox("Fill in Blank", MsgBoxStyle.Information, "Error")
            End If
        End If
    End Sub

    Private Function getIncidentObject() As Object
        Dim obj(9) As Object
        obj(0) = txtbxTitle.Text
        obj(1) = txtbxLoc.Text
        obj(2) = dtpickReport.Value
        obj(3) = txtbxSummary.Text

        obj(4) = txtbxWhat.Text
        obj(5) = txtbxWhere.Text
        obj(6) = dtpickWhen.Value

        obj(7) = txtbxImpact.Text
        obj(8) = txtbxOImpact.Text
        obj(9) = cmbxFirst.Text
        Return obj
    End Function

    Private Sub populateForm(data As DataTable)
        txtbxTitle.Text = data.Rows(0).Item("title")
        txtbxLoc.Text = data.Rows(0).Item("location")
        txtbxSummary.Text = data.Rows(0).Item("incSummary")
        txtbxWhat.Text = data.Rows(0).Item("incWhat")
        txtbxWhere.Text = data.Rows(0).Item("incWhere")
        txtbxImpact.Text = data.Rows(0).Item("incImpact")
        txtbxOImpact.Text = data.Rows(0).Item("incOImpact")
        cmbxFirst.Text = data.Rows(0).Item("firstTime")
        dtpickReport.Value = data.Rows(0).Item("reportDate")
        dtpickWhen.Value = data.Rows(0).Item("incDate")
    End Sub

    Private Sub clearForm()
        txtbxTitle.Text = ""
        txtbxLoc.Text = ""
        txtbxSummary.Text = ""
        txtbxWhat.Text = ""
        txtbxWhere.Text = ""
        txtbxImpact.Text = ""
        txtbxOImpact.Text = ""
    End Sub

    Private Sub Incident_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class