using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MKEValueConvert
{
	public partial class SessionsListView : ContentPage
	{
		public SessionsListView()
		{
			InitializeComponent();
			BindingContext = new SessionsListViewModel();
		}
	}
}
