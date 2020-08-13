using Shhh.Models;
using Shhh.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shhh.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SilensorAction : ContentPage
    {
        private readonly SilensorActionViewModel vm;

        public SilensorAction()
        {
            InitializeComponent();
        }

        public SilensorAction(Silensor silensor)
        {
            InitializeComponent();
            BindingContext = vm = new SilensorActionViewModel(silensor);
        }
    }
}