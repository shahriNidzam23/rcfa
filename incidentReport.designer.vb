<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Incident_Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Incident_Report))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Home4 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxTitle = New System.Windows.Forms.TextBox()
        Me.txtbxLoc = New System.Windows.Forms.TextBox()
        Me.dtpickReport = New System.Windows.Forms.DateTimePicker()
        Me.txtbxSummary = New System.Windows.Forms.TextBox()
        Me.txtbxWhat = New System.Windows.Forms.TextBox()
        Me.dtpickWhen = New System.Windows.Forms.DateTimePicker()
        Me.txtbxWhere = New System.Windows.Forms.TextBox()
        Me.txtbxImpact = New System.Windows.Forms.TextBox()
        Me.txtbxOImpact = New System.Windows.Forms.TextBox()
        Me.cmbxFirst = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(999, 639)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 29)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(43, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1283, 41)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Incident Report"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 39)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "    Title "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 39)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "    Report Date "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(401, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 40)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Incident Location / Plant"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.CadetBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(53, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 39)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Failure Description "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Salmon
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(43, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 230)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Define Problem"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.CadetBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(214, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(341, 39)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "What Happen ?"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.CadetBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(214, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(341, 39)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "When did it Happen ?"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.CadetBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(214, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(341, 39)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Where did it Happen ? "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.CadetBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(214, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(341, 77)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Consequence of failure?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Human/ Environment/ Operations/ Maintenance/ Assets/ HSE" & _
    "/ Process impacts"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.CadetBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(214, 514)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(341, 39)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Other consequence ?"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(578, 359)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(748, 39)
        Me.TextBox8.TabIndex = 48
        Me.TextBox8.WordWrap = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Salmon
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(43, 559)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(512, 28)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Is it first time failure ?"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1110, 639)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 29)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.CadetBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Honeydew
        Me.Label16.Location = New System.Drawing.Point(43, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1283, 143)
        Me.Label16.TabIndex = 59
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home4
        '
        Me.Home4.BackColor = System.Drawing.Color.Salmon
        Me.Home4.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home4.ForeColor = System.Drawing.Color.White
        Me.Home4.Location = New System.Drawing.Point(0, 29)
        Me.Home4.Name = "Home4"
        Me.Home4.Size = New System.Drawing.Size(129, 39)
        Me.Home4.TabIndex = 147
        Me.Home4.Text = " Home"
        Me.Home4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1221, 639)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 29)
        Me.btnNext.TabIndex = 169
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1420, 39)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "     Incident Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbxTitle
        '
        Me.txtbxTitle.Location = New System.Drawing.Point(184, 178)
        Me.txtbxTitle.Multiline = True
        Me.txtbxTitle.Name = "txtbxTitle"
        Me.txtbxTitle.Size = New System.Drawing.Size(1111, 29)
        Me.txtbxTitle.TabIndex = 194
        '
        'txtbxLoc
        '
        Me.txtbxLoc.Location = New System.Drawing.Point(561, 212)
        Me.txtbxLoc.Multiline = True
        Me.txtbxLoc.Name = "txtbxLoc"
        Me.txtbxLoc.Size = New System.Drawing.Size(734, 35)
        Me.txtbxLoc.TabIndex = 195
        '
        'dtpickReport
        '
        Me.dtpickReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickReport.Location = New System.Drawing.Point(184, 217)
        Me.dtpickReport.Name = "dtpickReport"
        Me.dtpickReport.Size = New System.Drawing.Size(200, 20)
        Me.dtpickReport.TabIndex = 196
        '
        'txtbxSummary
        '
        Me.txtbxSummary.Location = New System.Drawing.Point(184, 253)
        Me.txtbxSummary.Multiline = True
        Me.txtbxSummary.Name = "txtbxSummary"
        Me.txtbxSummary.Size = New System.Drawing.Size(1111, 35)
        Me.txtbxSummary.TabIndex = 197
        '
        'txtbxWhat
        '
        Me.txtbxWhat.Location = New System.Drawing.Point(578, 325)
        Me.txtbxWhat.Multiline = True
        Me.txtbxWhat.Name = "txtbxWhat"
        Me.txtbxWhat.Size = New System.Drawing.Size(748, 35)
        Me.txtbxWhat.TabIndex = 198
        '
        'dtpickWhen
        '
        Me.dtpickWhen.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpickWhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickWhen.Location = New System.Drawing.Point(586, 367)
        Me.dtpickWhen.Name = "dtpickWhen"
        Me.dtpickWhen.Size = New System.Drawing.Size(200, 20)
        Me.dtpickWhen.TabIndex = 199
        '
        'txtbxWhere
        '
        Me.txtbxWhere.Location = New System.Drawing.Point(578, 394)
        Me.txtbxWhere.Multiline = True
        Me.txtbxWhere.Name = "txtbxWhere"
        Me.txtbxWhere.Size = New System.Drawing.Size(748, 44)
        Me.txtbxWhere.TabIndex = 200
        '
        'txtbxImpact
        '
        Me.txtbxImpact.Location = New System.Drawing.Point(578, 437)
        Me.txtbxImpact.Multiline = True
        Me.txtbxImpact.Name = "txtbxImpact"
        Me.txtbxImpact.Size = New System.Drawing.Size(748, 77)
        Me.txtbxImpact.TabIndex = 201
        '
        'txtbxOImpact
        '
        Me.txtbxOImpact.Location = New System.Drawing.Point(578, 513)
        Me.txtbxOImpact.Multiline = True
        Me.txtbxOImpact.Name = "txtbxOImpact"
        Me.txtbxOImpact.Size = New System.Drawing.Size(748, 48)
        Me.txtbxOImpact.TabIndex = 202
        '
        'cmbxFirst
        '
        Me.cmbxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFirst.FormattingEnabled = True
        Me.cmbxFirst.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbxFirst.Location = New System.Drawing.Point(578, 565)
        Me.cmbxFirst.Name = "cmbxFirst"
        Me.cmbxFirst.Size = New System.Drawing.Size(748, 21)
        Me.cmbxFirst.TabIndex = 203
        '
        'Incident_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 749)
        Me.Controls.Add(Me.cmbxFirst)
        Me.Controls.Add(Me.txtbxOImpact)
        Me.Controls.Add(Me.txtbxImpact)
        Me.Controls.Add(Me.txtbxWhere)
        Me.Controls.Add(Me.dtpickWhen)
        Me.Controls.Add(Me.txtbxWhat)
        Me.Controls.Add(Me.txtbxSummary)
        Me.Controls.Add(Me.dtpickReport)
        Me.Controls.Add(Me.txtbxLoc)
        Me.Controls.Add(Me.txtbxTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Home4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox8)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Incident_Report"
        Me.Text = "Incident Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Home4 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtbxLoc As System.Windows.Forms.TextBox
    Friend WithEvents dtpickReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbxSummary As System.Windows.Forms.TextBox
    Friend WithEvents txtbxWhat As System.Windows.Forms.TextBox
    Friend WithEvents dtpickWhen As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbxWhere As System.Windows.Forms.TextBox
    Friend WithEvents txtbxImpact As System.Windows.Forms.TextBox
    Friend WithEvents txtbxOImpact As System.Windows.Forms.TextBox
    Friend WithEvents cmbxFirst As System.Windows.Forms.ComboBox
End Class
