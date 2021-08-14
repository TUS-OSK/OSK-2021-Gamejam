using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_toEND : MonoBehaviour
{
    public SuperPlayer superplayer_SC;


    private void ChangeScene()
    {
        SceneManager.LoadScene("end_test");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // is called once per frame
    void Update()
    {
        if (superplayer_SC.mobData.hp < 0)
        {
            ChangeScene();
        }
    }
}
