using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Canvas使う為の準備

public class PlayerController : MonoBehaviour
{

	[SerializeField] float speed;//移動スピード
	[SerializeField] Text scoreText;
	[SerializeField] Text winText;

	Rigidbody rb;//取得したRigidbodyを格納しておく為の変数
	int score;


	void Start()
	{
		rb = this.gameObject.GetComponent<Rigidbody>();//Rigidbodyを取得→変数rbに格納
		init();//各種要素初期化
	}

	// Update is called once per frame
	void Update()
	{
		Move();//Playerの移動
	}

	//Playerの移動
	void Move()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");//横方向の入力を取得
		float moveVertical = Input.GetAxis("Vertical");//縦方向の入力を取得

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);//移動する方向ベクトル作成

		rb.AddForce(movement * speed);//『方向ベクトル×大きさ』の力を加える
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Gem")//当たった相手のtagがGemだった時
		{
			col.gameObject.SetActive(false);
			score++;
			SetCountText();//UI表示の更新
		}
	}

	//各種要素初期化の為の関数
	void init()
	{
		score = 0;
		winText.text = "";
		SetCountText();
	}

    //UI表示の更新
	void SetCountText()
	{
		scoreText.text = "Count : " + score.ToString();

		if(score >= 4)
		{
			winText.text = "You Win !!";
		}
	}
}
