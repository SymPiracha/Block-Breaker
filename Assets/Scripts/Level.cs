using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBLocks; //serialized for debugging
    
    //cached reference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlocks()
    {
        breakableBLocks++;
       
    }
    public void BlocksDestroyed()
    {
        breakableBLocks--;
       
        if (breakableBLocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
