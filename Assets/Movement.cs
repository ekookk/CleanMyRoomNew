using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speed = 1.5f;
    public Text countText;

    private int count;

    void Start()
    {
        count = 0;
        SetCountText();

    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trash"))
        {
            other.gameObject.SetActive(false);
            count = count + 20;
            SetCountText();

        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }
}
