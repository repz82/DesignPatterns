namespace Interpreter
{
    public class RaizQuadrada
    {
        private double x;

        public RaizQuadrada(double x)
        {
            this.x = x;
        }

        public double Avalia()
        {
            return System.Math.Sqrt(x);
        }
    }
}