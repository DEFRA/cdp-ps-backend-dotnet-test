using Microsoft.AspNetCore.Builder;

namespace CdpPsBackendDotnetTest.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   {
      var _builder = WebApplication.CreateBuilder();

      var isDev = CdpPsBackendDotnetTest.Config.Environment.IsDevMode(_builder);

      Assert.False(isDev);
   }
}
