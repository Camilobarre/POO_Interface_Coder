using POO_Interface_Coder.Models;

bool bandera = true;
//Instancia vacía para poder utilzar los métodos
Coder coder = new Coder("", "", "", "");

while (bandera)
{
    Console.WriteLine("==============================================================================");
    Console.WriteLine("                               Gestión del sistema                            ");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("                             1. Agregar Coder                                 ");
    Console.WriteLine("                             2. Mostrar Coder                                 ");
    Console.WriteLine("                             3. Editar Coder                                  ");
    Console.WriteLine("                             4. Eliminar Coder                                ");
    Console.WriteLine("                             0. Salir                                         ");
    Console.WriteLine("==============================================================================");
    Console.Write("Selecciona una opción: ");

    var opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            // Salir del programa
            Console.WriteLine("Hasta luego, vuelva pronto!");
            bandera = false;
            break;

        case 1:
            // Agregar un nuevo Coder
            coder.Crear();
            break;

        case 2:
            // Mostrar todos los Coder
            coder.Leer();
            break;

        case 3:
            // Editar un Coder
            coder.Actualizar();
            break;

        case 4:
            // Eliminar un Coder
            coder.Eliminar();
            break;

        default:
            Console.WriteLine("Opción incorrecta, intente de nuevo.");
            break;
    }
}