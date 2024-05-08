using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool: IPool<Bullet>
{
    private Bullet bulletGo;

    private List<Bullet> bullets;

    public BulletPool(Bullet _bulletGo)
    {
        bulletGo = _bulletGo;
    }

    public Bullet Get()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].gameObject.activeInHierarchy)
            {
                return bullets[i];
            }
        }
        var bullet = GameObject.Instantiate(bulletGo) as Bullet;
        bullets.Add(bullet);
        return bullet;
    }

    public void Release(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }
}
