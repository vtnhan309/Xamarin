using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MH_Chao());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MH_TinhTong());
    }

    private void CmdLogin_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MH_Login());
    }

    private void CmdEntry_Clicked(object sender, EventArgs e)
    {

    }

    private void CmdScrollView_Clicked(object sender, EventArgs e)
    {

    }

    private void CmdFlexLayout_Clicked(object sender, EventArgs e)
    {

    }

    private void CmdGridLayout_Clicked(object sender, EventArgs e)
    {

    }

    private void CndAbsoluteLayout_Clicked(object sender, EventArgs e)
    {

    }

    private void CmdListview1_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }

    private void CndAbsoluteLayout_Clicked_1(object sender, EventArgs e)
    {

    }

    private void CmdAbsoluteLayout_Clicked(object sender, EventArgs e)
    {

    }
  }
}
