using UnityEngine;
using System.Collections;

public class FigureLineController : MonoBehaviour
{

    public GameObject Bar;
	public GameObject[] Figures;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
	    if (Bar != null)
	    {
            //foreach (GameObject figure in Figures)
            //{
            //    figure.transform.rotation = Bar.transform.rotation;
            //}
	    }
    }

    //void OnCollisionEnter(Collision c)
    //{
    //    if (c.gameObject.name == "Ball")
    //    {
    //        c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
    //    }
    //    if (c.gameObject.name == "Figure")
    //    {
    //        c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
    //    }
    //    if (c.gameObject.name == "Goalkeeper")
    //    {
    //        c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
    //    }
    //}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Ball")
        {
            Debug.LogWarning("Ball Collision from FigureLineController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "Figure")
        {
            Debug.LogWarning("Figure Collision from FigureLineController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
        if (c.gameObject.name == "Goalkeeper")
        {
            Debug.LogWarning("Goalkeeper Collision from FigureLineController");
            //c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
        }
    }
}
