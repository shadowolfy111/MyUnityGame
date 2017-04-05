using UnityEngine;
using System.Collections;

public class MessBox : MonoBehaviour {

	public Animator anim;
	private bool ps;
	private int blend;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		ps = true;
		blend = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (blend != 0)
		{
			blend = 0;
		}

		if (Input.GetKeyDown("m"))
		    {
			    switch (ps)
			    {
			    case false:
				    ps = true;
					blend = 1;
				    break;
			    case true:
				    ps = false;
					blend = 2;
				    break;
				}
			}
		anim.SetBool ("PlayStop", ps);
		anim.SetInteger ("Blend", blend);
	}
}
