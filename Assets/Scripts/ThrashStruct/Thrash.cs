using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Thrash : MonoBehaviour
{
    private List<PieceOfThrash> _piecesOfThrash;
    [SerializeField] private float _explosionRadius;
    private void Awake()
    {
        _piecesOfThrash = GetComponentsInChildren<PieceOfThrash>().ToList();

    }
    public void Explode()
    {
        _piecesOfThrash.ForEach(p => {

            Rigidbody rb = p.GetRigidbody();

            if(rb != null)
            {
                rb.AddExplosionForce(p.thrashPieceData.Get(), transform.position, _explosionRadius);
            }

        });
    }
}
