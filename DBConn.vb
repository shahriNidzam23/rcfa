Public Class DBConn
    Private cnn As New OleDb.OleDbConnection

    Public Sub DbConnection()
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\rcfa.mdb"
        cnn.Open()
        cnn.Close()
    End Sub

    Public Sub closeConnection()
        cnn.Close()
    End Sub

    Public Function register(username As String, p2 As String) As Boolean
        DbConnection()
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Try
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO [user]([username], [userpw], [status]) VALUES('" & username & "','" & p2 & "', 'active')"
            cmd.ExecuteNonQuery()
            closeConnection()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            closeConnection()
            Return False
        End Try
    End Function

    Public Function login(username As String, pw As String) As String
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [user] WHERE [username]='" & username & "' AND [userpw]='" & pw & "'", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            If alldata.Rows.Count > 0 Then
                If logoutOtherUser(alldata.Rows(0).Item("id").ToString) Then
                    closeConnection()
                    Return "OK"
                Else
                    Return "Error"
                End If
            Else
                'errorText = "Username did not Exist"
                closeConnection()
                Return "ERROR"
            End If

        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return ex.ToString
        End Try
    End Function

    Public Function logoutOtherUser(id As String) As Boolean
        Try
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [user]", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            If alldata.Rows.Count > 0 Then
                Try
                    For Each row As DataRow In alldata.Rows
                        Dim newCmd As New OleDb.OleDbCommand
                        newCmd.Connection = cnn
                        If Not row("id") = id Then
                            newCmd.CommandText = "UPDATE [user] " & _
                                            " SET status='inactive'" & _
                                            " WHERE id=" & row("id")
                        Else
                            newCmd.CommandText = "UPDATE [user] " & _
                                            " SET status='active'" & _
                                            " WHERE id=" & row("id")
                        End If
                        newCmd.ExecuteNonQuery()
                    Next row
                    Return True
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
                    Return False
                End Try
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return False
        End Try
    End Function

    Public Function logout() As Boolean
        Try
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            newCmd.CommandText = "UPDATE [user] " & _
                            " SET status='inactive'" & _
                            " WHERE status='active'"
            newCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return False
        End Try
    End Function

    Public Function incidentReport(incident As Object, id As Integer) As Boolean
        DbConnection()
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Try
            cmd.Connection = cnn

            If id = 0 Then
                cmd.CommandText = "INSERT INTO [incident](" & _
                                     "[userID], " & _
                                     "[title], " & _
                                     "[location], " & _
                                     "[reportDate], " & _
                                     "[incSummary], " & _
                                     "[incWhat], " & _
                                     "[incWhere], " & _
                                     "[incDate], " & _
                                     "[incImpact], " & _
                                     "[incOImpact], " & _
                                     "[firstTime], " & _
                                     "[status], " & "[completed]) VALUES(" & _
                                     getActiveUser() & _
                                     ",'" & incident(0) & _
                                     "','" & incident(1) & _
                                     "','" & incident(2) & _
                                     "','" & incident(3) & _
                                     "','" & incident(4) & _
                                     "','" & incident(5) & _
                                     "','" & incident(6) & _
                                     "','" & incident(7) & _
                                     "','" & incident(8) & _
                                     "', '" & incident(9) & _
                                     "','active', 'no')"
            Else
                cmd.CommandText = "UPDATE incident " & _
                                "SET title='" & incident(0) & "', " & _
                                "location='" & incident(1) & "', " & _
                                "reportDate='" & incident(2) & "', " & _
                                "incSummary='" & incident(3) & "', " & _
                                "incWhat='" & incident(4) & "', " & _
                                "incWhere='" & incident(5) & "', " & _
                                "incDate='" & incident(6) & "', " & _
                                "incImpact='" & incident(7) & "', " & _
                                "incOImpact='" & incident(8) & "', " & _
                                "firstTime='" & incident(9) & "' " & _
                                "WHERE id=" & id

            End If

            cmd.ExecuteNonQuery()
            closeConnection()
            If id = 0 Then
                Try
                    DbConnection()
                    Dim query2 As String = "Select @@Identity"
                    cmd.CommandText = query2
                    id = cmd.ExecuteScalar()
                    setOpenIncidentID(id)
                Catch ex As Exception
                    closeConnection()
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
                End Try
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            closeConnection()
            Return False
        End Try
    End Function

    Public Function getActiveUser() As String
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [user] WHERE [status]='active'", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            If alldata.Rows.Count > 0 Then
                Return alldata.Rows(0).Item("id")
            Else
                'errorText = "Username did not Exist"
                closeConnection()
                Return "ERROR"
            End If

        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return ex.ToString
        End Try
    End Function
    Public Function getInfoActiveUser() As String
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [user] WHERE [status]='active'", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            If alldata.Rows.Count > 0 Then
                Return alldata.Rows(0).Item("username") & "," & alldata.Rows(0).Item("userpw")
            Else
                'errorText = "Username did not Exist"
                closeConnection()
                Return "ERROR"
            End If

        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return ex.ToString
        End Try
    End Function

    Public Function getIncidentID() As Integer
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [openIncident]", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            closeConnection()
            If alldata.Rows.Count > 0 Then
                Return Convert.ToInt32(alldata.Rows(0).Item("openID"))
            Else
                'errorText = "Username did not Exist"
                Return -1
            End If

        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return -1
        End Try
    End Function

    Public Function getIncidentName() As ArrayList
        Dim incidentName As New ArrayList()
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [incident] LEFT JOIN [user] ON incident.userID = user.ID WHERE user.status = 'active'", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            closeConnection()
            If alldata.Rows.Count > 0 Then
                For i As Integer = alldata.Rows.Count - 1 To 0 Step -1
                    incidentName.Add(alldata.Rows(i).Item("incident.ID") & "-" & alldata.Rows(i).Item("title"))
                Next
            Else
                'errorText = "Username did not Exist"
            End If

            incidentName.Add("0-New Incident Report")
            Return incidentName
        Catch ex As Exception
            incidentName.Add("0-New Incident Report")
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return incidentName
        End Try
    End Function

    Public Function getIncident(id As Integer) As DataTable
        Dim alldata As New DataTable
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [incident] WHERE ID = " & id & "", cnn)

            closeConnection()
            allDataAdapter.Fill(alldata)
            If alldata.Rows.Count > 0 Then
                Return alldata
            Else
                Return alldata
            End If
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return alldata
        End Try
    End Function

    Public Function setOpenIncidentID(id As Integer) As Boolean
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [openIncident]", cnn)

            Dim alldata As New DataTable
            allDataAdapter.Fill(alldata)
            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            If alldata.Rows.Count > 0 Then
                newCmd.CommandText = "UPDATE [openIncident] " & _
                                " SET openID='" & id & "'" & _
                                " WHERE id=1"
            Else
                newCmd.CommandText = "INSERT INTO [openIncident]([openID]) VALUES('0')"
            End If

            newCmd.ExecuteNonQuery()
            closeConnection()
            Return True
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return False
        End Try
    End Function

    Public Function insertTeam(obj As Object, id As Integer) As Integer
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If


            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            If id > 0 Then
                newCmd.CommandText = "UPDATE [team] " & _
                                "SET TMleader='" & obj(0) & "', " & _
                                "TMdept='" & obj(1) & "', " & _
                                "TMfaci='" & obj(2) & "', " & _
                                "TMemail='" & obj(3) & "', " & _
                                "TMteam='" & obj(4) & "', " & _
                                "PRleader='" & obj(5) & "', " & _
                                "PRdept='" & obj(6) & "', " & _
                                "PRemail='" & obj(7) & "', " & _
                                "PRteam='" & obj(8) & "' " & _
                                "WHERE id=" & id
            Else
                newCmd.CommandText = "INSERT INTO [team](" & _
                                     "[TMleader], " & _
                                     "[TMdept], " & _
                                     "[TMfaci], " & _
                                     "[TMemail], " & _
                                     "[TMteam], " & _
                                     "[PRleader], " & _
                                     "[PRdept], " & _
                                     "[PRemail], " & _
                                     "[PRteam], " & _
                                     "[incidentID]) " & _
                                     " VALUES(" & _
                                     "'" & obj(0) & _
                                     "','" & obj(1) & _
                                     "','" & obj(2) & _
                                     "','" & obj(3) & _
                                     "','" & obj(4) & _
                                     "','" & obj(5) & _
                                     "','" & obj(6) & _
                                     "','" & obj(7) & _
                                     "','" & obj(8) & _
                                     "'," & getIncidentID() & _
                                     ")"

            End If

            newCmd.ExecuteNonQuery()

            If id = 0 Then
                Dim query2 As String = "Select @@Identity"
                newCmd.CommandText = query2
                id = newCmd.ExecuteScalar()
            End If

            closeConnection()
            Return id
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return -1
        End Try
    End Function
    Public Function insertExec(obj As Object, id As Integer) As Integer
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If


            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            If id > 0 Then

                newCmd.CommandText = "UPDATE [exec] " & _
                                "SET fMecha='" & obj(0) & "', " & _
                                "contCause='" & obj(1) & "', " & _
                                "uBasic='" & obj(2) & "', " & _
                                "mRecomm='" & obj(3) & "' " & _
                                "WHERE id=" & id
            Else
                newCmd.CommandText = "INSERT INTO [exec](" & _
                                     "[fMecha], " & _
                                     "[contCause], " & _
                                     "[uBasic], " & _
                                     "[mRecomm], " & _
                                     "[incidentID]) " & _
                                     " VALUES(" & _
                                     "'" & obj(0) & _
                                     "','" & obj(1) & _
                                     "','" & obj(2) & _
                                     "','" & obj(3) & _
                                     "'," & getIncidentID() & _
                                     ")"

            End If

            newCmd.ExecuteNonQuery()

            If id = 0 Then
                Dim query2 As String = "Select @@Identity"
                newCmd.CommandText = query2
                id = newCmd.ExecuteScalar()
            End If

            closeConnection()
            Return id
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return -1
        End Try
    End Function

    Public Function getTeam() As DataTable
        Dim alldata As New DataTable
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [team] WHERE incidentID = " & getIncidentID() & "", cnn)

            closeConnection()
            allDataAdapter.Fill(alldata)
            Return alldata
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return alldata
        End Try
    End Function
    Public Function getExec() As DataTable
        Dim alldata As New DataTable
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [exec] WHERE incidentID = " & getIncidentID() & "", cnn)

            closeConnection()
            allDataAdapter.Fill(alldata)
            Return alldata
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return alldata
        End Try
    End Function

    Public Function getFnR() As DataTable
        Dim alldata As New DataTable
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [fnr] WHERE incidentID = " & getIncidentID() & "", cnn)
            closeConnection()
            allDataAdapter.Fill(alldata)

            
                Return alldata
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return alldata
        End Try
    End Function

    Public Function insertFnR(obj As Object, id As Integer, type As Boolean) As Integer
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If


            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            'type = true means update
            If type Then
                newCmd.CommandText = "UPDATE [fnr] " & _
                                "SET cause='" & obj(0) & "', " & _
                                "recommendation='" & obj(1) & "', " & _
                                "actionBy='" & obj(2) & "', " & _
                                "dateline='" & obj(3) & "', " & _
                                "status='" & obj(4) & "', " & _
                                "remarks='" & obj(5) & "' " & _
                                "WHERE id=" & id
            Else
                newCmd.CommandText = "INSERT INTO [fnr](" & _
                                     "[incidentID], " & _
                                     "[cause], " & _
                                     "[recommendation], " & _
                                     "[actionBy], " & _
                                     "[dateline], " & _
                                     "[status], " & _
                                     "[remarks]) " & _
                                     " VALUES(" & _
                                     "" & getIncidentID() & _
                                     ",'" & obj(0) & _
                                     "','" & obj(1) & _
                                     "','" & obj(2) & _
                                     "','" & obj(3) & _
                                     "','" & obj(4) & _
                                     "','" & obj(5) & _
                                     "')"

            End If

            newCmd.ExecuteNonQuery()

            If Not type Then
                Dim query2 As String = "Select @@Identity"
                newCmd.CommandText = query2
                id = newCmd.ExecuteScalar()
            End If

            closeConnection()
            Return id
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return -1
        End Try
    End Function

    Public Function deleteFnR(id As Integer) As Boolean
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If


            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            newCmd.CommandText = "DELETE * FROM [fnr] WHERE id=" & id

            newCmd.ExecuteNonQuery()
            closeConnection()
            Return True
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return False
        End Try
    End Function

    Public Function insertChgLog(staffid As String, activity As String) As Boolean
        DbConnection()
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Try
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO [chgLog]([incidentID], [staffid], [timestamp], [activity]) VALUES(" & getIncidentID() & ",'" & staffid & "','" & timestamp & "', '" & activity & "')"
            cmd.ExecuteNonQuery()
            closeConnection()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            closeConnection()
            Return False
        End Try
    End Function

    Public Function updateNewChgLog() As Boolean
        Try
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim newCmd As New OleDb.OleDbCommand
            newCmd.Connection = cnn
            newCmd.CommandText = "UPDATE [chgLog] " & _
                            " SET incidentID=" & getIncidentID() & _
                            " WHERE incidentID=0"
            newCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return False
        End Try
    End Function

    Public Function getChg() As DataTable
        Dim alldata As New DataTable
        Try
            DbConnection()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            Dim int As Integer
            int = getIncidentID()
            Dim allDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM [chgLog] WHERE incidentID = " & getIncidentID() & "", cnn)
            closeConnection()
            allDataAdapter.Fill(alldata)


            Return alldata
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Return alldata
        End Try
    End Function

    Public Function promptSaved(activity As String) As Boolean
        Dim message, title As String
        Dim id As Object
        ' Set prompt.
        message = "Key-in ID"
        ' Set title.
        title = "Changes Log"

        ' Display message, title, and default value.
        id = InputBox(message, title, "")
        ' If user has clicked Cancel, set myValue to defaultValue 
        If id Is "" Then
            Return False
        End If

        insertChgLog(id, activity)
        Return True
    End Function

End Class
