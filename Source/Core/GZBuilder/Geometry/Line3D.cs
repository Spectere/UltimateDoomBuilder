﻿using System;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Rendering;

namespace CodeImp.DoomBuilder.GZBuilder.Geometry 
{
	public class Line3D 
	{
		// Coordinates
		public Vector3D v1;
		public Vector3D v2;
		public PixelColor color;

		// Constructors
		public Line3D(Vector3D v1, Vector3D v2) 
		{
			this.v1 = v1;
			this.v2 = v2;
			this.color = General.Colors.InfoLine;
		}

		public Line3D(Vector3D v1, Vector3D v2, PixelColor color) 
		{
			this.v1 = v1;
			this.v2 = v2;
			this.color = color;
		}

		public Vector3D GetDelta() { return v2 - v1; }

		// This calculates the angle
		public float GetAngle() 
		{
			// Calculate and return the angle
			Vector2D d = GetDelta();
			return -(float)Math.Atan2(-d.y, d.x) + Angle2D.PIHALF;
		}
	}
}
