using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText Text;
	public GameObject Player1;
	public GameObject Player2;
    public GameObject Ball;
    
	public int score1 = 0;
	public int score2 = 0;

	// Use this for initialization
	void Start () {
		if (Ball != null) {
			var ballController = Ball.AddComponent<BallController>();
			ballController.GoalScoredDelegate = GoalScored;
				}
		
		UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateScore()
	{
		Text.text = "Player 1 " + score1 + " : " + score2 + " Player 2";
	}

	void GoalScored(string player)
	{
		if (player == "Player1")
{
score1++;
}
		if (player == "Player2")
{
score2++;
}
UpdateScore();
	}
}
