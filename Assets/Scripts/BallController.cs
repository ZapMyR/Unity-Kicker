using UnityEngine;
using System.Collections;

public delegate void GoalScoredDelegate(string player);

public class BallController : MonoBehaviour {

	public GoalScoredDelegate GoalScoredDelegate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.name == "Goal1")
		{
			Debug.LogWarning("Goal1 Collision from BallController");
			//c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
			if (GoalScoredDelegate != null)
			{
				GoalScoredDelegate("Player1");
			}
		}
		if (c.gameObject.name == "Goal2")
		{
			Debug.LogWarning("Goal2 Collision from BallController");
			//c.rigidbody.AddForce((c.transform.position - transform.position).normalized * 500);
			if (GoalScoredDelegate != null)
			{
				GoalScoredDelegate("Player2");
			}
		}
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
