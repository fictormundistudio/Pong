using System.Numerics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

//to=do list:
//0: Make the ball move
//1: Decide at random what way the ball wil travel first (Ether choose - or not -)
//2: Decide the angel that the ball will move at. (On the X axis choose within what degrees the ball should first travel)

public class Ball : MonoBehaviour
{

    Rigidbody2D rb_ball;
    float moveSpeed = 1f;
    private UnityEngine.Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb_ball = GetComponent<Rigidbody2D>();
        direction = new UnityEngine.Vector2(GetXValue(), Random.Range(-1, 1));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    int GetXValue()
    {
        int Angle = Random.Range(-1, 1);
        if (Angle == 0)
        {
            Angle = 1;
        }
        return Angle;
    }

}
