﻿Imports System.Data.SqlClient
Public Class FormMovimientos
    Dim da As SqlDataAdapter

    Private Sub rdbDeposito_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDepositos.CheckedChanged
        ConsultarDeposito()
    End Sub

    Private Sub rdbRetiros_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRetiros.CheckedChanged
        Dim dt As New DataTable
        Dim query As String = "SELECT m.id_cuenta As 'ID Cuenta', c.tipo As Tipo, m.deposito As Depósito, m.fecha As Fecha"
        query &= " From tbl_datoscliente d"
        query &= " INNER JOIN tbl_cuenta c ON d.id_cliente = c.id_cliente"
        query &= " INNER JOIN tbl_movimientos m ON c.id_cuenta = m.id_cuenta"
        query &= " WHERE d.id_cliente = " & idUsuario & " AND m.retiro IS NOT null;"
        da = New SqlDataAdapter(query, mYConn)
        da.Fill(dt)
        If dt.Rows.Count Then
            dtgMovimientos.DataSource = dt
        End If
        If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
    End Sub

    Private Sub FormMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarDeposito()
    End Sub

    Private Sub ConsultarDeposito()
        Dim dt As New DataTable
        Dim query As String = "SELECT m.id_cuenta As 'ID Cuenta', c.tipo As Tipo, m.retiro As Retiro, m.fecha As Fecha"
        query &= " From tbl_datoscliente d"
        query &= " INNER JOIN tbl_cuenta c ON d.id_cliente = c.id_cliente"
        query &= " INNER JOIN tbl_movimientos m ON c.id_cuenta = m.id_cuenta"
        query &= " WHERE d.id_cliente = " & idUsuario & " AND m.deposito IS NOT null;"
        da = New SqlDataAdapter(query, mYConn)
        da.Fill(dt)
        If dt.Rows.Count Then
            dtgMovimientos.DataSource = dt
        End If
        If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class