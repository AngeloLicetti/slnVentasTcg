

  DELETE DVENTA;
  DELETE ARTICULO;
  DELETE VENTA;
  DELETE TRABAJADOR;
  DELETE CLIENTE;
  DELETE UMEDIDA;

  INSERT INTO UMEDIDA(UMedidaId, Nombre, Descripcion) VALUES ('11111', 'Unidad', 'Una unidad es un solo artículo');
  INSERT INTO UMEDIDA(UMedidaId, Nombre, Descripcion) VALUES ('22222', 'Unidad2', 'Una unidad2 es un solo artículo');
  INSERT INTO UMEDIDA(UMedidaId, Nombre, Descripcion) VALUES ('33333', 'Unidad3', 'Una unidad3 es un solo artículo');
  INSERT INTO UMEDIDA(UMedidaId, Nombre, Descripcion) VALUES ('44444', 'Unidad3', 'Una unidad4 es un solo artículo');

  INSERT INTO CLIENTE(ClienteId, Apellidos, Nombres, Celular, Direccion, Email, Imagen) VALUES ('11111','Sanchez Tupia','Luis','955567888','Surco','luisito@masmail.com','');
  INSERT INTO CLIENTE(ClienteId, Apellidos, Nombres, Celular, Direccion, Email, Imagen) VALUES ('22222','Candela Peña','Anderley','987654321','Miraflowers','acandela@jocmail.com','');
  INSERT INTO CLIENTE(ClienteId, Apellidos, Nombres, Celular, Direccion, Email, Imagen) VALUES ('33333','Heredia','Andre','999888777','San Isidro','aheredia@urpmail.com','');
  INSERT INTO CLIENTE(ClienteId, Apellidos, Nombres, Celular, Direccion, Email, Imagen) VALUES ('44444','Mora','Meli','987654321','Surco, cerca de la richi','lameli@urpmail.com','');

  INSERT INTO TRABAJADOR(TrabajadorId, Apellidos, Nombres, Cargo, Dni, Celular, Direccion, Email, Imagen) VALUES ('11111', 'Licetti Leon', 'Angelo Giovanni', 'Vendedor', '72630638', '955567834', 'Pueblo Libre', 'alicetti@gmail.com','');
  INSERT INTO TRABAJADOR(TrabajadorId, Apellidos, Nombres, Cargo, Dni, Celular, Direccion, Email, Imagen) VALUES ('22222', 'Lau Loo', 'Carlos Arturo', 'Vendedor', '73638419', '938298364', 'Surco', 'clau@gmail.com','');
  INSERT INTO TRABAJADOR(TrabajadorId, Apellidos, Nombres, Cargo, Dni, Celular, Direccion, Email, Imagen) VALUES ('33333', 'Paredes Mesias', 'Jose', 'Vendedor', '7349257', '9362817', 'Surco', 'jparedes@gmail.com','');
  INSERT INTO TRABAJADOR(TrabajadorId, Apellidos, Nombres, Cargo, Dni, Celular, Direccion, Email, Imagen) VALUES ('44444', 'Mujica', 'Gabs', 'Vendedora', '73615940', '947285104', 'Surco', 'gabs@gmail.com','');

  INSERT INTO VENTA(VentaId, Fecha, Comentario, ClienteId, TrabajadorId) VALUES ('11111', '2018-11-11', 'Comentario1', '11111', '11111');
  INSERT INTO VENTA(VentaId, Fecha, Comentario, ClienteId, TrabajadorId) VALUES ('22222', '2018-12-11', 'Comentario2', '22222', '22222');
  INSERT INTO VENTA(VentaId, Fecha, Comentario, ClienteId, TrabajadorId) VALUES ('33333', '2018-13-11', 'Comentario3', '33333', '33333');
  INSERT INTO VENTA(VentaId, Fecha, Comentario, ClienteId, TrabajadorId) VALUES ('44444', '2018-13-11', 'Comentario4', '22222', '33333');

  INSERT INTO ARTICULO(ArticuloId, Nombre, Descripcion, Cantidad, Precio, Imagen, UMedidaId) VALUES ('11111', 'Cubo 3x3 Gan Air SM', 'El cubo más suave que se ha producido hasta ahora', 100, 119.90, '', '11111');
  INSERT INTO ARTICULO(ArticuloId, Nombre, Descripcion, Cantidad, Precio, Imagen, UMedidaId) VALUES ('22222', 'Cubo 4x4 Wuque M', 'Cubo mágnetico profesional y veloz', 200, 99.90, '', '22222');
  INSERT INTO ARTICULO(ArticuloId, Nombre, Descripcion, Cantidad, Precio, Imagen, UMedidaId) VALUES ('33333', 'Cubo 2x2 Moyu Weipo', 'Primer 2x2 producido en masa por Moyu', 300, 54.90, '', '33333');
  INSERT INTO ARTICULO(ArticuloId, Nombre, Descripcion, Cantidad, Precio, Imagen, UMedidaId) VALUES ('44444', 'Cubo 5x5 Qiyi Wushuang M', 'Primer 5x5 magnetico producido en masa por Qiyi', 150, 59.90, '', '33333');

  INSERT INTO DVENTA(DVentaId, Cantidad, Precio, VentaId, ArticuloId) VALUES ('11111', 10, 119.90, '11111', '11111');
  INSERT INTO DVENTA(DVentaId, Cantidad, Precio, VentaId, ArticuloId) VALUES ('22222', 7, 99.90, '22222', '22222');
  INSERT INTO DVENTA(DVentaId, Cantidad, Precio, VentaId, ArticuloId) VALUES ('33333', 2, 54.90, '33333', '33333');
  INSERT INTO DVENTA(DVentaId, Cantidad, Precio, VentaId, ArticuloId) VALUES ('44444', 1, 99.90, '33333', '22222');

  SELECT * FROM DVENTA;
  SELECT * FROM ARTICULO;
  SELECT * FROM VENTA;
  SELECT * FROM TRABAJADOR;
  SELECT * FROM CLIENTE;
  SELECT * FROM UMEDIDA;
