using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float minSpeed = 12.0f;
    private float maxSpeed = 16.0f;
    private float maxTorque = 10.0f;
    private float xRange = 4.0f;
    private float ySpawnPos = 6.0f;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        //lets get a reference to our rigidbody
        rbody = GetComponent<Rigidbody>();
        //now lets add a random force in the up directon
        rbody.AddForce(RandomForce(), ForceMode.Impulse);
        //lets also add a random torque
        rbody.AddTorque(RandomTroque(), RandomTroque(), RandomTroque(), ForceMode.Impulse);
        //random position
        transform.position = RandomSpawnPos();

    }
    Vector3 RandomForce() 
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTroque()
   {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new  Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
