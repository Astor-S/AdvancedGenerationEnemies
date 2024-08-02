using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    public Enemy EnemyPrefab => _enemyPrefab;
    public Vector3 TargetPosition => _target.transform.position;
}