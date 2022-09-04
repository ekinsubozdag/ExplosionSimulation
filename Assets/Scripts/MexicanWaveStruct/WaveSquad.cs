using DG.Tweening;
using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaveSquad : MonoBehaviour
{
    private SplinePositioner _splinePositioner;
    private float _waveDuration;
    private Sequence _sequence;
    private void Awake()
    {
        _splinePositioner = GetComponent<SplinePositioner>();
    }

    public void SetSplineComputer(SplineComputer splineComputer)
    {
        _splinePositioner.spline = splineComputer;
    }

    public void SetPosition(float distance)
    {
        _splinePositioner.SetDistance(distance);
    }

    public void DoWave(float waveSpeed)
    {
        
        _waveDuration = waveSpeed*3;
        _sequence?.Kill();

        _sequence = DOTween.Sequence();
        var oldPosY = transform.position.y;
        var targetPosY = transform.position.y + .5f;
        _sequence.Append(transform.DOMoveY(targetPosY,_waveDuration/2).SetEase(Ease.InSine)).Append(transform.DOMoveY(oldPosY, _waveDuration / 2).SetEase(Ease.OutSine));
    }

}
