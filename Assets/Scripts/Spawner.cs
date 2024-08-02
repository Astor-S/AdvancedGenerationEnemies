using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _spawnFrequency = 2f;
    [SerializeField] private int _minRange = 0;

    private WaitForSeconds _wait;

    private void Awake()
    {
        _wait = new WaitForSeconds(_spawnFrequency);
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        bool isRunning = true;

        while (isRunning)
        {
            int spawnIndex = Random.Range(_minRange, _spawnPoints.Count);
            SpawnPoint spawnPoint = _spawnPoints[spawnIndex];

            Enemy enemyPrefab = spawnPoint.EnemyPrefab;
            Enemy newEnemy = Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);

            newEnemy.SetTarget(spawnPoint.TargetPosition);

            yield return _wait;
        }
    }
}