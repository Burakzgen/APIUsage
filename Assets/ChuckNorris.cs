using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChuckNorris : MonoBehaviour
{
    public Text jokeText;
    //public Image image;
    public void NewJoke()
    {
        Joke joke = APIHelper.GetNewJoke();
        jokeText.text = joke.icon_url;
        //ýmage = joke.icon_url;
    }
}
