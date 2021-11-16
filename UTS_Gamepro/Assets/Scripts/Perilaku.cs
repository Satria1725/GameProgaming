using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perilaku : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D coll){
if (coll.gameObject.tag == "enemyTag"){
    Debug.Log("Game Over");
    Die();
    
}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("Playagain");
    }
}
