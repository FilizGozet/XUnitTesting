using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Theory]
        [InlineData("Tim","","LastName")]
        [InlineData("", "Corey", "FirstName")]
        public void AddPeopleToPeopleList_ShouldFail(string firstName, string LastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName=firstName, LastName=LastName};
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));

        }
    }
}
