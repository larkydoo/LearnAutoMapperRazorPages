using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnAutoMapper.Pages
{
    public class CaseCModel : BasePageModel
    {
        public PersonDTO MyDTO { get; set; }
        public Person MyEntity { get; set; }
        public ActionResult OnGet()
        {
            try
            {
                MyEntity = new Person
                {
                    Name = "Snorkel Omnibus",
                    Age = 23,
                };
                
                MyDTO = Mapper.Map<PersonDTO>(MyEntity);
                MyDTO.Hometown = "Hometown from somewhere other than Person Entity.";
            }
            catch (AutoMapperConfigurationException exc)
            {
                TempData["Exception"] = "Exception encountered. Can't map where there are fields in target object that are missing in source object. Uncomment MappingProfile code to correct this.";
            }
            return Page();
        }

        //public class MappingProfile : Profile
        //{
        //    public MappingProfile() => CreateMap<Person, PersonDTO>().ReverseMap();
        //}

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class PersonDTO
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}