using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interface_Coder.Interfaces;
public interface ICRUD
{
    void Crear();
    void Leer();
    void Actualizar();
    void Eliminar();
}