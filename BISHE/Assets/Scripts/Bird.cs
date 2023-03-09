using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Transform[] waypoints;
    public int index = 1;
    public float speed;
    public Transform target;
    private Animator birdAnim;

    public bool isAttracted = false;
    public Vector3 foodPosition;

    private void Start()
    {
        target = waypoints[index];
        birdAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if(isAttracted == false)
        {
            transform.Translate(Vector3.Normalize(target.position - transform.position) * speed * Time.deltaTime, Space.World);
            transform.LookAt(target);

            if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            {
                if (index == 1)
                {
                    target = waypoints[0];
                    index = 0;
                }
                else
                {
                    target = waypoints[1];
                    index = 1;
                }
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
