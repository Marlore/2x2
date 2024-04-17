using Cells;
using Godot;
using PlayerEngine;
using System;

namespace FieldData
{
    public static class Field
    {
        public static Player DeskPlayer;

        public static void SpawnRandom() 
        {
            Random rand = new Random();
            var plate = DeskPlayer.field.FindAll(x => x.Value == 0);
            plate[rand.Next(0, plate.Count)].Value = 2;
        }
        public static void MoveUp()
        {
            for (int i = 0; i < DeskPlayer.field.Count; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.Find(x => x.Column == currentTile.Column && x.Value==0 && x.Row< currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }

            for (int i = 0; i < DeskPlayer.field.Count; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var calculatedTile = DeskPlayer.field.Find(x => x.Row == currentTile.Row - 1 && x.Column == currentTile.Column && x.Value == currentTile.Value);
                if (calculatedTile != null)
                {
                    calculatedTile.Value += currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            for (int i = 0; i < DeskPlayer.field.Count; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.Find(x => x.Column == currentTile.Column && x.Value == 0 && x.Row < currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            SpawnRandom();
        }
        public static void MoveDown()
        {
            for (int i = DeskPlayer.field.Count-1; i >=0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.FindLast(x => x.Column == currentTile.Column && x.Value == 0 && x.Row > currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }

            for (int i = DeskPlayer.field.Count - 1; i >= 0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var calculatedTile = DeskPlayer.field.FindLast(x => x.Row == currentTile.Row +1 && x.Column == currentTile.Column && x.Value == currentTile.Value);
                if (calculatedTile != null)
                {
                    calculatedTile.Value += currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            for (int i = DeskPlayer.field.Count - 1; i >= 0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.FindLast(x => x.Column == currentTile.Column && x.Value == 0 && x.Row > currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            SpawnRandom();
        }
        public static void MoveLeft() 
        {
            for (int i = 0; i < DeskPlayer.field.Count ; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.Find(x => x.Column < currentTile.Column && x.Value == 0 && x.Row == currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }

            for (int i = 0; i < DeskPlayer.field.Count; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var calculatedTile = DeskPlayer.field.Find(x => x.Row == currentTile.Row && x.Column == currentTile.Column-1 && x.Value == currentTile.Value);
                if (calculatedTile != null)
                {
                    calculatedTile.Value += currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            for (int i = 0; i < DeskPlayer.field.Count; i++)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.Find(x => x.Column < currentTile.Column && x.Value == 0 && x.Row == currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            SpawnRandom();
        }
        public static void MoveRight()
        {
            for (int i = DeskPlayer.field.Count - 1; i >= 0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.FindLast(x => x.Column > currentTile.Column && x.Value == 0 && x.Row == currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }

            for (int i = DeskPlayer.field.Count - 1; i >= 0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var calculatedTile = DeskPlayer.field.FindLast(x => x.Row == currentTile.Row && x.Column == currentTile.Column + 1 && x.Value == currentTile.Value);
                if (calculatedTile != null)
                {
                    calculatedTile.Value += currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            for (int i = DeskPlayer.field.Count - 1; i >= 0; i--)
            {
                var currentTile = DeskPlayer.field[i];
                var tiletoadd = DeskPlayer.field.FindLast(x => x.Column > currentTile.Column && x.Value == 0 && x.Row == currentTile.Row);
                if (tiletoadd != null)
                {
                    tiletoadd.Value = currentTile.Value;
                    currentTile.Value = 0;
                }
            }
            SpawnRandom();
        }
    }
}