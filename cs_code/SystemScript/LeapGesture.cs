using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapGesture : MonoBehaviour
{
    public GameObject mySphere;
   
    void Start()
    {
        
    }

    // Update is called once per frame 

    void Update()

    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Vector3 a = new Vector3(-2.494317f, 8.11f, -34.83127f); //ʵ����Ԥ�����position�����Զ���
            Quaternion b = new Quaternion(0, 0, 0, 0);//ʵ����Ԥ�����rotation�����Զ���
                                                      // Use this for initialization
            GameObject Sphere = GameObject.Instantiate(mySphere, a, b) as GameObject;
        }
    }

}
