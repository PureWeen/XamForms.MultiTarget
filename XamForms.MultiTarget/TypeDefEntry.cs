using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

#if WINDOWS
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Media;
using Windows.UI;
#endif

#if iOS
using UIKit;
using Xamarin.Forms.Platform.iOS;
#endif

#if ANDROID
using Android.Content;
using Xamarin.Forms.Platform.Android;
#endif

using XamForms.MultiTarget;

#if !PORTABLE
[assembly: ExportRenderer(typeof(TypeDefEntry), typeof(TypeDefEntryRenderer))]
#endif
namespace XamForms.MultiTarget
{
    public class TypeDefEntry : Entry
    {
    }



#if ANDROID
    public class TypeDefEntryRenderer : EntryRenderer
    {
        public TypeDefEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                Control.Text = "TypeDefEntryRenderer";
            }
        }
    }
#endif

#if iOS
    public class TypeDefEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged (e);

            if (Control != null) {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB (204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
#endif

#if WINDOWS 
    public class TypeDefEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new SolidColorBrush(Colors.Cyan);
            }
        }
    }

#endif

}
