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
        private Theme theme;
        public Cell(Button but, int column, int row)
        {
            Gameobject = but;
            Value = 0;
            Column = column;
            Row = row;
            theme = Gameobject.Theme;
            Value = 0;
        }

        void UpdateUI()
        {
            if (Value != 0)
                Gameobject.Text = Value.ToString();
            else
                Gameobject.Text = "";
            var color = MapIntToColor(Value*50);
            Gameobject.Modulate = color.Inverted();
            if (Value.ToString().Length >= 2)
                Gameobject.AddThemeFontSizeOverride("font_size", 50 - ((Value.ToString().Length - 2) * 12));
            else
                Gameobject.RemoveThemeFontSizeOverride("font_size");
        }
        public Color MapIntToColor(int colorValue)
        {
            byte red = (byte)((colorValue >> 16) & 0xFF);
            byte green = (byte)((colorValue >> 8) & 0xFF);
            byte blue = (byte)(colorValue & 0xFF);

            // Create and return the Color object
            return new Color(red, green, blue, 1);
        }

    }

}

