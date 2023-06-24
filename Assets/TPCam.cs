using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class TPCam : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam;
    [SerializeField] private GameObject dirLight;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            var rotX = dirLight.transform.rotation.x;
            var rotVal = 45;
            if (rotX >= 45)
                rotVal = -45;
            dirLight.transform.localEulerAngles = new Vector3(rotX + rotVal, 0, 0);
        }
    }
}
