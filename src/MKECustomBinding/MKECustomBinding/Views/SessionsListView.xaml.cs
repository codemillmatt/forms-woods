using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MKEValueConvert;

namespace MKECustomBinding
{
	public partial class SessionsListView : ContentPage
	{
		public SessionsListView()
		{
			InitializeComponent();

			BindingContext = new SessionsListViewModel();

			sessionsList.ItemSelected += async (sender, e) =>
			{
				var feedback = e.SelectedItem as SessionFeedback;

				await Navigation.PushAsync(new SessionDetailView(new SessionDetailViewModel(feedback, Navigation)));
			};
		}
	}
}
