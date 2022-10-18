using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{

    // private Vector2 tempPos;

    // private SpriteRenderer sr;

    // [SerializeField]
    // private float max_Y = -3.2f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TagManager.GROUND_TAG))
        {
            Destroy(gameObject);
        }
    }

    // void HandleKnifeDissapearing()
    // {
    //     if (tempPos.y = max_Y)
    //         sr.enabled = false;
    // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
