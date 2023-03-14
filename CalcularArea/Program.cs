using CalcularArea;

internal class Program
{
    private static void Main(string[] args)
    {
        Quadrado quadrado = new Quadrado();
        Triangulo triangulo = new Triangulo();

        quadrado.ladoB = 10;
        quadrado.ladoA = quadrado.ladoB;

        triangulo.ladoB = 3;
        triangulo.ladoA = 15;

        Console.WriteLine(quadrado.ToString());
        Console.WriteLine(triangulo.ToString());

        Console.WriteLine(quadrado.CalcularArea());
        Console.WriteLine(triangulo.CalcularArea());
    }
}