<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResults
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
        Me.wbImages = New System.Windows.Forms.WebBrowser()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtJPGList = New System.Windows.Forms.TextBox()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbImages
        '
        Me.wbImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbImages.Location = New System.Drawing.Point(2, 191)
        Me.wbImages.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbImages.Name = "wbImages"
        Me.wbImages.Size = New System.Drawing.Size(869, 419)
        Me.wbImages.TabIndex = 6
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Location = New System.Drawing.Point(2, 1)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(869, 46)
        Me.pnlButtons.TabIndex = 7
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(397, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(777, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtJPGList
        '
        Me.txtJPGList.Location = New System.Drawing.Point(2, 53)
        Me.txtJPGList.Multiline = True
        Me.txtJPGList.Name = "txtJPGList"
        Me.txtJPGList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJPGList.Size = New System.Drawing.Size(869, 132)
        Me.txtJPGList.TabIndex = 8
        '
        'SearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 618)
        Me.Controls.Add(Me.txtJPGList)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.wbImages)
        Me.Name = "SearchResults"
        Me.Text = "Search Results"
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbImages As WebBrowser
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtJPGList As TextBox
End Class
