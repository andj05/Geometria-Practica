namespace GeometriaApp
{
    // Esta clase hereda de la clase abstracta Shape
    public class Rectangle : Shape
    {
        // Constructor que pasa los valores al constructor de la clase base
        public Rectangle(double ancho, double alto) : base(ancho, alto) { }

        // Implementación del método abstracto para calcular el área del rectángulo
        public override double CalculateSurface()
        {
            return Ancho * Alto;  // Área = Ancho * Alto
        }
    }
}
