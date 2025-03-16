using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 1000f;



    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
    }

    void FireProjectile()

    {
        GameObject projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation);
        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.position * projectileSpeed);
    }
}
