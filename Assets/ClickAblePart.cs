using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAblePart : MonoBehaviour
{
    public GameObject linkedPart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OnClick()
    {
        if (linkedPart != default)
        {
            FaceManager faceManager = linkedPart.GetComponentInParent<FaceManager>();
            faceManager.enable(linkedPart);
        }
        
    }
}
