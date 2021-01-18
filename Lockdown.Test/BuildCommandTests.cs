// Test unitario creado por terminal con el comando --> dotnet new xunit -n Lockdown.test
using Lockdown.Commands;
using System;
using Xunit;
using Lockdown.Test.Utils;
using Shouldly;

namespace Lockdown.test
{
    public class BuildCommandTests
    {
        [Fact]
        public void TestWriteToConsole()
        {
            //Setup -- creamos la consola de prueba
            var testConsole = new TestConsole();
            var buildCommand = new BuildCommand(testConsole);

            //act  -  ejecutamos la accion
            buildCommand.OnExecute();

            //Assert --  nos aseguramos que lo que esperamos haya sucedido
            string writtenText = testConsole.GetWrittenContent();
            writtenText.ShouldBe("You executed the build command\n");
        }
    }
}
