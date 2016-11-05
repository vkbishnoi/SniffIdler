using SniffIdler.BL;
using System;
using System.Windows;
using System.Windows.Threading;

namespace SniffIdler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var _viewModel = new SniffViewModel(new SniffEventLogReader());

            _viewModel.StartBusy += new EventHandler(startProgress);
            _viewModel.StopBusy += new EventHandler(stopProgress);
            DataContext = _viewModel;
            InitializeComponent();
        }

        void startProgress(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                bi.IsBusy = true;
            }), null);
        }

        void stopProgress(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(()=>
            {
                bi.IsBusy = false;
            }), null);
        }
        
    }
}
