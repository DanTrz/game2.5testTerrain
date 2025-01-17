using Godot;
using System;

public partial class TreeConeDark2 : Node3D
{
	CollisionShape3D collisionCSGShape;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		collisionCSGShape = GetNode<CollisionShape3D>("%CollisionShape3D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var Camera = GetViewport().GetCamera3D();

		if (Camera == null) return;

		// var targetPos = Camera.GlobalPosition;

		// //LookAt(targetPos);
		// //collisionCSGShape.LookAt(targetPos, Vector3.Up);
		// collisionCSGShape.LookAt(targetPos);


		// GD.PrintT("trying to adjust positions");
		var toCamera = (Camera.GlobalPosition - GlobalPosition).Normalized();
		//collisionCSGShape.LookAt(GlobalPosition + toCamera, Vector3.Up);
		//collisionCSGShape.LookAt(GlobalTransform.Origin + toCamera, Vector3.Up);
		LookAt(GlobalPosition + toCamera, Vector3.Up);
	}
}
