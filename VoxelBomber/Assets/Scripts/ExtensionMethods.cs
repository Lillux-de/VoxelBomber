using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods {


	/// <summary>
	/// Rounds Vector3.
	/// </summary>
	/// <param name="vector3"></param>
	/// <param name="decimalPlaces"></param>
	/// <returns></returns>
	public static Vector3 Round(this Vector3 vector3, int decimalPlaces = 0){
		float multiplier = 1;
		for (int i = 0; i < decimalPlaces; i++){
			multiplier *= 10f;
		}
		return new Vector3(
			Mathf.Round(vector3.x *multiplier) / multiplier,
			Mathf.Round(vector3.y *multiplier) / multiplier,
			Mathf.Round(vector3.z *multiplier) / multiplier			
		);
	}



	/// <summary>
	/// Resizes Object to desired Length
	/// </summary>
	/// <param name="GameObject"></param>
	/// <param name="newSize"></param>
	/// <returns></returns>
	public static void newScale(GameObject GameObject, float newSize){
		Vector3 size = GameObject.GetComponent<Renderer>().bounds.size;
		Vector3 rescale = GameObject.transform.localScale;

		rescale.x = newSize * rescale.x / size.x;
		rescale.y = newSize * rescale.y / size.y;
		rescale.z = newSize * rescale.z / size.z;

		GameObject.transform.localScale = rescale;
	}

}
