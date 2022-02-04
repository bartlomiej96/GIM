using UnityEngine;
using UnityEditor;
using System.Collections;

public class Pyramid: MonoBehaviour {
  public GameObject prefab; //prefab of building block
  int height; //height or number of layers

  void Start() {
    //Enter the height and basic block's reference
    GameObject new_prefab = null;
    GameObject prev_prefab = null;
    height = 10;
    height--;
    for (int y = 0; y <= height; y++) {
      for (int x = -(height - y); x <= height - y; x++) {
        prev_prefab = null;
        new_prefab = null;
        for (int z = -(height - y); z <=height - y; z++) {
          new_prefab = GameObject.Instantiate(prefab, new Vector3(x * 5.0F, y * 5 + 5, z * 5.0F), Quaternion.identity) as GameObject;
          new_prefab.name = prefab.name;
          if(prev_prefab != null && prefab != null){
          SpringJoint fj = new_prefab.AddComponent<SpringJoint>() as SpringJoint;
          fj.connectedBody = prev_prefab.GetComponent<Rigidbody>(); 
          }
        prev_prefab = new_prefab;
        }
      }
    }
  }
}