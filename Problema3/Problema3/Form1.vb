Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim vector(0) As String
        Dim vector1(0) As String
        Dim edad As Integer = 0
        Dim h As Integer = 0
        Dim m As Integer = 0
        Dim porcentajeH As Integer = 0
        Dim porcentajeM As Integer = 0
        Dim b As Boolean = False
        Dim cont1 As Integer = 0
        Do
            lsbImpresiones.Items.Clear()
            ReDim vector(cont1)
            ReDim vector1(cont1)
            vector(cont1) = InputBox("Ingrese su genero 1.Mujer, 2.Hombre, 0.Mostrar", "Cargar Datos")
            If Val(vector(vector.Length - 1)) = 0 Then
                b = True
                lsbImpresiones.Items.Add("el porcentaje de hombres mayores a " & vbCrLf & " 40 años es " & porcentajeH & vbCrLf & "% y la cantidad de ellos es " & h)
                lsbImpresiones.Items.Add("el porcentaje de mujeres entre 18 y 25 años es " & porcentajeM & vbCrLf & "% y la cantidad de ellas es " & m)
                Exit Do
            End If
            'lsbImpresiones.Items.Add(vector(cont1))
            vector1(cont1) = InputBox("Ingrese su edad", "Cargar Datos")
            cont1 += 1
            For i = 0 To vector.Length - 1
                If Val(vector(i)) = 2 And Val(vector1(i)) > 40 Then
                    Dim f As Integer
                    f += 1
                    h = f
                    edad += 1
                    porcentajeH = (f / edad) * 100
                    If porcentajeM > porcentajeH Then
                        porcentajeM = Math.Abs(porcentajeM - porcentajeH)
                    ElseIf porcentajeM < porcentajeH Then
                        porcentajeM = Math.Abs(porcentajeH - porcentajeM)
                    ElseIf porcentajeM = porcentajeH Then
                        porcentajeM = Math.Abs(porcentajeH - porcentajeM)
                    End If
                ElseIf Val(vector(i)) = 1 And Val(vector1(i)) >= 18 And Val(vector1(i)) <= 25 Then
                    Dim j As Integer
                    j += 1
                    m = j
                    edad += 1
                    porcentajeM = (j / edad) * 100
                    If porcentajeH > porcentajeM Then
                        porcentajeH = Math.Abs(porcentajeH - porcentajeM)
                    ElseIf porcentajeH < porcentajeM Then
                        porcentajeH = Math.Abs(porcentajeM - porcentajeH)
                    ElseIf porcentajeH = porcentajeM Then
                        porcentajeH = Math.Abs(porcentajeM - porcentajeH)
                    End If

                ElseIf Val(vector(vector.Length - 1)) = 0 Then
                    b = True
                End If
            Next
        Loop While b = False
    End Sub
End Class