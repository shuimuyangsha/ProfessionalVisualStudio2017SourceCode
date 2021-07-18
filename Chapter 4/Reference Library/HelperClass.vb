Public Class HelperClass

    Public Function HelpWithNumbers(i As Integer, j As Integer) As Integer
        Return i * j
    End Function

    Public Function MoreHelpWithNumbers(i As Integer, j As Integer, k As Integer) As Integer
        Return HelpWithNumbers(i, j) * HelpWithNumbers(j, k)
    End Function
End Class

Public Class Customer
    Property Name As String
    Property Orders As List(Of Order)

    Public Sub New()
        'Orders = New List(Of Order)
    End Sub

End Class

Public Class Order
    Property Description As String

End Class