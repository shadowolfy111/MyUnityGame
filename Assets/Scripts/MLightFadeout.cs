using UnityEngine;
using System.Collections;

public class MLightFadeout : MonoBehaviour {

	public Light lt;
	private float ctrl;
	private bool amp;

	// Use this for initialization
	void Start () 
	{
		lt = GetComponent<Light>();
		amp = true;
		ctrl = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (amp == false && ctrl > 0.0f)
		{
			ctrl = ctrl-0.1f;
		}
		if (amp == true && ctrl < 0.5f)
		{
			ctrl = ctrl +0.1f;
		}

		if (Input.GetKeyDown("m"))
		{
			switch (amp)
			{
				case true:
				amp = false;
			    break;
			    case false:
				amp = true;
				break;
			}
		}
		lt.intensity = ctrl;
		print (amp);
		print (ctrl);
	}
}
