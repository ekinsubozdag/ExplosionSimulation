using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]private Thrash _thrash;
    [SerializeField] private TimeManager _timeManager;

    private bool _explosionStarted;
    private bool _isSlowDown;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(!_explosionStarted)
            {
                _explosionStarted = true;
                _thrash.Explode();
                return;
            }

            _timeManager.SetSlowMotion(_isSlowDown);
            _isSlowDown = !_isSlowDown;

        }
    }
}
