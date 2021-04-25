using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public Transform shooter;
    public float detectionDistance = 5;
    public ObjectPool bulletPool;
    public IShootable gun;

    private const float BULLET_DELAY = 1f;
    private float targetTime = BULLET_DELAY;

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

            transform.LookAt(playerPosition);

            // timer
            targetTime -= Time.deltaTime;

            if (targetTime <= 0) {
                gun.shoot();
                targetTime = BULLET_DELAY;
            }

            // andrew - go closer to player, shoot once its close enough (player should die when it takes enough hits)
            // jason - heatlh system
            // william - turn towards the player, start shooting
        }
    }
}
