using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = -10;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(transform.forward * enemySpeed * Time.deltaTime);
    }
}
