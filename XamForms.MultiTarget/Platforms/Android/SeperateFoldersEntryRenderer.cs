using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamForms.MultiTarget;
using XamForms.MultiTarget.Platforms.Android;

[assembly: ExportRenderer(typeof(SeperateFoldersEntry), typeof(SeperateFoldersEntryRenderer))]
namespace XamForms.MultiTarget.Platforms.Android
{
    public class SeperateFoldersEntryRenderer : EntryRenderer
    {
        public SeperateFoldersEntryRenderer(Context context) : base(context)
        {
        }
    }
}
