using UnityEngine;
using System.Collections;

//using System;
public class ActionIntervel : MonoBehaviour {
	public float completTime = 0f;
	public GameObject m_target;
	private float currentTime = 0f;


	public Vector3 m_targetPos = Vector3.zero;
	public Vector3 m_targetAngle = Vector3.zero;
	public Vector3 m_targetScale = Vector3.zero;

	public bool isMove = false;
	public bool isRotate = false;
	public bool isScale = false;


	//private float x = 0f;

	public delegate void VoidCallFunc ();

	public event VoidCallFunc CompleteFunc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime >= completTime) {		
			CompleteFunc();
			Debug.Log ("CompletTime");
			currentTime = 0f;
			Destroy (this);
		} else {
		
			if (isMove) 
			
				m_target.transform.Translate (m_targetPos/completTime*Time.deltaTime);

			
			if (isRotate) 
			

				m_target.transform.Rotate (m_targetAngle/completTime*Time.deltaTime);

			if (isScale){
		
				//x = m_targetScale / completTime * Time.deltaTime;
				m_target.transform.localScale = Vector3.Lerp(m_target.transform.localScale, m_targetScale, Time.deltaTime
				);
			}
		}
		 
	}
	public static void MoveToPos(GameObject target, Vector3 targetPos, float time, VoidCallFunc ac)

	{

		ActionIntervel ai = target.AddComponent<ActionIntervel> ();
		ai.completTime = time;
		ai.m_target = target;
		ai.m_targetPos = targetPos;
		ai.isMove = true;
		ai.CompleteFunc = ac;


	}
	public static void RotateToAngel(GameObject target, Vector3 targetAngle, float time, VoidCallFunc ac)
	{
		ActionIntervel ai = target.AddComponent<ActionIntervel> ();
		ai.completTime = time;
		ai.m_target = target;
		ai.m_targetAngle = targetAngle;
		ai.isRotate = true;
		ai.CompleteFunc = ac;
	}
	public static void ScaleToScale(GameObject target, Vector3 targetScale, float time, VoidCallFunc ac){
		ActionIntervel ai = target.AddComponent<ActionIntervel> ();
		ai.completTime = time;
		ai.m_target = target;
		ai.m_targetScale = targetScale;
		ai.isScale = true;
		ai.CompleteFunc = ac;

	}
}
