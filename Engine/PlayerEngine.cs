using Cells;
using Godot;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;

namespace PlayerEngine
{
    public class Player
    {
        public List<Cell>field = new List<Cell>();
        public Player(int grid, Node coreNode) 
        {
            int columnCount = (int)Math.Sqrt(grid);
            for(int i =0; i<grid; i++)
            {
                var but = (Button)coreNode.GetChild(i);
                decimal columndec = i / columnCount;
                int Column = (int)Math.Floor(columndec);
                int Row;
                if (Column == 0)
                    Row = i;
                else
                    Row = (int)i % columnCount;
                GD.Print(Column + " " + Row);
                field.Add(new Cell(but,Column,Row));
            }
        }
    }
}