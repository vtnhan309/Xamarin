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
	public partial class MH_TinhTong : ContentPage
	{
		public MH_TinhTong ()
		{
			InitializeComponent ();
		}

    private void CmdCountSum_Clicked(object sender, EventArgs e)
    {
      double _num1, _num2, _sum;
      _num1 = double.Parse(numA.Text);
      _num2 = double.Parse(numB.Text);
      _sum = _num1 + _num2;
      Sum.Text = _sum.ToString();
    }

    private void CmdBackHome_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainPage());
    }
  }
}