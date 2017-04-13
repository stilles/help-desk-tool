using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk_Tool
{
    class wmi
    {
        public List<computerInformation> QuerySystemInfo(string _target)
        {
            var computerInfo = new List<computerInformation>();

                try
                {
                    //  WMI Query using 'System.Management'.
                    //1st query
                    ManagementScope scope = new ManagementScope("\\\\" + _target + "\\root\\cimv2");
                    scope.Connect();
                    ObjectQuery query = new ObjectQuery("SELECT Name FROM Win32_Processor");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                    ManagementObjectCollection queryCollection = searcher.Get();

                    string _targetCPUName = "not set";
                    foreach (ManagementObject m in queryCollection)
                    {
                        _targetCPUName = (m["Name"].ToString());
                    }

                    
                    //  WMI Query using 'System.Management'.
                    //3rd query
                    ManagementScope scope3 = new ManagementScope("\\\\" + _target + "\\root\\cimv2");
                    scope3.Connect();
                    ObjectQuery query3 = new ObjectQuery("SELECT LastBootUpTime FROM Win32_OperatingSystem");
                    ManagementObjectSearcher searcher3 = new ManagementObjectSearcher(scope3, query3);
                    ManagementObjectCollection queryCollection3 = searcher3.Get();

                    string _targetSystemUptime = "not set";
                    foreach (ManagementObject m in queryCollection3)
                    {
                        DateTime _uptimeDateTime = ManagementDateTimeConverter.ToDateTime(m["LastBootUpTime"].ToString());
                        TimeSpan _uptimeTimeSpan = DateTime.Now.ToUniversalTime() - _uptimeDateTime.ToUniversalTime();

                        string _days = _uptimeTimeSpan.ToString("%d") + " days";
                        string _hours = _uptimeTimeSpan.ToString("%h") + " hours";
                        string _minutes = _uptimeTimeSpan.ToString("%m") + " minutes";

                        _targetSystemUptime = _days + ", " + _hours + ", " + _minutes;
                    }
                     

                    //  WMI Query using 'System.Management'.
                    //2nd query
                    ManagementScope scope2 = new ManagementScope("\\\\" + _target + "\\root\\cimv2");
                    scope2.Connect();
                    ObjectQuery query2 = new ObjectQuery("SELECT Manufacturer,Model,Name,TotalPhysicalMemory FROM Win32_ComputerSystem");
                    ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope2, query2);
                    ManagementObjectCollection queryCollection2 = searcher2.Get();
                    foreach (ManagementObject m in queryCollection2)
                    {
                        computerInfo.Add(new computerInformation { Name = (m["Name"].ToString()),
                                                                   Manufacturer = (m["Manufacturer"].ToString()),
                                                                   Model = (m["Model"].ToString()),
                                                                   TotalPhysicalMemory = (m["TotalPhysicalMemory"].ToString()),
                                                                   CPUName = _targetCPUName,
                                                                   SystemUptime = _targetSystemUptime,
                        });
                    }
                    
                    
                
                }
                catch (Exception)
                {
                    //throw e;
                }

            return computerInfo;
        }


        public List<computerInformation> QueryUserInfo(string _target)
        {
            var computerInfo = new List<computerInformation>();

            try
            {
                ManagementScope scope = new ManagementScope("\\\\" + _target + "\\root\\cimv2");
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT UserName FROM Win32_ComputerSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    computerInfo.Add(new computerInformation
                    {
                        UserName = (m["UserName"].ToString()),
                    });
                }
            }
            catch (Exception)
            {
                //throw e;
            }

            return computerInfo;
        }
    }
}
