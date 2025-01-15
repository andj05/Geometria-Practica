using System;

namespace GeometriaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una matriz de diferentes Shapes
            Shape[] shapes = new Shape[]
            {
                new Rectangle(4, 5),    // Rectángulo con Ancho 4 y Alto 5
                new Triangle(4, 5),     // Triángulo con Ancho 4 y Alto 5
                new Circle(3)           // Círculo con radio 3
            };

            // Crear una matriz para almacenar las áreas
            double[] areas = new double[shapes.Length];

            // Calcular el área de cada forma y almacenarlo en la matriz areas
            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            // Mostrar las áreas calculadas
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Área de la forma {i + 1}: {areas[i]:F2}");
            }
        }
    }
}
