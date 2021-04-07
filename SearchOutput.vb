Public Class SearchResults
    Private _HTMLOutput As String
    Private _BrowserControl As New WebBrowser
    Private _lstPaths As New List(Of String)

    Dim GlobalSession As ESPOParms.Session

    Public Property HTMLOutput As String
        Get
            Return _HTMLOutput
        End Get
        Set(value As String)
            _HTMLOutput = value
        End Set
    End Property

    Public Property lstPaths As List(Of String)
        Get
            Return _lstPaths
        End Get
        Set(value As List(Of String))
            _lstPaths = value
        End Set
    End Property

    Public Property BrowserControl As WebBrowser
        Get
            Return _BrowserControl
        End Get
        Set(value As WebBrowser)
            _BrowserControl = value
        End Set
    End Property

    Public Sub GetParms(Session As ESPOParms.Session)
        GlobalSession = Session
    End Sub
    Private Sub SearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(1, 1)
        KeyPreview = True
        MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        For Each imagePath As String In lstPaths
            txtJPGList.Text.Append(imagePath)
        Next

        Refresh()

        wbImages.Navigate("about:blank")
        If wbImages.Document IsNot Nothing Then
            wbImages.Document.Write(String.Empty)
        End If
        wbImages.DocumentText = HTMLOutput

        For Each c As Control In Controls
            AddHandler c.MouseClick, AddressOf ClickHandler
        Next
    End Sub

    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Select Case e.Button
            Case MouseButtons.Left
                Me.BringToFront()
        End Select
    End Sub

    Sub UndockChild()
        If MdiParent Is Nothing Then
            Me.MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        Else
            Me.MdiParent = Nothing
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub SearchResults_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F5 Then
            btnRefresh.PerformClick()
        ElseIf e.KeyValue = Keys.F7 Then
            UndockChild()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Refresh()

    End Sub
End Class