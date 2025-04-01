using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    /* public GameObject projectilePrefab;
     public float projectileSpeed = 1000f;
     public Transform firingPoint; 



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
     */


    public GameObject projectilePrefab;
    public float projectileSpeed = 1000f;

    private void Update()
    {
         //GetButton =/ Get Key
        if (Input.GetButtonDown("Fire1"))
            FireProjectile();
    }

    private void FireProjectile()
    {
        //Instantiate (Copy) our projectile Prefab
        GameObject projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation);
        //Get the rigidbody of our projectile and add force to it
        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);

    }
}
