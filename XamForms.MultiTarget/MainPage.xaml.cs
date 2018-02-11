using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamForms.MultiTarget
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            StackLayout control = new StackLayout();

            control.Children.Add(new TypeDefEntry());

            control.Children.Add(new SeperateFoldersEntry());
            control.Children.Add(new FileExtensionEntry());
            Content = control;
        }
	}
}
