// Test unitario creado por terminal con el comando --> dotnet new xunit -n Lockdown.test
using Lockdown.Commands;
using System;
using Xunit;
using Lockdown.Test.Utils;

namespace Lockdown.test
{
    public class BuildCommandTests
    {
        [Fact]
        public void TestWriteToConsole()
        {
            var testConsole = new TestConsole();
            var buildCommand = new BuildCommand(testConsole);

            buildCommand.OnExecute();

            string writtenText = testConsole.GetWrittenContent();

            Assert.Equal("You executed the build command\n", writtenText);
        }
    }
}
