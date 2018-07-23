<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DCS
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
        Dim CausesLabel As System.Windows.Forms.Label
        Dim RecommendationsLabel As System.Windows.Forms.Label
        Dim Action_byLabel As System.Windows.Forms.Label
        Dim DatelineLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DCS))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CausesTextBox = New System.Windows.Forms.TextBox()
        Me.RecommendationsTextBox = New System.Windows.Forms.TextBox()
        Me.Action_byTextBox = New System.Windows.Forms.TextBox()
        Me.DatelineTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CausesLabel = New System.Windows.Forms.Label()
        RecommendationsLabel = New System.Windows.Forms.Label()
        Action_byLabel = New System.Windows.Forms.Label()
        DatelineLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CausesLabel
        '
        CausesLabel.AutoSize = True
        CausesLabel.BackColor = System.Drawing.Color.Transparent
        CausesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CausesLabel.ForeColor = System.Drawing.Color.White
        CausesLabel.Location = New System.Drawing.Point(37, 165)
        CausesLabel.Name = "CausesLabel"
        CausesLabel.Size = New System.Drawing.Size(67, 20)
        CausesLabel.TabIndex = 222
        CausesLabel.Text = "Causes:"
        '
        'RecommendationsLabel
        '
        RecommendationsLabel.AutoSize = True
        RecommendationsLabel.BackColor = System.Drawing.Color.Transparent
        RecommendationsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecommendationsLabel.ForeColor = System.Drawing.Color.White
        RecommendationsLabel.Location = New System.Drawing.Point(37, 191)
        RecommendationsLabel.Name = "RecommendationsLabel"
        RecommendationsLabel.Size = New System.Drawing.Size(147, 20)
        RecommendationsLabel.TabIndex = 224
        RecommendationsLabel.Text = "Recommendations:"
        '
        'Action_byLabel
        '
        Action_byLabel.AutoSize = True
        Action_byLabel.BackColor = System.Drawing.Color.Transparent
        Action_byLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Action_byLabel.ForeColor = System.Drawing.Color.White
        Action_byLabel.Location = New System.Drawing.Point(37, 217)
        Action_byLabel.Name = "Action_byLabel"
        Action_byLabel.Size = New System.Drawing.Size(78, 20)
        Action_byLabel.TabIndex = 226
        Action_byLabel.Text = "Action by:"
        '
        'DatelineLabel
        '
        DatelineLabel.AutoSize = True
        DatelineLabel.BackColor = System.Drawing.Color.Transparent
        DatelineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DatelineLabel.ForeColor = System.Drawing.Color.White
        DatelineLabel.Location = New System.Drawing.Point(37, 243)
        DatelineLabel.Name = "DatelineLabel"
        DatelineLabel.Size = New System.Drawing.Size(72, 20)
        DatelineLabel.TabIndex = 228
        DatelineLabel.Text = "Dateline:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = System.Drawing.Color.Transparent
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.ForeColor = System.Drawing.Color.White
        StatusLabel.Location = New System.Drawing.Point(37, 269)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(60, 20)
        StatusLabel.TabIndex = 230
        StatusLabel.Text = "Status:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.BackColor = System.Drawing.Color.Transparent
        RemarksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarksLabel.ForeColor = System.Drawing.Color.White
        RemarksLabel.Location = New System.Drawing.Point(37, 295)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(77, 20)
        RemarksLabel.TabIndex = 232
        RemarksLabel.Text = "Remarks:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Teal
        Me.Label16.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(98, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1420, 39)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "     Add New Finding And Recommendation"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Salmon
        Me.Label19.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-4, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 39)
        Me.Label19.TabIndex = 143
        Me.Label19.Text = " Home"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CausesTextBox
        '
        Me.CausesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CausesTextBox.Location = New System.Drawing.Point(196, 165)
        Me.CausesTextBox.Name = "CausesTextBox"
        Me.CausesTextBox.Size = New System.Drawing.Size(584, 24)
        Me.CausesTextBox.TabIndex = 223
        '
        'RecommendationsTextBox
        '
        Me.RecommendationsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecommendationsTextBox.Location = New System.Drawing.Point(196, 191)
        Me.RecommendationsTextBox.Name = "RecommendationsTextBox"
        Me.RecommendationsTextBox.Size = New System.Drawing.Size(584, 24)
        Me.RecommendationsTextBox.TabIndex = 225
        '
        'Action_byTextBox
        '
        Me.Action_byTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Action_byTextBox.Location = New System.Drawing.Point(196, 217)
        Me.Action_byTextBox.Name = "Action_byTextBox"
        Me.Action_byTextBox.Size = New System.Drawing.Size(584, 24)
        Me.Action_byTextBox.TabIndex = 227
        '
        'DatelineTextBox
        '
        Me.DatelineTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatelineTextBox.Location = New System.Drawing.Point(196, 243)
        Me.DatelineTextBox.Name = "DatelineTextBox"
        Me.DatelineTextBox.Size = New System.Drawing.Size(584, 24)
        Me.DatelineTextBox.TabIndex = 229
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(196, 269)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(584, 24)
        Me.StatusTextBox.TabIndex = 231
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksTextBox.Location = New System.Drawing.Point(196, 295)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(584, 24)
        Me.RemarksTextBox.TabIndex = 233
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(666, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 26)
        Me.Button2.TabIndex = 235
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 234
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(822, 471)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CausesLabel)
        Me.Controls.Add(Me.CausesTextBox)
        Me.Controls.Add(RecommendationsLabel)
        Me.Controls.Add(Me.RecommendationsTextBox)
        Me.Controls.Add(Action_byLabel)
        Me.Controls.Add(Me.Action_byTextBox)
        Me.Controls.Add(DatelineLabel)
        Me.Controls.Add(Me.DatelineTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DCS"
        Me.Text = "Finding And Recommendation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents CausesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecommendationsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Action_byTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatelineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
