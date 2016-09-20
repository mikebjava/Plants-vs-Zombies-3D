using UnityEngine;
using System.Collections;

public class ProjectileAI : MonoBehaviour
{
    [Tooltip("The life time of the projectile, in seconds.")]
    public int LifeTime = 5;
    public float Speed = 0.5f;
    [Tooltip("Direction that the projectile travels. (Default Left -> Right)")]
    public Vector3 Direction = new Vector3(0f, 0f, 1f);

    private float CreationTime;

    void Start()
    {
        CreationTime = Time.time;
    }

    void FixedUpdate()
    {
        if (CreationTime + LifeTime <= Time.time)
        {
            GameObject.Destroy(this.gameObject);
            return;
        }

        transform.position += Direction * Speed;
    }
}
