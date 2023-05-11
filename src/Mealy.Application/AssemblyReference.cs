using System.Reflection;

namespace Mealy.Application;

public static class AssemblyReference
{
  public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
