using System;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using Xamarin.Forms;
using FontIconsInXamarinForms.Droid.Renderers;
using System.Diagnostics;

[assembly: ExportRenderer(typeof(Label), typeof(LabelTypefaceRenderer))]
[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(ButtonTypefaceRenderer))]

namespace FontIconsInXamarinForms.Droid.Renderers
{
	class FontUtils
	{
		public static void ApplyTypeface(TextView view, string fontFamily)
		{
			if (!string.IsNullOrEmpty(fontFamily))
			{
				Typeface typeFace = null;
				try
				{
					typeFace = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, fontFamily);
				}
				catch (Exception ex) {
					Debug.WriteLine($"Could not load font {fontFamily}: {ex}");
				}

				if (typeFace != null)
				{
					view.Typeface = typeFace;
				}
			}
		}
	}
	
	public class LabelTypefaceRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			FontUtils.ApplyTypeface(Control, Element.FontFamily);
		}
	}

	public class ButtonTypefaceRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			FontUtils.ApplyTypeface(Control, Element.FontFamily);
		}
	}
}
