using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 20;

    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}