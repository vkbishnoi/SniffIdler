using System;

namespace SniffIdler.BL
{
    public interface ISniffEventLogReader
    {
        void GetKCDetails(DateTime checkDate, out int numberOfTimes, out int totalMinutes);
    }
}