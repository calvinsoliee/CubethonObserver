using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Chapter.Observer
//{
    public class PlayerMovement : MonoBehaviour
    {

        public Rigidbody rb;

        public float forwardForce = 2000f;
        public float sidewaysForce = 500f;
        GameManager gameManager;

    void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                Command moveRight = new MoveRight(rb, sidewaysForce);
                Invoker invoker = new Invoker();
                invoker.SetCommand(moveRight);
                invoker.ExecuteCommand();
            }

            if (Input.GetKey("a"))
            {
                Command moveLeft = new MoveLeft(rb, sidewaysForce);
                Invoker invoker = new Invoker();
                invoker.SetCommand(moveLeft);
                invoker.ExecuteCommand();
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame(null);
            }
        }
    }
//}
