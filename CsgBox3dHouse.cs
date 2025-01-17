using Godot;
using System;

public partial class CsgBox3dHouse : CsgBox3D
{
	private Vector3 originalScale;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		originalScale = Scale;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Transform3D cameratTransform = GetViewport().GetCamera3D().GlobalTransform;
		// Transform3D spriteTransform = GlobalTransform;

		// Vector3 basisX = spriteTransform.Basis.X;
		// Vector3 basisY = spriteTransform.Basis.Y;
		// Vector3 basisZ = spriteTransform.Basis.Z;

		// basisZ = (cameratTransform.Origin - spriteTransform.Origin).Normalized();
		// basisX = basisY.Cross(basisZ).Normalized() * originalScale.X;

		// GlobalTransform = new Transform3D(basisX, basisY, basisZ, spriteTransform.Origin);


	}
}
