﻿using System;
using Xamarin.Forms;

namespace XFProfile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PhoneClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Twitter", "Twitter clicked!", "OK");
        }

        private async void MailClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Instagram", "Instagram clicked!", "OK");
        }

        private async void FollowClicked(object sender, EventArgs e)
        {
            await DisplayAlert("ShowMore", "Show More clicked!", "OK");
        }
    }
}
