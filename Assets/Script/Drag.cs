using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler
{
    private RectTransform map;
    private RectTransform screen;
    private Camera main;
    
    private void Awake()
    {
        map = GameObject.FindGameObjectWithTag("Map").GetComponent<RectTransform>();
        screen = GameObject.FindGameObjectWithTag("Screen").GetComponent<RectTransform>();
        main = Camera.main;
    }
    public void OnDrag(PointerEventData eventData)
    {
        float x = map.position.x + eventData.delta.x;
        float y = map.position.y + eventData.delta.y;
        float worldH = screen.sizeDelta.y / 2;
        float worldW = screen.sizeDelta.x / 2;
        float xSize = map.sizeDelta.x / 2;
        float ySize = map.sizeDelta.y / 2;
        if(xSize>worldW)
        {
            float temp = xSize - worldW;
            x = Mathf.Clamp(x, -temp + worldW, temp + worldW);
        }
        else
        {
            float temp =  worldW - xSize;
            x = Mathf.Clamp(x, -temp + worldW, temp + worldW);
        }
        if(ySize>worldH)
        {
            float temp = ySize - worldH;
            y = Mathf.Clamp(y, -temp + worldH, temp + worldH);
        }
        else
        {
            float temp = worldH - ySize;
            y = Mathf.Clamp(y, -temp + worldH, temp + worldH);
        }
        map.position = new Vector2(x, y);
    }
}
