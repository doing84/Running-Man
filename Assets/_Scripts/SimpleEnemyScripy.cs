using UnityEngine;
using System.Collections;

public class SimpleEnemyScripy : MonoBehaviour {

    protected Vector3 velocity;
    public Transform _transform;
    public float distance = 50.0f;
    public float speed = 10.0f;
    Vector3 _originalPosition;

// member values.
    private float originalDistance;
    private bool loopDistance;
    private float saveDistance;

    public void Start()
    {
        _originalPosition = gameObject.transform.position;
        _transform = GetComponent<Transform>();
        velocity = new Vector3(speed, 0, 0);
        _transform.Translate(velocity.x * Time.deltaTime, 0, 0);

        this.saveDistance = distance;
        this.loopDistance = false;
    }

    public void Update()
    {
        //Debug.Log("Enemy" + transform.position.x + ", " + _originalPosition.x + ", " + distance + ", " + velocity.x);
        //Debug.Log("Enemy" + transform.position.x + " < " + (_originalPosition.x - distance));
        if (transform.position.x > _originalPosition.x - distance)
        {
           // Debug.Log(_originalPosition.x - distance + "Left side");
            transform.Translate(-velocity.x * Time.deltaTime, 0, 0);
            
        }
        else if (transform.position.x < _originalPosition.x + distance)
        {
           // Debug.Log(_originalPosition.x + distance + "right side");
            transform.Translate((1 * velocity.x) * Time.deltaTime, 0, 0);
            //velocity = velocity*-1;
        }

        //Debug.Log("Enemy: " + this.originalDistance + ", " + this.distance + ", " + this.loopDistance);
        if (this.loopDistance == false)
        {
            
            this.originalDistance++;
            if (this.originalDistance >= this.distance)
            {
                this.loopDistance = true;
                this.distance = 0.0f;
            }
        }
        else
        {
            this.originalDistance--;
            if (this.originalDistance <= 0)
            {
                this.loopDistance = false;
                this.distance = this.saveDistance;
            }
        }
    }

}
