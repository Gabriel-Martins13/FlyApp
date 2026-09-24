namespace AppFly;

public partial class FlyoutP : FlyoutPage
{
	public FlyoutP()
	{
         InitializeComponent();

        //Define que a página inicial aberta dentro do Detail é a MainPage (Home)
        Detail = new NavigationPage(new MainPage());
    }

    private void Valorant(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new valorant());
        IsPresented = false;
    }

    private void OnValorantClicked(object sender, EventArgs e)
    {

    }
}