Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Interop
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Logging
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim presionSalida, ΔP, A, dif, f, km, tolerancia, Re, Hfi, hm, hf, ht, Q, D, H, V, L, g, DD, caudal, rugo, diam, visc, fFric As Double
        ' Obtiene los valores de entrada del usuario '
        Dim caudalMaximo As Double = CDbl(txtCaudal.Text)
        Dim longitudTotal As Double = CDbl(txtLongitud.Text)
        Dim diametrotuberia As Double = CDbl(txtDiametro.Text)
        Dim rugosidadRelativa As Double = CDbl(txtRugosidad.Text)
        Dim diametroInterior As Double = diametrotuberia - 2 * rugosidadRelativa
        Dim densidad As Double = CDbl(txtFriccion.Text)
        ' Constantes necesarias '
        Const gravedad As Double = 9.81
        Const factorConversion As Double = 0.001
        Const factorFriccionInicial As Double = 0.01
        Const factorFriccionMaximo As Double = 0.01
        Const numeroMaximoIteraciones As Integer = 100
        ' Calcula el factor de fricción '
        Dim factorFriccion As Double = factorFriccionInicial
        Dim iteracionActual As Integer = 0
        Dim errorT
        H = Val(txtAltura.Text)
        L = Val(txtLongitud.Text)
        caudal = Val(txtCaudal.Text)
        rugo = Val(txtRugosidad.Text)
        diam = Val(txtDiametro.Text)
        visc = Val(txtViscocidad.Text)
        fFric = Val(txtFriccion.Text)
        Q = 0.00000001
        DD = 0.05
        g = 9.98
        D = 0
        km = 3.3
        tolerancia = 0.01
        Hfi = H
        ht = 0
        If rdbSimple.Checked = True Then
            While (caudal >= Math.Abs(Q))
                D = D + DD
                V = ((2 * (2 * g * D * Hfi) ^ 0.5) / (L) ^ 0.5) * Math.Log10((rugo / (3.7 * D)) + ((2.51 * visc * (L) ^ 0.5) / (D * (2 * g * D * Hfi) ^ 0.5)))
                A = Math.PI * D ^ 2 / 4
                Q = A * V
            End While
            MsgBox("El diametro que garantiza el caudal de diseño en una tuberia simple es " & Math.Abs(D) & " m")
            dif = 1
            hm = km * ((V ^ 2) / (2 * g))
            hf = H - hm
            Hfi = 100
            While Math.Abs(hf - Hfi) >= tolerancia
                Hfi = hf
                V = ((2 * (2 * g * D * Hfi) ^ 0.5) / (L) ^ 0.5) * Math.Log10((rugo / (3.7 * D)) + ((2.51 * visc * (L) ^ 0.5) / (D * (2 * g * D * Hfi) ^ 0.5)))
                hm = km * ((V ^ 2) / (2 * g))
                hf = H - hm
                Q = A * V
            End While
            MsgBox("El caudal que circula en la tuberia simple es " & Math.Abs(Q) & " m3/s")
        ElseIf rdbSerie.Checked = True Then
            Dim ΔPsistema As Double 'Caída de presión total del sistema
            Dim num_tuberias As Integer 'Variable para almacenar el número de tuberías que el usuario desea analizar

            Dim diametro(2) As Double 'Se crea el arreglo de diámetros con el tamaño especificado por el usuario
            Dim Caudales(2) As Double
            Dim Longitudes(2) As Double
            Dim Rugosidades(2) As Double
            Dim PresionEntrada As Double
            Dim espesorTuberia As Double
            Dim perdida_caida_presion(2) As Double
            Dim presion_disponible(2) As Double

            For i = 0 To 1 'Ciclo para llenar el arreglo con los diámetros de cada tubería
                diametro(i) = InputBox("Ingrese el diámetro de la tubería " & i + 1 & " (en metros):")
                Caudales(i) = InputBox("Ingrese el Caudal de la tubería " & i + 1 & " (en m3/s):")
                Longitudes(i) = InputBox("Ingrese la Longitud de la tubería " & i + 1 & " (en m):")
                Rugosidades(i) = InputBox("Ingrese la rugosidad de la tubería " & i + 1 & " (en m):")
                PresionEntrada = InputBox("Ingrese la presion de entrada de la tubería " & i + 1 & " (en m):")
                espesorTuberia = InputBox("Ingrese el espesor de la tubería " & i + 1 & " (en m):")
            Next i
            Dim diametroInterior1 As Double = diametro(0) - 2 * espesorTuberia
            Dim diametroInterior2 As Double = diametro(1) - 2 * espesorTuberia
            Dim rugosidadRelativa1 As Double = Rugosidades(0) / diametroInterior1
            Dim rugosidadRelativa2 As Double = Rugosidades(1) / diametroInterior2

            ' Cálculo del caudal en la primera sección de tubería '
            Dim factorFriccion1 As Double = 0
            Dim iteracionActual1 As Integer = 0

            Do
                iteracionActual1 += 1
                Dim termino1 As Double = -2 * Math.Log10((rugosidadRelativa1 / (3.7 * diametroInterior1)) + (2.51 / (gravedad ^ 0.5 * diametroInterior1 ^ 0.5 * factorFriccion1 ^ 0.25)))
                Dim termino2 As Double = (1 / factorFriccion1) ^ 0.5
                factorFriccion1 = 1 / ((termino1 ^ 2 + termino2 ^ 2) ^ 0.5)
                presion_disponible(0) = factorFriccion1
                If iteracionActual1 > numeroMaximoIteraciones Then
                    MsgBox("No se pudo calcular el factor de fricción en la primera sección después de " & iteracionActual1 & " iteraciones.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            Loop While factorFriccion1 > factorFriccionMaximo

            Dim areaTuberia1 As Double = Math.PI / 4 * diametro(0) ^ 2
            Dim velocidadMedia1 As Double = caudalMaximo / areaTuberia1
            Dim velocidad1 As Double = caudalMaximo / areaTuberia1
            Dim factorArea1 As Double = areaTuberia1 / (Math.PI / 4 * diametro(0) ^ 2)
            Dim longitudEquivalent1 As Double = Longitudes(0) * factorArea1 ^ 2 + diametroInterior1 / diametro(0) * Longitudes(0) * factorArea1 * (1 - factorArea1)
            Dim perdidaCarga1 As Double = factorFriccion

            perdidaCarga1 = factorFriccion1 * longitudEquivalent1 / diametroInterior1 * velocidad1 ^ 2 / (2 * gravedad)

            ' Cálculo del caudal en la segunda sección de tubería '
            Dim factorFriccion2 As Double = 0
            Dim iteracionActual2 As Integer = 0

            Do
                iteracionActual2 += 1
                Dim termino1 As Double = -2 * Math.Log10((rugosidadRelativa2 / (3.7 * diametroInterior2)) + (2.51 / (gravedad ^ 0.5 * diametroInterior2 ^ 0.5 * factorFriccion2 ^ 0.25)))
                Dim termino2 As Double = (1 / factorFriccion2) ^ 0.5
                factorFriccion2 = 1 / ((termino1 ^ 2 + termino2 ^ 2) ^ 0.5)
                presion_disponible(1) = factorFriccion2
                If iteracionActual2 > numeroMaximoIteraciones Then
                    MsgBox("No se pudo calcular el factor de fricción en la segunda sección después de " & iteracionActual2 & " iteraciones.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            Loop While factorFriccion2 > factorFriccionMaximo

            Dim areaTuberia2 As Double = Math.PI / 4 * diametro(1) ^ 2
            Dim velocidadMedia2 As Double = caudalMaximo / areaTuberia2
            Dim velocidad2 As Double = caudalMaximo / areaTuberia2
            Dim factorArea2 As Double = areaTuberia2 / (Math.PI / 4 * diametro(1) ^ 2)
            Dim longitudEquivalent2 As Double = Longitudes(1) * factorArea2 ^ 2 + diametroInterior2 / diametro(1) * diametro(1) * factorArea2 * (1 - factorArea2)
            Dim perdidaCarga2 As Double = factorFriccion2 * longitudEquivalent2 / diametroInterior2 * velocidad2 ^ 2 / (2 * gravedad)
            perdida_caida_presion(0) = perdidaCarga2
            ' Cálculo del caudal total '
            Dim perdidaCargaTotal As Double = perdidaCarga1 + perdidaCarga2
            Dim caudalActual As Double = caudalMaximo
            Dim caudalAnterior As Double = caudalActual

            Do
                Dim areaTuberiaActual As Double = caudalActual / velocidadMedia1
                Dim factorAreaActual As Double = areaTuberiaActual / (Math.PI / 4 * diametro(0) ^ 2)
                Dim longitudEquivalentActual As Double = Longitudes(0) * factorAreaActual ^ 2 + diametroInterior1 / diametro(0) * diametro(0) * factorAreaActual * (1 - factorAreaActual)
                Dim factorFriccionActual As Double = 0
                Dim iteracionActualActual As Integer = 0

                Do
                    iteracionActualActual += 1
                    Dim termino1 As Double = -2 * Math.Log10((rugosidadRelativa1 / (3.7 * diametroInterior1)) + (2.51 / (gravedad ^ 0.5 * diametroInterior1 ^ 0.5 * factorFriccionActual ^ 0.25)))
                    Dim termino2 As Double = (1 / factorFriccionActual = 1 / ((termino1 ^ 2 + termino2 ^ 2) ^ 0.5))

                    If iteracionActualActual > numeroMaximoIteraciones Then
                        MsgBox("No se pudo calcular el factor de fricción después de " & iteracionActualActual & " iteraciones.", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                Loop While factorFriccionActual > factorFriccionMaximo

                perdidaCarga1 = factorFriccionActual * longitudEquivalentActual / diametroInterior1 * velocidadMedia1 ^ 2 / (2 * gravedad)
                caudalActual = caudalMaximo - perdidaCargaTotal / (factorFriccionActual * longitudEquivalentActual / diametroInterior1 * velocidadMedia1 ^ 2 / (2 * gravedad) + factorFriccion2 * longitudEquivalent2 / diametroInterior2 * velocidadMedia2 ^ 2 / (2 * gravedad))
                perdida_caida_presion(1) = perdidaCarga1
                If Math.Abs(caudalActual - caudalAnterior) < 0.0001 Then
                    Exit Do
                End If

                caudalAnterior = caudalActual
            Loop

            ' Mostrar resultados '
            MsgBox(Format("caudalMaximo: " & caudalMaximo, "0.0000"))
            MsgBox(Format("perdidaCarga1: " & perdidaCarga1, "0.0000"))
            MsgBox(Format("factorFriccion1: " & factorFriccion1, "0.0000"))
            MsgBox(Format("velocidad1: " & velocidad1, "0.0000"))
            MsgBox(Format("diametroInterior1: " & diametroInterior1, "0.0000"))
            MsgBox(Format(caudalActual, "0.0000"))
            MsgBox(Format("perdidaCarga2: " & perdidaCarga2, "0.0000"))
            MsgBox(Format("factorFriccion2: " & factorFriccion2, "0.0000"))
            MsgBox(Format("velocidad2: " & velocidad2, "0.0000"))
            MsgBox(Format("diametroInterior2: " & diametroInterior2, "0.0000"))
            MsgBox(Format(caudalMaximo - caudalActual, "0.0000"))
            MsgBox(Format("perdidaCargaTotal: " & perdidaCargaTotal, "0.0000"))
            Chart1.ChartAreas.Clear()
            Chart1.Series.Clear()
            Chart1.ChartAreas.Add("Area1")

            ' Agregar los datos al chart
            Chart1.Series.Add("factor Friccion vs. pérdida de carga")
            Chart1.Series(0).ChartType = SeriesChartType.Line
            For i As Integer = 0 To num_tuberias - 1
                Chart1.Series(0).Points.AddXY(presion_disponible(i), perdida_caida_presion(i))
            Next

            ' Configurar los ejes
            Chart1.ChartAreas(0).AxisX.Title = "factor Friccion (m)"
            Chart1.ChartAreas(0).AxisY.Title = "pérdida de carga (kPa)"

            ' Mostrar el chart
            Chart1.Visible = True
        ElseIf rdbParalelo.Checked = True Then

            Dim ΔPsistema As Double 'Caída de presión total del sistema
            Dim num_tuberias As Integer 'Variable para almacenar el número de tuberías que el usuario desea analizar
            Dim PresionEntrada As Double 'Presión disponible en la entrada del sistema
            num_tuberias = InputBox("Ingrese el número de tuberías que desea analizar:") 'Se solicita al usuario el número de tuberías

            Dim diametro(num_tuberias - 1) As Double 'Se crea el arreglo de diámetros con el tamaño especificado por el usuario
            Dim Caudales(num_tuberias - 1) As Double
            Dim Longitudes(num_tuberias - 1) As Double
            Dim Rugosidades(num_tuberias - 1) As Double
            Dim perdida_caida_presion(num_tuberias - 1) As Double
            Dim presion_disponible(num_tuberias - 1) As Double
            For i = 0 To num_tuberias - 1 'Ciclo para llenar el arreglo con los diámetros de cada tubería
                diametro(i) = InputBox("Ingrese el diámetro de la tubería " & i + 1 & " (en metros):")
                Caudales(i) = InputBox("Ingrese el Caudal de la tubería " & i + 1 & " (en m3/s):")
                Longitudes(i) = InputBox("Ingrese la Longitud de la tubería " & i + 1 & " (en m):")
                Rugosidades(i) = InputBox("Ingrese la rugosidad de la tubería " & i + 1 & " (en m):")
                PresionEntrada = InputBox("Ingrese la presion de entrada de la tubería " & i + 1 & " (en m):")
            Next i
            For i = 0 To UBound(diametro) 'Iterar a través de cada tubería
                'Calcular las características de la tubería i
                Dim ε As Double 'Rugosidad de la tubería i
                D = diametro(i)
                Q = Caudales(i)
                L = Longitudes(i)
                ε = Rugosidades(i)

                ' Agregar los puntos al gráfico


                'Calcular la velocidad del fluido
                A = (3.14159 * D ^ 2) / 4 'Área de la sección transversal de la tubería i
                V = Q / A 'Velocidad del fluido en la tubería i

                'Calcular el número de Reynolds
                Re = (densidad * V * D) / rugo

                'Verificar si el flujo es laminar o turbulento
                If Re < 2300 Then
                    'Calcular la pérdida de carga utilizando la ecuación de Poiseuille
                    hf = (128 * rugo * L * Q) / (3.14159 * D ^ 4)
                ElseIf Re > 4000 Then
                    'Calcular el factor de fricción de Moody
                    f = (1.8 * Math.Log10((6.9 / Re) + ((ε / (3.7 * D)) ^ 1.11))) ^ -2
                    'Calcular la pérdida de carga utilizando la ecuación de Darcy-Weisbach
                    hf = (f * L * V ^ 2) / (2 * D * g)
                Else
                    'Calcular la pérdida de carga utilizando una combinación de las ecuaciones de Poiseuille y Darcy-Weisbach
                    hf = (((128 * rugo * L * Q) / (3.14159 * D ^ 4)) + ((f * L * V ^ 2) / (2 * D * g))) / 2
                End If
                'Calcular la caída de presión total de la tubería i
                ΔP = hf * densidad * g
                perdida_caida_presion(i) = ΔP
                presion_disponible(i) = hf
                'Acumular la caída de presión total de todas las tuberías
                ΔPsistema = ΔPsistema + ΔP
            Next i
            'Calcular la presión disponible en la salida del sistema
            presionSalida = PresionEntrada - ΔPsistema


            ' Llenar los arreglos con los datos de cada tubería
            ' ...

            ' Configurar el chart
            Chart1.ChartAreas.Clear()
            Chart1.Series.Clear()
            Chart1.ChartAreas.Add("Area1")

            ' Agregar los datos al chart
            Chart1.Series.Add("Perdida de Caida de Presion vs. pérdida de carga")
            Chart1.Series(0).ChartType = SeriesChartType.Line
            For i As Integer = 0 To num_tuberias - 1
                Chart1.Series(0).Points.AddXY(presion_disponible(i), perdida_caida_presion(i))
            Next

            ' Configurar los ejes
            Chart1.ChartAreas(0).AxisX.Title = "pérdida de carga (m)"
            Chart1.ChartAreas(0).AxisY.Title = "Pérdida de Caida de Presión (kPa)"

            ' Mostrar el chart
            Chart1.Visible = True
        ElseIf rbdMixta.Checked = True Then
            Dim ΔPsistema As Double 'Caída de presión total del sistema
            Dim num_tuberias As Integer 'Variable para almacenar el número de tuberías que el usuario desea analizar
            Dim PresionEntrada As Double 'Presión disponible en la entrada del sistema

            Dim diametro(2) As Double 'Se crea el arreglo de diámetros con el tamaño especificado por el usuario
            Dim Caudales(2) As Double
            Dim Longitudes(2) As Double
            Dim Rugosidades(2) As Double
            Dim perdida_caida_presion(2) As Double
            Dim presion_disponible(2) As Double
            For i = 0 To 1 'Ciclo para llenar el arreglo con los diámetros de cada tubería
                diametro(i) = InputBox("Ingrese el diámetro de la tubería " & i + 1 & " (en metros):")
                Caudales(i) = InputBox("Ingrese el Caudal de la tubería " & i + 1 & " (en m3/s):")
                Longitudes(i) = InputBox("Ingrese la Longitud de la tubería " & i + 1 & " (en m):")
                Rugosidades(i) = InputBox("Ingrese la rugosidad de la tubería " & i + 1 & " (en m):")
                PresionEntrada = InputBox("Ingrese la presion de entrada de la tubería " & i + 1 & " (en m):")
            Next i
            ' Cálculo de la pérdida de carga en la primera sección de la tubería '
            Dim factorFriccion1 As Double = 0.01 ' Valor inicial para el factor de fricción'
            Dim diametroInterior1 As Double = diametro(0) - 2 * Rugosidades(0)
            Dim longitudTotal1 As Double = Longitudes(0)
            Dim iteracionActual1 As Integer = 0

            Do
                iteracionActual1 += 1
                Dim termino1 As Double = -2 * Math.Log10((Rugosidades(0) / (3.7 * diametro(0)) + (2.51 / (gravedad ^ 0.5 * diametroInterior1 ^ 0.5 * factorFriccion1 ^ 0.25))))
                Dim termino2 As Double = (1 / factorFriccion1) ^ 0.5
                factorFriccion1 = 1 / ((termino1 ^ 2 + termino2 ^ 2) ^ 0.5)
                presion_disponible(0) = factorFriccion1
                If iteracionActual1 > numeroMaximoIteraciones Then
                    MsgBox("No se pudo calcular el factor de fricción en la primera sección después de " & iteracionActual1 & " iteraciones.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            Loop While factorFriccion1 > factorFriccionMaximo

            ' Cálculo de la pérdida de carga en la segunda sección de la tubería '
            Dim factorFriccion2 As Double = 0.01 ' Valor inicial para el factor de fricción'
            Dim diametroInterior2 As Double = diametro(1) - 2 * Rugosidades(1)
            Dim longitudTotal2 As Double = Longitudes(1)
            Dim iteracionActual2 As Integer = 0

            Do
                iteracionActual2 += 1
                Dim termino3 As Double = -2 * Math.Log10((Rugosidades(1) / (3.7 * diametroInterior2)) + (2.51 / (gravedad ^ 0.5 * diametroInterior2 ^ 0.5 * factorFriccion2 ^ 0.25)))
                Dim termino4 As Double = (1 / factorFriccion2) ^ 0.5
                factorFriccion2 = 1 / ((termino3 ^ 2 + termino4 ^ 2) ^ 0.5)
                presion_disponible(1) = factorFriccion2
                If iteracionActual2 > numeroMaximoIteraciones Then
                    MsgBox("No se pudo calcular el factor de fricción en la segunda sección después de " & iteracionActual2 & " iteraciones.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            Loop While factorFriccion2 > factorFriccionMaximo

            ' Cálculo de la velocidad media y el caudal de diseño '
            Dim areaTuberia1 As Double = Math.PI / 4 * diametro(0) ^ 2
            Dim areaTuberia2 As Double = Math.PI / 4 * diametro(1) ^ 2
            Dim velocidadMedia1 As Double = caudalMaximo / areaTuberia1
            Dim velocidadMedia2 As Double = caudalMaximo / areaTuberia2
            Dim velocidadMediaTotal As Double = (velocidadMedia1 * Longitudes(0) + velocidadMedia2 * Longitudes(1)) / (Longitudes(0) + Longitudes(1))
            Dim areaTotal As Double = caudalMaximo / velocidadMediaTotal
            Dim diametroTotal As Double = (4 * areaTotal / Math.PI) ^ 0.5

            ' Cálculo de la pérdida de carga total '
            Dim velocidad1 As Double = caudalMaximo / areaTuberia1
            Dim velocidad2 As Double = caudalMaximo / areaTuberia2
            Dim factorArea1 As Double = areaTuberia1 / areaTotal
            Dim factorArea2 As Double = areaTuberia2 / areaTotal
            Dim longitudEquivalent1 As Double = Longitudes(0) * factorArea1 ^ 2 + diametroInterior1 / diametroTotal * Longitudes(0) * factorArea1 * (1 - factorArea1)

            Dim longitudEquivalent2 As Double = Longitudes(1) * factorArea2 ^ 2 + diametroInterior2 / diametroTotal * Longitudes(1) * factorArea2 * (1 - factorArea2)

            Dim perdidaCarga1 As Double = factorFriccion1 * longitudEquivalent1 * velocidad1 ^ 2 / (2 * diametroInterior1 * gravedad)
            perdida_caida_presion(0) = perdidaCarga1
            Dim perdidaCarga2 As Double = factorFriccion2 * longitudEquivalent2 * velocidad2 ^ 2 / (2 * diametroInterior2 * gravedad)
            perdida_caida_presion(1) = perdidaCarga2
            Dim perdidaCargaTotal As Double = perdidaCarga1 + perdidaCarga2


            MsgBox(Format("caudalMaximo: " & caudalMaximo, "0.0000"))
            MsgBox(Format("perdidaCarga1: " & perdidaCarga1, "0.0000"))
            MsgBox(Format("factorFriccion1: " & factorFriccion1, "0.0000"))
            MsgBox(Format("velocidad1: " & velocidad1, "0.0000"))
            MsgBox(Format("diametroInterior1: " & diametroInterior1, "0.0000"))
            MsgBox(Format("perdidaCarga2: " & perdidaCarga2, "0.0000"))
            MsgBox(Format("factorFriccion2: " & factorFriccion2, "0.0000"))
            MsgBox(Format("velocidad2: " & velocidad2, "0.0000"))
            MsgBox(Format("diametroInterior2: " & diametroInterior2, "0.0000"))
            MsgBox(Format("perdidaCargaTotal: " & perdidaCargaTotal, "0.0000"))

            ' Mostrar los resultados al usuario '
            MsgBox("El diametro total es: " & diametroTotal.ToString("0.##"))
            MsgBox("La perdida de carga es: " & perdidaCargaTotal.ToString("0.##"))
            Chart1.ChartAreas.Clear()
            Chart1.Series.Clear()
            Chart1.ChartAreas.Add("Area1")

            ' Agregar los datos al chart
            Chart1.Series.Add("Factor de friccion vs. pérdida de carga")
            Chart1.Series(0).ChartType = SeriesChartType.Line
            For i As Integer = 0 To num_tuberias - 1
                Chart1.Series(0).Points.AddXY(presion_disponible(i), perdida_caida_presion(i))
            Next

            ' Configurar los ejes
            Chart1.ChartAreas(0).AxisX.Title = "Factor de friccion (m)"
            Chart1.ChartAreas(0).AxisY.Title = "pérdida de carga (kPa)"

            ' Mostrar el chart
            Chart1.Visible = True
        End If

    End Sub
    Private Sub TxtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltura.KeyPress, txtCaudal.KeyPress, txtDiametro.KeyPress, txtFriccion.KeyPress, txtRugosidad.KeyPress, txtViscocidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
        End If
    End Sub

End Class
