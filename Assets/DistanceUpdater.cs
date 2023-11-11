using Mapbox.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceUpdater : MonoBehaviour
{
    [SerializeField]private Transform _player;
    private Transform _marker;
    private const float mindistance = 1f;
    [SerializeField]private GameObject button;
    [SerializeField] private SpawnOnMap _spawnOnMap;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    if(!_marker && _spawnOnMap._spawnedObjects!=null)
    {
    _marker = _spawnOnMap._spawnedObjects[0].transform;
    }
    Debug.Log(Vector3.Distance(_player.position, _marker.position));
    if (_marker.position == Vector3.zero)
        return;
    if (Vector3.Distance(_player.position, _marker.position) < mindistance)
    {
    button.SetActive(true);
    }
    }
}
