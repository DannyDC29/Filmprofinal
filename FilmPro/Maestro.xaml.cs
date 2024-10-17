namespace FilmPro;

public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();


    }

    private void Page1(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page1());
        App.flyoutPage.IsPresented = false;
    }

    private void Page5(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page5());
        App.flyoutPage.IsPresented = false;
    }

    private void Page3(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page3());
        App.flyoutPage.IsPresented = false;
    }

    private void Page2(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page2());
        App.flyoutPage.IsPresented = false;
    }

    private void Page4(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page4());
        App.flyoutPage.IsPresented = false;
    }
}