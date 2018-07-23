Public Class Team
    Dim id As Integer
    Private db As New DBConn
    Dim closePage As Boolean

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        closePage = False
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Whys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        id = 0

        Dim temp As DataTable = db.getTeam()

        If temp.Rows.Count > 0 Then
            populateForm(temp)
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If (validateText(TextBox2.Text)) Then
            ComboBox1.Items.Add(TextBox2.Text)
            MsgBox(TextBox2.Text + " added as Team Member", , "Success")
            ComboBox1.Text = TextBox2.Text
            TextBox2.Text = ""
        Else
            MsgBox("Insert Team Member Name", , "Error")
        End If
    End Sub
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

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If (validateText(ComboBox1.SelectedItem)) Then
            Dim result As Integer = MessageBox.Show("Are You Sure to Remove " + ComboBox1.SelectedItem + "?", "Remove Team Member", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ComboBox1.Items.Remove(ComboBox1.SelectedItem)
                If (ComboBox1.Items.Count = 0) Then
                    ComboBox1.Text = ""
                Else
                    ComboBox1.Text = ComboBox1.Items(0)
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (validateText(TextBox1.Text)) Then
            ComboBox2.Items.Add(TextBox1.Text)
            MsgBox(TextBox1.Text + " added as Team Member", , "Success")
            ComboBox2.Text = TextBox1.Text
            TextBox1.Text = ""
        Else
            MsgBox("Insert Team Member Name", , "Error")
        End If
    End Sub
    Private Function validateText1(p2 As String) As Boolean
        Dim res As Boolean
        Try
            If (p2.Length = 0 OrElse p2.Length = 1 OrElse p2 = "") Then
                res = False
            Else
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (validateText1(ComboBox2.SelectedItem)) Then
            Dim result As Integer = MessageBox.Show("Are You Sure to Remove " + ComboBox2.SelectedItem + "?", "Remove Team Member", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ComboBox2.Items.Remove(ComboBox2.SelectedItem)
                If (ComboBox2.Items.Count = 0) Then
                    ComboBox2.Text = ""
                Else
                    ComboBox2.Text = ComboBox2.Items(0)
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TeamLeadTextBox.Text = ""
        DepartmentTextBox.Text = ""
        FacilitatorTextBox.Text = ""
        EmailTextBox.Text = ""
        TextBox2.Text = ""
        Peer_leadTextBox.Text = ""
        Peer_DepartmentTextBox.Text = ""
        Peer_emailTextBox.Text = ""
        TextBox1.Text = ""
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If db.promptSaved("RCFA Team") Then
            id = db.insertTeam(getTeamObject(), Convert.ToInt32(id))
            If Not id = -1 Then
                If id = 0 Then
                    MsgBox("Team Saved", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Team Updated", MsgBoxStyle.Information, "Success")
                End If
            End If
        End If

    End Sub

    Private Function getTeamObject() As Object
        Dim obj(8) As Object
        Dim teamString As String = ""
        Dim teamStringPeer As String = ""

        Try
            For i As Integer = 0 To (ComboBox1.Items.Count - 1)
                teamString = teamString + ComboBox1.Items(i)
                If Not i = (ComboBox1.Items.Count - 1) Then
                    teamString = teamString + ","
                End If
            Next
        Catch ex As Exception

        End Try

        Try
            For i As Integer = 0 To (ComboBox2.Items.Count - 1)
                teamStringPeer = teamStringPeer + ComboBox2.Items(i)
                If Not i = (ComboBox2.Items.Count - 1) Then
                    teamStringPeer = teamStringPeer + ","
                End If
            Next
        Catch ex As Exception

        End Try

        obj(0) = TeamLeadTextBox.Text
        obj(1) = DepartmentTextBox.Text
        obj(2) = FacilitatorTextBox.Text
        obj(3) = EmailTextBox.Text
        obj(4) = teamString

        obj(5) = Peer_leadTextBox.Text
        obj(6) = Peer_DepartmentTextBox.Text
        obj(7) = Peer_emailTextBox.Text
        obj(8) = teamStringPeer

        Return obj
    End Function

    Private Sub populateForm(Data As DataTable)
        Dim teamString As String = ""
        Dim teamStringPeer As String = ""
        Dim strArr() As String
        Dim strArr2() As String
        id = Convert.ToInt32(Data.Rows(0).Item("ID"))
        TeamLeadTextBox.Text = Data.Rows(0).Item("TMleader")
        DepartmentTextBox.Text = Data.Rows(0).Item("TMdept")
        FacilitatorTextBox.Text = Data.Rows(0).Item("TMfaci")
        EmailTextBox.Text = Data.Rows(0).Item("TMemail")
        teamString = Data.Rows(0).Item("TMteam")
        Peer_leadTextBox.Text = Data.Rows(0).Item("PRleader")
        Peer_DepartmentTextBox.Text = Data.Rows(0).Item("PRdept")
        Peer_emailTextBox.Text = Data.Rows(0).Item("PRemail")
        teamStringPeer = Data.Rows(0).Item("PRteam")


        'String to Array
        strArr = teamString.Split(",")
        For i As Integer = 0 To (strArr.Count - 1)
            ComboBox1.Items.Add(strArr(i))
        Next

        strArr2 = teamStringPeer.Split(",")
        For i As Integer = 0 To (strArr2.Count - 1)
            ComboBox2.Items.Add(strArr2(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        closePage = False
        Me.Close()
        Data_Collection.Show()
    End Sub

    Private Sub Team_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class