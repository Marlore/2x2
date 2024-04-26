using Cells;
using Godot;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;

namespace PlayerEngine
{
    public class Player
    {

        public CpuParticles2D Particles;
        public List<Cell>field = new List<Cell>();
        private Node gridNode;
        public bool GameOver;
        public int Score { get { return field.Sum(x => x.Value); } }
        public Player(int grid, Node coreNode) 
        {
            GameOver = false;
            gridNode = coreNode.GetNode("CanvasLayer/ColorRect/GridContainer");
            Particles = (CpuParticles2D)coreNode.GetNode("CanvasLayer/ColorRect/CPUParticles2D");
            Particles.EmissionSphereRadius = ((Button)gridNode.GetChild(0)).Size.X;
            int columnCount = (int)Math.Sqrt(grid);
            for (int i =0; i<grid; i++)
            {
                var but = (Button)gridNode.GetChild(i);
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