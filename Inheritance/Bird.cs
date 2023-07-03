using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
            CanFly = true;
            ColorOfWings = "black";
            BirdColor = "grey";
            BeakColor = "pink";


		}
        public bool CanFly { get; set; }
        public string BirdColor  { get; set; }
        public string ColorOfWings { get; set; }
        public string BeakColor { get; set; }
    }
}

