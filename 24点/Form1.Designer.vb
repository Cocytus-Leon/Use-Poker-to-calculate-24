<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 巧算24点
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.NUM1 = New System.Windows.Forms.RichTextBox()
        Me.NUM2 = New System.Windows.Forms.RichTextBox()
        Me.NUM3 = New System.Windows.Forms.RichTextBox()
        Me.NUM4 = New System.Windows.Forms.RichTextBox()
        Me.btncount = New System.Windows.Forms.Button()
        Me.Ans = New System.Windows.Forms.ListBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(158, 395)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(70, 35)
        Me.btnstart.TabIndex = 0
        Me.btnstart.Text = "发牌"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'NUM1
        '
        Me.NUM1.Font = New System.Drawing.Font("幼圆", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUM1.ForeColor = System.Drawing.Color.Red
        Me.NUM1.Location = New System.Drawing.Point(33, 8)
        Me.NUM1.Name = "NUM1"
        Me.NUM1.Size = New System.Drawing.Size(155, 170)
        Me.NUM1.TabIndex = 1
        Me.NUM1.Text = ""
        '
        'NUM2
        '
        Me.NUM2.Font = New System.Drawing.Font("幼圆", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUM2.ForeColor = System.Drawing.Color.Blue
        Me.NUM2.Location = New System.Drawing.Point(203, 8)
        Me.NUM2.Name = "NUM2"
        Me.NUM2.Size = New System.Drawing.Size(155, 170)
        Me.NUM2.TabIndex = 2
        Me.NUM2.Text = ""
        '
        'NUM3
        '
        Me.NUM3.Font = New System.Drawing.Font("幼圆", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUM3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NUM3.Location = New System.Drawing.Point(33, 206)
        Me.NUM3.Name = "NUM3"
        Me.NUM3.Size = New System.Drawing.Size(155, 170)
        Me.NUM3.TabIndex = 3
        Me.NUM3.Text = ""
        '
        'NUM4
        '
        Me.NUM4.Font = New System.Drawing.Font("幼圆", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUM4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NUM4.Location = New System.Drawing.Point(203, 206)
        Me.NUM4.Name = "NUM4"
        Me.NUM4.Size = New System.Drawing.Size(155, 170)
        Me.NUM4.TabIndex = 5
        Me.NUM4.Text = ""
        '
        'btncount
        '
        Me.btncount.Location = New System.Drawing.Point(381, 133)
        Me.btncount.Name = "btncount"
        Me.btncount.Size = New System.Drawing.Size(70, 36)
        Me.btncount.TabIndex = 6
        Me.btncount.Text = "计算"
        Me.btncount.UseVisualStyleBackColor = True
        '
        'Ans
        '
        Me.Ans.Font = New System.Drawing.Font("幼圆", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Ans.ItemHeight = 18
        Me.Ans.Location = New System.Drawing.Point(472, 12)
        Me.Ans.Name = "Ans"
        Me.Ans.Size = New System.Drawing.Size(316, 364)
        Me.Ans.TabIndex = 7
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(543, 395)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(70, 35)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "清空"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(381, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(419, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(721, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "？"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(649, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "解的个数"
        '
        '巧算24点
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Ans)
        Me.Controls.Add(Me.btncount)
        Me.Controls.Add(Me.NUM4)
        Me.Controls.Add(Me.NUM3)
        Me.Controls.Add(Me.NUM2)
        Me.Controls.Add(Me.NUM1)
        Me.Controls.Add(Me.btnstart)
        Me.Name = "巧算24点"
        Me.Text = "巧算24点"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnstart As Button
    Friend WithEvents NUM1 As RichTextBox
    Friend WithEvents NUM2 As RichTextBox
    Friend WithEvents NUM3 As RichTextBox
    Friend WithEvents NUM4 As RichTextBox
    Friend WithEvents btncount As Button
    Friend WithEvents Ans As ListBox
    Friend WithEvents btnclear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
