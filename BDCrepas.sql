create database esp32;
use esp32;
create table ejemplo (id serial primary key, sensor varchar(10), valor int);
select * from ejemplo;

drop database crepas;

create database crepas;
use crepas;

CREATE TABLE IF NOT EXISTS Productos (
  idProductos int auto_increment primary key primary key,
  NombreP VARCHAR(45) NOT NULL,
  Precio INT NOT NULL,
  seccion varchar(20) NOT NULL);

insert into Productos(NombreP, Precio,seccion) values("crepa_Dulce_Especial",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Crepizza",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Salada_Especial",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Dulce_Tropical",35,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Tropical",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Tres_Quesos",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Crepastor",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Helado",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Costa_de_Amor",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Tres_Moras",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Platano_con_Durazno",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Dulce_Especial",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Napolitana",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Helado_Vainilla",40,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Rinc_Oreo",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Dulce_Especial",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Galleta_Oreo",35,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("crepa_Platano_con_cajeta",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Philadelphia_con_Mermelada_de_Frambuesa",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Philadelphia_con_Mermelada_de_Fresa",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Philadelphia_con_Mermelada_de_Zarzamora",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Philadelphia_con_Jamon",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Philadelphia_con_Mermelada_de_Fresa",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Nutella_con_nuez",30,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Nutella_con_platano",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Nutella_con_Fresa",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Nutella_con_durazno",25,"Creapa");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Moka_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Moka_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Vainilla_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Vainilla_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Cafe_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Cafe_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Galleta_oreo_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Galleta_oreo_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Rompope_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Rompope_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_ChocoRoll_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_ChocoRoll_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Mazapan_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Mazapan_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Chocolate_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Chocolate_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Capuchino_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Capuchino_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Fresa_chico",20,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Frappes_Fresa_Grande",25,"Frappe");
insert into Productos(NombreP, Precio,seccion) values("Waffle_Tradicional",30,"Waffle");
insert into Productos(NombreP, Precio,seccion) values("Waffle_Minis",25,"Waffle");
insert into Productos(NombreP, Precio,seccion) values("Chamoyadas_con_Caribe",45,"Chamoyadas");
insert into Productos(NombreP, Precio,seccion) values("Chamoyadas_Chica",20,"Chamoyadas");
insert into Productos(NombreP, Precio,seccion) values("Chamoyadas_Grande",25,"Chamoyadas");

select * from Productos;

CREATE TABLE IF NOT EXISTS Pedidos (
  idPedidos serial,
  idLista INT NOT NULL,
  fecha DATE NOT NULL,
  TipoPedido VARCHAR(9) NOT NULL,
  idProductos INT NOT NULL,
  Cliente varchar(20) NOT NULL,
  direccion varchar(50));
ALTER TABLE Pedidos ADD constraint pk_id_Pedidos_Lista_Productos primary key (idPedidos, idLista, idProductos);
ALTER TABLE Pedidos ADD constraint fk_idProductos FOREIGN KEY (idProductos) REFERENCES Productos (idProductos);

INSERT INTO Pedidos(idLista, fecha, TipoPedido, idProductos, Cliente, direccion) VALUES(1,'2020-07-20',"Local", 2, "Juan", "");

select * from Pedidos;
SELECT Pedidos.idLista, Productos.NombreP FROM Pedidos, Productos WHERE idLista=1 AND Pedidos.idProductos = Productos.idProductos;
DELETE FROM Pedidos WHERE idPedidos=2;