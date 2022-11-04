using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.R)
      {
         GetComponent<Renderers>().material.color = Color.red;
      }
      if (Input.GetKeyDown(KeyCode.G))
      {
         GetComoponent<Renderers>().material.color = Color.green;
      }
      if (Input.GetKeyDown(KeyCode.B))
      {
         GetComponent<Renderers>().material.color = Color.blue;
      }   
}


