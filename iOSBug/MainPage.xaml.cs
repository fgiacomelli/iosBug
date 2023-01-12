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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		viewModel.ButtonClicked();
	}
}

