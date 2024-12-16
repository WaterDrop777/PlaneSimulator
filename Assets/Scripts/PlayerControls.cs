using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.LightTransport;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public int speed = 0;
    public float deltaSpeed;
    //public Vector3 rotateOfPlayer =  new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z)
    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(new Vector3(speed / 305 * Time.deltaTime * deltaSpeed / 205, speed / 25 * Time.deltaTime * deltaSpeed, 0));
        if (Input.GetKey(KeyCode.Space))
        {
            speed += 5;
        }
        else
        {
        if (speed > 0)
            speed -= 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.back * deltaSpeed * Time.deltaTime * 10);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.forward * deltaSpeed * Time.deltaTime * 10);
        }
    }
}
