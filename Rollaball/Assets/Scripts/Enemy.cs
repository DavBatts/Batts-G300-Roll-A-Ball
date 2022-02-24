using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPosition;



    void start()
    {
        transform.position = new Vector3(5.0f, .05f, 5.0f);
        startingPosition = transform.position;

    }

    void Update()
    {
        Vector3 v =startingPosition;
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;

        
    }
}
