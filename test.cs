using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
	private string 		test_s;
	// Use this for initialization
	void Start ()
	{

		test_s = "test_master";

		test_s = "test_branch1";

		Debug.Log (test_s);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

