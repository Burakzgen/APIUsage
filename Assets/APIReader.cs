using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APIReader : MonoBehaviour
{
    public Image requesImage;
    private const string URL = "https://http.cat/";
    public int[] urlvalue;
    private int value;
    public void Request()
    {
        value += 1;
        WWW reques = new WWW(URL+urlvalue[value]);
        StartCoroutine(OnReponse(reques));
    }

    private IEnumerator OnReponse(WWW req)
    {
        yield return req;
        Texture2D texture = req.texture;
        requesImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

    }
}
