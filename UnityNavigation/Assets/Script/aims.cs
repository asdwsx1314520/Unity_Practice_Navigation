using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aims : MonoBehaviour
{
    private float bottom_right = 4.0f;
    private float bottom_lift = -14.7f;

    private float bottom_up = 4.0f;
    private float bottom_down = -14.7f;

    void Awake()
    {
        changPosition();
    }

    /// <summary>
    /// 隨機位置
    /// </summary>
    public void changPosition()
    {
        float pos_X = Random.Range(bottom_lift, bottom_right);
        float pos_Z = Random.Range(bottom_down, bottom_up);

        transform.position = new Vector3(pos_X, transform.position.y, pos_Z);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            changPosition();
        }
    }
}
