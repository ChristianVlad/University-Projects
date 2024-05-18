USE LABORATORIO03

CREATE TABLE LIBROS(
codigo_libro INT,
titulo_libro VARCHAR(100),
isbn VARCHAR(100),
fecha_edicion VARCHAR(100),
nombre_autor_libro VARCHAR(100),
apellido_autor_libro VARCHAR(100),
fecha_nacimiento_autor VARCHAR(100),
descripcion_libro VARCHAR(100)
);

SELECT * FROM LIBROS

INSERT INTO LIBROS (codigo_libro, titulo_libro, isbn, fecha_edicion, nombre_autor_libro, apellido_autor_libro, fecha_nacimiento_autor, descripcion_libro)
VALUES
(1, 'El principito', '978-84-207-6207-7', '1943-04-06', 'Antoine', 'de Saint-Exupéry', '1900-06-29', 'Una novela filosófica y poética.'),
(2, 'Cien años de soledad', '978-84-376-0494-7', '1967-05-30', 'Gabriel', 'García Márquez', '1927-03-06', 'Una novela que narra la historia de la familia Buendía en Macondo.'),
(3, '1984', '978-88-04-69315-4', '1949-06-08', 'George', 'Orwell', '1903-06-25', 'Una novela distópica que presenta un futuro totalitario y vigilante.');


CREATE PROCEDURE sp_RegistrarLibro(
@codigo_libro INT,
@titulo_libro VARCHAR(100),
@isbn VARCHAR(100),
@fecha_edicion VARCHAR(100),
@nombre_autor_libro VARCHAR(100),
@apellido_autor_libro VARCHAR(100),
@fecha_nacimiento_autor VARCHAR(100),
@descripcion_libro VARCHAR(100) 
)
AS
BEGIN
	INSERT INTO LIBROS(codigo_libro, titulo_libro, isbn, fecha_edicion, nombre_autor_libro, apellido_autor_libro, fecha_nacimiento_autor, descripcion_libro)
	VALUES (@codigo_libro, @titulo_libro, @isbn, @fecha_edicion, @nombre_autor_libro, @apellido_autor_libro, @fecha_nacimiento_autor, @descripcion_libro)
END

CREATE PROCEDURE sp_EditarLibro(
@codigo_libro INT,
@titulo_libro VARCHAR(100),
@isbn VARCHAR(100),
@fecha_edicion VARCHAR(100),
@nombre_autor_libro VARCHAR(100),
@apellido_autor_libro VARCHAR(100),
@fecha_nacimiento_autor VARCHAR(100),
@descripcion_libro VARCHAR(100) 
)
AS
BEGIN
	UPDATE LIBROS 
	SET titulo_libro = @titulo_libro,
	    isbn = @isbn,
	    fecha_edicion = @fecha_edicion,
	    nombre_autor_libro = @nombre_autor_libro,
	    apellido_autor_libro = @apellido_autor_libro,
	    fecha_nacimiento_autor = @fecha_nacimiento_autor,
	    descripcion_libro = @descripcion_libro
	WHERE codigo_libro = @codigo_libro
END

CREATE PROCEDURE sp_EliminarLibro(
@codigo_libro INT
)
AS
BEGIN
	DELETE FROM LIBROS WHERE codigo_libro = @codigo_libro
END



CREATE PROCEDURE SP_DeleteTicket
    @Id_Ticket INT
AS
BEGIN
    -- Delete the ticket from the TicketsMaster table
    DELETE FROM Tickets WHERE Id_Ticket = @Id_Ticket;
END
DROP PROCEDURE IF EXISTS SP_DeleteTicket;
