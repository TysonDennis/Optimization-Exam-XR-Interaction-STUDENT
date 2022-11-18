using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLifespan : MonoBehaviour
{
    [SerializeField]
    float lifeSpan = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideBall", lifeSpan);
    }

    private void HideBall()
    {
        gameObject.SetActive(false);
    }
}
