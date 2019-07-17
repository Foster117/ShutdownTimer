using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShutdownTimer
{
    class RegistryChecker
    {
        public bool CheckIsHibernationOn()
        {
            RegistryKey local = Registry.LocalMachine;
            RegistryKey power = local.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power");
            int hibernation = Convert.ToInt32(power.GetValue("HibernateEnabled"));
            if (hibernation == 1)
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
