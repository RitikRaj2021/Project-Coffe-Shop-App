namespace MauiApp1test.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();


    }

    //Opens up the Espresso menu when the button is clicked
    private async void Button_Clicked1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Espresso());
    }

    //Opens up the HotDrinks menu when the button is clicked
    private async void Button_Clicked2(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HotDrinks());
    }

    //Opens up the ColdDrinks menu when the button is clicked
    private async void Button_Clicked3(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ColdDrinks());
    }

    //Opens up the QuickBites menu when the button is clicked
    private async void Button_Clicked4(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new QuickBites());
    }

    //Opens up the FullMenu menu when the button is clicked
    private async void Button_Clicked5(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FullMenu());
    }
}