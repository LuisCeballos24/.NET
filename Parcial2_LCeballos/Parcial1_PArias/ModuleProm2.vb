Module ModuleProm2
    Public Function PendienteRecta(ByVal x1 As Decimal, ByVal x2 As Decimal, ByVal y1 As Decimal, ByVal y2 As Decimal) As Decimal
        PendienteRecta = Format(((y2 - y1) / (x2 - x1)), "##0.00")
    End Function
End Module
