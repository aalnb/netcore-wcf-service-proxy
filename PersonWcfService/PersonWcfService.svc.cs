﻿using System.Collections.Generic;
using PersonWcfService.DTO;

namespace PersonWcfService
{
    public class PersonWcfService : IPersonWcfService
    {
        private static readonly List<PersonDto> Persons = new List<PersonDto>
        {
            new PersonDto { FirstName = "Michael", LastName = "Smithers", CountryCode = "US" },
            new PersonDto { FirstName = "Lisa", LastName = "Anderson", CountryCode = "US" },
            new PersonDto { FirstName = "Matti", LastName = "Meikäläinen", CountryCode = "FI" },
            new PersonDto { FirstName = "Ule", LastName = "Sundkvist", CountryCode = "SV" },
            new PersonDto { FirstName = "Kalle", LastName = "LindStröm", CountryCode = "SV" },
            new PersonDto { FirstName = "Ville", LastName = "Heinonen", CountryCode = "FI" }
        };

        public List<PersonDto> GetPersons()
        {
            return Persons;
        }

        public void SavePerson(PersonDto person)
        {
            Persons.Add(person);
        }

        public void Clear()
        {
            Persons.Clear();
        }
    }
}