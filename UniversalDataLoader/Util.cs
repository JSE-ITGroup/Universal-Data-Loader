using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UniversalDataLoader
{
   public class Util
    {
       public static string ApplicationVersion()
       {
            string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
           // string assemblyVersion = Assembly.LoadFile('your assembly file').GetName().Version.ToString();
            string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            string productVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;


            //
            var thisApp = Assembly.GetExecutingAssembly();
            AssemblyName name = new AssemblyName(thisApp.FullName);
           
            //

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
           return version + "|" + fileVersion + "|" + productVersion + "|" + name.Version + "|" + thisApp.FullName;
       }
        public static string GetApplicationName()
        {
          
             var thisApp = Assembly.GetExecutingAssembly();
            AssemblyName name = new AssemblyName(thisApp.FullName);
            return  thisApp.FullName;
        }
    }
}
