using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamForms.MultiTarget;
using XamForms.MultiTarget.Platforms.UWP;

[assembly: ExportRenderer(typeof(FileExtensionEntry), typeof(FileExtensionEntryRenderer))]
namespace XamForms.MultiTarget.Platforms.UWP
{
    public class FileExtensionEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {                
                Control.Text = "FileExtensionEntryRenderer";
            }
        }
    }
}
