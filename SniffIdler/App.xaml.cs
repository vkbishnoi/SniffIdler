using System.Windows;
using System.Threading;

namespace SniffIdler
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Mutex mut;
        public App()
        {
            bool createdNew;
            mut = new Mutex(true, "KC_ALPHA", out createdNew);

            if (!createdNew)
            {
                this.Shutdown();
            }
        }
    }
}
