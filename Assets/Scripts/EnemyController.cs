using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = Color.white;
        if (Vector3.Distance(transform.position, player.position) < detectionRadius)
        {
            c = Color.red;
        }
        Debug.DrawLine(transform.position, player.position, c);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, player.position);
    }
}
