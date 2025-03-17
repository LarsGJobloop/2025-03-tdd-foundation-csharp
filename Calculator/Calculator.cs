namespace Calculator;

public interface ICalculator
{
  float Add(float a, float b);
}

public class Calculator : ICalculator
{
  public float Add(float a, float b)
  {
    return a + b;
  }
}
