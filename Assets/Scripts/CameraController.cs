using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField] GameObject player;//カメラが追従する対象(PlayerをUnityからアタッチ)
	Vector3 offset;//Playerからカメラの位置までの座標の差

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position + offset;//自分(カメラ)の位置をPlayerから一定の位置に保つ

        //この動きはMainCameraをPlayerの子要素にすることでも実現できる！
	}
}
