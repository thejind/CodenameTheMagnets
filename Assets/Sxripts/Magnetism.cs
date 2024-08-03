using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetism : MonoBehaviour
{
    EMagneticPolarity polarityState;
    
    public void updatePolarity(EMagneticPolarity polarity)
    {
        polarityState = polarity;
    }

    public EMagneticPolarity getPolarity()
    {
        return polarityState;
    }
    
}
public enum EMagneticPolarity
{
    Positive,
    Negative,
    Neutral
}