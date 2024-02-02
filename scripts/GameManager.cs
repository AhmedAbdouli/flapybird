using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public GameObject column;
    bool game_started = false;
    public GameObject start_panel;
    void Start()
    {
        Time.timeScale=0;
    }

    void Update()
    {
          if (Input.GetKeyDown(KeyCode.Space) && game_started== false){
            Time.timeScale=1;
            StartCoroutine(Createcolumn());
            game_started = true;
            start_panel.SetActive(false);

          }
        
    }

    IEnumerator Createcolumn(){
        yield return new WaitForSeconds(1);

        GameObject new_column = Instantiate(column);
        new_column.transform.position = new Vector3(5,Random.Range(-2f,2f),0);

        StartCoroutine(Createcolumn());
    }
    public void restartgame(){
        SceneManager.LoadScene("game");
    }
}
