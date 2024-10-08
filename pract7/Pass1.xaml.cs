namespace pract7;

public partial class Pass1 : ContentPage
{
	public Pass1()
	{
		InitializeComponent();
		cbnback.Text = "<=";
	}

	async private void Clicked1(object sender, EventArgs e)
	{
		Data.password += "1";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked2(object sender, EventArgs e)
	{
		Data.password += "2";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked3(object sender, EventArgs e)
	{
		Data.password += "3";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked4(object sender, EventArgs e)
	{
		Data.password += "4";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked5(object sender, EventArgs e)
	{
		Data.password += "5";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked6(object sender, EventArgs e)
	{
		Data.password += "6";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked7(object sender, EventArgs e)
	{
		Data.password += "7";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked8(object sender, EventArgs e)
	{
		Data.password += "8";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked9(object sender, EventArgs e)
	{
		Data.password += "9";
		await Navigation.PushModalAsync(new Pass2());
	}
	async private void Clicked0(object sender, EventArgs e)
	{
		Data.password += "0";
		await Navigation.PushModalAsync(new Pass2());
	}
	private void ClickedBack(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}
}