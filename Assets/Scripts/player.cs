using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int coins;
    [SerializeField] private int health;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movx = Input.GetAxis("Horizontal");
        float movz = Input.GetAxis("Vertical");

        Vector3 mov_vector = new Vector3(movx, 0, movz);
        rb.linearVelocity = mov_vector * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
            Destroy(other.gameObject);
    }
}
