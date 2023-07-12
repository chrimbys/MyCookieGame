using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource SE;
    [SerializeField]
    AudioClip click;
    [SerializeField]
    AudioClip register;
    [SerializeField]
    AudioClip make;
    [SerializeField]
    AudioClip lavelUp;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SE.clip = click;
            SE.Play();
        }
    }
    public void OnClickPurchaseButton()
    {
        SE.clip =register;
        SE.Play();
    }
    public void OnClickMakeButton()
    {
        SE.clip = make;
        SE.Play();
    }
    public void OnClickLavelUpButton()
    {
        SE.clip = lavelUp;
        SE.Play();
    }

}
