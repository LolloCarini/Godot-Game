using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public override void _Ready()
	{

	}

	public override void _Process(double delta)
	{
		float velocità = 2;

		Position += Input.GetVector("move_left", "move_right", "move_up", "move_down") * velocità;
	}
}
