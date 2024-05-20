        double altura_en_m, peso_en_kg, IMC;

        Console.Write("Ingresa el valor de altura en m: ");
        altura_en_m = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el valor de peso en kg: ");
        peso_en_kg = double.Parse(Console.ReadLine());

        IMC = peso_en_kg / (altura_en_m * altura_en_m);

        if (IMC < 16)
            Console.WriteLine("Criterio de ingreso en hospital");
        else if (IMC < 17)
            Console.WriteLine("Infrapeso");
        else if (IMC < 18)
            Console.WriteLine("Bajo peso");
        else if (IMC < 25)
            Console.WriteLine("Peso normal (saludable)");
        else
            Console.WriteLine("Sobrepeso");

Console.WriteLine(IMC);
