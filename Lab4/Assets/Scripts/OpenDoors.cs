using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] private Animator door = null;
    
    // Start is called before the first frame update
    void Start()
    {
        //area.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        door.Play("Open");
        
    }

    private void OnTriggerExit(Collider other)
    {
        door.Play("Close");
        
    }
}
