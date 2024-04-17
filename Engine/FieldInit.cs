using Godot;
using FieldData;
using System;

public partial class FieldInit : Node2D
{
    public Signal SwipeDetection;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

        base._Ready();
        int lenght = (int)this.GetMeta("lenght");
        Node node = GetNode("CanvasLayer/ColorRect/GridContainer");
        Field.DeskPlayer = new PlayerEngine.Player(lenght, node);
        Field.SpawnRandom();
    }
    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventKey eventKey)
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
    // Called every frame. 'delta' is the elapsed time since the previous frame.

}
