using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eServiceApp.Models
{
    public class DeviceForApproval:INotifyPropertyChanged
    {
        
        private string licenseNumber;

        public string LicenseNumber
        {
            get { return licenseNumber; }
            set { 
                licenseNumber = value;
                RaisePropertyChanged("LicenseNumber");
                }
        }

        private string manfucturer;

        public string Manufucturer
        {
            get { return manfucturer; }
            set { 
                manfucturer = value;
                RaisePropertyChanged("Manufucturer");
                }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { 
                model = value;
                RaisePropertyChanged("Model");
                }
        }

        private string deviceType;

        public string DeviceType
        {
            get { return deviceType; }
            set {  
                deviceType = value;
                RaisePropertyChanged("DeviceType");
            }
        }
                             
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged!=null)
            {
                this.PropertyChanged(this,new  PropertyChangedEventArgs(name));
            }
        }

    }
}
