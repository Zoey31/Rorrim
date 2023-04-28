using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAblePart : MonoBehaviour, ClickAbleInterface
{
    public GameObject linkedPart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OnHover()
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
