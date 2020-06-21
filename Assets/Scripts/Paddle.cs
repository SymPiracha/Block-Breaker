using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float zValue = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;
   
    }

    private float GetXPos()
    {
        if (FindObjectOfType<GameStatus>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }

}


/*
//things to try:
- fix score reset
- change bounce value when you hit a power up
- change clamp value to limit where the paddle goes to as a power down
- have a powerup which makes the ball stick back to the paddle, when you press left click ball come backs to paddle for a limited amount of time
- change ball gravity
- change game speed 
- for lightsabe,maybe make other paddle inactive:gameObject.setactive(false);

    */
