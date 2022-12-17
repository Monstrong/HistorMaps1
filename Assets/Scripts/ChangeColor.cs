using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ChangeColor : MonoBehaviour
{
    public Renderer engineBodyRenderer;
    public float speed;
    public Color Red, White, Blue, Green;

    public void ToRed()
    {
        engineBodyRenderer.material.DOColor(Red, 1);
    }

    public void ToWhite()
    {
        engineBodyRenderer.material.DOColor(White, 1);
    }

    public void ToBlue()
    {
        engineBodyRenderer.material.DOColor(Blue, 1);
    }

    public void ToGreen()
    {
        engineBodyRenderer.material.DOColor(Green, 1);
    }
}
/* public Renderer engineBodyRenderer;
    public float speed;
    public Color[] colors = new Color[] {
        color ToWhite,
        color Red,
        color Blue,
        };
    public color endColor;

    float startTime;

    public void White()
    {
        StartCoroutine(ChangeEngineColour());
    }


    private IEnumerator ChangeEngineColour()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != endColor)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(colors[0], endColor, tick);
            yield return null;
        }
    }
}*/