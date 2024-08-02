using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _targetPosition;

    private void Update()
    {
        transform.LookAt( _targetPosition );
    }

    public void SetTarget(Vector3 targetPosition)
    {
        _targetPosition = targetPosition;
    }
}