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

		if (Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0, -velocità);
		}
		else if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, velocità);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-velocità, 0);
		}
		else if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(velocità, 0);
		}
	}
}
