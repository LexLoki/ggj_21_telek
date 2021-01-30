using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 [ExecuteInEditMode]
 public class ParaBackground : MonoBehaviour
 {
   public ParaCamera paraCamera;
   List<ParaLayer> paraLayers = new List<ParaLayer>();
  
   void Start()
   {
       if (paraCamera == null)
         paraCamera = Camera.main.GetComponent<ParaCamera>();
       if (paraCamera != null)
         paraCamera.onCameraTranslate += Move;
       SetLayers();
   }
  
   void SetLayers()
   {
       paraLayers.Clear();
       for (int i = 0; i < transform.childCount; i++)
       {
           ParaLayer layer = transform.GetChild(i).GetComponent<ParaLayer>();
  
           if (layer != null)
           {
               layer.name = "Layer-" + i;
               paraLayers.Add(layer);
           }
       }
     }
     void Move(float delta)
     {
         foreach (ParaLayer layer in paraLayers)
       {
           layer.Move(delta);
       }
   }
 }