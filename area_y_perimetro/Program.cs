        double baseRectangulo, alturaRectangulo, area, perimetro;

        Console.Write("Ingresa el valor de la base del rectángulo: ");
        baseRectangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el valor de la altura del rectángulo: ");
        alturaRectangulo = double.Parse(Console.ReadLine());

        area = baseRectangulo * alturaRectangulo;
        perimetro = 2 * (baseRectangulo + alturaRectangulo);

        Console.WriteLine($"El área del rectángulo es: {area}");
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    


