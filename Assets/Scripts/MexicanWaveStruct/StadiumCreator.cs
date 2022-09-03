using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadiumCreator : MonoBehaviour
{
    private SplineComputer _splineComputer;
    private void Awake()
    {
        _splineComputer = GetComponentInChildren<SplineComputer>();
        
    }

    private void CreateStadium()
    {

    }
}
