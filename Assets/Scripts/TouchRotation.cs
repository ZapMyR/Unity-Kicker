using UnityEditor;
using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour
{
    public GameObject OutputObject;

    public Vector3 mouseDownStart;
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
                var y = Input.mousePosition.y - mouseDownStart.y;
                OutputObject.transform.Rotate(0, y, 0);
	        }
	    }
	}

    void OnMouseDown()
    {
        mouseDownStart = Input.mousePosition;
        isMouseDown = true;
    }
}
