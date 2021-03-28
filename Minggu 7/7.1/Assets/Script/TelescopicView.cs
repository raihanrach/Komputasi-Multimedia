using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopicView : MonoBehaviour
{
    public float zoom = 2.0f;
    public float speedIn = 100.0f;
    public float speedOut = 100.0f;
    public float initFov;
    public float currFov;
    public float minFov;
    public float addFov;
    public float vMax = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        initFov = Camera.main.fieldOfView;
        minFov = initFov / zoom;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ZoomView();
        }
        else
        {
            ZoomOut();
        }

        float currentDistance = currFov - initFov;
        float totalDistance = minFov - initFov;
    }

    void ZoomView()
    {
        currFov = Camera.main.fieldOfView;
        addFov = speedIn * Time.deltaTime;
        if(Mathf.Abs(currFov - minFov) < 0.5f)
        {
            currFov = minFov;
        } else if (currFov - addFov >= minFov)
        {
            currFov -= addFov;
            Camera.main.fieldOfView = currFov;
        }
    }

    void ZoomOut()
    {
        currFov = Camera.main.fieldOfView;
        addFov = speedOut * Time.deltaTime;
        if (Mathf.Abs(currFov - initFov) < 0.5f)
        {
            currFov = initFov;
        }
        else if (currFov + addFov <= initFov)
        {
            currFov += addFov;
            Camera.main.fieldOfView = currFov;
        }
    }
}
