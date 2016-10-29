using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace MKEValueConvert
{
	public class SessionsListViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public SessionsListViewModel()
		{
			Title = "Sessions";

			// Populate the models ... because we're too lazy to create a service to do so
			SessionFeedbackList = SessionFeedbackService.AllSessions;
		}

		string _title;
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
			}
		}

		public ObservableCollection<SessionFeedback> SessionFeedbackList { get; set; } = new ObservableCollection<SessionFeedback>();
				

	}
}
