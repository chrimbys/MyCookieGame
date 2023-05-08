using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorManager : MonoBehaviour
{
    [SerializeField]
    GameObject flourbutton;


    // Start is called before the first frame update
    void Start()
    {

        flourbutton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
