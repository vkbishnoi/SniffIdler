using System;
using System.Diagnostics;
using System.Linq;

namespace SniffIdler.BL
{
    /// <summary>
    /// Read the security log for lock and unlock information of a workstation
    /// </summary>
    public class SniffEventLogReader : ISniffEventLogReader
    {
        const int LOCK_ID = 4800;
        const int UNLOCK_ID = 4801;
        const string SECURITY_LOG = "Security";

        public void GetKCDetails(DateTime checkDate, out int numberOfTimes,
                                    out int totalMinutes)
        {
            if(checkDate == null)
            {
                throw new ArgumentException($"{nameof(checkDate)} should not be null.");
            }

            numberOfTimes = 0;
            totalMinutes = 0;

            //Open up the security logs
            EventLog securityLog = new EventLog(SECURITY_LOG);

            //Read entries related to workstation lock and unlock for today only
            var lockEntries = securityLog.Entries.Cast<EventLogEntry>()
                .Where(x => x.InstanceId == LOCK_ID && x.TimeWritten.Date == checkDate).ToList();
            var unLockEntries = securityLog.Entries.Cast<EventLogEntry>()
                .Where(x => x.InstanceId == UNLOCK_ID && x.TimeWritten.Date == checkDate).ToList();

            if (lockEntries.Count == 0)
            {
                return;
            }

            if (lockEntries.Count < unLockEntries.Count)
            {
                //Something is not right as we expect these lock and unlock entries count to be same.
                //We will make them same by removing the top unlock entries
                int k = unLockEntries.Count - lockEntries.Count;
                for (int i = 0; i < k; i++)
                {
                    unLockEntries.RemoveAt(0);
                }
            }

            //Number of times a person was away from the workstation by locking his/her workstation
            numberOfTimes = lockEntries.Count;

            //Calculate the number of minutes the person was away from workstation
            for (int i = 0; i < lockEntries.Count; i++)
            {
                DateTime one = lockEntries[i].TimeWritten;
                DateTime two = unLockEntries[i].TimeWritten;

                totalMinutes += (int)(two - one).TotalMinutes;
            }
        }
    }
}
