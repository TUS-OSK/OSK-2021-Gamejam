
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{

    //public
    public float speed = 1.0f;

    //private
    private Text text;
    private Image image;
    private float time;


    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        text.color = GetAlphaColor(text.color);
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time);

        return color;
    }
}