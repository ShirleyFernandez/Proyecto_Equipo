create database esp32;
use esp32;
create table ejemplo (id serial primary key, sensor varchar(10), valor int);
select * from ejemplo;

drop database crepas;

CREATE database crepas;
Use crepas;


/*CREAMOS LA TABLA PRODUCTOS*/
Create  table CATALOGO_PRODUCTOS(
idProductos INT NOT NULL PRIMARY KEY, /*Definimos Llave Primaria*/
Nombre VARCHAR(40),
Precio INT NOT NULL,
categoria VARCHAR (30))
ENGINE = InnoDB;

/*INSERCION DE NUESTROS PRODUCTOS*/
				/*CREPAS*/
insert into CATALOGO_PRODUCTOS values(1,"Dulce_Especial",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(2,"Crepizza",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(3,"Salada_Especial",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(4,"Dulce_Tropical",35,"CREPA");
insert into CATALOGO_PRODUCTOS values(5,"Tropical",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(6,"Tres_Quesos",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(7,"Crepastor",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(8,"Crepa_Helado",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(9,"Costa_de_Amor",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(10,"Tres_Moras",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(11,"Platano_con_Durazno",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(12,"Dulce_Especial",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(13,"Napolitana",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(14,"Helado_Vainilla",40,"CREPA");
insert into CATALOGO_PRODUCTOS values(15,"Rinc-Oreo",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(16,"Dulce_Especial",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(17,"Galleta_Oreo",35,"CREPA");
insert into CATALOGO_PRODUCTOS values(18,"Platano_con_Cajeta",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(19,"Philadelphia",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(20,"Philadelphia_con_MFrambuesa",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(21,"Philadelphia_con_MFresa",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(22,"Philadelphia_con_MZarzamora",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(23,"Philadelphia_con_Jamon",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(24,"Nutella",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(25,"Nutella_con_nuez",30,"CREPA");
insert into CATALOGO_PRODUCTOS values(26,"Nutella_con_platano",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(27,"Nutella_con_Fresa",25,"CREPA");
insert into CATALOGO_PRODUCTOS values(28,"Nutella_con_durazno",25,"CREPA");

/*BEBIDAS Y/O FRAPPES*/
insert into CATALOGO_PRODUCTOS values(29,"MokaC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(30,"MokaG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(31,"VainillaC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(32,"VainillaG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(33,"CaféC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(34,"CaféG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(35,"Galleta_OreoC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(36,"Galleta_OreoG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(37,"RompopeC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(38,"RompopeG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(39,"ChocoRollC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(40,"ChocoRollG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(41,"MazapánC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(42,"MazapánG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(43,"ChocolateC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(44,"ChocolateG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(45,"CapuchinoC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(46,"CapuchinoG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(47,"FresaC",20,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(48,"FresaG",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(49,"RompopeC",25,"FRAPPE");
insert into CATALOGO_PRODUCTOS values(50,"RompopeG",25,"FRAPPE");

/*OTROS PRODUCTOS*/
insert into CATALOGO_PRODUCTOS values(51,"Waffle_Tradicional",30,"OTROS");
insert into CATALOGO_PRODUCTOS values(52,"Waffle_Minis",25,"OTROS");
insert into CATALOGO_PRODUCTOS values(53,"ChamoyadasCaribe",45,"OTROS");
insert into CATALOGO_PRODUCTOS values(54,"ChamoyadaC",20,"OTROS");
insert into CATALOGO_PRODUCTOS values(55,"ChamoyadaG",25,"OTROS");



/*CREAMOS LA TABLA CLIENTES*/
CREATE TABLE IF NOT EXISTS CLIENTES (
  idClientes INT auto_increment  PRIMARY KEY, /*Definimos Llave Primaria*/
  Nombre VARCHAR(45) NULL,
  Direccion VARCHAR(45) NULL)
  ENGINE = InnoDB;
  

/*CREAMOS LA TABLA PEDIDOS*/
CREATE TABLE IF NOT EXISTS PEDIDOS(
idPedidos INT not null PRIMARY KEY,  /*Definimos Llave Primaria*/
Cantidad INT NOT NULL,
Tipo_Pedido VARCHAR(45) NOT NULL,
Estado_Pedido VARCHAR(40),
/*La tabla requiere de otras dos tablas con respecto a los campos, entonces definimos las relaciones como Llaves Foraneas*/
FK_idProd INT NOT NULL,
FK_idCli INT NOT NULL)
ENGINE = InnoDB;
/*Asignamos llaves foraneas y referencias a las tablas correspondientes*/
/*Productos_idProd*/
ALTER TABLE CATALOGO_PRODUCTOS ADD INDEX (idProductos);
ALTER TABLE PEDIDOS ADD FOREIGN KEY (FK_idProd) REFERENCES CATALOGO_PRODUCTOS(idProductos);
/*Clientes_idCli*/
ALTER TABLE CLIENTES ADD INDEX (idClientes);
ALTER TABLE PEDIDOS ADD FOREIGN KEY (FK_idCli) REFERENCES CLIENTES(idClientes);

/*CREAMOS LA TABLA VENTAS*/
CREATE TABLE IF NOT EXISTS VENTAS(
id_Ventas INT NOT NULL PRIMARY KEY,
FechaV DATE,
FK_idPedidos INT NOT NULL, /*de acuerdo a la tabla pedidos --su id-- estos se concatenan y se almacenan en este campo*/
FK_idProd INT NOT NULL,
FK_idCli INT NOT NULL)
ENGINE = InnoDB;
/*AQUI FALTA AGREGAR LOS ADD INDEX*/
ALTER TABLE VENTAS ADD foreign key(FK_idPedidos) REFERENCES PEDIDOS(idPedidos);
ALTER TABLE VENTAS ADD foreign key(FK_idProd) REFERENCES PEDIDOS(FK_idProd);
ALTER TABLE VENTAS ADD foreign key(FK_idCli) REFERENCES PEDIDOS(FK_idCli);

select * from CATALOGO_PRODUCTOS;
DELETE FROM CATALOGO_PRODUCTOS WHERE idProductos=1;

INSERT INTO CLIENTES (Nombre,Direccion)VALUES("CLIENTE A","");
INSERT INTO CLIENTES VALUES('',"CLIENTE B","Mariano_Matamoros_69");
SELECT * FROM CLIENTES;

INSERT INTO PEDIDOS(idPedidos,Cantidad,Tipo_Pedido,Estado_Pedido,FK_idProd,FK_idCli) VALUES(1,2,"LOCAL","PREPARACIÓN",5,1);

INSERT INTO VENTAS(id_Ventas,FechaV,FK_idPedidos,FK_idProd,FK_idCli) VALUES(1,'2020-07-24',1,5,1);