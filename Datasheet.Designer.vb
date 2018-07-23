<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datasheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IncidentReportDataSet1 = New WindowsApplication1.IncidentReportDataSet1()
        Me.IncidentReportDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentReportDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentReportDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.IncidentReportDataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(79, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(748, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'IncidentReportDataSet1
        '
        Me.IncidentReportDataSet1.DataSetName = "IncidentReportDataSet1"
        Me.IncidentReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncidentReportDataSet1BindingSource
        '
        Me.IncidentReportDataSet1BindingSource.DataSource = Me.IncidentReportDataSet1
        Me.IncidentReportDataSet1BindingSource.Position = 0
        '
        'Datasheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Datasheet"
        Me.Text = "Datasheet"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentReportDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentReportDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IncidentReportDataSet1BindingSource As BindingSource
    Friend WithEvents IncidentReportDataSet1 As IncidentReportDataSet1
End Class
