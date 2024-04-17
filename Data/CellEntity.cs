using Godot;
using System;

namespace Cells
{
    public class Cell
    {
        private int _value;
        public int Value { get { return this._value; } set { this._value = value; UpdateUI(); } }
        public Button Gameobject;
        public int Column;
        public int Row;
        public Cell(Button but, int column, int row)
        {
            Gameobject = but;
            Value = 0;
            Column = column;
            Row = row;
        }

        void UpdateUI()
        {
            if (Value != 0)
                Gameobject.Text = Value.ToString();
            else
                Gameobject.Text = "";
        }
       
    }

}

