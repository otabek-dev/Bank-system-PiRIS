using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient_1.Entities
{
    internal class Chart
    {
        DataBase dataBase = new DataBase();

        public Chart(string typeDeposit, string currency, byte percentage, byte durationInMonths, string chartName)
        {
            TypeDeposit = typeDeposit ?? throw new ArgumentNullException(nameof(typeDeposit));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            ChartName = chartName ?? throw new ArgumentNullException(nameof(chartName));
            Percentage = percentage;
            DurationInMonths = durationInMonths;
        }
        public Chart(string typeDeposit, string currency, byte percentage, byte durationInMonths, string chartName, int id)
        {
            TypeDeposit = typeDeposit ?? throw new ArgumentNullException(nameof(typeDeposit));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            ChartName = chartName ?? throw new ArgumentNullException(nameof(chartName));
            Percentage = percentage;
            DurationInMonths = durationInMonths;
            Id = id;
        }

        public string TypeDeposit { get; set; }
        public string ChartName { get; set; }
        public string Currency { get; set; }
        public byte Percentage { get; set; }
        public byte DurationInMonths { get; set; }
        public int Id { get; set; }


        public virtual int ExecuteNonQuery()
        {
            //dataBase.OpenConnection();
            
            return 0;
        }
    }
}
