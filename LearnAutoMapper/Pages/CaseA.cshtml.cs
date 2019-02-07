using Microsoft.AspNetCore.Mvc;

namespace LearnAutoMapper.Pages
{
    public class CaseAModel : BasePageModel
    {
        public PersonDTO MyDTO { get; set; }
        public Person MyEntity { get; set; }
        public ActionResult OnGet()
        {
            MyEntity = new Person
            {
                Name = "Snorkel Omnibus",
                Age = 23,
            };
            MyDTO = Mapper.Map<PersonDTO>(MyEntity);
            return Page();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class PersonDTO
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}