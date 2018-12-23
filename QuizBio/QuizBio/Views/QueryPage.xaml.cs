using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizBio.Models;
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

            vm.FadeIn = async (answer) =>
            {
                if (answer == EOptions.Option_1)
                {
                    await Task.WhenAll(option_1.FadeTo(1, 500),
                                       justification.FadeTo(1, 500));
                }
                else if (answer == EOptions.Option_2)
                {
                    await Task.WhenAll(option_2.FadeTo(1, 500),
                                       justification.FadeTo(1, 500));
                }
                else if (answer == EOptions.Option_3)
                {
                    await Task.WhenAll(option_3.FadeTo(1, 500),
                                       justification.FadeTo(1, 500));
                }
                else
                {
                    await Task.WhenAll(option_4.FadeTo(1, 500),
                                       justification.FadeTo(1, 500));
                }
            };

        }
    }
}
