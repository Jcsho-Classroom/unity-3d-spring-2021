using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = Color.white;
        if (Vector3.Distance(transform.position, player.position) < detectionDistance)
        {
            c = Color.red;
        }
        Debug.DrawLine(transform.position, player.position, c);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, player.position);
    }

    private void OnTriggerStay(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Vector3 playerPosition = player.gameObject.transform.position;

            // andrew - go closer to player, shoot once its close enough (player should die when it takes enough hits)
            // jason - attack the player, rotate towards the player
            // william - turn towards the player, start shooting
        }
    }
}
