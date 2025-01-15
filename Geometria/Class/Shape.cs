using System;

namespace GeometriaApp
{
    // Tenemos la clase abstracta Shape
    public abstract class Shape
    {
        // Campos para el ancho y alto
        public double Ancho { get; set; }
        public double Alto { get; set; }

        // Constructor para inicializar los campos
        public Shape(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        // Método abstracto para calcular el área
        public abstract double CalculateSurface();
    }
}
