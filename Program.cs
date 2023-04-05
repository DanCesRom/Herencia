namespace Herencia
{
    public class Program
    {
        public static int price;
        public static int Eleccion;
        public static int limite;

        static public void Main(String[] args)
        {
            for (int i = 0; i < 1;)
            {
                price = 0;
                Console.Clear();
                Console.WriteLine("Elige tu hamburguesa: ");
                Console.WriteLine("");

                for (int x = 1; x < 4; x++) { Console.WriteLine($"{x}) {Ingredientes.hamburguesas[x - 1]} \n"); } //Muestra los tipos de Hamburguesas disponibles
                Console.WriteLine("4) Ver Precio Base de Hamburguesas e Ingredientes");     //Muestra los precios de las Hamburguesas y Adicionales
                Eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (Eleccion == 1)
                {
                    price += 50;
                    Console.WriteLine("La Hamburguesa Clasica Contiene: \n");
                    foreach (string x in Tipos.clasica) { Console.WriteLine(x); }     //Muestra el contenido de la Hamburguesa Clasica
                    Relleno.Opciones();                                             //Corre la funcion .Opciones() en la Clase Relleno
                }

                else if (Eleccion == 2)
                {
                    price += 40;
                    Console.WriteLine("La Hamburguesa Saludable Contiene: \n");     //Muestra el contenido de la Hamburguesa Saludable
                    foreach (string x in Tipos.saludable) { Console.WriteLine(x); }
                    Relleno.Opciones();                                             //Corre la funcion .Opciones() en la Clase Relleno
                }

                else if (Eleccion == 3)
                {
                    price += 80;
                    Console.WriteLine("La Hamburguesa Premium Contiene: \n");       //Muestra el contenido de la Hamburguesa Premium
                    foreach (string x in Tipos.premium) { Console.WriteLine(x); }
                    Relleno.Opciones();                                             //Corre la funcion .Opciones() en la Clase Relleno
                }

                else if (Eleccion == 4)
                {
                    Console.WriteLine("El Precio Base de Cada Hamburguesa e Ingredientes son: \n");
                    for (int x = 0; x < 3; x++) { Console.WriteLine(Ingredientes.hamburguesas[x] + " son " + Precios.hamburguesas[x] + " pesos."); }         //Muestra cada tipo de Hamburguesa con su Precio
                    Console.WriteLine("\n" + "Adicionales" + "\n");
                    for (int x = 0; x < 6; x++) { Console.WriteLine(Ingredientes.adicionales[x] + " Cuesta: " + Precios.adicionales[x] + " Pesos"); }       //Muestra cada tipo de Adicional con su Precio
                    Console.WriteLine("\nPresione Cualquier Tecla para volver al Menu");Console.ReadKey();
                }

                else {Console.WriteLine("No Eligio ninguna de las opciones..."); Thread.Sleep(4000);}

            }
        }
    }
}

