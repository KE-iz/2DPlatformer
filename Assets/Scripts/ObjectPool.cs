using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    public GameObject bulletPrefab;
    public int bulletLimit = 30;

    List<GameObject> bullets;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        bullets = new List<GameObject>();

        for (int i = 0; i < bulletLimit; i++)
        {
            GameObject go = Instantiate(bulletPrefab, transform);
            go.SetActive(false);
        }
    }


    public GameObject GetBullet()
    {
        foreach (GameObject go in bullets)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                return go;
            }
        }

        GameObject obj = Instantiate(bulletPrefab, transform);
        bullets.Add(obj);
        return obj;
    }
    // return null; 일정 갯수가 넘어서 렉 때문에 만들지 않는게 좋다 -> null (총알이 더 이상 없구나)
}