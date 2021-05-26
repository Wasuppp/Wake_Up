using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtesterot : MonoBehaviour
{
    [SerializeField] GameObject Player;

    bool roda = false;
    float Tempo = 0f;

    private void Start()
    {
        roda = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint2"))
        {
            roda = true;
        }
    }

    private void FixedUpdate()
    {
        if (roda == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > 1f)
            {
                Player.transform.Rotate(0, -90, 0);
                Debug.Log("Roda");
                roda = false;
            }
        }
    }
}
