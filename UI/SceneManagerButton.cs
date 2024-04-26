using Godot;
using System;

public partial class SceneManagerButton : VBoxContainer
{
	public void _on_x_4_pressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/4x_4.tscn");
	}
    public void _on_x_8_pressed()
	{
        GetTree().ChangeSceneToFile("res://Scenes/8x_8.tscn");
    }
	public void _on_x_10_pressed()
	{
        GetTree().ChangeSceneToFile("res://Scenes/10x_10.tscn");
    }
}
