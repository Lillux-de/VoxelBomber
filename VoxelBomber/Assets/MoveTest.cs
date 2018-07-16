using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour {

	public GameObject bombprefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 3, 0, Input.GetAxis("Vertical") * Time.deltaTime * 3);
		
		if(Input.GetButtonUp("Jump")){// || Input.GetButton("Fire")){
			Instantiate(bombprefab , new Vector3(Mathf.RoundToInt(transform.position.x), 1 ,Mathf.RoundToInt(transform.position.z)) , Quaternion.identity);
		}
	}
}
