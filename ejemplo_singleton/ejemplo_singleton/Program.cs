using ejemplo_singleton;

ConexionBasedeDatos conexion1 = ConexionBasedeDatos.ObtenerInstancia("Conexion1");
ConexionBasedeDatos conexion2 = ConexionBasedeDatos.ObtenerInstancia("Conexion2");

Console.WriteLine("-->Resultado:");
Console.WriteLine(conexion1.Nombre);
Console.WriteLine(conexion2.Nombre);
Console.WriteLine("Singleton no permite nueva instancia porque ya existe una, entonces muestra la misma...");

Console.ReadLine();