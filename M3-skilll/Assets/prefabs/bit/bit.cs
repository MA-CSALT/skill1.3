using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer spriteRenderer;
    bool state = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state) 
        {
            spriteRenderer.color = Color.green;
        }

        else
        {
            spriteRenderer.color = Color.red;
        }
    }

    private void OnMouseUp()
    {
        state = !state;
    }

}
