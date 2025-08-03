using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverZoomItem : MonoBehaviour
{
    private Vector3 originaScale;
    private Vector3 targetScale;

    public float hoverScaleFactor = 1.5f;
    public float hoverScaleSpeed = 2;

    private bool isHover = false;


    // Start is called before the first frame update
    void Start()
    {
        originaScale = transform.localScale;
        targetScale = originaScale;
    }

    void OnMouseEnter()
    {
        isHover = true;
        targetScale = originaScale * hoverScaleFactor;
    }

    void OnMouseExit()
    {
        isHover = false;
        targetScale = originaScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * hoverScaleSpeed);
    }
}
