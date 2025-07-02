<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridButton1 = New System.Windows.Forms.Button()
        Me.GridButton2 = New System.Windows.Forms.Button()
        Me.GridButton3 = New System.Windows.Forms.Button()
        Me.GridButton4 = New System.Windows.Forms.Button()
        Me.GridButton5 = New System.Windows.Forms.Button()
        Me.GridButton6 = New System.Windows.Forms.Button()
        Me.GridButton7 = New System.Windows.Forms.Button()
        Me.GridButton8 = New System.Windows.Forms.Button()
        Me.GridButton9 = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(393, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Player 1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(384, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(1499, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1508, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Player 2"
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.White
        Me.RestartButton.BackgroundImage = CType(resources.GetObject("RestartButton.BackgroundImage"), System.Drawing.Image)
        Me.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RestartButton.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.RestartButton.Location = New System.Drawing.Point(957, 60)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(100, 100)
        Me.RestartButton.TabIndex = 13
        Me.RestartButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(957, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = " Restart"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GridButton1
        '
        Me.GridButton1.BackColor = System.Drawing.Color.White
        Me.GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton1.Location = New System.Drawing.Point(749, 295)
        Me.GridButton1.Name = "GridButton1"
        Me.GridButton1.Size = New System.Drawing.Size(176, 175)
        Me.GridButton1.TabIndex = 15
        Me.GridButton1.UseVisualStyleBackColor = False
        '
        'GridButton2
        '
        Me.GridButton2.BackColor = System.Drawing.Color.White
        Me.GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton2.Location = New System.Drawing.Point(922, 295)
        Me.GridButton2.Name = "GridButton2"
        Me.GridButton2.Size = New System.Drawing.Size(176, 175)
        Me.GridButton2.TabIndex = 16
        Me.GridButton2.UseVisualStyleBackColor = False
        '
        'GridButton3
        '
        Me.GridButton3.BackColor = System.Drawing.Color.White
        Me.GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton3.Location = New System.Drawing.Point(1095, 295)
        Me.GridButton3.Name = "GridButton3"
        Me.GridButton3.Size = New System.Drawing.Size(176, 175)
        Me.GridButton3.TabIndex = 17
        Me.GridButton3.UseVisualStyleBackColor = False
        '
        'GridButton4
        '
        Me.GridButton4.BackColor = System.Drawing.Color.White
        Me.GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton4.Location = New System.Drawing.Point(749, 467)
        Me.GridButton4.Name = "GridButton4"
        Me.GridButton4.Size = New System.Drawing.Size(176, 175)
        Me.GridButton4.TabIndex = 18
        Me.GridButton4.UseVisualStyleBackColor = False
        '
        'GridButton5
        '
        Me.GridButton5.BackColor = System.Drawing.Color.White
        Me.GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton5.Location = New System.Drawing.Point(922, 467)
        Me.GridButton5.Name = "GridButton5"
        Me.GridButton5.Size = New System.Drawing.Size(176, 175)
        Me.GridButton5.TabIndex = 19
        Me.GridButton5.UseVisualStyleBackColor = False
        '
        'GridButton6
        '
        Me.GridButton6.BackColor = System.Drawing.Color.White
        Me.GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton6.Location = New System.Drawing.Point(1095, 467)
        Me.GridButton6.Name = "GridButton6"
        Me.GridButton6.Size = New System.Drawing.Size(176, 175)
        Me.GridButton6.TabIndex = 20
        Me.GridButton6.UseVisualStyleBackColor = False
        '
        'GridButton7
        '
        Me.GridButton7.BackColor = System.Drawing.Color.White
        Me.GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton7.Location = New System.Drawing.Point(749, 639)
        Me.GridButton7.Name = "GridButton7"
        Me.GridButton7.Size = New System.Drawing.Size(176, 175)
        Me.GridButton7.TabIndex = 21
        Me.GridButton7.UseVisualStyleBackColor = False
        '
        'GridButton8
        '
        Me.GridButton8.BackColor = System.Drawing.Color.White
        Me.GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton8.Location = New System.Drawing.Point(922, 639)
        Me.GridButton8.Name = "GridButton8"
        Me.GridButton8.Size = New System.Drawing.Size(176, 175)
        Me.GridButton8.TabIndex = 22
        Me.GridButton8.UseVisualStyleBackColor = False
        '
        'GridButton9
        '
        Me.GridButton9.BackColor = System.Drawing.Color.White
        Me.GridButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridButton9.Location = New System.Drawing.Point(1095, 639)
        Me.GridButton9.Name = "GridButton9"
        Me.GridButton9.Size = New System.Drawing.Size(176, 175)
        Me.GridButton9.TabIndex = 23
        Me.GridButton9.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Lime
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(384, 867)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(132, 48)
        Me.BackButton.TabIndex = 24
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1499, 867)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(132, 48)
        Me.ExitButton.TabIndex = 25
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(228, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1648, 74)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(130, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PlayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1808, 943)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GridButton9)
        Me.Controls.Add(Me.GridButton8)
        Me.Controls.Add(Me.GridButton7)
        Me.Controls.Add(Me.GridButton6)
        Me.Controls.Add(Me.GridButton5)
        Me.Controls.Add(Me.GridButton4)
        Me.Controls.Add(Me.GridButton3)
        Me.Controls.Add(Me.GridButton2)
        Me.Controls.Add(Me.GridButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PlayForm"
        Me.Text = "Tic Tac Toe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RestartButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GridButton1 As Button
    Friend WithEvents GridButton2 As Button
    Friend WithEvents GridButton3 As Button
    Friend WithEvents GridButton4 As Button
    Friend WithEvents GridButton5 As Button
    Friend WithEvents GridButton6 As Button
    Friend WithEvents GridButton7 As Button
    Friend WithEvents GridButton8 As Button
    Friend WithEvents GridButton9 As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
