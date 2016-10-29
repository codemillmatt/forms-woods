using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MKEValueConvert;

namespace MKECustomBinding
{
	public partial class SessionDetailView : ContentPage
	{
		public SessionDetailView(SessionDetailViewModel sdvm)
		{
			InitializeComponent();

			BindingContext = sdvm;
		}
	}
}
