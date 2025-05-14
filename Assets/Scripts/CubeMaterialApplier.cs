using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMaterialApplier : MonoBehaviour
{
    public Material cubeMaterial;

    void Start()
    {
        // ���� ������ GameObject�� �������� (�� ������ ���)
        GameObject[] allObjects = SceneManager.GetActiveScene().GetRootGameObjects();

        foreach (GameObject rootObj in allObjects)
        {
            // ���� ������ ������ ��� �ڽı��� �˻�
            foreach (Transform child in rootObj.GetComponentsInChildren<Transform>(true))
            {
                if (child.name.ToLower().Contains("cube") && child.GetComponent<Renderer>())
                {
                    child.GetComponent<Renderer>().material = cubeMaterial;
                }
            }
        }
    }
}

