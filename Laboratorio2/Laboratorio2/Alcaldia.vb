Public Class Alcaldia
    Private alcalde(3) As Integer

    Public Sub cargarAlcaldes(ByVal alcalde1 As Integer, ByVal alcalde2 As Integer, ByVal alcalde3 As Integer, ByVal alcalde4 As Integer)
        alcalde(0) = alcalde1
        alcalde(1) = alcalde2
        alcalde(2) = alcalde3
        alcalde(3) = alcalde4
    End Sub

    Public Function calcularMayor() As String
        Dim indice As Integer

        For i = 0 To alcalde.Length - 1
            If alcalde(i) = alcalde.Max Then
                indice = i
                Exit For
            End If
        Next

        Return numeroDeAlcalde(indice)
    End Function

    Public Function calcularMenor() As String
        Dim indice As Integer

        For i = 0 To alcalde.Length - 1
            If alcalde(i) = alcalde.Min Then
                indice = i
                Exit For
            End If
        Next

        Return numeroDeAlcalde(indice)
    End Function

    Private Function numeroDeAlcalde(ByVal alcalde As Integer)
        Select Case alcalde
            Case 0
                Return "Alcalde 1"
            Case 1
                Return "Alcalde 2"
            Case 2
                Return "Alcalde 3"
            Case 3
                Return "Alcalde 4"
            Case Else
                Return "Alcalde Incorrecto"
        End Select
    End Function

End Class
