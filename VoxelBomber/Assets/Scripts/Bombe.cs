using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : MonoBehaviour {

	public GameObject flame;
	private int[] dir = {5,5,5,5}; //0=top - 1=right - 2=bot - 3=left

	// Use this for initialization
	void Start () {
		GetComponent<Animation>().Play();
		StartCoroutine(Zuenden());
	}

	private IEnumerator Zuenden(){
		yield return new WaitForSeconds(3);
		Explodieren();	
	}

	void Explodieren(){

		Instantiate(flame , new Vector3(transform.position.x , transform.position.y , transform.position.z) , Quaternion.identity);

		//Up
		for(int i = 1 ; i <= dir[0] ; i++){
			Instantiate(flame , new Vector3(transform.position.x , transform.position.y , transform.position.z + i) , Quaternion.identity);
		}
		//right
		for(int i = 1 ; i <= dir[0] ; i++){
			Instantiate(flame , new Vector3(transform.position.x + i, transform.position.y , transform.position.z) , Quaternion.identity);
		}
		//bot
		for(int i = 1 ; i <= dir[0] ; i++){
			Instantiate(flame , new Vector3(transform.position.x , transform.position.y , transform.position.z - i) , Quaternion.identity);
		}
		//left
		for(int i = 1 ; i <= dir[0] ; i++){
			Instantiate(flame , new Vector3(transform.position.x - i, transform.position.y , transform.position.z) , Quaternion.identity);
		}
		Destroy(gameObject);
	}
}
