using Packt.shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public class Person : object
    {
        public string? name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonders;

        public List<Person> Children = new List<Person>();
    }

    

}