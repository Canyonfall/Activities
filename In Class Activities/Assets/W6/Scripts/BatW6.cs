using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _chaseSpeed = 3f;

    private bool _isChasing = false;
    private Transform _target;

    public void StartChasing(Transform player)
    {
        _target = player;
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }

    public void Update()
    {
        Vector3.MoveTowards(transform.position, _target.position, _chaseSpeed * Time.deltaTime);
    }
}