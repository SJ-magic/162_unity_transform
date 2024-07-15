/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class GetTransform : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
        
    }
	
	/******************************
	******************************/
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space) ){
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
			
			for (int i = 0; i < 1E+7; i++)
            {
				Transform t = gameObject.GetComponent<Transform>();		// 0.79 [s]
				// Transform t = gameObject.transform;						// 0.65 [s]
				// Transform t = GetComponent<Transform>();				// 0.48 [s]
				// Transform t = transform;								// 0.37 [s]
            }
			
            sw.Stop();
            UnityEngine.Debug.Log(sw.Elapsed);
		}
    }
}
