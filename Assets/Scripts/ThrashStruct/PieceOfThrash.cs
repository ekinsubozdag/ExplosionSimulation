using UnityEngine;

public class PieceOfThrash : MonoBehaviour
{
    public ThrashPieceData thrashPieceData;
    private Rigidbody _rb;

    public Rigidbody GetRigidbody() => _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        InitializeData();
    }
    private void InitializeData()
    {
        float force = Random.Range(500, 1000);
        thrashPieceData = new ThrashPieceData(force);
    }

}

