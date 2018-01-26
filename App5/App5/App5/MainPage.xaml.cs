using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.Title = "住所検索アプリ";
            getAddressSearchBtn.Clicked += GetAddressSearchBtn_Clicked;

            this.BindingContext = new Address();
		}
        private async void GetAddressSearchBtn_Clicked(
            object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(AddressEntry.Text)&&((string)AddressEntry.Text).Length == 7)
            {
                Address Ad = await Core.GetAddressSerchResult(AddressEntry.Text);
                if(Ad == null)
                {
                    DisplayAlert("通知", "検索に失敗しました", "OK");
                    return;
                }
                else
                {
                    this.BindingContext = Ad;
                }
            }
            else
            {
                DisplayAlert("警告", "郵便番号は7桁で入力してください", "OK");
            }
        }

    }
}
