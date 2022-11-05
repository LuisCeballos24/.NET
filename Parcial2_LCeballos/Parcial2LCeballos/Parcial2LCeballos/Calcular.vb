Public Class Calcular
    Dim parcial1, parcial2, parcial3, total, porcentaje As Decimal
    Public Sub Asignar(ByVal p1 As Decimal, ByVal p2 As Decimal, ByVal p3 As Decimal)
        parcial1 = p1
        parcial2 = p2
        parcial3 = p3
    End Sub
    Public Function Aprueba() As Decimal
        Aprueba = (parcial1 + parcial2 + parcial3) * 60 / 300
        total = Aprueba
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
