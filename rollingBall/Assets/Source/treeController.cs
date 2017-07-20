using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeController : MonoBehaviour {

    public Rigidbody treeRB;

	// Use this for initialization
	void Start () {
        treeRB = new Rigidbody();
        treeRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
