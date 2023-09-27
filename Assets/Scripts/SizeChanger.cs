using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        float scaledSpeed = _speed * Time.deltaTime;
        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;
        float scaleZ = transform.localScale.z;
        transform.localScale = new Vector3(scaleX + scaledSpeed, scaleY + scaledSpeed, scaleZ + scaledSpeed);
    }
}