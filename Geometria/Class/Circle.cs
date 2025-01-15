
namespace GeometriaApp
{
    // Clase Circle, hereda de Shape
    public class Circle : Shape
    {
        // Constructor que inicializa Ancho y Alto con el mismo valor (el radio)
        public Circle(double radio) : base(radio, radio) { }

        // Implementación del método abstracto para calcular el área del círculo
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Ancho, 2);  // Área = π * radio^2
        }
    }
}
