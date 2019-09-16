using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		public static double FindSightAngle(double v, double distance)
		{
            var g = 9.8;
            var s =v*v; 
            var corner = 0.5*Math.Asin(distance*g/s);
            return corner;
		}
	}
}	