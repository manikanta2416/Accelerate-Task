using Form_DAL_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_DAL_Layer
{
    public class Repository
    {
        private FormContext context;
        public Repository(FormContext context)
        {
            this.context = context;
        }
        public bool AddRegister(RegisterFormDetail register)
        {

            bool status = false;
            try
            {
               
                    context.Add(register);
                
                context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public List<RegisterFormDetail> GetallRequests()
        {
            List<RegisterFormDetail> list= new List<RegisterFormDetail>();
            try
            {
                list = context.RegisterFormDetails.ToList();
            }catch(Exception)
            {
                list = null;
            }
            return list;
        }

    }
}
