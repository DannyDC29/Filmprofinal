﻿namespace FilmPro
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

            Flyout = new Maestro();
            Detail = new NavigationPage(new Menu());

            App.flyoutPage = this;
        }
    }

}
