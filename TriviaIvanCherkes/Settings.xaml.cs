namespace TriviaIvanCherkes;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();

        FontPicker.ItemsSource = new List<string>
        {
            "10", "12", "14", "16", "18"
        };

        DifficultyPicker.ItemsSource = new List<string>
        {
            "Easy", "Medium", "Hard"
        };
    }

    void FontPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
    }

    void DifficultyPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
    }

    void TimeLimitEntry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        //if value < 0 || > 40 displayAlert
    }

    void NumOfQuestionsEntry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        //if value < 0 || > 40 displayAlert
    }
}
