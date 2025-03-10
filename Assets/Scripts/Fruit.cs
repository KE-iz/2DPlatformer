using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float timeAdd = 8;    // 5초에서 8초로 변경

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.Instance.AddTime(timeAdd);
            GetComponent<Animator>().SetTrigger("Eaten");
            Invoke("DestroyThis", 0.3f);
        }
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
