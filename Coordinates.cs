/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
namespace InDepthWin
{
	class Coordinates
	{
		public int X, Y;
		public Coordinates(int x, int y)
		{
			X = x;
			Y = y;
		}

		public String CurrentC()
		{
			return X.ToString("0000") + ":" + Y.ToString("0000");
		}

	}
}
