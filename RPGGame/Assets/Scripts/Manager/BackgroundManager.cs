using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public List<BackgroundLayers> layers = new List<BackgroundLayers>();

    private void Start()
    {
        CameraManager.Instance.OnScrolling.AddListener(HandleOnScrolling);
    }

    private void HandleOnScrolling(float scrollValue)
    {
        foreach (var layer in layers)
        {
            layer.Scroll(scrollValue);
        }
    }
}

[System.Serializable]
public class BackgroundLayers
{
    public Transform obj = null;
    [Range(0, 10)]
    public float scrollSpeed = 1f;

    public void Scroll(float scrollValue)
    {
        obj.transform.position = new Vector3(-(scrollValue * scrollSpeed), obj.transform.position.y, obj.transform.position.z);
    }
}