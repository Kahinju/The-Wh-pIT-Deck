using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class GameController : MonoBehaviour
{
    public GameObject player;

    public GameObject enemy;

    private BoxCollider2D enemy_collider;

    private BoxCollider2D player_collider;



    // Start is called before the first frame update
    void Start()
    {
        enemy_collider = enemy.GetComponent<BoxCollider2D>() as BoxCollider2D;

        player_collider = player.GetComponent<BoxCollider2D>() as BoxCollider2D;

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        detectPlayer();
    }

    void detectPlayer()
    {
        bool test = enemy_collider.IsTouching(player_collider);

        if (test)
        {
            var rend = enemy.GetComponent<Image>();
            rend.material.SetColor("_Color", Color.red);
        }
        
    }

    void movePlayer()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.transform.position += Vector3.left * 5f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.transform.position += Vector3.right * 5f;
        }
    }
    
}

 


