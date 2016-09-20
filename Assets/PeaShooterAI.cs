using UnityEngine;
using System.Collections;

public class PeaShooterAI : MonoBehaviour
{
    [Tooltip("The Game Object that holds the transform value for the starting position of the attack projectiles.")]
    public GameObject FireLocation;
    public GameObject Projectile;
    private Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        if (animator == null)
            this.animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Shoot");

        if (Projectile != null && FireLocation != null)
        {
            Instantiate(Projectile, FireLocation.transform.position, Projectile.transform.rotation);
        }
    }
}
