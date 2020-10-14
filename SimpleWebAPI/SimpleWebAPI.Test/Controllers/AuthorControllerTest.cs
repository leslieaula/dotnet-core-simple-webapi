using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleWebAPI.Test.Controllers
{
    public class AuthorControllerTest
    {
        [Fact]
        public void Should_Ok_When_Success_Get_Data()
        {
            var result = 1 + 1;
            Assert.True(result > 1);
            Assert.True(result == 2);
        }
    }
}
