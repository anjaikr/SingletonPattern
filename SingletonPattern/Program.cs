using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SingletonPattern
{

    public class ReportingSingleton
    {
        private static ReportingSingleton instance = null;

        public int numReport { get; set; }
        private ReportingSingleton()
        { }
        public static ReportingSingleton GetInstance()
        {
            lock (typeof(ReportingSingleton))
            {
                if (instance == null)
                {
                    instance = new ReportingSingleton();
                }
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetReportingMethodfromA();
            GetReportingMethodfromB();
            GetReportingMethodfromC();
            Console.ReadLine();
        }

        public static void GetReportingMethodfromA()
        {
            var singletonInstancefromA = ReportingSingleton.GetInstance();
            singletonInstancefromA.numReport++;
            Console.WriteLine(singletonInstancefromA.numReport.ToString());

        }
        public static void GetReportingMethodfromB()
        {
            var singletonInstancefromB = ReportingSingleton.GetInstance();
            singletonInstancefromB.numReport++;
            Console.WriteLine(singletonInstancefromB.numReport.ToString());
        }

        public static void GetReportingMethodfromC()
        {
            var singletonInstancefromC = ReportingSingleton.GetInstance();
            singletonInstancefromC.numReport++;
            Console.WriteLine(singletonInstancefromC.numReport.ToString());
        }
    }
}
