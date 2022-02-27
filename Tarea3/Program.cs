
static void fragmentoif()
{
    int can, c200, c100, c50, c20, c10, c5, c1;
    float centa, centa50, centa25, centa10, centa5, centa1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;
    centa50 = centa25 = centa10 = centa5 = centa1 = 0.00f;
    string linea;

    Console.Write("Ingrese la cantidad: ");
    linea = Console.ReadLine();
    centa = float.Parse(linea);
    can = (int)centa;
    centa = centa - can;

    if ((can >= 200))
    {
        c200 = (can / 200);
        can = can - (c200 * 200);
    }
    if ((can >= 100))
    {
        c100 = (can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 50))
    {
        c50 = (can / 50);
        can = can - (c50 * 50);
    }
    if ((can >= 20))
    {
        c20 = (can / 20);
        can = can - (c20 * 20);
    }
    if ((can >= 10))
    {
        c10 = (can / 10);
        can = can - (c10 * 10);
    }
    if ((can >= 5))
    {
        c5 = (can / 5);
        can = can - (c5 * 5);
    }
    if ((can >= 1))
    {
        c1 = (can / 1);
        can = can - c1;

    }
    //Contador de centavos
    if ((centa >= 0.50))
    {
        centa50 = 1;
        centa = (centa - 0.50f);
    }
    if ((centa >= 0.25))
    {
        centa25 = 1;
        centa = (centa - 0.25f);
    }
    if ((centa >= 0.10))
    {
        centa10 = (centa - (centa % 0.10f)) / 0.10f;
        centa = (centa % 0.10f);
        centa10 = (float)Math.Round(centa10, 2);
    }
    if ((centa >= 0.05))
    {
        centa5 = (centa - (centa % 0.05f)) / 0.05f;
        centa = (centa % 0.05f);
        centa5 = (float)Math.Round(centa5, 2);
    }
    if ((centa >= 0.01))
    {
        centa1 = (centa / 0.01f);
        centa1 = (float)Math.Round(centa1, 2);
    }


    Console.WriteLine($"Billetes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {centa50}");
    Console.WriteLine($"Monedas de 25 centavos: {centa25}");
    Console.WriteLine($"Monedas de 10 centavos: {centa10}");
    Console.WriteLine($"Monedas de 5 centavos: {centa5}");
    Console.WriteLine($"Monedas de 1 centavo: {centa1}");
    Console.ReadKey();
}
static void fragmentocase()
{
    //declaramos nuestra variables
    int can, c200, c100, c50, c20, c10, c5, c1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

    float centa, centa50, centa25, centa10, centa5, centa1;
    centa50 = centa25 = centa10 = centa5 = centa1 = 0.00f;

    string linea;

    //pedimos la cantidad de dinero al usuario y lo guardamos en las variables que evaluaremos
    Console.Write("Ingrese la cantidad: ");
    linea = Console.ReadLine();
    centa = float.Parse(linea);
    can = (int)centa;
    centa = centa - can;

    //verificcion de cuantos billetes hay
    switch (can)
    {
        case > 0:
            c200 = (can / 200);
            can = can - (c200 * 200);
     
            c100 = (can / 100);
            can = can - (c100 * 100);
               
            c50 = (can / 50);
            can = can - (c50 * 50);           
                 
            c20 = (can / 20);
            can = can - (c20 * 20);
                  
            c10 = (can / 10);
            can = can - (c10 * 10);
                  
            c5 = (can / 5);
            can = can - (c5 * 5);
          
            c1 = (can / 1);
            can = can - c1;
            break;

    }

    //ahora verificamos cuantos centavos hay
    switch(centa)
    {
        case >= 0.0f:
           
            centa50 = (centa - (centa % 0.50f)) / 0.50f;
            centa = (centa % 0.50f);
            centa50 = (float)Math.Round(centa50, 2);

            centa25 = (centa - (centa % 0.25f)) / 0.25f;
            centa = (centa % 0.25f);
            centa25 = (float)Math.Round(centa25, 2);

            centa10 = (centa - (centa % 0.10f)) / 0.10f;
            centa = (centa % 0.10f);
            centa10 = (float)Math.Round(centa10, 2);
       
            centa5 = (centa - (centa % 0.05f)) / 0.05f;
            centa = (centa % 0.05f);
            centa5 = (float)Math.Round(centa5, 2);
       
            centa1 = (centa / 0.01f);
            centa1 = (float)Math.Round(centa1, 2);
            break;
    }
  
 

    //mostrale al usuario el resultado
    Console.WriteLine($"Billetes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {centa50}");
    Console.WriteLine($"Monedas de 25 centavos: {centa25}");
    Console.WriteLine($"Monedas de 10 centavos: {centa10}");
    Console.WriteLine($"Monedas de 5 centavos: {centa5}");
    Console.WriteLine($"Monedas de 1 centavo: {centa1}");
    Console.ReadKey();

}
static void fragmentodolar()
{
    //declaramos nuestra variables
    int can, c200, c100, c50, c20, c10, c5, c1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

    float conver, centa, centa50, centa25, centa10, centa5, centa1;
    centa50 = centa25 = centa10 = centa5 = centa1 = 0.00f;

    string linea;

    //pedimos la cantidad de dinero al usuario y lo guardamos en las variables que evaluaremos
    Console.Write("Ingrese la cantidad en dolares: ");
    linea = Console.ReadLine();
    centa = float.Parse(linea);
    conver = centa * 7.7f;
    conver = (float)Math.Round(conver, 2);
    can = (int)conver;
    centa = conver - can;

    //verificacion de cuantos billetes hay
    switch (can)
    {
        case > 0:
            c200 = (can / 200);
            can = can - (c200 * 200);

            c100 = (can / 100);
            can = can - (c100 * 100);

            c50 = (can / 50);
            can = can - (c50 * 50);

            c20 = (can / 20);
            can = can - (c20 * 20);

            c10 = (can / 10);
            can = can - (c10 * 10);

            c5 = (can / 5);
            can = can - (c5 * 5);

            c1 = (can / 1);
            can = can - c1;
            break;
    }

    //ahora verificamos cuantos centavos hay
    switch (centa)
    {
        case >= 0.0f:

            centa50 = (centa - (centa % 0.50f)) / 0.50f;
            centa = (centa % 0.50f);
            centa50 = (float)Math.Round(centa50, 2);

            centa25 = (centa - (centa % 0.25f)) / 0.25f;
            centa = (centa % 0.25f);
            centa25 = (float)Math.Round(centa25, 2);

            centa10 = (centa - (centa % 0.10f)) / 0.10f;
            centa = (centa % 0.10f);
            centa10 = (float)Math.Round(centa10, 2);

            centa5 = (centa - (centa % 0.05f)) / 0.05f;
            centa = (centa % 0.05f);
            centa5 = (float)Math.Round(centa5, 2);

            centa1 = (centa / 0.01f);
            centa1 = (float)Math.Round(centa1, 2);
            break;
        
    }

    



    //mostrale al usuario el resultado
    Console.WriteLine("\nCantidad de billetes y monedas en quetzales: ");
    Console.WriteLine($"\nBilletes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {centa50}");
    Console.WriteLine($"Monedas de 25 centavos: {centa25}");
    Console.WriteLine($"Monedas de 10 centavos: {centa10}");
    Console.WriteLine($"Monedas de 5 centavos: {centa5}");
    Console.WriteLine($"Monedas de 1 centavo: {centa1}");
    Console.WriteLine($"\n\nCantidad ingresada: {linea}");
    Console.WriteLine($"Cantidad en Quetzales: {conver}"); 
    
    Console.ReadKey();

}

//fragmentoif();
//fragmentocase();
//fragmentodolar();
