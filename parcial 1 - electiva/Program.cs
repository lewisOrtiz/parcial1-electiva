using System;
using System.Collections.Generic;
public class Program {

    public static void Main(){
        Dictionary<dynamic, dynamic> alcancia = new Dictionary<dynamic, dynamic>();
        alcancia.Add("50", 0);
        alcancia.Add("100", 0);
        alcancia.Add("200", 0);
        alcancia.Add("500", 0);
        alcancia.Add("1000", 0);

        int c = 1; 
        while (c!=0) {
            Console.WriteLine("Alcancia!");
            Console.WriteLine("1. Insertar moneda");
            Console.WriteLine("2. Ver cantidad de monedas");
            Console.WriteLine("3. Ver cantidad total de dinero");
            Console.WriteLine("4. Ver cantidad monedas por denominación");
            Console.WriteLine("5. Ver cantidad total de dinero por denominación");
            Console.WriteLine("0. Salir");


            string res = Console.ReadLine();
            switch (res) {
                case "1":
                    Console.WriteLine("Ingresa moneda");
                    string moneda = Console.ReadLine();
                    if (moneda == "50" ||
                        moneda == "100" ||
                        moneda == "200" ||
                        moneda == "500" ||
                        moneda == "1000"
                    )
                    {

                        alcancia[moneda] = alcancia[moneda] + 1;
                        Console.WriteLine("Moneda insertada!");
                    }
                    else { 
                        Console.WriteLine("Moneda incorrecta!");
                    }
                    break;
                case "2":
                    int total = 0;
                    foreach (var m in alcancia) {
                        total = total + m.Value;
                    }
                    Console.WriteLine("Total de monedas: " + total);
                    break;
                case "3":
                    int totalDinero = 0;
                    foreach (var m in alcancia) {
                        totalDinero = totalDinero + (m.Value * Convert.ToInt32(m.Key));
                    }
                    Console.WriteLine("Total de dinero: $" + totalDinero);
                    break;
                case "4":
                    Console.WriteLine("Que denominación?");
                    Console.WriteLine("50");
                    Console.WriteLine("100");
                    Console.WriteLine("200");
                    Console.WriteLine("500");
                    Console.WriteLine("1000");
                    string p = Console.ReadLine();
                    if (p == "50" ||
                        p == "100" ||
                        p == "200" ||
                        p == "500" ||
                        p == "1000"
                    )
                    {
                        Console.WriteLine("Hay " + alcancia[p] + " de " + p);
                    }
                    else { 
                        Console.WriteLine("denominacíon incorrecta!");
                    }

                    break;
                case "5":
                    Console.WriteLine("Que denominación?");
                    Console.WriteLine("50");
                    Console.WriteLine("100");
                    Console.WriteLine("200");
                    Console.WriteLine("500");
                    Console.WriteLine("1000");
                    string t = Console.ReadLine();
                    if (t == "50" ||
                        t == "100" ||
                        t == "200" ||
                        t == "500" ||
                        t == "1000"
                    ) { 
                        int total2 = Convert.ToInt32(t) * alcancia[t];
                        Console.WriteLine("Hay $" + total2 + " en monedas de " + t);
                    }
                    else {
                        Console.WriteLine("denominacíon incorrecta!");
                    }
                    break;
                case"0":
                    c = 0;
                    break;
                default:
                    break;
            }
        }


    }
}
