using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public GameObject cubePrefab;
    GameObject[] cube = new GameObject[512];
    public float maxScale;
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject _instanceCube = (GameObject)Instantiate (cubePrefab);
            _instanceCube.transform.position = this.transform.position;
            _instanceCube.transform.parent = this.transform;
            _instanceCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3 (0, -0.703125f * i, 0);
            _instanceCube.transform.position = Vector3.forward * 100;
            cube[i] = _instanceCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (cube != null)
            cube[i].transform.localScale = new Vector3(10, (GetAudioData.samples[i] * maxScale) +2, 10);
        }

        }
}
