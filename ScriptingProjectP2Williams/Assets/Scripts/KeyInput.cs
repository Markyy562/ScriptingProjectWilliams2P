using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downfx;
    public Sprite upfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

  void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
