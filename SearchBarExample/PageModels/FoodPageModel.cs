using FreshMvvm;
using System;
using PropertyChanged;
using System.Collections.ObjectModel;

namespace SearchBarExample
{
	[ImplementPropertyChanged]
	public class FoodPageModel: FreshBasePageModel
	{
		private Smoothie _selectedItem;

		public ObservableCollection<Smoothie> Smoothies { set; get; }
		public Smoothie SelectedItem {
			get { return _selectedItem; }
			set { 
				_selectedItem = value;
			}
		}

		public FoodPageModel ()
		{
			Smoothies = new ObservableCollection<Smoothie> ();
			Smoothies.Add (new Smoothie { Name = "Blackberry-Kale Gelatinous Sludge Smoothie", Description = "Tastes like vomit.", ImagePath = "bkgss.png" });
			Smoothies.Add (new Smoothie { Name = "Funky Asparagus Disaster Smoothie", Description = "Asparagus makes your pee stink.", ImagePath = "fads.png" });
			Smoothies.Add (new Smoothie { Name = "Broccoli Bleck Smoothie", Description = "Broccoli doesn’t play nice with fruit.", ImagePath = "bbs.png" });
			Smoothies.Add (new Smoothie { Name = "Sweet Guacamole Smoothie", Description = "Avocado makes nothing taste better.", ImagePath = "sgs.png" });

		}
	}
}

