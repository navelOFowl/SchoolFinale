using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp
{
    public partial class ClientService
    {
        public string RemainTime
        {
            get
            {
                TimeSpan dTime = StartTime.Subtract(DateTime.Now);
                if(TimeSpan.Compare(dTime, new TimeSpan(0, 0, 0)) == -1)
                {
                    return "Услуга закончена";
                }
                return dTime.ToString();
            }
        }
    }
}
