using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.Rotate(new Vector3(0, _speed * Time.deltaTime, 0));
    }
}