using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AproximarCamera : MonoBehaviour
{
    public string Target;
    

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sphere = GameObject.Find(Target);
        float position = Vector3.Distance(sphere.transform.position, transform.position);
        
        if(position < 1.7)
        {
            transform.position = new Vector3(0, 0, transform.position.z);
            Debug.Log("Mudou");
        }
    }
}
