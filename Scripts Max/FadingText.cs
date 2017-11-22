using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadingText : MonoBehaviour
{
    public float time_between = 6f;
    void Update()
    {
        time_between -= Time.deltaTime;
        if (time_between >= 2.9f)
        {
            StartCoroutine(FadeTextToFullAlpha(3f, GetComponent<Text>()));
        }
        if (time_between <= 2.9f)
        {
            StartCoroutine(FadeTextToZeroAlpha(3f, GetComponent<Text>()));

        }
        if(time_between <= 0f)
        {
            time_between = 6f;
        }
    }



    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
