create procedure Top5ProductosVendidos2
as 
begin
select top 5 p.nombre as Producto, sum(cantidad_detalle) as Cantidad from detalles_factura f
inner join talle_producto t on f.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
group by t.cod_producto, p.nombre
order by sum(cantidad_detalle) desc
end

Create procedure MostrarTop5Vendidos
as
begin
select top 5 p.nombre as Producto, Concat('$ ', f.importe_detalle) as Precio, sum(cantidad_detalle) as "Vendidos",  Concat('$ ', Sum(f.importe_detalle)) as "Ventas Netas" from detalles_factura f
inner join talle_producto t on f.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
group by t.cod_producto, p.nombre, f.importe_detalle
order by sum(cantidad_detalle) desc, f.importe_detalle desc
end

create procedure VentasDiarias
@fechaHoy date
as 
begin
select id_factura as "N° Factura", Concat(e.apellido, ' ', e.nombre) as Vendedor, CONCAT(c.Apellido, c.Nombre) as Cliente, f.fecha_factura as Fecha, f.cantidad_factura as Cantidad, concat('$', f.importe_factura) as Total from factura f
inner join Usuarios u  on u.id_Usuario = f.id_usuario
inner join empleados e on e.Id_empleado = u.id_empleado
inner join clientes c on f.id_cliente = c.Id_Cliente
where f.fecha_factura = @fechaHoy
end


create procedure VentasPorVendedor
as 
begin
select concat(e.apellido, ' ', e.nombre) as Vendedor, count(*) as Ventas, concat('$ ', sum(f.importe_factura)) as 'Montos Ganados' from factura f
inner join Usuarios u  on u.id_Usuario = f.id_usuario
inner join empleados e on e.Id_empleado = u.id_empleado
group by e.apellido, e.nombre
order by sum(f.importe_factura) desc
end

create procedure VentasPorVendedorFiltradoPorFecha2
@min date,
@max date
as 
begin
select concat(e.apellido, ' ', e.nombre) as Vendedor, count(*) as Ventas, concat('$ ', sum(f.importe_factura)) as 'Montos Ganados' from factura f
inner join Usuarios u  on u.id_Usuario = f.id_usuario
inner join empleados e on e.Id_empleado = u.id_empleado
where f.fecha_factura >= convert(date,getdate()) and f.fecha_factura <= convert(date,getdate())
group by e.apellido, e.nombre
order by sum(f.importe_factura) asc
end

create procedure VentasPorVendedorFiltradoPorFecha(@min date,@max date)
as 
begin
select concat(e.apellido, ' ', e.nombre) as Vendedor, count(*) as Ventas, concat('$ ', sum(f.importe_factura)) as 'Montos Ganados' from factura f
inner join Usuarios u  on u.id_Usuario = f.id_usuario
inner join empleados e on e.Id_empleado = u.id_empleado
where f.fecha_factura >= convert(date,getdate()) and f.fecha_factura <= convert(date,getdate())
group by e.apellido, e.nombre
order by sum(f.importe_factura) asc
end


create procedure VentasPorCategoria
as 
begin
select c.descripcion_categoria as Categoria, sum(cantidad_detalle) as 'Unidades Vendidas', sum(f.importe_detalle) as 'Monto Ganado' from detalles_factura f
inner join talle_producto t on f.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
inner join Categoria c on p.id_categoria = c.id_categoria
group by p.id_categoria, c.descripcion_categoria
order by sum(cantidad_detalle) desc
end


create procedure VentasPorCategoriaFecha
@fdesde date,
@fhasta date
as 
begin
select c.descripcion_categoria as Categoria, sum(cantidad_detalle) as 'Unidades Vendidas', sum(dt.importe_detalle) as 'Monto Ganado' 
from detalles_factura dt
inner join talle_producto t on dt.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
inner join Categoria c on p.id_categoria = c.id_categoria
inner join factura f on dt.id_factura = f.id_factura
where f.fecha_factura >= @fdesde and f.fecha_factura <= @fhasta 
group by p.id_categoria, c.descripcion_categoria
order by sum(dt.cantidad_detalle) desc
end

create procedure VentasPorMarca
as 
begin
select m.Descripcion as Marca, sum(cantidad_detalle) as 'Unidades Vendidas', sum(dt.importe_detalle) as 'Monto Ganado'  from detalles_factura dt
inner join talle_producto t on dt.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
inner join Marcas m on p.id_marca = m.id_Marca
inner join factura f on dt.id_factura = f.id_factura
group by p.id_marca, m.Descripcion
order by sum(dt.cantidad_detalle) desc
end


create procedure VentasPorMarcaFecha
@fdesde date,
@fhasta date
as 
begin
select m.Descripcion as Marca, sum(dt.cantidad_detalle) as 'Unidades Vendidas', sum(dt.importe_detalle) as 'Monto Ganado' from detalles_factura dt
inner join talle_producto t on dt.id_talle_prod = t.id_talle_prod
inner join Productos p on t.cod_producto = p.cod_producto
inner join Marcas m on p.id_marca = m.id_Marca
inner join factura f on dt.id_factura = f.id_factura
where f.fecha_factura >= @fdesde and f.fecha_factura <= @fhasta 
group by p.id_marca, m.Descripcion
order by sum(dt.cantidad_detalle) desc
end


create procedure VentasFiltradas
@desde date,
@hasta date
as
begin
select f.id_factura as 'N° Factura', concat(e.apellido, ' ',e.nombre) as 'Vendedor', concat(c.Apellido, c.Nombre), f.fecha_factura as Fecha, f.importe_factura as Total, f.cantidad_factura as Cantidad  from factura f
inner join clientes c on f.id_cliente = c.Id_Cliente
inner join Usuarios u on f.id_usuario = u.id_Usuario
inner join empleados e on u.id_Usuario = e.Id_empleado
--where f.fecha_factura >= @desde and f.fecha_factura <= @hasta
where f.fecha_factura >= '18/11/2022' and f.fecha_factura <= '18/11/2022'
end

create procedure VentasNetas
@desde date,
@hasta date
as 
begin
declare @d int = 0
select  ROW_NUMBER() OVER(ORDER BY f.fecha_factura) as 'N°', f.fecha_factura as 'Fecha', sum(f.importe_factura) as 'Ventas Netas' from factura f
inner join clientes c on f.id_cliente = c.Id_Cliente
inner join Usuarios u on f.id_usuario = u.id_Usuario
inner join empleados e on u.id_Usuario = e.Id_empleado
where f.fecha_factura >= @desde and f.fecha_factura <= @hasta
group by f.fecha_factura
order by f.fecha_factura asc
end























select concat(e.apellido, ' ', e.nombre) as Vendedor, count(*) as Ventas, concat('$ ', sum(f.importe_factura)) as "Montos Ganados" from factura f
inner join Usuarios u  on u.id_Usuario = f.id_usuario
inner join empleados e on e.Id_empleado = u.id_empleado
where fecha_factura >= '16/11/2022' and fecha_factura <= '17/11/2022'
group by e.apellido, e.nombre
order by "Montos Ganados" asc

