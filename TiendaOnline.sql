create database TIENDAONLINE
GO
USE TIENDAONLINE
GO
CREATE  TABLE [dbo].[Productos](
	[id] [int] IDENTITY(1,1) PRIMARY KEY  NOT NULL,
	[Nombre] [varchar](200) NULL,
	[descripcion] [varchar](500) NULL,
	[referencia] [int] NULL,
	[Categoria] [varchar](20) NULL,
	[precio] [numeric](20,2) NULL
	)

GO
	CREATE  PROCEDURE [dbo].[Listar_productos]
		as 
		begin
		select * from Productos

		end

GO
	CREATE  PROCEDURE [dbo].[Insertar_Productos]
		@nombre varchar(200) null,
		@descripcion varchar (500) null,
		@referencia int        null,
		@Categoria varchar(20) null,
		@precio numeric(20,2)  null
		as
		begin
 
		 insert into Productos(Nombre,descripcion,referencia,Categoria,precio) 
		 values (@nombre,@descripcion,@referencia,@Categoria,@precio)

		 end  
GO

 CREATE  PROCEDURE [dbo].[Editar_Productos]
        @id int,
        @nombre varchar(200) null,
		@descripcion varchar (500) null,
		@referencia int        null,
		@Categoria varchar(20) null,
		@precio numeric(20,2)  null
		as
		begin
 
		  update Productos set 
    
			 Nombre =@nombre,
			 descripcion =@descripcion,
			 referencia =@referencia,
			 Categoria = @Categoria,
			 precio = @precio 

			where id = @id

		 end

GO
 CREATE PROCEDURE [dbo].[Eliminar_Productos]

	@id int 
	as
	begin
 
	   delete from Productos 
	   where id = @id

	 end

GO
 CREATE PROCEDURE [dbo].[Seleccionar_Producto]
	@id int
	as 
	begin
	select * from Productos where id =@id

	end
GO