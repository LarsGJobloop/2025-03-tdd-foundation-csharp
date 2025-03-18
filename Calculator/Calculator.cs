using Logger;

namespace Calculator;

public interface ICalculator
{
  float Add(float a, float b);
}

public class Calculator : ICalculator
{
  readonly ICustomLogger? _logger;

  public Calculator() { }
  public Calculator(ICustomLogger logger)
  {
    _logger = logger;
  }

  public float Add(float a, float b)
  {
    var result = a + b;
    if (!float.IsFinite(result))
    {
      throw new ArgumentException($"Numbers must add up to something less then {float.MaxValue} or {float.MinValue}");
    }

    return a + b;
  }
}
