using UnityEngine;

[RequireComponent(typeof(PathFollower))]

public class Target : MonoBehaviour
{
    private PathFollower _pathFollower;

    private void Awake()
    {
        _pathFollower = GetComponent<PathFollower>();
    }
}