//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;
using Full_GRASP_And_SOLID;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter          
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
// La clase allInOnePrinter pasa a ser ConsolePrinter y le saqué Condicional de destination.
// En caso de querer agregar otro método de "print", debería agregar otra clase con el método PrintRecipe