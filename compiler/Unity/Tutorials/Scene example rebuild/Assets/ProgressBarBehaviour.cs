using ProgressBar.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace ProgressBar
{
  public class ProgressBarBehaviour : MonoBehaviour, IIncrementable, IDecrementable
  {
    public static ProgressBarBehaviour Instantiate()
    {
      GameObject a = GameObject.Find("ProgressBarLabelInside");
      ProgressBarBehaviour j = a.GetComponent<ProgressBarBehaviour>();
      j.m_FillerInfo = new FillerProperty(0, j.m_FillRect.rect.width);
      j.m_Value = new ProgressValue(0, j.m_FillerInfo.MaxWidth);
      j.XOffset = (j.transform.GetComponent<RectTransform>().rect.width - j.m_FillRect.rect.width) / 2;

      j.SetFillerSize(0);
      return j;
    }

    [SerializeField]
    private RectTransform m_FillRect;

    private FillerProperty m_FillerInfo;
    private bool privatestart;
    public bool startprogress
    {
      get { return privatestart; }
      set
      {
        if (value == true)
        {
          Value = 100.0f;
        }
        else
        {
          Value = -1.0f;
        }
        privatestart = value;
      }
    }

    private ProgressValue m_Value;

    public float Value
    {
      get
      {
        return Mathf.Round(m_Value.AsFloat / m_FillerInfo.MaxWidth * 100);
      }
      set
      {
        SetFillerSizeAsPercentage(value);
      }
    }

    public float TransitoryValue { get; private set; }

    private bool destroyed;
    public bool Destroyed
    {
      get { return destroyed; }
      set
      {
        destroyed = value;
        if (destroyed)
          GameObject.Destroy(this.gameObject);
      }
    }

    [SerializeField]
    private Text m_AttachedText;

    public int pspeed
    {
      get { return ProgressSpeed; }
      set
      {
        if (Finished)
        {
          this.gameObject.SetActive(false);
        }
        else
        {
          if (Value >= 0.005f && Value <= 100) //in progress
          {
            ProgressSpeed = value;
            this.gameObject.SetActive(true);
          }
          else if (value == 40) // not isEntered
          {
            ProgressSpeed = 0;
            TransitoryValue = 0;
          }
          Value += 0.006f;
        }
      }
    }

    public int ProgressSpeed;

    public bool isDone { get { return m_Value.AsFloat == m_FillerInfo.MaxWidth; } }

    public bool isPaused { get { return TransitoryValue == m_Value.AsFloat; } }

    public bool TriggerOnComplete;

    private float XOffset;


    void Update()
    {
      if (TransitoryValue == 0)
      {
        this.gameObject.SetActive(false);
      }
      if (TransitoryValue != m_Value.AsFloat && TransitoryValue != 100)
      {
        float Dvalue = m_Value.AsFloat - TransitoryValue;

        if (Dvalue > 0)
        {
          TransitoryValue += ProgressSpeed * Time.deltaTime;
          if (TransitoryValue > m_Value.AsFloat)
            TransitoryValue = m_Value.AsFloat;
        }
        else if (Dvalue < 0)
        {
          TransitoryValue -= ProgressSpeed * Time.deltaTime;
          if (TransitoryValue < m_Value.AsFloat)
            TransitoryValue = m_Value.AsFloat;
        }

        if (TransitoryValue >= m_FillerInfo.MaxWidth)
          TransitoryValue = m_FillerInfo.MaxWidth;
        else if (TransitoryValue < 0)
          TransitoryValue = 0;

        SetFillerSize(TransitoryValue);
      }
    }

    public void SetFillerSize(float Width)
    {
      if (m_AttachedText)
      {
        m_AttachedText.text = Mathf.Round(Width / m_FillerInfo.MaxWidth * 100).ToString() + " %";
        if (Mathf.Round(Width / m_FillerInfo.MaxWidth * 100) == 100)
        {
          Finished = true;
        }
      }

      m_FillRect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, XOffset, Width);
    }
    public bool Finished;
    public void SetFillerSizeAsPercentage(float Percent)
    {
      m_Value.Set(m_FillerInfo.MaxWidth * Percent / 100);

      if (Value < 0)
      {
        Value = 0;
      }
      else if (Value > 100)
      {
        Value = 100;
      }
    }

    public void OnComplete()
    {
    }

    public void IncrementValue(float inc)
    {
      Value += inc;

      if (Value > 100) Value = 100;
    }

    public void DecrementValue(float dec)
    {
      Value -= dec;

      if (Value < 0) Value = 0;
    }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    