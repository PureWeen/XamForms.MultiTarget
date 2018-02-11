using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamForms.MultiTarget;
using XamForms.MultiTarget.Platforms.Android;

[assembly: ExportRenderer(typeof(FileExtensionEntry), typeof(FileExtensionEntryRenderer))]
namespace XamForms.MultiTarget.Platforms.Android
{
    public class FileExtensionEntryRenderer : EntryRenderer
    {
        public FileExtensionEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
                Control.Text = "FileExtensionEntryRenderer";
        }
    }
}
