namespace Mealy.Domain.Common.Validation;

public sealed class Error : IEquatable<Error>
{
  public static readonly Error None = new(string.Empty, string.Empty);

  public Error(string code, string message)
  {
    Code = code;
    Message = message;
  }

  public string Code { get; }
  public string Message { get; }

  public static implicit operator string(Error error) => error.Code;

  public static bool operator ==(Error? first, Error? second)
  {
    if (first is null && second is null)
    {
      return true;
    }

    if (first is null || second is null)
    {
      return false;
    }

    return first.Equals(second);
  }

  public static bool operator !=(Error? first, Error? second) => !(first == second);

  public bool Equals(Error? other)
  {
    if (other is null)
    {
      return false;
    }

    return Code == other.Code && Message == other.Message;
  }

  public override bool Equals(object? obj) => obj is Error error && Equals(error);

  public override int GetHashCode() => HashCode.Combine(Code, Message);

  public override string ToString() => Code;
}
