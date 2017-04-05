using UnityEngine;
using System.Collections;

public class TouchCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Print live number of touches
		Debug.Log (Input.touchCount);
		//Test if there is at least on touch
		if(Input.touchCount > 0)
		{
			//test touch ctrls


			//Gets 1st touch position (1 = 2nd, etc...)
			Debug.Log (Input.GetTouch (0).position);
			//Gets a array of touch position
			foreach (Touch touch in Input.touches)
			{
				Debug.Log (touch.position);
			}
			//Gets the phase of the touch
			if (Input.GetTouch (0).phase == TouchPhase.Began)
			{
				Debug.Log ("Touch Began");
			}
			if (Input.GetTouch (0).phase == TouchPhase.Moved)
			{
				Debug.Log ("Touch Moved");
			}
			if (Input.GetTouch (0).phase == TouchPhase.Ended)
			{
				Debug.Log ("Touch Ended");
			}
		}
	}
}