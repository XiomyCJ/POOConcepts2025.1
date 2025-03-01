namespace Taller01
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        private int _millisecond;
        
        public int Hour
        {
            get => _hour;
            set
            {
                if (ValidateHour(value))
                    _hour = value;
                else
                    throw new ArgumentException($"The hour: {value}, is not valid.");
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                if (ValidateMinute(value))
                    _minute = value;
                else
                    throw new ArgumentException($"The minute: {value}, is not valid.");
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                if (ValidateSecond(value))
                    _second = value;
                else
                    throw new ArgumentException($"The second: {value}, is not valid.");
            }
        }

        public int Millisecond
        {
            get => _millisecond;
            set
            {
                if (ValidateMillisecond(value))
                    _millisecond = value;
                else
                    throw new ArgumentException($"The millisecond: {value}, is not valid.");
            }
        }
        public Time() {
            Hour = 0;
            Minute = 0;
            Second = 0;
            Millisecond = 0;
        }
        public Time(int hour){
            Hour = hour;
            Minute = 0;
            Second = 0;
            Millisecond = 0;
        }
        public Time(int hour, int minute) {
            Hour = hour;
            Minute = minute;
            Second = 0;
            Millisecond = 0;
        }
        public Time(int hour, int minute, int second) {
            Hour = hour;
            Minute = minute;
            Second = second;
            Millisecond = 0;
        }
        public Time(int hour, int minute, int second, int millisecond) {
            Hour = hour;
            Minute = minute;
            Second = second;
            Millisecond = millisecond;
        }
        public override string ToString()
        {
            string period = _hour >= 12 ? "PM" : "AM";
            int displayHour = _hour % 12;
            return string.Format("{0:00}:{1:00}:{2:00}.{3:000} {4}", displayHour, _minute, _second, _millisecond, period);
        }

        public long ToMilliseconds() => (_hour * 3600000) + (_minute * 60000L) + (_second * 1000L) + _millisecond;
        public long ToSeconds() => (_hour * 3600L) + (_minute * 60L) + _second;
        public long ToMinutes() => (_hour * 60L) + _minute;

        public Time Add(Time other)
        {
            int totalMillisecond = this.Millisecond + other.Millisecond;
            int extraSecond = totalMillisecond / 1000;
            totalMillisecond = totalMillisecond % 1000;

            int totalSecond = this.Second + other.Second + extraSecond;
            int extraMinute = totalSecond / 60;
            totalSecond = totalSecond % 60;

            int totalMinute = this.Minute + other.Minute + extraMinute;
            int extraHour = totalMinute / 60;
            totalMinute = totalMinute % 60;

            int totalHour = this.Hour + other.Hour + extraHour;
            bool nextDay = totalHour >= 24;
            totalHour = totalHour % 24;
            
            return new Time(totalHour, totalMinute, totalSecond, totalMillisecond);
        }

        public bool IsOtherDay(Time other)
        {
            return (this.Hour + other.Hour) >= 24 || (this.Hour + other.Hour == 23 && this.Minute + other.Minute >= 60);
        }

        private bool ValidateHour(int hour) => hour >= 0 && hour <= 23;
        private bool ValidateMinute(int minute) => minute >= 0 && minute <= 59;
        private bool ValidateSecond(int second) => second >= 0 && second <= 59;
        private bool ValidateMillisecond(int millisecond) => millisecond >= 0 && millisecond <= 999;
    }
}
