/*
 * Code Written by: Patrik Schodrowski
 * All rights reserved
*/
using System;
namespace InDepthWin
{
	class Place
	{
		public int PCounter = 0;
		public int PCapacity;
		public String placename;
		public Coordinates placeXY;
		public int plindex;

		public Place(int index, String name, Coordinates xy, int PCap)
		{
			plindex = index;
			placename = name;
			placeXY = xy;
			PCapacity = PCap;
		}
	}
}
