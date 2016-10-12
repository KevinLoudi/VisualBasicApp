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
        Me.Input = New System.Windows.Forms.TextBox
        Me.Write = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.Exiting = New System.Windows.Forms.Button
        Me.Output = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(32, 32)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(501, 25)
        Me.Input.TabIndex = 0
        '
        'Write
        '
        Me.Write.Location = New System.Drawing.Point(34, 93)
        Me.Write.Name = "Write"
        Me.Write.Size = New System.Drawing.Size(102, 33)
        Me.Write.TabIndex = 1
        Me.Write.Text = "Write"
        Me.Write.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(32, 145)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(102, 33)
        Me.Clear.TabIndex = 2
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Exiting
        '
        Me.Exiting.Location = New System.Drawing.Point(32, 195)
        Me.Exiting.Name = "Exiting"
        Me.Exiting.Size = New System.Drawing.Size(102, 33)
        Me.Exiting.TabIndex = 3
        Me.Exiting.Text = "Exit"
        Me.Exiting.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(174, 93)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(359, 135)
        Me.Output.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 332)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Exiting)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Write)
        Me.Controls.Add(Me.Input)
        Me.Name = "Form1"
        Me.Text = "UI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents Write As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Exiting As System.Windows.Forms.Button
    Friend WithEvents Output As System.Windows.Forms.TextBox

End Class
