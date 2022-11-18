Imports System.Data
Imports System.Data.SqlClient
    Imports System.Collections
Public Class VentasPorMarca

    Dim conexion = New SqlConnection("server=ABI\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ReportePorCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTDesde.Value = Date.Today
        DTHasta.Value = Date.Today
        cargarGridVentas()
    End Sub


    Private Sub cargarGridVentas()
        cmd = New SqlCommand("VentasPorMarca", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.open()
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Data As DataTable = New DataTable()
        dr.Close()
        da.Fill(Data)
        da.Dispose()
        conexion.Close()
        dgvListaCategorias.DataSource = Data
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Dim desde As Date = CDate(DTDesde.Value.Date)
        Dim hasta As Date = CDate(DTHasta.Value.Date)
        cargarGridVentasPorFechas(desde, hasta)
    End Sub


    Private Sub cargarGridVentasPorFechas(desde As Date, hasta As Date)
        cmd = New SqlCommand("VentasPorMarcaFecha", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fdesde", desde)
        cmd.Parameters.AddWithValue("@fhasta", hasta)
        conexion.open()
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Data As DataTable = New DataTable()
        dr.Close()
        da.Fill(Data)
        da.Dispose()
        conexion.Close()
        dgvListaCategorias.DataSource = Data
    End Sub

    Private Sub CPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPeriodo.SelectedIndexChanged
        Dim elec As Integer = CInt(CBPeriodo.SelectedIndex.ToString)
        Dim fecDesde As Date
        Dim fecHasta As Date = Date.Today
        Dim numdia As Integer = CInt(fecHasta.DayOfWeek)
        If elec = 0 Then
            If numdia = 1 Then
                fecDesde = fecHasta
            ElseIf numdia = 2 Then
                fecDesde = fecHasta.AddDays(-2)
            ElseIf numdia = 3 Then
                fecDesde = fecHasta.AddDays(-3)
            ElseIf numdia = 4 Then
                fecDesde = fecHasta.AddDays(-4)
            ElseIf numdia = 5 Then
                fecDesde = fecHasta.AddDays(-5)
            End If
            cargarGridVentasPorFechas(fecDesde, fecHasta)
        End If
        If elec = 1 Then
            fecDesde = PrimerDiaDelMes(fecHasta)
            cargarGridVentasPorFechas(fecDesde, fecHasta)
        End If
        If elec = 2 Then
            fecDesde = PrimerDiaDelMes(fecHasta.AddMonths(-2))
            cargarGridVentasPorFechas(fecDesde, fecHasta.AddDays(1))
        End If
    End Sub

    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    Private Sub ReportePorVendedores_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        cargarGridVentas()
        CBPeriodo.ResetText()
        CBPeriodo.SelectedIndex = -1
    End Sub
End Class