using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileCreator : MonoBehaviour
{

    [SerializeField]private List<PieceOfThrash> _piecesOfThrash;
    [SerializeField]private Thrash _thrash;
    [SerializeField] private Vector3 _areaLimits;
    [SerializeField] private float _physicsDuration;
    private int _pieceCount = 40;

    [ContextMenu("CreatePile")]
    public void CreatePile()
    {
       InstantiatePrefabs();
        RunPhysics(_physicsDuration);
    }

    private void RunPhysics(float duration)
    {
        var delta = 0.02f;
        Physics.autoSimulation = false;
        for(float i = 0; i <= duration; i += delta)
        {
            Physics.Simulate(delta);
        }
        Physics.autoSimulation = true;
    }


    private void InstantiatePrefabs()
    {
#if UNITY_EDITOR

        for (int i = 0; i < _pieceCount; i++)
        {

            var randomElementIndex = Random.Range(0, _piecesOfThrash.Count);
            PieceOfThrash pieceOfThrash;
            Vector3 randomPos = GetRandomPos();

            // pieceOfThrash = Instantiate(_piecesOfThrash[randomElementIndex], randomPos, Quaternion.identity, _thrash.transform);

          var obj =  (Component)UnityEditor.PrefabUtility.InstantiatePrefab(_piecesOfThrash[randomElementIndex]);
          obj.transform.SetPositionAndRotation(randomPos, Quaternion.identity);
            obj.transform.SetParent(_thrash.transform);
        }
#endif

    }

    private Vector3 GetRandomPos()
    {
        float randomX = Random.Range(-_areaLimits.x, _areaLimits.x);
        float randomY = Random.Range(1, _areaLimits.y); 
        float randomZ = Random.Range(-_areaLimits.z, _areaLimits.z);

        Vector3 randomPos = new Vector3(randomX,randomY, randomZ);
        return randomPos;
    }
}
