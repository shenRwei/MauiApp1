namespace MauiApp1;

public partial class FruitDetail : ContentPage
{
	public FruitDetail(string Name, string Image, string Description)
	{
		InitializeComponent();
		showName.Text = Name;
		showDescription.Text = Description;
		showImage.Source = Image;
	}
}