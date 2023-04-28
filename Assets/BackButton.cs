using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour, ClickAbleInterface
{
    public GameObject target;
    public void OnClick()
    {
        if (target == default)
        {

        }
        PanelManager panelManager = gameObject.transform.GetComponentInParent<PanelManager>();
        panelManager.EnablePanel(target);
    }

    public void OnHover()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
