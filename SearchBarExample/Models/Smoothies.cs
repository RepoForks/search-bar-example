using System;
namespace SearchBarExample
{
	public class Smoothie
	{
			public string Name { set; get; }
			public string Description { set; get; }
			public string ImagePath { set; get; }
			public string NameToUpper { 
				get { return Name.ToUpper (); } 
			}
	}
}

