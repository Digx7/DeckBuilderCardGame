using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    Lands land;

    public void Awake(){
      land = new Lands();
      land.typeOfLand = "I hate this";
    }

    public void Update()
    {
      if (Input.GetKeyDown(KeyCode.L))
      {
        Debug.Log ("The name of the land should be " + land.typeOfLand);
      }
    }
}
