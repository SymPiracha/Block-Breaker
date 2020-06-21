using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{
    //when something passes the collide, what do we want to happen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //we want to load the game over scene
        //using the SceneManagement name space, we use a string which indicated the name of the scene to load it
        //want to avoid string references in the future, in case you want to make changes later
        SceneManager.LoadScene("Game Over");
    }
}
