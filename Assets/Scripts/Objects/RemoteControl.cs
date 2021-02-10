using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteControl : MonoBehaviour
{
    public Sprite TV;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If E is pressed, toggle tv
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleTV();
        }

        // Change channel if tv is turned on: use arrow keys?
    }

    void ToggleTV() 
    {
        // play click remote sound
        if (!spriteRenderer.sprite)
        {
            // play tv turn on sound
            spriteRenderer.sprite = TV;
        }
        else
        {
            // play tv turn off sound
            spriteRenderer.sprite = null;
        }
    }
}
