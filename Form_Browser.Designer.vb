<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowserForm
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
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnOpenHTMLFile = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnGRAB = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.myBrowser = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlButtons.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.BackColor = System.Drawing.Color.Silver
        Me.pnlButtons.Controls.Add(Me.btnOpenHTMLFile)
        Me.pnlButtons.Controls.Add(Me.btnTest)
        Me.pnlButtons.Controls.Add(Me.btnGRAB)
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnForward)
        Me.pnlButtons.Controls.Add(Me.btnBack)
        Me.pnlButtons.Controls.Add(Me.btnSEARCH)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.txtSearch)
        Me.pnlButtons.Controls.Add(Me.btnHome)
        Me.pnlButtons.Location = New System.Drawing.Point(1, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(793, 87)
        Me.pnlButtons.TabIndex = 0
        '
        'btnOpenHTMLFile
        '
        Me.btnOpenHTMLFile.Location = New System.Drawing.Point(416, 12)
        Me.btnOpenHTMLFile.Name = "btnOpenHTMLFile"
        Me.btnOpenHTMLFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenHTMLFile.TabIndex = 9
        Me.btnOpenHTMLFile.Text = "Open"
        Me.btnOpenHTMLFile.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(586, 12)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnGRAB
        '
        Me.btnGRAB.Location = New System.Drawing.Point(335, 12)
        Me.btnGRAB.Name = "btnGRAB"
        Me.btnGRAB.Size = New System.Drawing.Size(75, 23)
        Me.btnGRAB.TabIndex = 6
        Me.btnGRAB.Text = "Grab HTML"
        Me.btnGRAB.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefresh.Location = New System.Drawing.Point(254, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnForward.Location = New System.Drawing.Point(173, 12)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 4
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(92, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSEARCH.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSEARCH.Location = New System.Drawing.Point(685, 52)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(62, 23)
        Me.btnSEARCH.TabIndex = 1
        Me.btnSEARCH.Text = "Search"
        Me.btnSEARCH.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(672, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(11, 55)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(668, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(11, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'myBrowser
        '
        Me.myBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myBrowser.Location = New System.Drawing.Point(1, 93)
        Me.myBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.myBrowser.Name = "myBrowser"
        Me.myBrowser.Size = New System.Drawing.Size(787, 325)
        Me.myBrowser.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLabel1, Me.stsLabel2, Me.stsLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsLabel1
        '
        Me.stsLabel1.Name = "stsLabel1"
        Me.stsLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'stsLabel2
        '
        Me.stsLabel2.Name = "stsLabel2"
        Me.stsLabel2.Size = New System.Drawing.Size(785, 17)
        Me.stsLabel2.Spring = True
        '
        'stsLabel3
        '
        Me.stsLabel3.Name = "stsLabel3"
        Me.stsLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'WebBrowserForm
        '
        Me.AcceptButton = Me.btnSEARCH
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnRefresh
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.myBrowser)
        Me.Controls.Add(Me.pnlButtons)
        Me.KeyPreview = True
        Me.Name = "WebBrowserForm"
        Me.Text = "ESPO Web Browser"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents WebBrowser1 As WebBrowserForm
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents myBrowser As Windows.Forms.WebBrowser
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSEARCH As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnGRAB As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsLabel1 As ToolStripStatusLabel
    Friend WithEvents stsLabel2 As ToolStripStatusLabel
    Friend WithEvents stsLabel3 As ToolStripStatusLabel
    Friend WithEvents btnTest As Button
    Friend WithEvents btnOpenHTMLFile As Button
End Class
