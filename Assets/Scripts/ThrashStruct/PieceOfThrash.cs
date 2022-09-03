using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceOfThrash : MonoBehaviour
{
    private ThrashPieceData thrashPieceData;

    private void Start()
    {
        InitializeData();
    }
    private void InitializeData()
    {
        thrashPieceData = new ThrashPieceData();
        float force = Random.Range(1, 20);
        thrashPieceData.Set(force);
    }
}
