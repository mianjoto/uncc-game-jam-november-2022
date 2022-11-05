using UnityEngine;

namespace Helpers
{
    public class Timer
    {
        public float TimeInitiated;
        public float TimerLength;
        public bool TimerDone;

        public Timer(float timerLength, bool startTimerImmediately = true)
        {
            this.TimerLength = timerLength;
            if (startTimerImmediately)
            {
                this.TimeInitiated = Time.time;
            }
            else
            {
                this.TimeInitiated = 0;
            }
            TimerDone = true;
        }

        public void StartTimer()
        {
            this.TimeInitiated = Time.time;
        }

        public void ResetTimer()
        {
            TimerDone = false;
            StartTimer();
        }

        public bool IsTimerDone()
        {
            if ((Time.time - TimeInitiated) >= TimerLength)
            {
                TimerDone = true;
            }
            else
            {
                TimerDone = false;
            }
            return TimerDone;
        }
    }
}
