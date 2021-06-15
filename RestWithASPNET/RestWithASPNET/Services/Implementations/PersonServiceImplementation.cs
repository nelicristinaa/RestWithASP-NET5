﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            } 
            return persons;
        }



        public Person FindById(long id)
        {
            return new Person
            {
                id = IncrementAndGet(),
                firstName = "Joao",
                lastName = "Silva",
                Address = "Uberlandi - MG - Brasil",
                Gender = "male"
            };
        }

       

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IncrementAndGet(),
                firstName = "Person name" + i,
                lastName = "Person lastName" + i,
                Address = "some adress" + i,
                Gender = "male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }



    }
}
