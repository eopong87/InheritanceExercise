using System;
namespace Inheritance
{
	public class Reptile : Animal
		
	{
		public Reptile()
		{
			HasRoughSkin = true;
			Age = 24;
			Slithers = true;
			NumOfLegs = 0;


		}
        public bool HasRoughSkin { get; set; }
        public int Age { get; set; }
        public bool Slithers { get; set; }
        public int NumOfLegs { get; set; }
    }
}

