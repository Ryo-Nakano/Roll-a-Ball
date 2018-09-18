using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotator : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);//一定スピードで回転
	}
}
