using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform hero;
    private Vector3 shift;

	// Use this for initialization
	void Start () {

        shift = transform.position - hero.transform.position;
        //获取镜头与角色之间的距离

    }
	
	// Update is called once per frame
	void Update () {

        transform.position = hero.transform.position + shift;
        //使当前镜头位置根据角色位置变化而变化

	}
}
