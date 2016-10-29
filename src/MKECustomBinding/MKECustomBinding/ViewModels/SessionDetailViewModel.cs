using System;
using MKEValueConvert;
using Xamarin.Forms;
using System.Linq;
using System.ComponentModel;
namespace MKECustomBinding
{
	public class SessionDetailViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		INavigation _nav;
		public SessionDetailViewModel(SessionFeedback feedback, INavigation nav)
		{
			_nav = nav;

			this.Feedback = feedback;
		}

		SessionFeedback _feedback;
		public SessionFeedback Feedback
		{
			get
			{
				return _feedback;
			}
			set
			{
				_feedback = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Feedback"));
			}
		}

		Command _saveFeedbackCommand;
		public Command SaveFeedbackCommand
		{
			get
			{
				if (_saveFeedbackCommand == null)
				{
					_saveFeedbackCommand = new Command(async () =>
					{
						var session = SessionFeedbackService.AllSessions.First(f => f.SessionId == Feedback.SessionId);
						var index = SessionFeedbackService.AllSessions.IndexOf(session);
						SessionFeedbackService.AllSessions.Remove(session);
						SessionFeedbackService.AllSessions.Insert(index, Feedback);

						await _nav.PopAsync(true);
					});
				}
				return _saveFeedbackCommand;
			}
		}
	}

}