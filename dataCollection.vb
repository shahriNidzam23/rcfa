Imports System.IO
Public Class Data_Collection
    Private db As New DBConn
    Dim filepath As String
    Dim endpath As String
    Dim oID As Integer
    Dim oName As String
    Dim closePage As Boolean

    Private Sub Label_Home2_Click(sender As Object, e As EventArgs)
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Button_Close2_Click(sender As Object, e As EventArgs)
        Homepage.Show()
        Me.Close()
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

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Homepage.Show()
        Me.Close()
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label4.Text = ComboBox2.SelectedItem
        fileList()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OPF.ShowDialog()
        filepath = OPF.FileName()
        TextBox1.Text = Path.GetFileName(filepath)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filename As String
        filename = Path.GetFileName(filepath)
        endpath = Application.StartupPath + "\RCFA File\Data Collection\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName
        Try
            FileCopy(filepath, endpath + "\" + filename)
            MsgBox("File " + filename + " Uploaded", , "Success")
            TextBox1.Text = ""
            fileList()
        Catch ex As Exception
            MsgBox(ex.Message, , "Error")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openFileNow()
    End Sub

    Private Sub deleteFileNow()

        If (validateText(ListBox1.SelectedItem)) Then
            endpath = Application.StartupPath + "\RCFA File\Data Collection\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName

            If System.IO.File.Exists(endpath + "\" + ListBox1.SelectedItem) = True Then
                If MsgBox("Are you sure to delete file " + ListBox1.SelectedItem, MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    File.Delete(endpath + "\" + ListBox1.SelectedItem)
                    fileList()
                End If
            Else
                MsgBox("File Does Not Exist")
            End If
        Else
            MsgBox("Choose File to Delete", , "Error")
        End If


    End Sub

    Private Sub openFileNow()

        If (validateText(ListBox1.SelectedItem)) Then
            endpath = Application.StartupPath + "\RCFA File\Data Collection\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName

            If System.IO.File.Exists(endpath + "\" + ListBox1.SelectedItem) = True Then
                Process.Start(endpath + "\" + ListBox1.SelectedItem)
            Else
                MsgBox("File Does Not Exist")
            End If
        Else
            MsgBox("Choose File to Open", , "Error")
        End If
    End Sub

    Private Sub fileList()
        ListBox1.Items.Clear()
        Try
            For Each di In System.IO.Directory.GetFiles(Application.StartupPath + "\RCFA File\Data Collection\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName, "*", IO.SearchOption.AllDirectories)
                ListBox1.Items.Add(Path.GetFileName(di))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        closePage = False
        Me.Close()
        Tools.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteFileNow()
    End Sub

    Private Sub Data_Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        oID = db.getIncidentID()
        oName = db.getIncident(oID).Rows(0).Item("title")
        createFolder()
    End Sub

    Private Sub createFolder()
        Dim chartNames() As String = {"Failure Reporting", "Physical Evidences", "Interviews", "Documents", "Drawing", "Process Data", "Enviromental Data", "Training"}
        Dim createPath As String

        For Each item As String In chartNames
            createPath = Application.StartupPath + "\RCFA File\Data Collection\" + item + "\" + oID.ToString() + "." + oName
            If (Not System.IO.Directory.Exists(createPath)) Then
                System.IO.Directory.CreateDirectory(createPath)
            End If
        Next
    End Sub

    Private Sub Data_Collection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class