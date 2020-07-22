using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Calendar.Models;

namespace Calendar
{
    public partial class JobsPage : ContentPage
    {
        public JobsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetJobsAsync();
        }

        async void OnJobAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JobEntryPage
            {
                BindingContext = new Job()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new JobEntryPage
                {
                    BindingContext = e.SelectedItem as Job
                });
            }
        }
    }
}