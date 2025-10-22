using Criticografo_GAFF.View;

namespace Criticografo_GAFF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Criticografo();
        }
    }
}
