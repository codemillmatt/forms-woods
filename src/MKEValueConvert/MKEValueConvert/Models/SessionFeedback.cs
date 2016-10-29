using System;
namespace MKEValueConvert
{
	public class SessionFeedback
	{
		public SessionFeedback()
		{
		}

		public string SessionName
		{
			get;
			set;
		}

		public int TreeRating
		{
			get;
			set;
		}

		public string Feedback
		{
			get;
			set;
		}

		public string EmailAddress
		{
			get;
			set;
		}

		public bool Attended
		{
			get;
			set;
		}
	}
}
