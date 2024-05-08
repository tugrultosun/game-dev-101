using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    private BulletPool bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        bulletPool = new BulletPool(bulletPrefab);
    }



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet=bulletPool.Get();
            bullet.transform.position = transform.position + Vector3.forward;
        }
    }


}
