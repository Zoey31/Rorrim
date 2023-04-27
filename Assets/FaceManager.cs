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

    KeyValuePair<int, List<GameObject>> getIndexAndList(GameObject target)
    {
        int index = -1;
        List<GameObject> resultList = default;
        
        if (index == -1)
        {
            index = leftHair.FindIndex(gameObject => gameObject == target);
            resultList = leftHair;
        }
        
        if (index == -1)
        {
            index = rightHair.FindIndex(gameObject => gameObject == target);
            resultList = rightHair;
        }
        
        if (index == -1)
        {
            index = leftEye.FindIndex(gameObject => gameObject == target);
            resultList = leftEye;
        }
        
        if (index == -1)
        {
            index = nose.FindIndex(gameObject => gameObject == target);
            resultList = nose;
        }
        
        if (index == -1)
        {
            index = mouth.FindIndex(gameObject => gameObject == target);
            resultList = mouth;
        }
        
        if (index == -1)
        {
            index = head.FindIndex(gameObject => gameObject == target);
            resultList = head;
        }

        return new KeyValuePair<int, List<GameObject>>(index, resultList);
    }

    public bool enable(GameObject enableTarget)
    {
        var result = getIndexAndList(enableTarget);

        Debug.LogWarning(result.Key);

        if (result.Key != -1)
        {
            selectIthElement(result.Key, result.Value);
        }

        return true;
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
