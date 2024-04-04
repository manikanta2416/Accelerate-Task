using Form_DAL_Layer;
using Form_DAL_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static FormContext context;
        static Repository repository;
        static Program()
        {
            context = new FormContext();
            repository = new Repository(context);
           
        }
        static void Main(string[] args)

        {
            RegisterFormDetail obj=new RegisterFormDetail();
            /*            obj.RequestorId = 1;
            */           /* obj.RequestorEmail = "org123@gmail.com";
                        obj.RequestorName = "Manikanta";
                        obj.Criticality = "Na";
                        obj.RequestingTeam = "Na";
                        obj.RequestingTeamLocation = "Bharat";
                        obj.DataUsage = "5GB";
                        obj.CriticalityReason = "NA";
                        obj.HowIndexWillBeUsed = "NA";
                        obj.RequiredApplications = "Na";
                        obj.HistoryRequired = "Yes";
                        obj.IndexType = "Na";
                        obj.BlendComponents = "Na";
                        obj.IndexProvider = "Na";
                        obj.RequiredUniverse = "Yes";
                        obj.ReturnType = "Na";
                        obj.ConstituentsRequired = "yes";
                        obj.BaseCurrency = "Na";
                        obj.IndexName = "Na";
                        obj.VendorId = "V1";
                        obj.IsWacidataRequired = "yes";
                        obj.IndexCostApproval = "Na";
                        obj.AllergapproverEmailies = "Na";
                        string dateString = "2023-02-23";
                        DateTime parsedDate;

                        // Using DateTime.Parse (throws exception if format is invalid)
                        parsedDate = DateTime.Parse(dateString);
                        obj.RequiredHistoryDate = parsedDate;



                        bool result = repository.AddRegister(obj);
                        Console.WriteLine(result);*/
            List<RegisterFormDetail> list = new List<RegisterFormDetail>();
          list=  repository.GetallRequests();
            foreach (var i in list)
            {
                Console.WriteLine(i.RequestorName);
            }
        }
    }
}
