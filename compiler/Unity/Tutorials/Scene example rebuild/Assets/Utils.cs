using System;
using UnityEngine.Events;

namespace ProgressBar.Utils
{
  public interface IIncrementable
  {
    void IncrementValue(float inc);
  }

  public interface IDecrementable
  {
    void DecrementValue(float dec);
  }

  [Serializable]
  public class OnCompleteEvent : UnityEvent { }

  public class FillerProperty
  {
    public float MaxWidth;
    public float MinWidth;

    public FillerProperty(float Min, float Max)
    {
      MinWidth = Min;
      MaxWidth = Max;
    }

  }

  public class ProgressValue
  {
    public ProgressValue(float value, float MaxValue)
    {
      m_Value = value;
      m_MaxValue = MaxValue;
    }

    private float m_Value;
    private float m_MaxValue;

    public void Set(float newValue)
    {
      m_Value = newValue;
    }

    public float AsFloat { get { return m_Value; } }

    public int AsInt { get { return (int)m_Value; } }

    public float Normalized { get { return m_Value / m_MaxValue; } }
 
    public float PercentAsFloat { get { return Normalized * 100; } }

    public float PercentAsInt { get { return (int)(PercentAsFloat); } }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   