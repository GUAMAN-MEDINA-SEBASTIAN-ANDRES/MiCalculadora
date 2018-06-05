using System;

namespace MiCalculadora
{
    class Program
    {
        public static void Opciones ()
        {
            double valor1, valor2;
            int operacion;
            string reiniciar;

            do{
                Console.WriteLine("Elija la operacion que decee realizar :\n");
                Console.WriteLine("1) Suma\n2) Resta\n3) Multiplicacion\n4) Division\n5) Raiz Cuadrada\n");

                operacion=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero  :\n");
                valor1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero  :\n");
                valor2=Convert.ToDouble(Console.ReadLine());

                Suma calculo=new Suma();
                Resta calculo1=new Resta(); 
                Divicion calculo2=new Divicion(); 
                Multiplicacion calculo3=new Multiplicacion(); 
                Radicando calculo4=new Radicando();  

                switch (operacion)
                {
                     case 1: 
                            Console.WriteLine("la suma de los numeros es:  \n"+calculo.Sumar(valor1, valor2));
                     break;
                     case 2: 
                            Console.WriteLine("la resta de los numeros es:  \n"+calculo1.Restar(valor1, valor2));
                     break;
                     case 3: 
                            Console.WriteLine("la multiplicacion de los numeros es:  \n"+calculo3.Multiplicar(valor1, valor2));
                     break;
                     case 4: 
                            Console.WriteLine("la division de los numeros es:  \n"+calculo2.Dividir(valor1, valor2));
                     break;
                     case 5: 
                            Console.WriteLine("la division de los numeros es:  \n"+calculo4.Multiplicar(valor1));
                     break;
                            
                } 

                Console.WriteLine("Para repetir presione la r");
                reiniciar=Console.ReadLine();

            }while(reiniciar == "r");
        } 
        static void Elegir()
        {
            Opciones();
        }
    }
}