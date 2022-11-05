Public Class ClaseProm1
    Dim p1, p2, p3, total, porcentaje As Decimal
    Public Sub Asignar(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Decimal)
        p1 = a
        p2 = b
        p3 = c
    End Sub

    Public Function Pasa() As Decimal
        Pasa = (p1 + p2 + p3) * 60 / 300
        total = Pasa
    End Function

    Public Function CalcularA() As Decimal
        porcentaje = 0
        porcentaje = 91 - total
        CalcularA = Format(porcentaje * 100 / 40, "##0.00")
    End Function
    Public Function CalcularB() As Decimal
        porcentaje = 0
        porcentaje = 81 - total
        CalcularB = Format(porcentaje * 100 / 40, "##0.00")
    End Function
    Public Function CalcularC() As Decimal
        porcentaje = 0
        porcentaje = 71 - total
        CalcularC = Format(porcentaje * 100 / 40, "##0.00")
    End Function
    Public Function CalcularD() As Decimal
        porcentaje = 0
        porcentaje = 61 - total
        CalcularD = Format(porcentaje * 100 / 40, "##0.00")
    End Function
End Class
