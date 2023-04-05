using System.Diagnostics;

namespace Herencia
{
    public class Relleno
    {
        public static void Opciones() 
        {
            Console.WriteLine("\n");
            if (Program.Eleccion == 1) { Program.limite = 4; } else if (Program.Eleccion == 2) {  Program.limite = 2; } else if (Program.Eleccion == 3){  Program.limite = 0; }

            for (int z = 0; z < Program.limite; z++) //Define el Limite de Ingredientes Adicionales dependiendo el Tipo de Hamburguesa
            {
                Console.WriteLine($"Que mas quisieras agregarle a la Hamburguesa? Puedes agregarle {Program.limite} adicionales. Presione 0 Para finalizar de agregar \n");
                
                for (int x = 1; x < 7; x++) {Console.WriteLine($"{x}) {Ingredientes.adicionales[x-1]}");} //Muestra los Igredientes Adicionales que puedes elegir
                int eleccion = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                if (eleccion >= 1 && eleccion <= 6)
                {
                    Registro.factura_ingredientes.Add(Ingredientes.adicionales[eleccion-1]); //Agrega el Ingrediente a la factura
                }
                else { break; }
            }

            Console.WriteLine("Su factura incluye: \n");
            Console.WriteLine(Ingredientes.hamburguesas[Program.Eleccion - 1] + "\n"); //Muestra el tipo de Hamburguesa que elegiste
            foreach (string x in Registro.factura_ingredientes)
            {
                Console.WriteLine(x + " son " + Precios.adicionales[Registro.factura_ingredientes.IndexOf(x)] + " pesos");  //Muestra cada Ingrediente Adicional con su respectivo Precio que elegiste
                Program.price += Precios.adicionales[Registro.factura_ingredientes.IndexOf(x)];                             //Agrega el Precio de cada Ingrediente Adicional
            }
            Console.WriteLine($"\nLa factura hace {Program.price} pesos." + "\n\nPresione Cualquier Tecla para volver al Menu");
            Registro.factura_ingredientes.Clear();
            Console.ReadKey();
        }
    }
}

