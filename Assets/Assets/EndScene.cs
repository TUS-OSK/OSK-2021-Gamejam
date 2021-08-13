using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScene : SuperPlayer
{
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        result.text = "Score: " + playerData.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
