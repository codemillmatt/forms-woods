using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;
using MKECustomBinding;

[assembly:ExportEffect(typeof(LabelShadowEffect), "labelshadow"), ResolutionGroupName("MKE")]
namespace MKECustomBinding
{
	public class LabelShadowEffect : PlatformEffect
	{
		UIColor oldShadowColor;
		CGSize oldShadowOffset;

		public LabelShadowEffect()
		{

		}

		protected override void OnAttached()
		{
			if (Element is Label == false)
				return;

			var nativeLabel = Control as UILabel;
			oldShadowColor = nativeLabel.ShadowColor;
			oldShadowOffset = nativeLabel.ShadowOffset;

			nativeLabel.ShadowColor = UIColor.Magenta;
			nativeLabel.ShadowOffset = new CGSize(2, 3);
		}

		protected override void OnDetached()
		{
			if (oldShadowColor != null)
			{
				var nativeLabel = Control as UILabel;
				nativeLabel.ShadowColor = oldShadowColor;
				nativeLabel.ShadowOffset = oldShadowOffset;
			}
		}
	}
}
