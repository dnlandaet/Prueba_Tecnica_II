using System;

namespace pruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            CalcularPromedio();
            CalcularIva();
            calcularNumeroBinario();
            CalcularHipotenusa();
            FromMinToMay();
            ConvertirFechaTexto();
        }
            // Calcular Promedio //
        public static void CalcularPromedio()
        {
            Console.WriteLine("Cuantos elementos son?");
            
            int cantidad = Int32.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];
            for (int i = 0; i<cantidad; i++){
                Console.WriteLine("Ingrese el numero "+ (i+1));
                numeros[i]=Int32.Parse(Console.ReadLine());
            }
            double suma = 0;

            foreach(int numero in numeros)
            {
                suma += numero;
            }

            double promedio = suma / cantidad;
            Console.WriteLine("El promedio de los números es: " + promedio);
        }
         // Calcular IVA 19% //

        public static void CalcularIva(){
            Console.Write("Ingrese el valor total a pagar: ");
            double valorTotal = double.Parse(Console.ReadLine());

            double iva = valorTotal * 0.19;
            double precioConIva = valorTotal + iva;

            string etiquetaPrecio;
            if (precioConIva <= 100000.00)
            {
                etiquetaPrecio = "BARATO";
            }
            else if (precioConIva > 100000.00 && precioConIva < 150000.00)
            {
                etiquetaPrecio = "COMUN";
            }
            else
            {
                etiquetaPrecio = "CARO";
            }

            Console.WriteLine("Valor del IVA: {0:C2} (19%)", iva);
            Console.WriteLine("Precio con IVA incluido: {0:C2} ({1})", precioConIva, etiquetaPrecio);
        }

        // calcularNumeroBinario

        public static void calcularNumeroBinario(){
            Console.Write("Ingrese un número decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int[] binaryNumber = new int[32]; // máximo de 32 bits en un entero
            int index = 0;

            while (decimalNumber > 0)
            {
                binaryNumber[index] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                index++;
            }

            Console.Write("El número binario equivalente es: ");
            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.Write("\n");
        }

        //Calcular Hipotenusa
        public static void CalcularHipotenusa(){

            double a, b, c;

        Console.Write("Ingrese el valor de A (altura): ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de B (largo): ");
        b = double.Parse(Console.ReadLine());

        c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine("El valor de C (hipotenusa) es: " + c);
        }    

       // Convertir de minúscula a mayúscula

       public static void FromMinToMay(){

        Console.Write("Introduzca un texto en minúsculas: ");
        string texto = Console.ReadLine();

        string textoMayusculas = texto.ToUpper();

        Console.WriteLine("Texto en mayúsculas: " + textoMayusculas);
       } 

        // Convertir Fecha Texto 
       static public void ConvertirFechaTexto(){

         Console.WriteLine("Ingrese la fecha en formato de texto (ejemplo: 08/03/2023 10:30:00):");
            string fechaTexto = Console.ReadLine();

            if (DateTime.TryParse(fechaTexto, out DateTime fecha))
            {
                string fechaFormateada = fecha.ToString("yyyy.MM.dd  HH:mm:ss");
                Console.WriteLine($"La fecha convertida es: {fechaFormateada}");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }

            Console.ReadKey();
       }
    }
}
