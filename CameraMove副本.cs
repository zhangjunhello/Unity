using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public Transform target;//主角对象
	private Vector3 deltaP;//获取主角和相机相对位置
	// Use this for initialization
	void Start () {

		deltaP = transform.position - target.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void LateUpdate(){
	     
		Vector3 playerPos = target.position; //主角位置

		Vector3 currentPos = deltaP + playerPos;//相机位置 = 主角位置+相对位置

		transform.position = currentPos;
	}
}
