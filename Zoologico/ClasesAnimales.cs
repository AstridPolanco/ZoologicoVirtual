using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Leon
    {
        private string nombre {  get; set; }

        private int altura { get; set; }

        private int peso { get; set; }

        private string sexo { get; set; }

        private int edad {  get; set; }

        private string especie = "Leon";

        public Leon(string nombre, int altura, int peso, string sexo, int edad, string especie)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
            this.especie = especie;
        }
        public Leon(string nombre, string sexo)
        {
            this.nombre = nombre;
            this.sexo = sexo;
        }

        public void alimentar()
        {
            Console.WriteLine("Come carne");
        }

        public void ruido()
        {
            Console.WriteLine("GRRRRRR");
        }
        public override string ToString()
        {
            return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
        }
    }
}

class Elefante
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie="Elefante";

    public Elefante(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Elefante(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come hierbas");
    }

    public void ruido()
    {
        Console.WriteLine("FUUUUU");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Jirafa
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Jirafa";

    public Jirafa(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Jirafa(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come hojas");
    }

    public void ruido()
    {
        Console.WriteLine("UUUUUH");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Tigre
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Tigre";

    public Tigre(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Tigre(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }

    public void ruido()
    {
        Console.WriteLine("GRRRRRR");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Mono
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Mono";

    public Mono(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Mono(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come frutos");
    }

    public void ruido()
    {
        Console.WriteLine("UHUHUHUH");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Oso
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Oso";

    public Oso(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Oso(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come peces");
    }

    public void ruido()
    {
        Console.WriteLine("RAAAAAW");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Cocodrilo
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Cocodrilo";

    public Cocodrilo(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Cocodrilo(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come peces");
    }

    public void ruido()
    {
        Console.WriteLine("GRRRRR");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Serpiente
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Serpiente";

    public Serpiente(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Serpiente(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come ratones");
    }

    public void ruido()
    {
        Console.WriteLine("SSSSSSS");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Pinguino
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Pinguino";

    public Pinguino(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Pinguino(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come peces");
    }

    public void ruido()
    {
        Console.WriteLine("RRRGGG");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Lobo
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Lobo";

    public Lobo(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Lobo(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }

    public void ruido()
    {
        Console.WriteLine("AUUUUUU");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Cebra
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Cebra";

    public Cebra(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Cebra(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come hierbas");
    }

    public void ruido()
    {
        Console.WriteLine("YIIIIIP");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Rinoceronte
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Rinoceronte";

    public Rinoceronte(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Rinoceronte(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come ramas");
    }

    public void ruido()
    {
        Console.WriteLine("RUUUUUUU");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Panda
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Panda";

    public Panda(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Panda(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come bambú");
    }

    public void ruido()
    {
        Console.WriteLine("GRUGRUGRU");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class PavoReal
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Pavo Real";

    public PavoReal(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public PavoReal(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come semillas");
    }

    public void ruido()
    {
        Console.WriteLine("AHAAAAAA");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Tortuga
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }

    private int edad { get; set; }

    private string especie = "Tortuga";

    public Tortuga(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }
    public Tortuga(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }

    public void alimentar()
    {
        Console.WriteLine("Come algas marinas");
    }

    public void ruido()
    {
        Console.WriteLine("UHHHH");
    }
    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}