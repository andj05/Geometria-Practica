
namespace GeometriaApp
{
    // Clase Triangle, hereda de Shape
    public class Triangle : Shape
    {
        // Constructor que pasa los valores al constructor de la clase base
        public Triangle(double ancho, double alto) : base(ancho, alto) { }

        // Implementación del método abstracto para calcular el área del triángulo
        public override double CalculateSurface()
        {
            return (Ancho * Alto) / 2;  // Área = (Ancho * Alto) / 2
        }
    }
}
