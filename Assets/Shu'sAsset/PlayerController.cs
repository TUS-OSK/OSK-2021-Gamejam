using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : SuperPlayer
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }

        if (mobData.hp <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        SuperEnemy enemy = collision.gameObject.GetComponent<SuperEnemy>();
        if (enemy != null)
        {
            //this.Touch(enemy);
            Debug.Log("test");
        }

        SuperItem item = collision.gameObject.GetComponent<SuperItem>();
        if (item != null)
        {
            this.Touch(item);
        }

    }

}
