using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainthrust = 1000f;
    [SerializeField] float rotationThrust = 100f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        ProcessRotation();
    }

    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainthrust * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationThrust);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThrust);
        }    
    }

    private void ApplyRotation(float rotationThrust)
    {
        transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
    }
}
