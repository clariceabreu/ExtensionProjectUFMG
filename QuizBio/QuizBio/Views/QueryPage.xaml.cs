using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizBio.ViewModels;
using Xamarin.Forms;

namespace QuizBio.Views
{
    public partial class QueryPage : ContentPage
    {
        public QueryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            QueryPageViewModel vm = BindingContext as QueryPageViewModel;

            vm.FadeOut = async () =>
            {
                await Task.WhenAll(
                    option_1.FadeTo(0, 500),
                    option_2.FadeTo(0, 500),
                    option_3.FadeTo(0, 500),
                    option_4.FadeTo(0, 500)
                );
            };

            vm.FadeIn = async () =>
            {
                await Task.WhenAll(
                    option_2.FadeTo(1, 500),
                    justification.FadeTo(1,500)
                    
                );
            };

        }
    }
}
