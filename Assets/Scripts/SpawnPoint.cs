using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    [SerializeField] private Target _target;
    public Enemy GetEnemyPrefab()
    {
        return _enemyPrefab;
    }

    public Vector3 GetTargetPosition()
    {
       return _target.transform.position;
    }
}