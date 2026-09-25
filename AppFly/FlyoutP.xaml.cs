namespace AppFly;

public partial class FlyoutP : FlyoutPage
{
    public FlyoutP()
    {
        InitializeComponent();

        Detail = new NavigationPage(new MainPage());
    }

    private void Minecraft(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Minecraft());
        IsPresented = false;
    }

    private void hades(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new hades());
        IsPresented = false;
    }

    private void Valorant(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new valorant());
        IsPresented = false;
    }
}