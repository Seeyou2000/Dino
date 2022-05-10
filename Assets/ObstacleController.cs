using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private Transform _obstaclePrefab;

    public float spawnTime;

    private float _timeSum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeSum += Time.deltaTime;

        if (_timeSum > spawnTime)
        {
            Transform t = Instantiate(_obstaclePrefab);
            t.position = new Vector3(3.32f, -0.66f);
            _timeSum -= spawnTime;
        }
    }
}
