using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmyspawmer : MonoBehaviour
{
    public List<GameObject> mylist = new List<GameObject>();

    
    public void Spawn(GameObject jamil)
    {
       jamil = mylist[Random.Range(0,mylist.Count)];
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
