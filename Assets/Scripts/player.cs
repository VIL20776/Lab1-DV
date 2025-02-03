using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private int coins = 0;
    private int health = 3;
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
        if (other.gameObject.tag == "Coin") {
            coins += 1;
            Debug.Log("Coin obtained! Total coins: " + coins);
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Trap") {
            health -= 1;
            Debug.Log("Daño recibido! Vida restante " + health);
            if (health <= 0) {
                Debug.Log("Juego Terminado.");
                Destroy(gameObject);
            }
        }
    }
}
