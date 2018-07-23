Imports PowerPoint = Microsoft.Office.Interop.PowerPoint

Public Class Exec
    Private db As New DBConn
    Dim oID As Integer
    Dim incidentName
    Dim strArr() As String
    Dim FnRData As DataTable
    Dim fMecha() As String
    Dim contCause() As String
    Dim uBasic() As String
    Dim mRecomm() As String
    Dim closePage As Boolean

    Private Sub Exec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closePage = True
        oID = db.getIncidentID()
        populateIncident(db.getIncident(Convert.ToInt32(oID)))
        populateTeam(db.getTeam())
        populateFnR(db.getFnR())
        Dim temp As DataTable = db.getExec()

        If temp.Rows.Count > 0 Then
            getExec(temp)
        End If
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        closePage = False
        Me.Close()
        Homepage.Show()
    End Sub

    Private Sub populateIncident(Data As DataTable)
        incidentName = Data.Rows(0).Item("title")
        reportTitle.Text = "Title: " & Data.Rows(0).Item("title")
        reportDate.Text = "Incident Date and Time: " & Data.Rows(0).Item("incDate")
        reportLoc.Text = "Location: " & Data.Rows(0).Item("location")
        reportSum.Text = "Summary: " & Data.Rows(0).Item("incSummary")
    End Sub

    Private Sub populateTeam(Data As DataTable)
        teamLead.Text = "Team Leader: " & Data.Rows(0).Item("TMleader")
        'teamMem

        Dim teamString As String = Data.Rows(0).Item("TMteam")
        strArr = teamString.Split(",")
        teamMem.Text = ""
        For i As Integer = 0 To (strArr.Count - 1)
            teamMem.Text = teamMem.Text & "- " & strArr(i) & vbNewLine
            'ComboBox1.Items.Add(Data.Rows(0).Item("TMteam")(i))
        Next
    End Sub

    Private Sub populateFnR(Data As DataTable)
        FnRData = Data
        For i As Integer = 0 To (Data.Rows.Count - 1)
            Dim row As String() = New String() {Data.Rows(i).Item("ID"), Data.Rows(i).Item("cause"), Data.Rows(i).Item("recommendation"), Data.Rows(i).Item("actionBy"), Data.Rows(i).Item("dateline"), Data.Rows(i).Item("status"), Data.Rows(i).Item("remarks")}
            DataGridView1.Rows.Add(row)
        Next

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'DataGridView1.Height = (DataGridView1.Rows.Count() + 1) * DataGridView1.Rows(0).Height
    End Sub
    Private Sub getExec(Data As DataTable)
        fMecha = Data.Rows(0).Item("fMecha").Split(",")
        contCause = Data.Rows(0).Item("contCause").Split(",")
        uBasic = Data.Rows(0).Item("uBasic").Split(",")
        mRecomm = Data.Rows(0).Item("mRecomm").Split(",")
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

    Private Sub pwrPntButton_Click(sender As Object, e As EventArgs) Handles pwrPntButton.Click
        loading.Show()
        Dim ppApplication As PowerPoint.ApplicationClass = Nothing
        Dim ppPresentation As PowerPoint.Presentation = Nothing
        Dim ppSlide As PowerPoint.Slide = Nothing
        Dim ppTextRange As PowerPoint.TextRange = Nothing
        Dim ppShape As PowerPoint.Shape = Nothing
        Dim tFrm As PowerPoint.TextFrame = Nothing
        Dim page As Integer = 1

        ' FINAL NAME TO SAVE
        Dim fileName = "Executive Summary(" & incidentName & ").pptx"
        Dim condition As Boolean = True

        Try

            If condition Then

                ppApplication = New Microsoft.Office.Interop.PowerPoint.ApplicationClass()
                ppPresentation = ppApplication.Presentations.Add
                ppApplication.WindowState = PowerPoint.PpWindowState.ppWindowMaximized

                incrementProgressBar(20)
                '2 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Objectives"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ' ADD TEXTBOX
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 160, 800, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                ' ADD TEXTRANGE
                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange

                ' DEFINE BULLETS
                tFrm = ppSlide.Shapes(2).TextFrame
                ' TEXT
                ppTextRange.Text = "To present to XXXX RCFA Review Panel on the outcome of final RCFA XXXXX."
                ppTextRange.Font.Size = 24
                ppTextRange.Font.Name = "Verdana"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

                tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered


                ' ANOTHER TEXT INSIDE TEXTBOX
                ppTextRange.InsertAfter("" & Chr(10))
                ppTextRange.InsertAfter("To seek approval from XXXX RCFA Review Panel on the recommendations and way forward")

                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '4(1) Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Executive Summary"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ' ADD TEXTBOX
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 800, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                ' ADD TEXTRANGE
                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange


                ' DEFINE BULLETS
                tFrm = ppSlide.Shapes(2).TextFrame
                ' TEXT
                ppTextRange.Text = "Failure mechanism/Causal Factor[s] for the problem is[are]:"
                ppTextRange.Font.Size = 25
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                'tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered

                Dim incrementfMecha As Integer = 1
                For i As Integer = 0 To (fMecha.Count - 1)
                    If (validateText(fMecha(i))) Then
                        ppTextRange.InsertAfter("" & Chr(10))
                        Dim num As Integer = incrementfMecha
                        Dim text As String = Chr(9) & num.ToString() & ". " & fMecha(i)
                        With ppTextRange.InsertAfter(text)
                            .Font.Size = 20
                            .Font.Bold = False
                        End With
                        incrementfMecha = incrementfMecha + 1
                    End If
                Next
                incrementfMecha = 1

                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '4(2) Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Executive Summary"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ' ADD TEXTBOX
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 800, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                ' ADD TEXTRANGE
                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange


                ' DEFINE BULLETS
                tFrm = ppSlide.Shapes(2).TextFrame
                ' TEXT
                ppTextRange.Text = "Contributory Cause[s] for the problem is[are]:"
                ppTextRange.Font.Size = 25
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                'tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered

                Dim incrementcontCause As Integer = 1
                For i As Integer = 0 To (contCause.Count - 1)
                    If (validateText(contCause(i))) Then
                        ppTextRange.InsertAfter("" & Chr(10))
                        Dim num As Integer = incrementcontCause
                        Dim text As String = Chr(9) & num.ToString() & ". " & contCause(i)
                        With ppTextRange.InsertAfter(text)
                            .Font.Size = 20
                            .Font.Bold = False
                        End With
                        incrementcontCause = incrementcontCause + 1
                    End If
                Next
                incrementcontCause = 1

                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '4(3) Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Executive Summary"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ' ADD TEXTBOX
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 800, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                ' ADD TEXTRANGE
                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange


                ' DEFINE BULLETS
                tFrm = ppSlide.Shapes(2).TextFrame
                ' TEXT
                ppTextRange.Text = "Underlying/Basic Cause[s] for the problem is[are]:"
                ppTextRange.Font.Size = 25
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                'tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered

                Dim incrementuBasic As Integer = 1
                For i As Integer = 0 To (uBasic.Count - 1)
                    If (validateText(uBasic(i))) Then
                        ppTextRange.InsertAfter("" & Chr(10))
                        Dim num As Integer = incrementuBasic
                        Dim text As String = Chr(9) & num.ToString() & ". " & uBasic(i)
                        With ppTextRange.InsertAfter(text)
                            .Font.Size = 20
                            .Font.Bold = False
                        End With
                        incrementuBasic = incrementuBasic + 1
                    End If
                Next
                incrementuBasic = 1

                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '4(4) Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Executive Summary"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ' ADD TEXTBOX
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 800, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                ' ADD TEXTRANGE
                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange


                ' DEFINE BULLETS
                tFrm = ppSlide.Shapes(2).TextFrame
                ' TEXT
                ppTextRange.Text = "Recommended action item[s]:"
                ppTextRange.Font.Size = 25
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                'tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered

                Dim incrementmRecomm As Integer = 1
                For i As Integer = 0 To (mRecomm.Count - 1)
                    If (validateText(mRecomm(i))) Then
                        ppTextRange.InsertAfter("" & Chr(10))
                        Dim num As Integer = incrementmRecomm
                        Dim text As String = Chr(9) & num.ToString() & ". " & mRecomm(i)
                        With ppTextRange.InsertAfter(text)
                            .Font.Size = 20
                            .Font.Bold = False
                        End With
                        incrementmRecomm = incrementmRecomm + 1
                    End If
                Next
                incrementmRecomm = 1

                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '6 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Introduction"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "Equipment/System description:"
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing

                incrementProgressBar(30)
                '7 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Sources of Evidence"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "Sources of evidence, data, and information:"
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing

                '8 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Evidence : Location photo[s]"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing

                '9 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Evidence : Failure Mechanism"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing

                '10 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Evidence : Related P&ID"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 110, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "P&ID[s]: "
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

                ppTextRange.InsertAfter("(generic & close-up view, with labels)").Font.Size = 12

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing

                '11 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Evidence : Engineering Drawing[s]"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 110, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "Engineering drawing[s]: "
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

                ppTextRange.InsertAfter("(generic & close-up view, with labels)").Font.Size = 12

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '12 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Evidence : PI / DCS"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 110, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "PIMS & DCS graph[s]: "
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

                ppTextRange.InsertAfter("(generic & close-up view, with labels)").Font.Size = 12

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '13 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "History of Equipment"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 130, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
                ppTextRange.Text = "History of the item/equipment (and similar items/equipments) is as follows:"
                ppTextRange.Font.Size = 18
                ppTextRange.Font.Name = "Museo Sans 100 (Body)"
                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)
                ppTextRange.Font.Bold = True

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '14 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "RCFA Process and Methodology"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ppSlide.Shapes.AddPicture(Application.StartupPath + "\RCFA File\Image\slide 9.PNG", False, True, 150, 150, 500, 350)
                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '15 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Problem Statement - Sample"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '16 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Event and Condition Charting"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '17 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Root Cause Failure Analysis : Sample of S-5Why"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '18 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Root Cause Failure Analysis : Sample of Tripod Beta"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '19 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Root Cause Failure Analysis : Sample of Fault Tree Analysis"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '20 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Conclusion"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                '21 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
                With ppSlide.Shapes.Item(1).TextFrame.TextRange
                    .Text = "Finding And Recommendation"
                    .Font.Name = "Museo Sans 900"
                    .Font.Size = 32
                    .Font.Color.RGB = RGB(58, 146, 142)
                    .Font.Bold = True
                End With

                ' ADD TABLE
                ppShape = ppSlide.Shapes.AddTable(FnRData.Rows.Count + 1, 6, 100, 120)

                ppShape.Table.Cell(1, 1).Shape.TextFrame _
                .TextRange.Text = "Cause"
                ppShape.Table.Cell(1, 2).Shape.TextFrame _
                .TextRange.Text = "Recommendation"
                ppShape.Table.Cell(1, 3).Shape.TextFrame _
                .TextRange.Text = "Action By"
                ppShape.Table.Cell(1, 4).Shape.TextFrame _
                .TextRange.Text = "Dateline"
                ppShape.Table.Cell(1, 5).Shape.TextFrame _
                .TextRange.Text = "Status"
                ppShape.Table.Cell(1, 6).Shape.TextFrame _
                .TextRange.Text = "Remarks"

                For i As Integer = 0 To (FnRData.Rows.Count - 1)
                    ppShape.Table.Cell(i + 2, 1).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("cause")
                    ppShape.Table.Cell(i + 2, 2).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("recommendation")
                    ppShape.Table.Cell(i + 2, 3).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("actionBy")
                    ppShape.Table.Cell(i + 2, 4).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("dateline")
                    ppShape.Table.Cell(i + 2, 5).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("status")
                    ppShape.Table.Cell(i + 2, 6).Shape.TextFrame _
                    .TextRange.Text = FnRData.Rows(i).Item("remarks")
                Next

                ppShape.Table.Columns(2).Width = 100
                page += 1
                ppSlide = Nothing
                '22 Slide
                ppSlide = ppPresentation.Slides.Add(page, PowerPoint.PpSlideLayout.ppLayoutBlank)
                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 20, 212, 489, 41).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentRight

                ppTextRange = ppSlide.Shapes(1).TextFrame.TextRange
                ppTextRange.Text = "Thank You"
                ppTextRange.Font.Size = 32
                ppTextRange.Font.Name = "Museo Sans 900"
                ppTextRange.Font.Color.RGB = RGB(58, 146, 142)
                ppTextRange.Font.Bold = True

                ' MUST SET IT TO NOTHING
                page += 1
                ppSlide = Nothing
                incrementProgressBar(30)
            End If
        Catch ex As Exception
            condition = True
            loading.Close()
            MsgBox("Error Occurred !!" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            incrementProgressBar(10)
            ' clean up
            ppSlide = Nothing


            GC.Collect()
            GC.WaitForPendingFinalizers()
            loading.Close()

        End Try
    End Sub

    Private Sub incrementProgressBar(percent As Integer)
        loading.ProgressBar1.Increment(percent)
    End Sub

    Private Sub Exec_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If closePage Then
            Application.Exit()
        End If
    End Sub
End Class

'loading.Show()
'Dim ppApplication As PowerPoint.ApplicationClass = Nothing
'Dim ppPresentation As PowerPoint.Presentation = Nothing
'Dim ppSlide As PowerPoint.Slide = Nothing
'Dim ppTextRange As PowerPoint.TextRange = Nothing
'Dim ppShape As PowerPoint.Shape = Nothing
'Dim tFrm As PowerPoint.TextFrame = Nothing

'' FINAL NAME TO SAVE
'Dim fileName = "Executive Summary(" & incidentName & ").pptx"
'Dim condition As Boolean = True

'        Try

'            If condition Then

'                ppApplication = New Microsoft.Office.Interop.PowerPoint.ApplicationClass()
'                ppPresentation = ppApplication.Presentations.Add
'                ppApplication.WindowState = PowerPoint.PpWindowState.ppWindowMaximized

'                incrementProgressBar(20)
''First Slide
'                ppSlide = ppPresentation.Slides.Add(1, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
'                With ppSlide.Shapes.Item(1).TextFrame.TextRange
'                    .Text = "Executive Summary"
'                    .Font.Name = "Arial Black"
'                    .Font.Size = 22
'                    .Font.Color.RGB = RGB(0, 0, 0)
'                End With
'                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 160, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft

'                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange
'                ppTextRange.Text = reportTitle.Text
'                ppTextRange.Font.Size = 24
'                ppTextRange.Font.Name = "HleveticaNeue LT 55 Roman"
'                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

'' ANOTHER TEXT INSIDE TEXTBOX

'                ppTextRange.InsertAfter("" & Chr(10))
'                ppTextRange.InsertAfter(reportDate.Text)
'                ppTextRange.InsertAfter("" & Chr(10))
'                ppTextRange.InsertAfter(reportLoc.Text)
'                ppTextRange.InsertAfter("" & Chr(10))
'                ppTextRange.InsertAfter(reportSum.Text)


'' DRAW LINE
'                ppShape = ppSlide.Shapes.AddLine(70, 100, 650, 100) ' Y should be same
'' LINE COLOR
'                ppShape.Line.ForeColor.RGB = RGB(0, 0, 0)
'' BOLD LINE
'                ppShape.Line.Weight = 3


'' MUST SET IT TO NOTHING
'                ppSlide = Nothing

'                incrementProgressBar(30)
''Second Slide
'                ppSlide = ppPresentation.Slides.Add(2, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
'                With ppSlide.Shapes.Item(1).TextFrame.TextRange
'                    .Text = "Team Members"
'                    .Font.Name = "Arial Black"
'                    .Font.Size = 22
'                    .Font.Color.RGB = RGB(0, 0, 0)
'                End With
'' ADD TEXTBOX
'                ppSlide.Shapes.AddTextbox(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, 65, 160, 400, 200).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentLeft
'' ADD TEXTRANGE
'                ppTextRange = ppSlide.Shapes(2).TextFrame.TextRange

'' DEFINE BULLETS
'                tFrm = ppSlide.Shapes(2).TextFrame
'' TEXT
'                ppTextRange.Text = strArr(0)
'                ppTextRange.Font.Size = 24
'                ppTextRange.Font.Name = "HleveticaNeue LT 55 Roman"
'                ppTextRange.Font.Color.RGB = RGB(0, 0, 0)

'                tFrm.TextRange.ParagraphFormat.Bullet.Type = PowerPoint.PpBulletType.ppBulletUnnumbered


'' ANOTHER TEXT INSIDE TEXTBOX
'                For i As Integer = 1 To (strArr.Count - 1)
'                    ppTextRange.InsertAfter("" & Chr(10))
'                    ppTextRange.InsertAfter(strArr(i))
'                Next

'' DRAW LINE
'                ppShape = ppSlide.Shapes.AddLine(70, 100, 650, 100) ' Y should be same
'' LINE COLOR
'                ppShape.Line.ForeColor.RGB = RGB(0, 0, 0)
'' BOLD LINE
'                ppShape.Line.Weight = 3
'                ppSlide = Nothing

'                incrementProgressBar(30)
''Third Slide
'                ppSlide = ppPresentation.Slides.Add(3, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
'                With ppSlide.Shapes.Item(1).TextFrame.TextRange
'                    .Text = "Finding And Recommendation"
'                    .Font.Name = "Arial Black"
'                    .Font.Size = 20
'                    .Font.Color.RGB = RGB(0, 0, 0)
'                End With

'' ADD TABLE
'                ppShape = ppSlide.Shapes.AddTable(FnRData.Rows.Count + 1, 6, 100, 120)

'                ppShape.Table.Cell(1, 1).Shape.TextFrame _
'                .TextRange.Text = "Cause"
'                ppShape.Table.Cell(1, 2).Shape.TextFrame _
'                .TextRange.Text = "Recommendation"
'                ppShape.Table.Cell(1, 3).Shape.TextFrame _
'                .TextRange.Text = "Action By"
'                ppShape.Table.Cell(1, 4).Shape.TextFrame _
'                .TextRange.Text = "Dateline"
'                ppShape.Table.Cell(1, 5).Shape.TextFrame _
'                .TextRange.Text = "Status"
'                ppShape.Table.Cell(1, 6).Shape.TextFrame _
'                .TextRange.Text = "Remarks"

'                For i As Integer = 0 To (FnRData.Rows.Count - 1)
'                    ppShape.Table.Cell(i + 2, 1).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("cause")
'                    ppShape.Table.Cell(i + 2, 2).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("recommendation")
'                    ppShape.Table.Cell(i + 2, 3).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("actionBy")
'                    ppShape.Table.Cell(i + 2, 4).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("dateline")
'                    ppShape.Table.Cell(i + 2, 5).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("status")
'                    ppShape.Table.Cell(i + 2, 6).Shape.TextFrame _
'                    .TextRange.Text = FnRData.Rows(i).Item("remarks")
'                Next

'                ppShape.Table.Columns(2).Width = 100


'' DRAW LINE
'                ppShape = ppSlide.Shapes.AddLine(70, 100, 650, 100) ' Y should be same
'' LINE COLOR
'                ppShape.Line.ForeColor.RGB = RGB(0, 0, 0)
'' BOLD LINE
'                ppShape.Line.Weight = 3
'                ppSlide = Nothing
'                incrementProgressBar(30)
'            End If
'        Catch ex As Exception
'            condition = True
'            loading.Close()
'            MsgBox("Error Occurred !!" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Error")
'        Finally
'            incrementProgressBar(10)
'' clean up
'            ppSlide = Nothing


'            GC.Collect()
'            GC.WaitForPendingFinalizers()
'            loading.Close()

'        End Try