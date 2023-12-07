public class Persona {

    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Dirección { get; set; }

    public void MostrarDatos() {
        Console.WriteLine("Nombre: {0}", Nombre);
        Console.WriteLine("Edad: {0}", Edad);
        Console.WriteLine("Dirección: {0}", Dirección);
    }

    public void CalcularIMC() {
        Console.WriteLine("Introduce el peso:");
        int peso = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce la altura:");
        int altura = int.Parse(Console.ReadLine());

        if (altura != 0)
        {
            float imc = peso / (altura * altura);
            Console.WriteLine("IMC: {0}", imc);
        }
        else
        {
            Console.WriteLine("La altura no puede ser 0");
        }
    }

    public void ActualizarDatos() {
        // Obtiene los datos del usuario
        Console.WriteLine("Introduce tu nombre:");
        Nombre = Console.ReadLine();
        Console.WriteLine("Introduce tu edad:");
        Edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce tu dirección:");
        Dirección = Console.ReadLine();
    }
}
