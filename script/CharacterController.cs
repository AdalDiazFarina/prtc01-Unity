using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private float rotationSpeed = 100.0F;
    private int puntuacion = 0;
    public float speed = 10.0F;
    private Rigidbody rb;
    // Update is called once per frame
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // The value will be in tje range -1...1 for keyboard and joystick input
        // Movimiento del personaje
        float translation_v = Input.GetAxis("Vertical") * speed;
        float translation_h = Input.GetAxis("Horizontal") * speed;
        translation_v *= Time.deltaTime;
        translation_h *= Time.deltaTime;
        transform.Translate(new Vector3(translation_h, 0, translation_v));

        // Rotaticion en los ejes Q y E
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(new Vector3(0, -1 ,0) * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(new Vector3(0, 1 ,0) * rotationSpeed * Time.deltaTime);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "cylinder") {
                Debug.Log("puntuacion: " + (puntuacion++));
            } else if (collision.gameObject.tag == "cylinderA" && Input.GetKey(KeyCode.Space)) {
                collision.transform.Translate(new Vector3(collision.transform.position.x - rb.position.x, 0, collision.transform.position.z - rb.position.z));
            }
        }
    }
}