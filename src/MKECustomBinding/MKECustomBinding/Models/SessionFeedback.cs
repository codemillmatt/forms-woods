using System;
namespace MKEValueConvert
{
	public class SessionFeedback
	{
		public int SessionId { get; set; }

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
