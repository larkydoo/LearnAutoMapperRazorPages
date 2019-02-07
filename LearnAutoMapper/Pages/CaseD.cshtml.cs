using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnAutoMapper.Pages
{
    public class CaseDModel : BasePageModel
    {
        public PersonDTO MyDTO { get; set; }
        public Person MyEntity { get; set; }
        public ActionResult OnGet()
        {
            MyEntity = new Person
            {
                Name = "Snorkel Omnibus",
                Age = 23,
                Address = new Address
                {
                    Street = "Main Street",
                    Town = "Smallville"
                }
            };
            MyDTO = Mapper.Map<PersonDTO>(MyEntity);
            return Page();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Address Address { get; set; }
        }
        public class Address
        {
            public string Street { get; set; }
            public string Town { get; set; }
        }
        public class PersonDTO
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string AddressStreet { get; set; }
            public string AddressTown { get; set; }
        }
    }
}