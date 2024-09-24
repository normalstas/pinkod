namespace pract7
{
	public partial class MainPage : ContentPage
	{

		string fio1, name1, otchh,nuzh;
		int age1,ozenka;
		bool sw11, sw22;

		private ImageData selectedImageData;

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
				sw22 = sw2.IsToggled;
				Save.sw221 = sw22;
				nuzh = pc1.SelectedItem.ToString();
				Save.nuzh11 = nuzh;
				ozenka = int.Parse(lb1.Text);
				Save.ozenka1 = ozenka;
				flag = true;
				if (selectedImageData != null)
				{
					// Переход на новую страницу и передача данных
					await Navigation.PushAsync(new NewPage1(selectedImageData));
				}
				else
				{
					await DisplayAlert("Ошибка", "Сначала выберите изображение.", "OK");
				}

			}

		}

		private void sl_ValueChanged_1(object sender, ValueChangedEventArgs e)
		{
			lb1.Text = sl.Value.ToString();
			lb1.Text = e.NewValue.ToString();
		}

		async public void Button_Clicked_1(object sender, EventArgs e)
		{
			var options = new PickOptions
			{
				PickerTitle = "Выберите картинку",
				FileTypes = FilePickerFileType.Images,


			};

			var result = await FilePicker.PickAsync(options);
			if (result != null)
			{
				// Отображение выбранного изображения
				selectedImageData = new ImageData
				{
					ImagePath = result.FullPath
				};
				img.Source = ImageSource.FromFile(result.FullPath);
				await DisplayAlert("Успех", "Изображение выбрано!", "OK");

			}
			else
			{
				// Пользователь отменил выбор
				await DisplayAlert("Ошибка", "Изображение не выбрано.", "OK");
			}
		}


	}

}
