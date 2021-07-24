using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_test : MonoBehaviour
{
    public Vector3 shotVec3;
    public Item shotitem;
    
    public void shott()
    {
        shotitem.Shot(shotVec3);
    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
