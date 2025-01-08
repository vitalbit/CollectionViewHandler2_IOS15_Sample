using System.Collections.ObjectModel;

namespace CollectionViewHandler2_IOS15_Sample;

public partial class MainPage : ContentPage
{
	public ObservableCollection<string> ImagesToDisplay { get; } = new();

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
		ImagesToDisplay.Clear();

		ImagesToDisplay.Add("dotnet_bot.png");
		ImagesToDisplay.Add("dotnet_bot.png");
		ImagesToDisplay.Add("dotnet_bot.png");
		
        base.OnAppearing();
    }
}

