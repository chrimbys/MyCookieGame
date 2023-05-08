using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlinking : MonoBehaviour
{
    [SerializeField]
    Color color;

    [SerializeField]
    Text text;

    [SerializeField]
    float speed = 1.0f;

    [SerializeField]
    float time;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color = GetAlphaColor(text.color);

        
    }

    private Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * speed;
        color.a = Mathf.Sin(time);

        return color;
    }

}
