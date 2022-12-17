using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhite : MonoBehaviour
{
    public Renderer engineBodyRenderer;
    public float speed;
    public Color Red, White, Blue, Green;
    float startTime;

    public void WhiteToRed()
    {
        StartCoroutine(ChangeColourWhiteToRed());
    }

    public void RedToWhite()
    {
        StartCoroutine(ChangeColourRedToWhite());
    }

    public void RedToBlue()
    {
        StartCoroutine(ChangeColourRedToBlue());
    }

    public void BlueToRed()
    {
        StartCoroutine(ChangeColourBlueToRed());
    }

    private IEnumerator ChangeColourRedToWhite()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != White)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(Red, White, tick);
            yield return null;
        }
    }
    private IEnumerator ChangeColourWhiteToRed()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != Red)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(White, Red, tick);
            yield return null;
        }
    }
    private IEnumerator ChangeColourRedToBlue()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != Blue)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(Red, Blue, tick);
            yield return null;
        }
    }
    private IEnumerator ChangeColourBlueToRed()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != Red)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(Blue, Red, tick);
            yield return null;
        }
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