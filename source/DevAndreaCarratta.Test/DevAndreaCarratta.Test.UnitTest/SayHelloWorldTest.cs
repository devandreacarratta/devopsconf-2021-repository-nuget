using DevAndreaCarratta.HelloWorld;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DevAndreaCarratta.Test.UnitTest
{
    public class SayHelloWorldTest
    {


        [Fact]
        public async Task SayToAnonymousTest()
        {
            await Task.Delay(1); // do something
            SayHelloWorld hello = new SayHelloWorld();
            string result = hello.SayToAnonymous();
            Assert.True(result == $"Hello World!");
        }

        [Fact]
        public async Task SayToFrindTest()
        {
            await Task.Delay(1); // do something

            string friend = "Andrea";

            SayHelloWorld hello = new SayHelloWorld();
            string result = hello.SayToFriend(friend);
            Assert.True(result == $"Hello World {friend}!");
        }
    }
}
