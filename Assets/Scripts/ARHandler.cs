using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARHandler : MonoBehaviour
{
    [SerializeField]private GameObject _cube;
    [SerializeField] private Transform _camera;
    private void Start()
    {
        ARSession.stateChanged += EnableGameObject;
    _cube.transform.position = _camera.position + (_camera.forward * 3);
    _cube.transform.position = new Vector3(_cube.transform.position.x, _camera.position.y, _cube.transform.position.y);
    _cube.SetActive(true);

    }

    private void EnableGameObject(ARSessionStateChangedEventArgs eventarg)
    {
    if(eventarg.state ==ARSessionState.SessionTracking)
    {
        _cube.transform.position = _camera.position + (_camera.forward * 6);
        _cube.transform.position = new Vector3(_cube.transform.position.x, _camera.position.y, _cube.transform.position.x);
        _cube.SetActive(true);
        
    }
    }

    private void OnDestroy()
    {
    
    }
}
