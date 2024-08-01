using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void SetDirection(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition).normalized;
        transform.forward = direction;
    }
}