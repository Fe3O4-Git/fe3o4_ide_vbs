<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.BarStatusMain = New System.Windows.Forms.StatusStrip()
        Me.ProgressbarMain = New System.Windows.Forms.ToolStripProgressBar()
        Me.TextboxMain = New System.Windows.Forms.RichTextBox()
        Me.DialogFileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.BarToolMain = New System.Windows.Forms.ToolStrip()
        Me.ButtonOpenMain = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSaveMain = New System.Windows.Forms.ToolStripButton()
        Me.ButtonRunMain = New System.Windows.Forms.ToolStripButton()
        Me.ButtonStopMain = New System.Windows.Forms.ToolStripButton()
        Me.ProcessMain = New System.Diagnostics.Process()
        Me.BarStatusMain.SuspendLayout()
        Me.BarToolMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarStatusMain
        '
        Me.BarStatusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressbarMain})
        Me.BarStatusMain.Location = New System.Drawing.Point(0, 428)
        Me.BarStatusMain.Name = "BarStatusMain"
        Me.BarStatusMain.Size = New System.Drawing.Size(800, 22)
        Me.BarStatusMain.TabIndex = 2
        '
        'ProgressbarMain
        '
        Me.ProgressbarMain.Name = "ProgressbarMain"
        Me.ProgressbarMain.Size = New System.Drawing.Size(100, 16)
        '
        'TextboxMain
        '
        Me.TextboxMain.Location = New System.Drawing.Point(0, 28)
        Me.TextboxMain.Name = "TextboxMain"
        Me.TextboxMain.Size = New System.Drawing.Size(800, 397)
        Me.TextboxMain.TabIndex = 3
        Me.TextboxMain.Text = ""
        '
        'BarToolMain
        '
        Me.BarToolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonOpenMain, Me.ButtonSaveMain, Me.ButtonRunMain, Me.ButtonStopMain})
        Me.BarToolMain.Location = New System.Drawing.Point(0, 0)
        Me.BarToolMain.Name = "BarToolMain"
        Me.BarToolMain.Size = New System.Drawing.Size(800, 25)
        Me.BarToolMain.TabIndex = 4
        Me.BarToolMain.Text = "ToolStrip1"
        '
        'ButtonOpenMain
        '
        Me.ButtonOpenMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonOpenMain.Image = CType(resources.GetObject("ButtonOpenMain.Image"), System.Drawing.Image)
        Me.ButtonOpenMain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonOpenMain.Name = "ButtonOpenMain"
        Me.ButtonOpenMain.Size = New System.Drawing.Size(40, 22)
        Me.ButtonOpenMain.Text = "Open"
        '
        'ButtonSaveMain
        '
        Me.ButtonSaveMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonSaveMain.Image = CType(resources.GetObject("ButtonSaveMain.Image"), System.Drawing.Image)
        Me.ButtonSaveMain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSaveMain.Name = "ButtonSaveMain"
        Me.ButtonSaveMain.Size = New System.Drawing.Size(35, 22)
        Me.ButtonSaveMain.Text = "Save"
        '
        'ButtonRunMain
        '
        Me.ButtonRunMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonRunMain.Image = CType(resources.GetObject("ButtonRunMain.Image"), System.Drawing.Image)
        Me.ButtonRunMain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonRunMain.Name = "ButtonRunMain"
        Me.ButtonRunMain.Size = New System.Drawing.Size(32, 22)
        Me.ButtonRunMain.Text = "Run"
        '
        'ButtonStopMain
        '
        Me.ButtonStopMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButtonStopMain.Enabled = False
        Me.ButtonStopMain.Image = CType(resources.GetObject("ButtonStopMain.Image"), System.Drawing.Image)
        Me.ButtonStopMain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonStopMain.Name = "ButtonStopMain"
        Me.ButtonStopMain.Size = New System.Drawing.Size(35, 22)
        Me.ButtonStopMain.Text = "Stop"
        '
        'ProcessMain
        '
        Me.ProcessMain.StartInfo.Domain = ""
        Me.ProcessMain.StartInfo.LoadUserProfile = False
        Me.ProcessMain.StartInfo.Password = Nothing
        Me.ProcessMain.StartInfo.StandardErrorEncoding = Nothing
        Me.ProcessMain.StartInfo.StandardOutputEncoding = Nothing
        Me.ProcessMain.StartInfo.UserName = ""
        Me.ProcessMain.SynchronizingObject = Me
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BarToolMain)
        Me.Controls.Add(Me.TextboxMain)
        Me.Controls.Add(Me.BarStatusMain)
        Me.Name = "FormMain"
        Me.Text = "Light IDE for VBS"
        Me.BarStatusMain.ResumeLayout(False)
        Me.BarStatusMain.PerformLayout()
        Me.BarToolMain.ResumeLayout(False)
        Me.BarToolMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarStatusMain As StatusStrip
    Friend WithEvents TextboxMain As RichTextBox
    Friend WithEvents DialogFileOpen As OpenFileDialog
    Friend WithEvents BarToolMain As ToolStrip
    Friend WithEvents ButtonOpenMain As ToolStripButton
    Friend WithEvents ProgressbarMain As ToolStripProgressBar
    Friend WithEvents ButtonSaveMain As ToolStripButton
    Friend WithEvents ButtonRunMain As ToolStripButton
    Friend WithEvents ButtonStopMain As ToolStripButton
    Friend WithEvents ProcessMain As Process
End Class
