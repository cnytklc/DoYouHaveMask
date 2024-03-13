using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicanService _applicanService;

        public PttManager(IApplicanService applicanService) // Constructor new yapıldığında çalışır
        {
            _applicanService = applicanService;
        }

        public void GiveMask(Person person)
        {
            if (_applicanService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");

            }
        }
    }
}
