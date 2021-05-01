using UnityEngine;

public class Rifle : MonoBehaviour, IShootable
{

  public ObjectPool bulletPool;

  public GameObject shooter;

  void Start()
  {

  }
  
  void Update()
  {

  }

  public void shoot() {
    GameObject bullet = bulletPool.GetPooledObject();
    if (bullet != null)
    {
        bullet.transform.position = shooter.transform.position;
        bullet.transform.rotation = shooter.transform.rotation;
        bullet.SetActive(true);
    }
  }
}