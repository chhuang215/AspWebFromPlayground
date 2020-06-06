Imports Microsoft.VisualBasic

Public Class MsgMain

    Public Property ID() As Integer
    Public Property Message() As String
    Public Property CreateDate() As Date
    Public Sub New()
        ID = -1
        Message = String.Empty
        CreateDate = Nothing
    End Sub

End Class
