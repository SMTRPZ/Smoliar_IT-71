﻿using Fifteen.Cells;
using Fifteen.Command;
using Fifteen.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field(5);
            field.SetGenerator(new FieldNumbers());
            field.GenerateField();

            var downMove = new DownMoveCommand(field);

            downMove.Execute();
            downMove.Undo();
        }
    }
}
