using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Charactor_Debug : MonoBehaviour 
{
    public Sprite sprite { get; private set;}
    public string text { get; private set;}


    void Awake()
    {
        
    }

    void Start()
    {
        sprite = GetComponent<Image>().sprite;
        text = "キャラクター情報";
    }
	
}
