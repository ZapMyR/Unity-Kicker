using UnityEngine;
using System.Collections;

public class FigureController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //void OnCollisionEnter(Collision c)
    //{
    //    if (c.gameObject.name == "Ball")
    //    {
    //        Debug.LogWarning("Ball Collision from FigureController");
    //        c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
    //    }
    //}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Ball")
        {
            Debug.LogWarning("Ball Collision from FigureController");
            c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 200);
            //c.rigidbody.AddForce(400.0F, 400.0F, 400.0F);
        }
        if (c.gameObject.name == "Figure")
        {
            Debug.LogWarning("Figure Collision from FigureController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "Goalkeeper")
        {
            Debug.LogWarning("Goalkeeper Collision from FigureController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
    }
}
