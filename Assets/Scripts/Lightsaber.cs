using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour
{
    [SerializeField] Paddle originalPaddle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 paddlePositon = new Vector3(originalPaddle.transform.position.x, originalPaddle.transform.position.y, 0);
        transform.position = paddlePositon;
    }
}
