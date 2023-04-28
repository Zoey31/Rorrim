using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel
{
    public GameObject gameObject;

    public Panel(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public void Enable()
    {
        gameObject.SetActive(true);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }
}

public class PanelManager : MonoBehaviour
{
    List<Panel> panels;
    void Start()
    {
        panels = new();
        buildFrom(gameObject);
        EnablePanel(0);
    }

    void EnablePanel(int index)
    {
        if (panels == default || panels.Count < (index + 1))
        {
            return;
        }

        for (int i = 0; i < index; ++i)
        {
            panels[i].Disable();
        }

        panels[index].Enable();

        for (int i = index + 1; i < panels.Count; ++i)
        {
            panels[i].Disable();
        }
    }

    public void EnablePanel(GameObject gameObject)
    {
        int index = panels.FindIndex(panel => panel.gameObject == gameObject);

        if (index > -1)
        {
            EnablePanel(index);
        }
    }

    void buildFrom(GameObject gameObject)
    {
        for (int i = 0; i < gameObject.transform.childCount; ++i)
        {
            GameObject child = gameObject.transform.GetChild(i).gameObject;

            if (child.name.EndsWith("Panel"))
            {
                panels.Add(new Panel(child));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
