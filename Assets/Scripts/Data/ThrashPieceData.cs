using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrashPieceData
{
    private float _forceFactor;
    public ThrashPieceData(float value)
    {
        _forceFactor = value;
    }
      public float Get()
        {
            return _forceFactor;
        }
    

}
