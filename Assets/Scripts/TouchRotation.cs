using UnityEditor;
using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour
{
    public GameObject OutputObject;
	public GameObject[] Figures;

	public float WallBoundary = 7.8F;

	private Vector3 resetPos;
	private Quaternion resetRot;

    private Vector3 mouseDownStart;
	private float outputObjectPositionInit;
	private float outputObjectPositionStart;
    private bool isMouseDown;
	private float rotationApplied;

	// Use this for initialization
	void Start () {	
		if (OutputObject != null) {
			resetPos = OutputObject.transform.position;
			resetRot = OutputObject.transform.rotation;
						outputObjectPositionInit = OutputObject.transform.position.x;
				}
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
            else if (OutputObject != null)
	        {
				// bereits stattgefundenes delta
				float currentObjectDelta = outputObjectPositionStart - outputObjectPositionInit;
				// y delta maus
                var y = Input.mousePosition.x - mouseDownStart.x;
				// x delta maus
				var x = Input.mousePosition.y - mouseDownStart.y;

				// x dämpfung
				x = x / 20;

				// noch durchzuführende rotation = y delta maus - bereits stattgefundene rotation
				var rotationTemp = y - rotationApplied;
				// delta dieser mausbewegung = ausgangsposition + x delta maus
				var movementToApply = outputObjectPositionStart - x;
				// insgesamter versatz = delta dieser mausbewegung + bereits stattgefundenes delta
				var movementTemp = movementToApply + currentObjectDelta;

				// "hit test" zwischen figuren und wänden
				if (movementTemp > WallBoundary)
				{
					movementTemp = WallBoundary;
				}
				else if (movementTemp < 0-WallBoundary)
				{
					movementTemp = 0-WallBoundary;
				}

				// anwendung der rotations- und positionsänderungen
				OutputObject.transform.Rotate(0, 0 - rotationTemp, 0);
				OutputObject.transform.position = new Vector3(movementTemp, OutputObject.transform.position.y, OutputObject.transform.position.z); 

				// merken des rotationsdeltas
				rotationApplied += rotationTemp;
	        }
			else
			{				
				Debug.Log("Unexpected");
			}
		}
	}

	public void ResetPosition()
	{
		OutputObject.transform.rotation = resetRot;
		OutputObject.transform.position = resetPos;
		
		isMouseDown = false;
		rotationApplied = 0;
	}



    void OnMouseDown()
    {
        mouseDownStart = Input.mousePosition;
		outputObjectPositionStart = OutputObject.transform.position.x;
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
