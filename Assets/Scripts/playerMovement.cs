using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    float bounds = 7.732f;
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxisRaw("Horizontal");

        float newposition = transform.position.x + speed * xinput * Time.deltaTime;
  
        if (newposition < bounds && newposition > -bounds)
        {
            transform.position += new Vector3(speed * xinput * Time.deltaTime, 0f, 0f);
        }

    }
}
