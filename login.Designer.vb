<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.RCFA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyLogin = New System.Windows.Forms.Label()
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.txtbxPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RCFA
        '
        Me.RCFA.BackColor = System.Drawing.Color.Transparent
        Me.RCFA.Font = New System.Drawing.Font("Haettenschweiler", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCFA.ForeColor = System.Drawing.Color.White
        Me.RCFA.Location = New System.Drawing.Point(157, 188)
        Me.RCFA.Name = "RCFA"
        Me.RCFA.Size = New System.Drawing.Size(421, 45)
        Me.RCFA.TabIndex = 0
        Me.RCFA.Text = "RCFA-Reporting System"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MistyRose
        Me.Label2.Location = New System.Drawing.Point(156, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 237)
        Me.Label2.TabIndex = 1
        '
        'MyLogin
        '
        Me.MyLogin.BackColor = System.Drawing.Color.SteelBlue
        Me.MyLogin.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLogin.ForeColor = System.Drawing.Color.White
        Me.MyLogin.Location = New System.Drawing.Point(178, 251)
        Me.MyLogin.Name = "MyLogin"
        Me.MyLogin.Size = New System.Drawing.Size(294, 36)
        Me.MyLogin.TabIndex = 2
        Me.MyLogin.Text = "My Login"
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Location = New System.Drawing.Point(184, 321)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(336, 20)
        Me.txtbxUsername.TabIndex = 9
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Location = New System.Drawing.Point(184, 367)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.Size = New System.Drawing.Size(336, 20)
        Me.txtbxPassword.TabIndex = 10
        Me.txtbxPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(181, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(184, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Location = New System.Drawing.Point(184, 420)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(163, 23)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnSignup
        '
        Me.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignup.Location = New System.Drawing.Point(357, 420)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(163, 23)
        Me.btnSignup.TabIndex = 14
        Me.btnSignup.Text = "Signup"
        Me.btnSignup.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 559)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxPassword)
        Me.Controls.Add(Me.txtbxUsername)
        Me.Controls.Add(Me.MyLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RCFA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RCFA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MyLogin As Label
    Friend WithEvents txtbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnSignup As System.Windows.Forms.Button
End Class
