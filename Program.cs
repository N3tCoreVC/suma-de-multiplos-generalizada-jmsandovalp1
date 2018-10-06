using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_multiplos_generalizada_jmsandovalp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int numv = 0;
            int listn = 0;
            int sumav = 0;
            int valores = 0;
            int i = 0;
            ArrayList arreglo2 = new ArrayList();

            Console.Write("Dame un numero que será el tope: ");
            String numerotope = Console.ReadLine();

            if (int.TryParse(numerotope, out num1))
            {
                Console.Write("Dame la cantidad de números a validar como residuo: ");
                String numerovalidar = Console.ReadLine();

                if (int.TryParse(numerovalidar, out numv))
                {
                    //int[] arreglo = new int[numv];
                    
                    int j = 0;
                    while (j < numv)
                    //for (int j=0; j<numv;j++)
                    {
                        Console.Write("Dame el numero {0} para validar como residuo: ",j);
                        String listav = Console.ReadLine();
                        if (int.TryParse(listav, out listn))
                        {
                            if (arreglo2.Contains(listav))
                            {
                                Console.WriteLine("Valor repetido dame otro numero");
                                
                            }
                            else
                            {
                                arreglo2.Add(listav);
                                j++;
                            }
                        }

                    }

                    for (int x=0; x<=num1;x++)
                    {
                        for (int z=0; z<numv;z++)
                        {
                            int.TryParse(arreglo2[z].ToString(), out valores);
                        
                            //int valores = (int) arreglo2[z];
                            if (x%valores == 0)
                            {
                                sumav = sumav + x;
                                break;
                            }
                        }
                    }
                }

                

            }
            else
            {
                Console.WriteLine("Escribe un numero valido");
            }

            Console.WriteLine("La suma de los múltiplos son: " + sumav);        
            
            

        }
    }
}
