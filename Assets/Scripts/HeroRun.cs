using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroRun : MonoBehaviour {

    public NavMeshAgent navAgent;//定义为public可使用拖拽赋值
    public Animator runAnime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //从相机位置发出一条到游戏物体的检测射线，将鼠标的屏幕坐标转化成射线。
            //!!!运行时18行出错，提示代码没有实例化。*检查MainCamera的tag属性是否设置为MainCamera，如果没有则会报错。
            RaycastHit hit;
            //创建一个保存碰撞信息的参数
            //用physics传递射线和输出一个碰撞信息
            if (Physics.Raycast(ray, out hit))
            {//如果发生碰撞，获取鼠标点击碰撞的坐标位置
                
                navAgent.SetDestination(hit.point);
                //利用NavMeshAgent组件控制人物移动到目标位置。

            }
        }
        runAnime.SetFloat("speed", navAgent.velocity.magnitude);
        //设置动画参数speed的值。通过NavMeshAgent获取速度大小赋给speed
	}
}
