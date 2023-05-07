using System.Reflection;

namespace Mealy.Persistence;

public static class AssemblyReference
{
  public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
