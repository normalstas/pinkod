namespace pract7;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		InitializePickers();
	}


	private void InitializePickers()
	{
		
			
			string fio1, name1, otchh1, nuzh1;
			int age1, ozenka;
			bool sw11, sw22;
			fio1 = Save.fio11;
			name1 = Save.name11;
			otchh1 = Save.otchh11;
			nuzh1 = Save.nuzh11;
			age1 = Save.age11;
			ozenka = Save.ozenka1;
			sw11 = Save.sw111;
			sw22 = Save.sw221;
			inf.Text = "Поздравляю(докс).Вот информация про вас:";
			fio.Text = "Ваше ФИО: ";
			f.Text = fio1;
			i.Text = name1;
			o.Text = otchh1;

			let.Text = $"Вам целых {age1}";

			if (sw11)
			{
				fotolb.IsVisible = true;
				foto.IsVisible = true;
			}

			if (nuzh1 == "Да")
			{
				obzhaga.Text = "Вам нужно общежитие";
			}
			else
			{
				obzhaga.Text = "Вам не нужно общежитие";
			}

			if (sw22)
			{
				starosta.Text = "Вы староста";
			}
			else
			{
				starosta.Text = "Вы не староста";
			}

			switch (ozenka)
			{
				case 2: otcen.Text = "У вас одни двойки:("; break;
				case 3: otcen.Text = "Оценки 3,можно лучше"; break;
				case 4: otcen.Text = "У вас одни 4, хорошо"; break;
				case 5: otcen.Text = "Вы отличник! Одни 5"; break;
				default:
					break;
			}
		
		 
	}
}