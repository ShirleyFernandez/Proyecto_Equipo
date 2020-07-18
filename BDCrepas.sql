create database esp32;
use esp32;
create table ejemplo (id serial primary key, sensor varchar(10), valor int);
select * from ejemplo;

create database crepas;
use crepas;

CREATE TABLE IF NOT EXISTS Productos (
  idProductos int auto_increment primary key primary key,
  Nombre VARCHAR(45) NOT NULL,
  Precio INT NOT NULL);

insert into Productos(Nombre, Precio) values("crepa_Dulce_Especial",30);
insert into Productos(Nombre, Precio) values("crepa_Crepizza",30);
insert into Productos(Nombre, Precio) values("crepa_Salada_Especial",40);
insert into Productos(Nombre, Precio) values("crepa_Dulce_Tropical",35);
insert into Productos(Nombre, Precio) values("crepa_Tropical",30);
insert into Productos(Nombre, Precio) values("crepa_Tres_Quesos",40);
insert into Productos(Nombre, Precio) values("crepa_Crepastor",40);
insert into Productos(Nombre, Precio) values("crepa_Helado",40);
insert into Productos(Nombre, Precio) values("crepa_Costa_de_Amor",25);
insert into Productos(Nombre, Precio) values("crepa_Tres_Moras",30);
insert into Productos(Nombre, Precio) values("crepa_Platano_con_Durazno",30);
insert into Productos(Nombre, Precio) values("crepa_Dulce_Especial",30);
insert into Productos(Nombre, Precio) values("crepa_Napolitana",40);
insert into Productos(Nombre, Precio) values("crepa_Helado_Vainilla",40);
insert into Productos(Nombre, Precio) values("crepa_Rinc_Oreo",25);
insert into Productos(Nombre, Precio) values("crepa_Dulce_Especial",25);
insert into Productos(Nombre, Precio) values("crepa_Galleta_Oreo",35);
insert into Productos(Nombre, Precio) values("crepa_Platano_con_cajeta",25);
insert into Productos(Nombre, Precio) values("Philadelphia_con_Mermelada_de_Frambuesa",25);
insert into Productos(Nombre, Precio) values("Philadelphia_con_Mermelada_de_Fresa",25);
insert into Productos(Nombre, Precio) values("Philadelphia_con_Mermelada_de_Zarzamora",25);
insert into Productos(Nombre, Precio) values("Philadelphia_con_Jamon",25);
insert into Productos(Nombre, Precio) values("Philadelphia_con_Mermelada_de_Fresa",25);
insert into Productos(Nombre, Precio) values("Nutella_con_nuez",30);
insert into Productos(Nombre, Precio) values("Nutella_con_platano",25);
insert into Productos(Nombre, Precio) values("Nutella_con_Fresa",25);
insert into Productos(Nombre, Precio) values("Nutella_con_durazno",25);
insert into Productos(Nombre, Precio) values("Frappes_Moka_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Moka_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Vainilla_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Vainilla_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Cafe_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Cafe_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Galleta_oreo_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Galleta_oreo_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Rompope_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Rompope_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_ChocoEoll_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_ChocoEoll_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Mazapan_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Mazapan_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Chocolate_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Chocolate_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Capuchino_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Capuchino_Grande",25);
insert into Productos(Nombre, Precio) values("Frappes_Fresa_chico",20);
insert into Productos(Nombre, Precio) values("Frappes_Fresa_Grande",25);
insert into Productos(Nombre, Precio) values("Waffle_Tradicional",30);
insert into Productos(Nombre, Precio) values("Waffle_Minis",25);
insert into Productos(Nombre, Precio) values("Chamoyadas_con_Caribe",45);
insert into Productos(Nombre, Precio) values("Chamoyadas_Chica",20);
insert into Productos(Nombre, Precio) values("Chamoyadas_Grande",25);

select * from Productos;

CREATE TABLE IF NOT EXISTS Clientes (
  idClientes INT NOT NULL,
  Nombre VARCHAR(45) NOT NULL,
  Direccion VARCHAR(45));
  
alter table Clientes add constraint pk_idClientes primary key (idClientes);

CREATE TABLE IF NOT EXISTS Pedidos (
  idPedidos INT NOT NULL,
  fecha DATE NOT NULL,
  Tipo_pedido VARCHAR(45) NOT NULL,
  idProductos INT NOT NULL,
  idClientes INT NOT NULL);
ALTER TABLE Pedidos ADD constraint pk_id_Pedidos_Productos_Clientes primary key (idPedidos, idProductos, idClientes);
ALTER TABLE Pedidos ADD constraint fk_idProductos FOREIGN KEY (idProductos) REFERENCES Productos (idProductos);
ALTER TABLE Pedidos ADD constraint fk_idClientes FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes);

CREATE TABLE IF NOT EXISTS ListaPedido (
  idLista INT NOT NULL,
  Fecha DATE NULL,
  Total_pago INT NULL,
  idPedidos INT NOT NULL,
  idProductos INT NOT NULL,
  idClientes INT NOT NULL);

alter table ListaPedido add primary key (idLista, idPedidos, idProductos, idClientes);
ALTER TABLE ListaPedido ADD FOREIGN KEY (idPedidos) REFERENCES Pedidos (idPedidos);
ALTER TABLE ListaPedido ADD FOREIGN KEY (idProductos) REFERENCES Pedidos (idProductos);
ALTER TABLE ListaPedido ADD FOREIGN KEY (idClientes) REFERENCES Pedidos (idClientes);
select * from Lista_pedido;