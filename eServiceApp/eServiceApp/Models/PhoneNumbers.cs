using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace eServiceApp.Models
{
    public class PhoneNumbers
    {
              
        public string SMSNumber { get; set; }        
      
        public string Price { get; set; }

        public string QuardPrice { get; set; }

        public string Number14xx { get; set; }

        public string Number15xx { get; set; }

        public string Number800xxxxxx { get; set; }

        public string Number900xxxxxx { get; set; }


        public List<PhoneNumbers> GetNumbers(string colXlName,string mappedColName,
            int firstRow,int firstCol,int lastRow,int lastCol )
        {
            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2013;


            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = assembly.GetManifestResourceStream("eServiceApp.Files.Number.xlsx");
            IWorkbook workbook = application.Workbooks.Open(inputStream);
            IWorksheet worksheet = workbook.Worksheets[0];

            Dictionary<string, string> mappingProperties = new Dictionary<string, string>();
            mappingProperties.Add(colXlName, mappedColName);
           

            List<PhoneNumbers> listOfNumbers = new List<PhoneNumbers>();
            listOfNumbers = worksheet.ExportData<PhoneNumbers>(firstRow, firstCol, lastRow, lastCol, mappingProperties);


            return listOfNumbers;
        }
        public string GetPrice(string number)
        {
            this.SMSNumber = number;

            #region convert to  integer numbers

            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
            //m1 = int.Parse(this.SMSNumber.Substring(0, 1));
            //m2 = int.Parse(this.SMSNumber.Substring(1, 1));
            //m3 =  int.Parse(this.SMSNumber.Substring(2, 1));
            //m4 =  int.Parse(this.SMSNumber.Substring(3, 1));
            //m5 =  int.Parse(this.SMSNumber.Substring(4, 1));

            m1 = int.Parse(this.SMSNumber.NullSafe(n => n.Substring(0, 1)));
            m2 = int.Parse(this.SMSNumber.NullSafe(n => n.Substring(1, 1)));
            m3 = int.Parse(this.SMSNumber.NullSafe(n => n.Substring(2, 1)));
            m4 = int.Parse(this.SMSNumber.NullSafe(n => n.Substring(3, 1)));
            m5 = int.Parse(this.SMSNumber.NullSafe(n => n.Substring(4, 1)));
            int.Parse(this.SMSNumber.NullSafe(n => n.Substring(4, 1)));
            #endregion convert to  integer numbers

            #region logic

            if (m1 == m2 && m2 == m3 && m3 == m4 && m4 == m5)
            {
                return (this.Price = "التصنيف ماسي وبتعرفة " + "قيمتها السنوية" + " 3600" + " او 1035" + " دينار لربع السنة.");
            }
            else if (m1 != m2 && m2 == m3 && m3 == m4 && m4 == m5 || m1 == m2 && m2 == m3 && m3 == m4 && m4 != m5)
            {
                return (this.Price = "التصنيف ذهبي وبتعرفة " + "قيمتها السنوية" + " 3000" + " او 870" + " دينار لربع السنة.");
            }
            else if (m1 == m2 + 1 && m2 == m3 + 1 && m3 == m4 + 1 && m4 == m5 + 1 || m1 == m2 - 1 && m2 == m3 - 1 && m3 == m4 - 1 && m4 == m5 - 1)
            {
                return (this.Price = "التصنيف فضي وبتعرفة " + "قيمتها السنوية" + " 2400" + " او 690" + " دينار لربع السنة.");
            }
            else if (m1 == m2 && m3 == m4 && m5 != m4 || m1 == m2 && m3 != m4 && m3 != m2 && m4 == m5 || m1 != m2 && m2 == m3 && m4 == m5)
            {
                return (this.Price = "التصنيف فضي وبتعرفة " + "قيمتها السنوية" + " 2400" + " او 960" + " دينار لربع السنة.");
            }
            else if (m3 == m4 && m4 == m5 || m2 == m3 && m3 == m4
                || m1 == m2 && m2 == m3 || m3 == m4 && m4 == m5)
            {
                return (this.Price = "التصنيف فضي وبتعرفة " + "قيمتهاالسنوية" + " 2400" + " او 960" + " دينار لربع السنة.");
            }
            else
            {
                return (this.Price = "التصنيف عادي وبتعرفة " + "قيمتها السنوية" + " 1800" + " او 520" + " دينار لربع السنة.");
            }

            #endregion logic
        }

        public bool is4DigitNumber(string number)
        {
            if (number == null || number == "")
            {
                return false;
            }
            else
            {
                this.Number14xx = number;
                string s1;
                s1 = this.Number14xx.Substring(0, 2);
                //s2 = this.Number14xx.NullSafe(n => n.Substring(1, 1));

                this.Number15xx = number;
                string s11;
                s11 = this.Number15xx.NullSafe(n => n.Substring(0, 2));
                //s12 = this.Number15xx.NullSafe(n => n.Substring(1, 1));

                if (s1 == "14" || s11 == "15")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool is10DigitNumber(string number)
        {
            if (number == null || number == "")
            {
                return false;
            }
            else
            {
                this.Number800xxxxxx = number;
                string s1, s11;

                s1 = this.Number800xxxxxx.Substring(0, 4);

                this.Number900xxxxxx = number;

                s11 = this.Number900xxxxxx.Substring(0, 4);

                if (s1 == "0800" || s11 == "0900")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
