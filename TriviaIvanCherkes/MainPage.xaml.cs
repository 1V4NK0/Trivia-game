namespace TriviaIvanCherkes;

public partial class MainPage : ContentPage
{
	

	//saving option

	public MainPage()
	{
		InitializeComponent();
	}

     void SettingsBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		 Shell.Current.GoToAsync(nameof(Settings));
    }

}


