using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    private const float Speed = 10.0f;
    private const float XRange = 10;
    private const float ZMin = -1.5f;
    private const float ZMax = 15.5f;
    private float _horizontalInput;
    private float _verticalInput;


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
        
        if(transform.position.z < ZMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZMin);
        }
        if(transform.position.z > ZMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZMax);
        }

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (_horizontalInput * Time.deltaTime * Speed));
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (_verticalInput * Time.deltaTime * Speed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}