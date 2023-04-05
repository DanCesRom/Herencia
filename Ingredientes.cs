namespace Herencia
{
    public class Ingredientes
    {
        public static string[] adicionales = { "Lechuga", "Tomates", "Bacon", "Pepinillos", "Queso", "Cebolla" };           //Arreglo de elementos de los Ingredientes
        public static string[] hamburguesas = { "Hamburguesa Clasica", "Hamburguesa Saludable", "Hamburguesa Premium", };    //Arreglo de tipos de Hamburguesas
    }
    public class Precios
    {
        public static int[] adicionales = { 10, 15, 20, 25, 30, 35 };   //Arreglo que contiene los precios de los Ingredientes

        public static int[] hamburguesas = { 50, 40, 80 };              //Arreglo que contiene los precios de los tipos de Hamburguesas
    }

    public class Registro
    {
        public static List<string> factura_ingredientes = new List<string>();       //Lista que contiene los elementos a facturar
    }

    public class Tipos
    {
        public static string[] clasica = { "Pan Brioche", "Carne" };                    //Arreglo que contiene elementos de Hamburguesa Clasica
        public static string[] saludable = { "Pan Integral", "Carne" };                 //Arreglo que contiene elementos de Hamburguesa Saludable
        public static string[] premium = { "Pan Relleno", "Carne", "Papitas", "Bebida" }; //Arreglo que contiene elementos de Hamburguesa Premium
    }
}

