using UnityEditor;
using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour
{
    public GameObject OutputObject;

    public Vector3 mouseDownStart;
	public Vector3 outputObjectPositionStart;
    public bool isMouseDown;

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
            }
            if (OutputObject != null && isMouseDown)
	        {
                var y = Input.mousePosition.x - mouseDownStart.x;
				var x = Input.mousePosition.y - mouseDownStart.y;
				x = x / 10;
				if (x > 7.8F)
				{
					x = 7.8F;
				}
				if (x < -7.8F)
				{
					x = -7.8F;
				}
                OutputObject.transform.Rotate(0, y, 0);
				OutputObject.transform.position = new Vector3(outputObjectPositionStart.x - x, OutputObject.transform.position.y, OutputObject.transform.position.z); 
	        }
	    }
	}

    void OnMouseDown()
    {
        mouseDownStart = Input.mousePosition;
		outputObjectPositionStart = OutputObject.transform.position;
        isMouseDown = true;
    }
}
