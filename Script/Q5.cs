using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class check : MonoBehaviour

{

    float x = 0;
    float y = 0;
    float z = 5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector3(x , y , z)*Time.deltaTime);
    }
     void OnCollisionEnter()
    {
        z = z * -1;
    }
}
