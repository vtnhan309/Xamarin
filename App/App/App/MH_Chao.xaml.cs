using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MH_Chao : ContentPage
	{
		public MH_Chao ()
		{
			InitializeComponent ();
		}

    private void CmdHello_Clicked(object sender, EventArgs e)
    {
      string name = txtName.Text;
      DisplayAlert("Chào", "Chào Bạn: " + name, "Thoát");
    }
  }
}