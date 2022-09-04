using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MexicanWaveManager : MonoBehaviour
{
    [SerializeField] private float _waveSeconds;


    private List<WaveSquad> _waveSquads;
    private WaitForSeconds _waiter;
    private int _counter;
    public void StartMexicanWave()
    {
        _counter = 1;
        _waveSquads = GetComponentsInChildren<WaveSquad>().ToList();
        _waiter = new WaitForSeconds(_waveSeconds);
        StartCoroutine(MexicanWave());
    }

    private IEnumerator MexicanWave()
    {
        while (true)
        {
            int index = _counter % _waveSquads.Count;
            _waveSquads[index].DoWave(_waveSeconds);
            Debug.Log("index" + index);
            _counter++;
            yield return _waiter;
        }
    }

}
