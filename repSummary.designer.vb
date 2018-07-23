<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exec
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exec))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button_Clr1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reportTitle = New System.Windows.Forms.Label()
        Me.reportDate = New System.Windows.Forms.Label()
        Me.reportLoc = New System.Windows.Forms.Label()
        Me.reportSum = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.teamMem = New System.Windows.Forms.Label()
        Me.teamLead = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pwrPntButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cause = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recommendations = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dateline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.CadetBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Honeydew
        Me.Label16.Location = New System.Drawing.Point(17, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1297, 706)
        Me.Label16.TabIndex = 71
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1252, 39)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "     Incident Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Salmon
        Me.Label19.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(0, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 39)
        Me.Label19.TabIndex = 145
        Me.Label19.Text = " Home"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(754, 490)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 29)
        Me.Button6.TabIndex = 173
        Me.Button6.Text = "New"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(976, 490)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 29)
        Me.Button8.TabIndex = 171
        Me.Button8.Text = "Save"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button_Clr1
        '
        Me.Button_Clr1.Location = New System.Drawing.Point(865, 490)
        Me.Button_Clr1.Name = "Button_Clr1"
        Me.Button_Clr1.Size = New System.Drawing.Size(105, 29)
        Me.Button_Clr1.TabIndex = 170
        Me.Button_Clr1.Text = "Clear "
        Me.Button_Clr1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(33, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1236, 676)
        Me.Label2.TabIndex = 175
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reportTitle
        '
        Me.reportTitle.AutoSize = True
        Me.reportTitle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportTitle.Location = New System.Drawing.Point(125, 163)
        Me.reportTitle.Name = "reportTitle"
        Me.reportTitle.Size = New System.Drawing.Size(54, 23)
        Me.reportTitle.TabIndex = 176
        Me.reportTitle.Text = "Title:"
        '
        'reportDate
        '
        Me.reportDate.AutoSize = True
        Me.reportDate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportDate.Location = New System.Drawing.Point(125, 191)
        Me.reportDate.Name = "reportDate"
        Me.reportDate.Size = New System.Drawing.Size(207, 23)
        Me.reportDate.TabIndex = 177
        Me.reportDate.Text = "Incident Date and Time:"
        '
        'reportLoc
        '
        Me.reportLoc.AutoSize = True
        Me.reportLoc.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportLoc.Location = New System.Drawing.Point(125, 219)
        Me.reportLoc.Name = "reportLoc"
        Me.reportLoc.Size = New System.Drawing.Size(90, 23)
        Me.reportLoc.TabIndex = 178
        Me.reportLoc.Text = "Location:"
        '
        'reportSum
        '
        Me.reportSum.AutoSize = True
        Me.reportSum.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportSum.Location = New System.Drawing.Point(125, 247)
        Me.reportSum.Name = "reportSum"
        Me.reportSum.Size = New System.Drawing.Size(95, 23)
        Me.reportSum.TabIndex = 179
        Me.reportSum.Text = "Summary:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 23)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Team Members:"
        '
        'teamMem
        '
        Me.teamMem.AutoSize = True
        Me.teamMem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamMem.Location = New System.Drawing.Point(125, 331)
        Me.teamMem.Name = "teamMem"
        Me.teamMem.Size = New System.Drawing.Size(64, 21)
        Me.teamMem.TabIndex = 182
        Me.teamMem.Text = "- Name"
        '
        'teamLead
        '
        Me.teamLead.AutoSize = True
        Me.teamLead.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamLead.Location = New System.Drawing.Point(125, 275)
        Me.teamLead.Name = "teamLead"
        Me.teamLead.Size = New System.Drawing.Size(122, 23)
        Me.teamLead.TabIndex = 183
        Me.teamLead.Text = "Team Leader:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 487)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 23)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Finding and Recommendation:"
        '
        'pwrPntButton
        '
        Me.pwrPntButton.Location = New System.Drawing.Point(1100, 513)
        Me.pwrPntButton.Name = "pwrPntButton"
        Me.pwrPntButton.Size = New System.Drawing.Size(144, 23)
        Me.pwrPntButton.TabIndex = 210
        Me.pwrPntButton.Text = "Export to Powerpoint"
        Me.pwrPntButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Cause, Me.Recommendations, Me.ActionBy, Me.Dateline, Me.Status, Me.Remarks})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(129, 513)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(938, 250)
        Me.DataGridView1.TabIndex = 211
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Cause
        '
        Me.Cause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cause.HeaderText = "Causes"
        Me.Cause.Name = "Cause"
        Me.Cause.ReadOnly = True
        '
        'Recommendations
        '
        Me.Recommendations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Recommendations.DefaultCellStyle = DataGridViewCellStyle2
        Me.Recommendations.HeaderText = "Recommendations"
        Me.Recommendations.Name = "Recommendations"
        Me.Recommendations.ReadOnly = True
        '
        'ActionBy
        '
        Me.ActionBy.HeaderText = "Action By"
        Me.ActionBy.Name = "ActionBy"
        Me.ActionBy.ReadOnly = True
        '
        'Dateline
        '
        Me.Dateline.HeaderText = "Dateline"
        Me.Dateline.Name = "Dateline"
        Me.Dateline.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'Exec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 694)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pwrPntButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.teamLead)
        Me.Controls.Add(Me.teamMem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.reportSum)
        Me.Controls.Add(Me.reportLoc)
        Me.Controls.Add(Me.reportDate)
        Me.Controls.Add(Me.reportTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button_Clr1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Exec"
        Me.Text = "Incident Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button_Clr1 As Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reportTitle As System.Windows.Forms.Label
    Friend WithEvents reportDate As System.Windows.Forms.Label
    Friend WithEvents reportLoc As System.Windows.Forms.Label
    Friend WithEvents reportSum As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents teamMem As System.Windows.Forms.Label
    Friend WithEvents teamLead As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pwrPntButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cause As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recommendations As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dateline As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
