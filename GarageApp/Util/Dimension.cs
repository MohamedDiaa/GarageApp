using System;
namespace GarageApp.Util
{
	public class Dimension
	{
        double Width { get; }
        double Height { get; }

		public Dimension(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}
	}
}

