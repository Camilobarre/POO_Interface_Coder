using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interface_Coder.Interfaces;

namespace POO_Interface_Coder.Models;
public class Coder : ICRUD
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    private List<Coder> coders = new List<Coder>();

    public Coder(string nombre, string apellido, string email, string telefono)
    {
        Id = Guid.NewGuid();
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Email = email;
        this.Telefono = telefono;
    }

    public void Crear()
    {
        Console.WriteLine("Ingrese los datos del nuevo Coder:");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Telefono: ");
        string telefono = Console.ReadLine();

        Coder nuevoCoder = new Coder(nombre, apellido, email, telefono);
        coders.Add(nuevoCoder);
        Console.WriteLine("Coder agregado éxitosamente.");
    }

    public void Leer()
    {
        if (coders.Count == 0)
        {
            Console.WriteLine("No hay coders para mostrar.");
            return;
        }
        foreach (var coder in coders)
        {
            Console.WriteLine($"Id: {coder.Id}, Nombre: {coder.Nombre} {coder.Apellido}, Email: {coder.Email}, Telefono: {coder.Telefono}");
        }
    }
    public void Actualizar()
    {
        Console.Write("Ingrese el ID del Coder a actualizar: ");
        var id = Guid.Parse(Console.ReadLine());
        var coder = coders.FirstOrDefault(c => c.Id == id);
        if (coder == null)
        {
            Console.WriteLine("Coder no encontrado.");
            return;
        }
        Console.WriteLine("Ingrese los nuevos datos:");
        Console.Write("Nombre: ");
        coder.Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        coder.Apellido = Console.ReadLine();
        Console.Write("Email: ");
        coder.Email = Console.ReadLine();
        Console.Write("Telefono: ");
        coder.Telefono = Console.ReadLine();
        Console.WriteLine("Usuario actualizado éxitosamente.");
    }


    public void Eliminar()
    {
        Console.Write("Ingrese el ID del Coder a eliminar: ");
        var id = Guid.Parse(Console.ReadLine());
        var coder = coders.FirstOrDefault(c => c.Id == id);
        if (coder == null)
        {
            Console.WriteLine("Coder no encontrado.");
            return;
        }
        coders.Remove(coder);
        Console.WriteLine("Coder eliminado éxitosamente.");
    }
}