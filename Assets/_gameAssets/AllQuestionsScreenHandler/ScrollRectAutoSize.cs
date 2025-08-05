using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollRectAutoSize : MonoBehaviour
{
    public int cellSize = 350;
    public void ChangeSize()
    {
        RectTransform rt = GetComponent<RectTransform>();
        int childCount = transform.childCount;
        int ySize = childCount * cellSize + 50;
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, ySize);
        rt.anchorMin = new Vector2(rt.anchorMin.x, 1);
        rt.anchorMax = new Vector2(rt.anchorMax.x, 1);
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, -ySize / 2);
    }
}
