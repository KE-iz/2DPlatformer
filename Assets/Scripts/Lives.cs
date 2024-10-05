using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public List<GameObject> lifeImage;

    public void SetLives(int life)
    {
        foreach (GameObject obj in lifeImage)
        {
            obj.SetActive(false);
        }

        for (int i = 0; i < life; i++)
        {
            lifeImage[i].SetActive(true);
        }
    }
}
