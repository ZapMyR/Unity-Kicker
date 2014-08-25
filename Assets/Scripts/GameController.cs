using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText Text;
	public GameObject Player1;
	public GameObject Player2;
    public GameObject Ball;
    
	public int score1 = 0;
	public int score2 = 0;

	private Vector3 ballStartPos;

	// Use this for initialization
	void Start () {
		if (Ball != null) {
			var ballController = Ball.AddComponent<BallController>();
			ballController.GoalScoredDelegate = GoalScored;
			ballStartPos = Ball.transform.position;
			Ball.rigidbody.velocity = Vector3.zero;
			Ball.transform.position = new Vector3(ballStartPos.x, ballStartPos.y, ballStartPos.z - 2.0F);
			
				}
		
		UpdateScore();
	}

	void OnGUI() {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Debug Menu");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if (GUI.Button (new Rect (20,40,80,20), "Reset")) {
			score1 = 0;
			score2 = 0;
			GoalScored();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void UpdateScore()
	{
		Text.text = "Player 1 " + score1 + " : " + score2 + " Player 2";
	}

	void GoalScored(string player = "Player1")
	{
		if (player == "Player1")
{
			score1++;
			Ball.transform.position = new Vector3(ballStartPos.x, ballStartPos.y, ballStartPos.z + 2.0F); 
}
		if (player == "Player2")
{
			score2++;
			Ball.transform.position = new Vector3(ballStartPos.x, ballStartPos.y, ballStartPos.z - 2.0F); 
}
		UpdateScore();
		
		var touchObjects = FindObjectsOfType<TouchRotation> ();
		foreach (var touchObject in touchObjects) {
			touchObject.ResetPosition();
		}

	}
}
