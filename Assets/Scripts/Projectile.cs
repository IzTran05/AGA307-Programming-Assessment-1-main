using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 1000f;
    public Transform firingPoint;

    /*void //Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject projectileInstance;
            projectileInstance = Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
            projectileInstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed);
            Destroy(projectileInstance, 5);
        }



    }
  */
   private void OnCollisionEnter(Collision collision)
    {
        //check to see if the collided objexct has the tag "Target"
        if (collision.collider.CompareTag("Target"))
        {
            //change the collided objects material colour to red
            collision.collider.GetComponent<Renderer>().material.color = Color.red;
            //destroy the collided object after one second
            Destroy(collision.collider.gameObject, 1f);
            //Dstroy this gameObject
            Destroy(this.gameObject);
        }

    }
  
}
