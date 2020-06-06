
Imports System.Data

Partial Class Default2
    Inherits System.Web.UI.Page

    Public Sub PageInit() Handles Me.Init

        Dim dt As DataTable = New DataTable()

        Dim lstMsgs As List(Of MsgMain) = New List(Of MsgMain)

        For i As Integer = 1 To 5
            Dim mm As New MsgMain
            mm.ID = i
            mm.Message = "Msg " & i
            mm.CreateDate = Date.Now
            lstMsgs.Add(mm)
        Next

        gvMsgTemplates.DataSource = lstMsgs
        gvMsgTemplates.DataBind()

    End Sub
    'Private Sub mv_Load(sender As Object, e As EventArgs) Handles mv.Load
    '    mv.SetActiveView(viewList)
    'End Sub

    'Protected Sub lbtnList_Click(sender As Object, e As EventArgs) Handles lbtnList.Click
    '    mv.SetActiveView(viewList)
    'End Sub
    'Protected Sub lbtnCreateTemplate_Click(sender As Object, e As EventArgs) Handles lbtnCreateTemplate.Click
    '    mv.SetActiveView(viewCreateTemplate)
    'End Sub
    'Protected Sub lbtnUploadAndSend_Click(sender As Object, e As EventArgs) Handles lbtnUploadAndSend.Click
    '    mv.SetActiveView(viewUploadAndSend)
    'End Sub


End Class
