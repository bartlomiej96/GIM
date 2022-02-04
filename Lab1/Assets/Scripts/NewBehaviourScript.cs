using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private int count;
    public GameObject textBox; 

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        textBox.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.GetComponent<Text>().text = "Score: " + count;
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHor, 0.0f, moveVer);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

        if (count >= 10) {
            textBox.GetComponent<Text>().text = "Victory! Score: " + count;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Pickup1") {
            other.gameObject.SetActive(false);
            count += 1;
        }
        if (other.gameObject.tag == "Pickup2")
        {
            other.gameObject.SetActive(false);
            count += 2;
        }
    }
}
