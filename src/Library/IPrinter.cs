using System;
using System.Collections.Generic;
using Full_GRASP_And_SOLID;

namespace  Full_GRASP_And_SOLID.Library;

public interface IPrinter  // Se crea una interfaz que mande a imprimir a todas las posibles impresoras
{
    void PrintRecipe(Recipe recipe);
}