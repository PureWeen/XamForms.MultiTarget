using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamForms.MultiTarget;
using XamForms.MultiTarget.Platforms.iOS;

[assembly: ExportRenderer(typeof(SeperateFoldersEntry), typeof(SeperateFoldersEntryRenderer))]
namespace XamForms.MultiTarget.Platforms.iOS
{
    public class SeperateFoldersEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}
