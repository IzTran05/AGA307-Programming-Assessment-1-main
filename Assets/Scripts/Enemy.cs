using System.Collections;
using UnityEngine;

public class Enemy : GameBehaviour
{
    [SerializeField]
    private EnemySize enemySize;
    float moveDistance = 5000;


    [Header("Stats")]
    private int mySpeed;
    private int myHealth;

    [Header("Score")]
    public int myScore;

    public void Initialize(Transform _startPos, string _name)
    {
        switch(enemySize)
        {
            case EnemySize.King:
                mySpeed = 5;
                myHealth = 5;
                myScore = 200;
                gameObject.GetComponent<Transform>().localScale += new Vector3(4f, 4f, 4f);
                break;
            case EnemySize.Knight:
                mySpeed = 5;
                myHealth = 2;
                myScore = 100;
                gameObject.GetComponent<Transform>().localScale += new Vector3(2f, 2f, 2f);
                break;
            case EnemySize.Baby:
                mySpeed = 5;
                myHealth = 1;
                myScore = 50;
                break;
        }
        print("Move");
        StartCoroutine(Move());
    }
    IEnumerator Move()
    {
        print("Moving");
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * mySpeed * Time.deltaTime);
            yield return null;
        }

        transform.Rotate(Vector3.up * 180);
        yield return new WaitForSeconds(3);
        StartCoroutine(Move());
    }

    public void Death()
    {
        _EM.RemoveEnemy(this.gameObject);
        
    }

}
