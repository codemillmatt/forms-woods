using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace MKEValueConvert
{
	public class SessionsListViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public SessionsListViewModel()
		{
			Title = "Sessions";

			// Populate the models ... because we're too lazy to create a service to do so
			var sessionSvc = new SessionFeedbackService();
			foreach (var item in sessionSvc.AllSessions)
			{
				SessionFeedbackList.Add(item);
			}

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
