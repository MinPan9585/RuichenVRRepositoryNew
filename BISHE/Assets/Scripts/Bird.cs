using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Transform[] waypoints;
    public int index = 0;
    public float speed;
    public Transform target;
    private Animator birdAnim;
    private AudioSource birdsfx;

    public bool isAttracted = false;
    public Vector3 foodPosition;

    private void Start()
    {
        target = waypoints[index];
        birdAnim = GetComponent<Animator>();
        birdsfx = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(isAttracted == false)
        {
            transform.Translate(Vector3.Normalize(target.position - transform.position) * speed * Time.deltaTime, Space.World);
            transform.LookAt(target);

            if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            {

                index++;
                if (index == waypoints.Length)
                {
                    index = 0;
                }
                target = waypoints[index];
            }
        }
        else
        {
            Food food = FindObjectOfType<Food>();
            transform.Translate(Vector3.Normalize(food.transform.position - transform.position) * speed * Time.deltaTime, Space.World);
            transform.LookAt(food.transform);

            if (Vector3.Distance(transform.position, food.transform.position) <= 5f)
            {
                StartCoroutine(ChangeAnimation());
            }

            if (Vector3.Distance(transform.position, food.transform.position) <= 0.2f)
            {
                
                Destroy(food.gameObject);
                birdsfx.Play();
                Can.foodAmount = 0;
                isAttracted = false;
            }
        }
    }

    IEnumerator ChangeAnimation()
    {
        birdAnim.SetTrigger("SwitchToHover");
        yield return new WaitForSeconds(2);
        birdAnim.SetTrigger("SwitchToFly");

    }
}
