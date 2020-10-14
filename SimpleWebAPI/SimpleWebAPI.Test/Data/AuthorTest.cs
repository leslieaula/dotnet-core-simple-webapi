using SimpleWebAPI.Data;
using SimpleWebAPI.Data.AuthorDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleWebAPI.Test.Data
{
    public class AuthorTest
    {
        [Fact]
        public void Should_Have_Default_Value_When_Instantiate_With_Empty_Constructor()
        {
            var author = new Author();
            Assert.NotNull(author);
        }

        [Fact]
        public void Should_Equal_Property_Value_With_Inserted_Paramater()
        {
            var firstname = "Ari";
            var author = new Author(firstname, "Ganteng", new DateTime(1945, 8, 17), Gender.Other);
            Assert.Equal(firstname, author.Firstname);
        }

        [Fact]
        public void Should_Success_Get_Full_Name()
        {
            var author = new Author("Ari", "Ganteng", new DateTime(1945, 8, 17), Gender.Other);
            Assert.NotEmpty(author.GetFullname());
            Assert.NotNull(author.GetFullname());
        }
    }
}
