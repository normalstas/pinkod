namespace pract7;

public partial class Pass3 : ContentPage
{
	public Pass3()
	{
		InitializeComponent();
		cbnback.Text = "<=";
	}
	string log = "123";
	async private void Clicked1(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "1";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked2(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "2";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked3(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "3";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked4(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "4";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked5(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "5";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked6(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "6";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked7(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "7";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked8(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "8";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked9(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "9";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void Clicked0(object sender, EventArgs e)
	{
		ell1.Fill = Colors.Green;
		ell2.Fill = Colors.Green;
		ell3.Fill = Colors.Green;
		Data.password += "0";
		if (Data.password == log)
		{
			await Navigation.PushModalAsync(new MainPage());

		}
		else
		{
			Data.password = Data.password[..^1];
			ell1.Fill = Colors.Red;
			ell2.Fill = Colors.Red;
			ell3.Fill = Colors.Red;
		}
	}
	async private void ClickedBack(object sender, EventArgs e)
	{
		Data.password = Data.password[..^1];
		await Navigation.PopModalAsync();
	}
}