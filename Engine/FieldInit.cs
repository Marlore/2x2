using Godot;
using FieldData;
using System;

public partial class FieldInit : Node2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        int lenght = (int)this.GetMeta("lenght");
        Node node = GetNode("CanvasLayer/ColorRect/GridContainer");
        FieldData.Field.DeskPlayer = new PlayerEngine.Player(lenght, node);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}
