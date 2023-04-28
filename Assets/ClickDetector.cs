using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(ray.origin, ray.origin + ray.direction * 1000, Color.red, 10);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            try
            {
                var target = hit.collider.gameObject.GetComponent<ClickAbleInterface>();
                target.OnHover();
                if (Input.GetMouseButtonDown(0))
                {
                    target.OnClick();
                }
            }
            catch
            {
               
            }

        }
    }
}
