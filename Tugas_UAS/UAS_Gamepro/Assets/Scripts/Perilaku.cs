using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Perilaku : MonoBehaviour
{
    
    public Text KekuatanText;
    private string KekuatanNum;


    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "enemyTag"){
            if(KekuatanNum=="Off"){
                Debug.Log("Game Over");
                Die();
            }
            else{

            }
    
        }
        else if (coll.gameObject.tag == "Finish"){
            Debug.Log("Finish");
            Finish();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        KekuatanNum = "Off";
        KekuatanText.text = "Power :" +KekuatanNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("GameOver");
    }
    void Finish(){
        Debug.Log("Finish");
        SceneManager.LoadScene ("Finish");
    }

    private void OnTriggerEnter2D(Collider2D Kekuatan){

        if(Kekuatan.tag =="powerupTag"){

        KekuatanNum = "On";
        Destroy(Kekuatan.gameObject);
        KekuatanText.text = "Power :" +KekuatanNum;

        }
    }
}
