using Godot;
using System;

public partial class Tree3D : Sprite3D
{

	[Export] Camera3D Camera;
	[Export] CsgCylinder3D collisionCSGShape;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Camera == null) return;

		// var targetPos = Camera.GlobalPosition;

		// //LookAt(targetPos);
		// //collisionCSGShape.LookAt(targetPos, Vector3.Up);
		// collisionCSGShape.LookAt(targetPos);


		// GD.PrintT("trying to adjust positions");
		var toCamera = (Camera.GlobalPosition - GlobalPosition).Normalized();
		//collisionCSGShape.LookAt(GlobalPosition + toCamera, Vector3.Up);
		collisionCSGShape.LookAt(toCamera, Vector3.Up);

	}

	// if sprite.billboard_mode != Sprite3D.BILLBOARD_DISABLED:
	// # Align the collision shape with the sprite's billboard rotation
	// var camera = get_viewport().get_camera_3d()
	// if camera:
	//     # Calculate the direction from the sprite to the camera
	//     var to_camera = (camera.global_transform.origin - sprite.global_transform.origin).normalized()

	// 	# Adjust the collision shape's rotation to face the camera
	// 	collision_shape.look_at(sprite.global_transform.origin + to_camera, Vector3.UP)

	// func _process(delta):

	// var target_pos = ... # Your target position to look at, player/camera/?
	// look_at(target_pos)
}
