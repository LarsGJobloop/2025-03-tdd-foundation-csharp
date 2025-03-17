namespace Calculator;

public interface ICalculator
{
  float Add(float a, float b);
}

public class Calculator : ICalculator
{
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
