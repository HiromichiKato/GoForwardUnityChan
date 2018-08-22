using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    //衝突を検知するためのコンポーネントを入れる
    BoxCollider2D boxCollider2D;
    //unitychanをいれる
    private GameObject unitychan2D;

    //Cubeの移動速度     private float speed = -0.2f;     //消滅位置     private float deadLine = -10;
    //衝突判定
    private bool isCollision = false;

	// Use this for initialization
	void Start () {
        this.boxCollider2D = GetComponent<BoxCollider2D>();
        this.unitychan2D = GameObject.Find("UnityChan2D");
	}
	
	// Update is called once per frame
	void Update () {
        //Cubeを移動させる         transform.Translate(this.speed, 0,0);         //画面外に出たら破棄する         if(transform.position.x < this.deadLine) {             Destroy(gameObject);
	    }
    }

    void OnCollisionEnter2D(Collision2D other) {
        this.isCollision = true;
        if (this.isCollision == true) {
            AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
            gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
        }

        if(other.gameObject.tag == "UnityChanTag") {
            GetComponent<AudioSource>().volume = 0;
        }
    }
}