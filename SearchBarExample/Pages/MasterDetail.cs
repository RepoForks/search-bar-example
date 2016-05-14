using System;
using Xamarin.Forms;
using FreshMvvm;

namespace SearchBarExample
{
	public class MasterDetail: MasterDetailPage
	{
		public MasterDetail ()
		{
			var master = new HambergerPage ();
			Master = master;

			var navContainer = new FreshNavigationContainer (FreshPageModelResolver.ResolvePageModel<FoodPageModel> ());
			navContainer.BarTextColor = Color.FromHex ("#4c4947");
			Detail = navContainer;
		}
	}
}

