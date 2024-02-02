using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Text txt_points ;
    int points = 0 ;

    public GameObject game_over;
    public AudioClip jump;
    public AudioClip lose;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,7);
            GetComponent<Animator>().Play("fly",0,0);

            GetComponent<AudioSource>().PlayOneShot(jump);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag== "floor") {
            Debug.Log("Game Over");
            Time.timeScale=0;
            GetComponent<AudioSource>().PlayOneShot(lose);
            game_over.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag== "point"){
            Debug.Log("+1 point");
            points++;
            txt_points.text = points.ToString();
        } 
    }
}
