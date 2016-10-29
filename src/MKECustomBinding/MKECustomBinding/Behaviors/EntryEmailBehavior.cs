using System;
using Xamarin.Forms;
using System.Text.RegularExpressions;
namespace MKECustomBinding
{
	public class EntryEmailBehavior : Behavior<Entry>
	{
		const string email_reg_ex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";

		public EntryEmailBehavior()
		{
		}

		protected override void OnAttachedTo(Entry bindable)
		{
			base.OnAttachedTo(bindable);

			bindable.TextChanged += Bindable_TextChanged;
		}

		protected override void OnDetachingFrom(Entry bindable)
		{
			base.OnDetachingFrom(bindable);

			bindable.TextChanged -= Bindable_TextChanged;
		}

		void Bindable_TextChanged(object sender, TextChangedEventArgs e)
		{
			var entry = sender as Entry;

			if (!Regex.IsMatch(entry.Text, email_reg_ex))
			{
				entry.TextColor = Color.Red;
			}
			else
			{
				entry.TextColor = Color.Default;
			}
		}
	}
}
