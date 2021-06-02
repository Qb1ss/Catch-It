using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timeRespawn;
    [SerializeField] private float _yPosition;
    private float[] _positions = { 2.8f, 0, -2.8f };

    [SerializeField] private GameObject[] _prefab;



    private void Start()
    {
        StartCoroutine(Coroutine());
    }



    private IEnumerator Coroutine()
    {
        while (true)
        {
            Instantiate(
                _prefab[Random.Range(0, _prefab.Length)], 
                new Vector3(_positions[Random.Range(0, 3)], _yPosition, gameObject.transform.position.z), 
                Quaternion.identity//Quaternion.Euler(new Vector3(-90f, 0, 0))
                );

            yield return new WaitForSeconds(_timeRespawn);
        }
    }
}
