<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Num1 = New System.Windows.Forms.TextBox
        Me.Num2 = New System.Windows.Forms.TextBox
        Me.Res = New System.Windows.Forms.TextBox
        Me.ButAdd = New System.Windows.Forms.Button
        Me.ButSubtract = New System.Windows.Forms.Button
        Me.ButDivide = New System.Windows.Forms.Button
        Me.ButMultiply = New System.Windows.Forms.Button
        Me.ButModules = New System.Windows.Forms.Button
        Me.Pie = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(30, 31)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(546, 25)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "2678.98"
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(30, 86)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(546, 25)
        Me.Num2.TabIndex = 1
        Me.Num2.Text = "31.78"
        '
        'Res
        '
        Me.Res.Location = New System.Drawing.Point(30, 140)
        Me.Res.Name = "Res"
        Me.Res.ReadOnly = True
        Me.Res.Size = New System.Drawing.Size(546, 25)
        Me.Res.TabIndex = 2
        '
        'ButAdd
        '
        Me.ButAdd.Location = New System.Drawing.Point(30, 171)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(155, 27)
        Me.ButAdd.TabIndex = 3
        Me.ButAdd.Text = "Add"
        Me.ButAdd.UseVisualStyleBackColor = True
        '
        'ButSubtract
        '
        Me.ButSubtract.Location = New System.Drawing.Point(227, 171)
        Me.ButSubtract.Name = "ButSubtract"
        Me.ButSubtract.Size = New System.Drawing.Size(155, 27)
        Me.ButSubtract.TabIndex = 4
        Me.ButSubtract.Text = "Subtract"
        Me.ButSubtract.UseVisualStyleBackColor = True
        '
        'ButDivide
        '
        Me.ButDivide.Location = New System.Drawing.Point(421, 171)
        Me.ButDivide.Name = "ButDivide"
        Me.ButDivide.Size = New System.Drawing.Size(155, 27)
        Me.ButDivide.TabIndex = 5
        Me.ButDivide.Text = "Divide"
        Me.ButDivide.UseVisualStyleBackColor = True
        '
        'ButMultiply
        '
        Me.ButMultiply.Location = New System.Drawing.Point(30, 220)
        Me.ButMultiply.Name = "ButMultiply"
        Me.ButMultiply.Size = New System.Drawing.Size(155, 27)
        Me.ButMultiply.TabIndex = 6
        Me.ButMultiply.Text = "Multiply"
        Me.ButMultiply.UseVisualStyleBackColor = True
        '
        'ButModules
        '
        Me.ButModules.Location = New System.Drawing.Point(227, 220)
        Me.ButModules.Name = "ButModules"
        Me.ButModules.Size = New System.Drawing.Size(155, 27)
        Me.ButModules.TabIndex = 7
        Me.ButModules.Text = "Modules"
        Me.ButModules.UseVisualStyleBackColor = True
        '
        'Pie
        '
        Me.Pie.Location = New System.Drawing.Point(421, 220)
        Me.Pie.Name = "Pie"
        Me.Pie.Size = New System.Drawing.Size(155, 27)
        Me.Pie.TabIndex = 8
        Me.Pie.Text = "ButPie"
        Me.Pie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Result"
        '
        'ButClear
        '
        Me.ButClear.Location = New System.Drawing.Point(227, 277)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(155, 27)
        Me.ButClear.TabIndex = 13
        Me.ButClear.Text = "Clear"
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 367)
        Me.Controls.Add(Me.ButClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pie)
        Me.Controls.Add(Me.ButModules)
        Me.Controls.Add(Me.ButMultiply)
        Me.Controls.Add(Me.ButDivide)
        Me.Controls.Add(Me.ButSubtract)
        Me.Controls.Add(Me.ButAdd)
        Me.Controls.Add(Me.Res)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Num2 As System.Windows.Forms.TextBox
    Friend WithEvents Res As System.Windows.Forms.TextBox
    Private WithEvents Num1 As System.Windows.Forms.TextBox
    Friend WithEvents ButAdd As System.Windows.Forms.Button
    Friend WithEvents ButSubtract As System.Windows.Forms.Button
    Friend WithEvents ButDivide As System.Windows.Forms.Button
    Friend WithEvents ButMultiply As System.Windows.Forms.Button
    Friend WithEvents ButModules As System.Windows.Forms.Button
    Friend WithEvents Pie As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButClear As System.Windows.Forms.Button

End Class
