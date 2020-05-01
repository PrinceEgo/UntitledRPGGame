using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance { private set; get; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public Transform target = null;
    [Range(0f, 1f)]
    public float smoothing = 0.2f;

    public FloatEvent OnScrolling = new FloatEvent();

    Vector3 refVelocity;

    private void FixedUpdate()
    {
        Follow();
    }
    private void Update()
    {
        Scrolling();
    }

    void Follow()
    {
        Vector3 targetPos = new Vector3(target.position.x, transform.position.y, transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref refVelocity, smoothing);
    }

    void Scrolling()
    {
        OnScrolling.Invoke(transform.position.x);
    }
}

public class FloatEvent : UnityEvent<float> { }