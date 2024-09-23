namespace pract7
{
	public partial class MainPage : ContentPage
	{

		string fio1, name1, otchh,nuzh;
		int age1,ozenka;
		bool sw11, sw22;
		bool flag = false;
		
		public MainPage()
		{
			InitializeComponent();
		}
		
		async private void Button_Clicked(object sender, EventArgs e)
		{
			bool age2 = int.TryParse(age.Text, out age1);
			if ((string.IsNullOrEmpty(fio.Text)) || (string.IsNullOrEmpty(name.Text)) ||
				(string.IsNullOrEmpty(otch.Text)) || (string.IsNullOrEmpty(age.Text)) ||
				pc1.SelectedItem == null || !age2)
			{
				DisplayAlert("Введите корректные данные", "", "ок");
			}
			else
			{
				fio1 = fio.Text;
				Save.fio11 = fio1;
				name1 = name.Text;
				Save.name11 = name1;
				otchh = otch.Text;
				Save.otchh11 = otchh;
				age1 = int.Parse(age.Text);
				Save.age11 = age1;
				sw11 = sw.IsToggled;
				Save.sw111 = sw11;
				sw22 = sw2.IsToggled;
				Save.sw221 = sw22;
				nuzh = pc1.SelectedItem.ToString();
				Save.nuzh11 = nuzh;
				ozenka = int.Parse(lb1.Text);
				Save.ozenka1 = ozenka;
				flag = true;
				await Navigation.PushAsync(new NewPage1());
			}
			
		}

		private void sl_ValueChanged_1(object sender, ValueChangedEventArgs e)
		{
			lb1.Text = sl.Value.ToString();
			lb1.Text = e.NewValue.ToString();
		}
	}

}
