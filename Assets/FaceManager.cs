using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour
{
    public List<GameObject> leftHair;
    public List<GameObject> rightHair;
    public List<GameObject> leftEye;
    public List<GameObject> rightEye;
    public List<GameObject> nose;
    public List<GameObject> mouth;
    public List<GameObject> head;
    // Start is called before the first frame update
    void Start()
    {
        selectDefault(leftHair);
        selectDefault(rightHair);
        selectDefault(leftEye);
        selectDefault(rightEye);
        selectDefault(nose);
        selectDefault(mouth);
        selectDefault(head);
    }

    void selectIthElement(int index, List<GameObject> gameObjects)
    {
        if (gameObjects == default || gameObjects.Count < (index + 1))
        {
            return;
        }

        for (int i = 0; i < index; ++i)
        {
            gameObjects[i].SetActive(false);
        }

        gameObjects[index].SetActive(true);

        for (int i = index + 1; i < gameObjects.Count; ++i)
        {
            gameObjects[i].SetActive(false);
        }
    }

    void selectDefault(List<GameObject> gameObjects)
    {
        selectIthElement(0, gameObjects);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
