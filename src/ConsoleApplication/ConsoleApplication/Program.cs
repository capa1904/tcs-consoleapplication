using System;
using System.Diagnostics;
using System.Reflection;
using PackageA;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintConsoleApplicationInfo();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static string GetName()
        {
            return "ConsoleApplication";
        }

        private static string GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string productVersion = fileVersionInfo.ProductVersion;
            return productVersion;
        }

        private static string GetSummary()
        {
            return $"{GetName()} v. {GetVersion()}";
        }

        private static void PrintConsoleApplicationInfo()
        {
            Console.WriteLine($"Application information: {GetSummary()}");
            PrintInformationAboutUsedPackage();
        }

        private static void PrintInformationAboutUsedPackage()
        {
            var classOfPackageA = new ClassOfPackageA();
            var packageInfo = classOfPackageA.GetSummary();
            Console.WriteLine($"Information about used package: {packageInfo}");
        }
    }
}
