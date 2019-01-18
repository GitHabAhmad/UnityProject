using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canspawn : MonoBehaviour
{
    
    public Transform[] Children;
 
    public void Canspawn()
    {
        Children[Children.Length - 1] = gameObject.transform;
        for (int i = 0; i < Children.Length; i++)
        {
          
            Children[i] = transform.GetChild(i).transform;
        }
      
    }
    void Start()
    {
        Children = new Transform[transform.childCount+1];
        Canspawn();
    }
    public void ReternTransform()
    {
        gameObject.transform.position = Children[Children.Length - 1].position;
        gameObject.transform.rotation = Children[Children.Length - 1].rotation;
        for (int i = 0; i < Children.Length; i++)
        {
            transform.GetChild(i).transform.position = Children[i].position;
            transform.GetChild(i).transform.rotation = Children[i].rotation;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ReternTransform();
        }
    }
}
