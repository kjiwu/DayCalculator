using System.Globalization;

namespace DayCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string days = tbDays.Text;
            if (string.IsNullOrEmpty(days))
            {
                return;
            }

            DateTime dateTime = new DateTime(2017, 7, 1);
            dateTime = dateTime.AddDays(double.Parse(days));

            lbDate.Text = dateTime.ToString("yyyy-MM-dd");
        }

        private string UTCToLocal(string utcTime)
        {
            DateTime dt = DateTime.ParseExact(utcTime, "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
            TimeZoneInfo localTime = TimeZoneInfo.Local;
            DateTime dateTime = TimeZoneInfo.ConvertTimeFromUtc(dt, localTime);
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnUtc_Click(object sender, EventArgs e)
        {
            string days = tbDays.Text;
            if (string.IsNullOrEmpty(days))
            {
                return;
            }
            lbDate.Text = UTCToLocal(days);
        }
    }
}
