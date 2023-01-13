namespace TriggerProblemiOSRelease;

public partial class MainPage : ContentPage
{
	MainPageViewModel viewModel;


    public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    private async void Privato_Tapped(object sender, TappedEventArgs e)
    {
		viewModel.ButtonClicked();
	}
}

