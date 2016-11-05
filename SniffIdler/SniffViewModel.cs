using SniffIdler.BL;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SniffIdler
{
    class SniffViewModel : INotifyPropertyChanged
    {

        private int _noOfTimes;
        private string _date;
        private int _time;
        private ICommand _kcCommand;
        private ISniffEventLogReader _eventLogReader;


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler StartBusy;
        public event EventHandler StopBusy;

        public SniffViewModel(ISniffEventLogReader eventLogReader)
        {
            _eventLogReader = eventLogReader;
        }
        

        /// <summary>
        /// Command to start operation KC
        /// </summary>
        public ICommand FindKCCommand
        {
            get
            {
                if (_kcCommand == null)
                {
                    _kcCommand = new SniffCommand(Execute);
                }

                return _kcCommand;
            }
        }

        /// <summary>
        /// Number of times person was away from workstation
        /// </summary>
        public int NumberOfTimes
        {
            get
            {
                return _noOfTimes;
            }
            set
            {
                if (_noOfTimes != value)
                {
                    _noOfTimes = value;
                    RaisePropertyChanged(nameof(NumberOfTimes));
                }
            }
        }

        /// <summary>
        /// Date of KC operation
        /// </summary>
        public string KCDate
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                RaisePropertyChanged(nameof(KCDate));
            }
        }

        /// <summary>
        /// Minutes person was away from workstation
        /// </summary>
        public int KCTime
        {
            get
            {
                return _time;
            }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    RaisePropertyChanged(nameof(KCTime));
                }
            }
        }

        void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        void Execute()
        {
            Task tsk = new Task(DoWork);
            tsk.Start();
        }

        void DoWork()
        {
            try
            {
                //Raise the event so that UI can start displaying the busy indicator
                StartBusy?.Invoke(this, null);
                int numOfTimes;
                int totalMinutes;
                _eventLogReader.GetKCDetails(DateTime.Now.Date, out numOfTimes, out totalMinutes);
                if (numOfTimes == 0)
                {
                    System.Windows.MessageBox.Show("Good job. You are spending quality time with your workstation.");
                    return;
                }

                //Number of times a person was away from the workstation by locking his/her workstation
                NumberOfTimes = numOfTimes;
                //Date, in our case it is today
                KCDate = DateTime.Now.Date.ToShortDateString();

                //Set the minutes for display on UI
                KCTime = totalMinutes;
            }
            catch(Exception)
            {
                StopBusy?.Invoke(this, null);
                throw;
            }
        }

    }

}
