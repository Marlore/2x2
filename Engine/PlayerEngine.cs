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
                int Row = (int)Math.Floor(columndec);
                int Column;
                if (Row == 0)
                    Column = i;
                else
                    Column = (int)i % columnCount;
                field.Add(new Cell(but,Column,Row));
            }
        }
    }
}