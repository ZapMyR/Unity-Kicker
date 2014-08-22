using UnityEditor;
using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour
{
    public GameObject OutputObject;
	public GameObject[] Figures;

    private Vector3 mouseDownStart;
	private Vector3 outputObjectPositionStart;
    private bool isMouseDown;
	private float rotationApplied;

	// Use this for initialization
	void Start () {	
	}
		
	// Update is called once per frame
	void Update () {
        if (isMouseDown)
	    {
            if (Input.GetMouseButtonUp(0))
            {
                isMouseDown = false;
				rotationApplied = 0;
            }
            if (OutputObject != null && isMouseDown)
	        {
                var y = Input.mousePosition.x - mouseDownStart.x;
				var x = Input.mousePosition.y - mouseDownStart.y;

				x = x / 20;

				var rotationTemp = y - rotationApplied;

				if (x > 7.8F)
				{
					x = 7.8F;
				}
				if (x < -7.8F)
				{
					x = -7.8F;
				}
				OutputObject.transform.Rotate(0, 0 - rotationTemp, 0);
				OutputObject.transform.position = new Vector3(outputObjectPositionStart.x - x, OutputObject.transform.position.y, OutputObject.transform.position.z); 
				rotationApplied += rotationTemp;

	        }
	    }
	}



    void OnMouseDown()
    {
        mouseDownStart = Input.mousePosition;
		outputObjectPositionStart = OutputObject.transform.position;
        isMouseDown = true;
    }

	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.name == "Wall")
		{
			Debug.Log("Wall hit");
			//var x = Input.mousePosition.y - mouseDownStart.y;
			//if (x > 0)
			//{
			//	upperWallBoundary = x;
			//}
			//else
			//{
			//	lowerWallBoundary = x;
			//}
		}
	}
}
