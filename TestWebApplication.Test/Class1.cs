

namespace TestWebApplication.Test
{
  using System;
  using Xunit;

  public class Class1
  {
    [Fact]
    public void Error()
    {
      throw new Exception();
    }

    [Fact]
    public void Ok()
    {
      return;
    }
  }
}
