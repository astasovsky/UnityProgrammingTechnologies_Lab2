using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 10.0f;
    private const float XRange = 10;
    private float _horizontalInput;


    private void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > XRange)
        {
            transform.position = new Vector3(XRange, transform.position.y, transform.position.z);
        }

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (_horizontalInput * Time.deltaTime * Speed));
    }
}