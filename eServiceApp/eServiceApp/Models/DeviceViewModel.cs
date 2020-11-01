using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using eServiceApp.Views;

namespace eServiceApp.Models
{
     public  class DeviceViewModel
    {
        public ObservableCollection<DeviceForApproval> deviceForApprovalsObservable { get; set; }
          
        public DeviceViewModel()
        {
            deviceForApprovalsObservable = new ObservableCollection<DeviceForApproval>(GetDevices());
        }

        public IEnumerable<DeviceForApproval> GetDevices()
        {
            ExcelEngine excelEngine = new ExcelEngine();
            
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;

               
                Assembly assembly = typeof(App).GetTypeInfo().Assembly;
                Stream inputStream = assembly.GetManifestResourceStream("eServiceApp.Files.Equipment2.xls");
                IWorkbook workbook = application.Workbooks.Open(inputStream);
                IWorksheet worksheet = workbook.Worksheets[0];
            
                Dictionary<string, string> mappingProperties = new Dictionary<string, string>();
                mappingProperties.Add("LicenceNo", "LicenseNumber");
                mappingProperties.Add("Manufucturer", "Manufucturer");
                mappingProperties.Add("Model", "Model");
                mappingProperties.Add("DeviceType", "DeviceType");

            List<DeviceForApproval> deviceForApprovals = new List<DeviceForApproval>();
             deviceForApprovals = worksheet.ExportData<DeviceForApproval>(1, 1, 419, 4, mappingProperties);
            

            return deviceForApprovals; 
        }

        
       


        

    }
}
