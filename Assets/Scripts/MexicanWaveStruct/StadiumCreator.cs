using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StadiumCreator : MonoBehaviour
{
    [SerializeField] private MexicanWaveManager mexicanWaveManager;
    [SerializeField] private WaveSquad waveSquad;
    [SerializeField] private int waveSquadCount;
    private SplineComputer _computer;
    private void Awake()
    {
        _computer = GetComponentInChildren<SplineComputer>();
        CreateStadium();
        InstantiateWaveSquads();
    }

    [ContextMenu("CreateStadium")]
    private void CreateStadium()
    {
        _computer = GetComponentInChildren<SplineComputer>();
        var nodes = GetComponentsInChildren<Node>().ToList();
        var points = new SplinePoint[nodes.Count];
        for (var i = 0; i < nodes.Count; i++)
        {
            var node = nodes[i];
            var newPoint = new SplinePoint(node.transform.position);
            points[i] = newPoint;
        }

        _computer.type = Spline.Type.CatmullRom;
        _computer.sampleMode = SplineComputer.SampleMode.Default;
        _computer.SetPoints(points, SplineComputer.Space.Local);
        _computer.Close();
    }

    
    private void InstantiateWaveSquads()
    {
        for (int i = 0; i < waveSquadCount; i++)
        {
            WaveSquad squad = Instantiate(waveSquad,mexicanWaveManager.transform);
            squad.SetSplineComputer(_computer);

            float distance = (1f /(float) waveSquadCount )*i;
            squad.SetPosition(distance);
        }
        mexicanWaveManager.StartMexicanWave();
    }
}
