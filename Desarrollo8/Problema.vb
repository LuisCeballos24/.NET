Module Problema
    Public Sub MultiplosDeTres(ByVal inicio As Integer, ByVal final As Integer, ByRef sumatoria As Integer)
        Dim contador As Integer
        sumatoria = 0
        For contador = inicio To final
            If contador Mod 3 = 0 Then
                sumatoria += contador

            End If
        Next
    End Sub
End Module
