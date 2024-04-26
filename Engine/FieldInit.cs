using Godot;
using FieldData;
using System;

public partial class FieldInit : Node2D
{
    public override void _Ready()
    {

        base._Ready();
        int lenght = (int)this.GetMeta("lenght");
        Field.DeskPlayer = new PlayerEngine.Player(lenght, this);
        Field.SpawnRandom();
    }
    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventKey eventKey && !Field.DeskPlayer.GameOver)
        {
            if (eventKey.Pressed && eventKey.Keycode == Key.Up)
                Field.MoveUp();
            else if (eventKey.Pressed && eventKey.Keycode == Key.Down)
                Field.MoveDown();
            else if(eventKey.Pressed && eventKey.Keycode == Key.Left)
                Field.MoveLeft();
            else if(eventKey.Pressed && eventKey.Keycode == Key.Right)
                Field.MoveRight();
        }
    }
    public void _on_backtomenu_pressed()
    {
        GetTree().ChangeSceneToFile("res://Scenes/menu.tscn");
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.

}
