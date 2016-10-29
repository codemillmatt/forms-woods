using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MKEValueConvert
{
	public class SessionFeedbackService
	{
		public SessionFeedbackService()
		{
			AllSessions.Add(
				new SessionFeedback()
				{
					SessionName = "Inside Open Source Cross Platform .Net", Attended=true
				});

			AllSessions.Add(
				new SessionFeedback() { SessionName = "From Legacy MVC to Modern MVC" }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "What Every Developer Should Know About SQL Performance" }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "Asynchronous? Parallel? Reactive? Help!" }
			);

			AllSessions.Add(
				new SessionFeedback() { SessionName = "An Introduction to Cross-Platform Mobile Development with Xamarin" }
			);
		}

		public List<SessionFeedback> AllSessions { get; set; } = new List<SessionFeedback>();
	}
}
