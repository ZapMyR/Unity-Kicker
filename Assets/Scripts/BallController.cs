using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Ball")
        {
            Debug.LogWarning("Ball Collision from BallController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "Figure")
        {
            Debug.LogWarning("Figure Collision from BallController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "Goalkeeper")
        {
            Debug.LogWarning("Goalkeeper Collision from BallController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "GameObject")
        {
            Debug.LogWarning("GameObject Collision from BallController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
    }
}
