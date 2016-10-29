using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MKEValueConvert
{
	public static class SessionFeedbackService
	{
		public static void SeedSessions()
		{
			AllSessions.Add(
				new SessionFeedback()
				{
					SessionName = "Inside Open Source Cross Platform .Net", TreeRating=2, SessionId=1
				});

			AllSessions.Add(
				new SessionFeedback() { SessionName = "From Legacy MVC to Modern MVC", SessionId = 2 }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "What Every Developer Should Know About SQL Performance", SessionId = 3 }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "Asynchronous? Parallel? Reactive? Help!", SessionId = 4 }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "An Introduction to Cross-Platform Mobile Development with Xamarin", SessionId = 5 }
			);
		}

		public static ObservableCollection<SessionFeedback> AllSessions { get; set; } = new ObservableCollection<SessionFeedback>();
	}
}
