Public Class ShowHTML
    Private _HTMLOutput As String
    Private _BrowserControl As New WebBrowser

    Dim GlobalSession As ESPOParms.Session

    Public Property HTMLOutput As String
        Get
            Return _HTMLOutput
        End Get
        Set(value As String)
            _HTMLOutput = value
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

    Private Sub ShowHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(1, 1)
        KeyPreview = True
        MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        txtHTML.Text = HTMLOutput
        'WBHTMLOutput.DocumentText = HTMLOutput
        Refresh()

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


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Sub UndockChild()
        If MdiParent Is Nothing Then
            Me.MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        Else
            Me.MdiParent = Nothing
        End If
    End Sub

    Private Sub ShowHTML_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F5 Then
            btnRefresh.PerformClick()
        ElseIf e.KeyValue = Keys.F7 Then
            UndockChild()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Refresh()
    End Sub

    Function ExtractImagePaths(ByVal ImageType As String, ByRef ImageTags() As String) As String()
        Dim IMGTag As String
        Dim IMGPath As String
        Dim ImageIDX As Int64
        Dim EqualPos As Int64
        Dim StopPos As Int64
        Dim Images() As String

        ReDim Images(0)
        ImageIDX = 0
        ExtractImagePaths = Nothing
        For i As Integer = 0 To BrowserControl.Document.Images.Count - 1
            IMGTag = BrowserControl.Document.Images(i).OuterHtml
            StopPos = InStr(IMGTag.ToUpper, "." & ImageType.ToUpper)
            If StopPos > 0 Then
                ImageTags(ImageIDX) = IMGTag
                EqualPos = InStr(IMGTag, "src=") + 3
                IMGPath = Mid(IMGTag, EqualPos + 2, ((StopPos - 1) - (EqualPos + 1)) + 4)
                Images(ImageIDX) = IMGPath
                ReDim Preserve Images(UBound(Images) + 1)
                ReDim Preserve ImageTags(UBound(ImageTags) + 1)
                ImageIDX += 1
            End If
        Next
        Return Images

    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SearchID As String
        Dim Title As String
        Dim TagPos As Integer
        Dim InnerHTML As String
        Dim images() As String
        Dim TagNames() As String
        Dim ImageIDX As Integer
        Dim TagNameIDX As Integer
        Dim LoopIDX As Integer
        Dim ImageType As String
        Dim ImageTags() As String
        Dim lstImagePaths As New List(Of String)

        ReDim images(0)
        ReDim ImageTags(0)
        ReDim TagNames(0)
        ImageIDX = 0
        TagNameIDX = 0
        LoopIDX = 0
        ImageType = txtSearch.Text
        InnerHTML = String.Empty
        images = ExtractImagePaths(ImageType, ImageTags)

        Dim App As New ESPOWebApp.SearchResults

        For i As Integer = 0 To images.Count - 1
            If Not IsNothing(images(i)) Then
                lstImagePaths.Add(images(i))
                InnerHTML += "<br>" & "<IMG src=" & images(i) & ">" & "<br>"
                'wbImages.DocumentText += InnerHTML
            End If
        Next

        Cursor = Cursors.Default
        stsLabel1.Text = "Loading ..."
        Cursor = Cursors.WaitCursor
        Refresh()
        'App.Visible = False
        App.GetParms(GlobalSession)
        App.HTMLOutput = InnerHTML
        App.lstPaths = lstImagePaths
        App.Text = "Search Results: " & BrowserControl.DocumentTitle
        App.Show()
        stsLabel1.Text = ""
        Cursor = Cursors.Default


        'For Each element In BrowserControl.Document.GetElementById("a")
        Title = BrowserControl.DocumentTitle
        'MsgBox("Title = " & Title)
        'Next
    End Sub
End Class