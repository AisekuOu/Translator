<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser.Margin = New System.Windows.Forms.Padding(2)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(11, 11)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.ScriptErrorsSuppressed = True
        Me.webBrowser.Size = New System.Drawing.Size(436, 257)
        Me.webBrowser.TabIndex = 0
        Me.webBrowser.Url = New System.Uri("https://fanyi.baidu.com/?aldtype=16047#auto/zh", System.UriKind.Absolute)
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 257)
        Me.Controls.Add(Me.webBrowser)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webBrowser As WebBrowser
End Class
