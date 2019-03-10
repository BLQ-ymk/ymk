using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fir_Cam : MonoBehaviour {

    public GameObject targetobj;
    public float mousesensity;
    public float MinY=-40f;
    public float MaxY=40f;
    float Camera_X;
    float Camera_Y;

	void Start () {
		
	}
	
	void Update () {
        Camera_X = transform.localEulerAngles.y+Input.GetAxis("Mouse X") * mousesensity;
        Camera_Y+= Input.GetAxis("Mouse Y") * mousesensity;
        Camera_Y = Mathf.Clamp(Camera_Y,MinY,MaxY);
        transform.localEulerAngles = new Vector3(-Camera_Y,Camera_X,0f);
        transform.position = targetobj.transform.position;
	}
}
