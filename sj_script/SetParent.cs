/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class SetParent : MonoBehaviour
{
	/****************************************
	****************************************/
	[SerializeField] GameObject prefab;
	
	/******************************
	******************************/
    void Start()
    {
        
    }

	/******************************
	******************************/
    void Update()
    {
		/********************
		public void SetParent (Transform parent, bool worldPositionStays);
		********************/
        if( Input.GetKeyDown(KeyCode.A) ){
			GameObject go = (GameObject)Instantiate( prefab, new Vector3(5, 0, 0), Quaternion.identity );
			go.transform.parent = transform;
			
		}else if( Input.GetKeyDown(KeyCode.B) ){
			GameObject go = (GameObject)Instantiate( prefab, new Vector3(5, 0, 0), Quaternion.identity );
			go.transform.SetParent(transform, true);
			
		}else if( Input.GetKeyDown(KeyCode.C) ){
			GameObject go = (GameObject)Instantiate( prefab, new Vector3(5, 0, 0), Quaternion.identity );
			go.transform.SetParent(transform, false);
			
		}
    }
}
