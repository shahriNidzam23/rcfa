Imports System.IO
Public Class Tools
    Private db As New DBConn
    Dim filepath As String
    Dim endpath As String
    Dim oID As Integer
    Dim oName As String
    Dim closePage As Boolean

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label4.Text = ComboBox2.SelectedItem
        oVisio.Visible = True
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
        endpath = Application.StartupPath + "\RCFA File\Chart\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName
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

    Private Sub openFileNow()

        If (validateText(ListBox1.SelectedItem)) Then
            endpath = Application.StartupPath + "\RCFA File\Chart\" + Label4.Text + "\" + oID.ToString() + "." + oName

            If System.IO.File.Exists(endpath + "\" + ListBox1.SelectedItem) = True Then
                Process.Start(endpath + "\" + ListBox1.SelectedItem)
            Else
                MsgBox("File Does Not Exist")
            End If
        Else
            MsgBox("Choose File to Open", , "Error")
        End If
    End Sub

    Private Sub deleteFileNow()

        If (validateText(ListBox1.SelectedItem)) Then
            endpath = Application.StartupPath + "\RCFA File\Chart\" + Label4.Text + "\" + oID.ToString() + "." + oName

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

    Private Sub fileList()
        ListBox1.Items.Clear()
        endpath = Application.StartupPath + "\RCFA File\Chart\" + Label4.Text + "\" + oID.ToString() + "." + oName
        Try
            For Each di In System.IO.Directory.GetFiles(endpath, "*", IO.SearchOption.AllDirectories)
                ListBox1.Items.Add(Path.GetFileName(di))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        closePage = False
        Me.Close()
        FnR.Show()
    End Sub

    Private Sub oVisio_Click(sender As Object, e As EventArgs) Handles oVisio.Click
        Dim fileType As String
        Select Case ComboBox2.SelectedItem
            Case "Fault Tree Chart"
                fileType = "\FTA Template.vsdx"
            Case "Five Why Chart"
                fileType = "\Five Why Template.vsdx"
            Case "Sequence Chart"
                fileType = "\E&C Template.vsdx"
            Case "Tripod Beta Chart"
                fileType = "\Tripod Template.vsdx"
            Case Else
                fileType = ""
        End Select

        Dim originPath As String = Application.StartupPath + "\RCFA File\Template" + fileType
        endpath = Application.StartupPath + "\RCFA File\Chart\" + ComboBox2.SelectedItem + "\" + oID.ToString() + "." + oName
        Dim newFileName As String = filename(ComboBox2.SelectedItem)

        If Not newFileName = "" Then
            'Copy file
            Try
                FileCopy(originPath, endpath + "\" + newFileName)
            Catch ex As Exception
                MsgBox(ex.Message, , "Error")
            End Try


            'Open File
            Process.Start(endpath + "\" + newFileName)
            fileList()
        End If

    End Sub

    Private Function filename(activity As String) As String
        Dim message, title As String
        Dim newfilename As Object
        ' Set prompt.
        message = "Enter File Name"
        ' Set title.
        title = "Open " + activity

        ' Display message, title, and default value.
        newfilename = InputBox(message, title, "")

        If Not newfilename = "" Then
            Return newfilename + ".vsdx"
        Else
            Return ""
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteFileNow()
    End Sub

    Private Sub Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        oID = db.getIncidentID()
        oName = db.getIncident(oID).Rows(0).Item("title")
        createFolder()
    End Sub
    Private Sub createFolder()
        Dim chartNames() As String = {"Fault Tree Chart", "Sequence Chart", "Five Why Chart", "Tripod Beta Chart"}
        Dim createPath As String

        For Each item As String In chartNames
            createPath = Application.StartupPath + "\RCFA File\Chart\" + item + "\" + oID.ToString() + "." + oName
            If (Not System.IO.Directory.Exists(createPath)) Then
                System.IO.Directory.CreateDirectory(createPath)
            End If
        Next
    End Sub

    Private Sub Tools_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button_Close2_Click(sender As Object, e As EventArgs)

    End Sub
End Class