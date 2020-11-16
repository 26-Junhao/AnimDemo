using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 10f;
    float deathcount = 0f;
    public Animator playerAnim;
    bool death = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (death == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                playerAnim.SetBool("isMove", true);
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                playerAnim.SetBool("isMove", false);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.rotation = Quaternion.Euler(0, 180, 0);
                playerAnim.SetBool("isMove", true);
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                playerAnim.SetBool("isMove", false);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.rotation = Quaternion.Euler(0, -90, 0);
                playerAnim.SetBool("isMove", true);
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                playerAnim.SetBool("isMove", false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.rotation = Quaternion.Euler(0, 90, 0);
                playerAnim.SetBool("isMove", true);
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                playerAnim.SetBool("isMove", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            deathcount++;
        }
        if(deathcount == 9)
        {
            playerAnim.SetTrigger("trigdeath");
            death = true;
        }
    }
}
