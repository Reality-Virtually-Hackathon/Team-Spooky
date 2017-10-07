using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour {
    public GameObject eyes;
    public int scareMeter;
    public bool isScared;
    public GameObject lastScareObject; //cant be scared by the same thing twice in a row
    public int speed;
    public GameObject patrolPointsParent;
    public GameObject[] points;
    public GameObject patrolTarget;
    public int currentPoint = 0;
    private Quaternion targetRotation;
    public GameObject exit;
    public GameObject scaredIndicator;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        foreach (Transform child in patrolPointsParent.transform)
        {
            if (currentPoint < points.Length)
            {
                points[currentPoint] = child.gameObject;
                currentPoint++;
            }

        }
        patrolTarget = points[0];
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (isScared == false) { Patrol(); }
        else { Patrol(); }
    }


    public void LineOfSightCheck(GameObject currentScaryObject, int scareObjectValue)
    {
        if (lastScareObject != currentScaryObject)
        {
            RaycastHit hit;

            if (Physics.Raycast(eyes.transform.position, (currentScaryObject.transform.position - eyes.transform.position), out hit, 12.0f) && hit.transform.gameObject == currentScaryObject)
            {

                ScareChange(scareObjectValue);
            }
        }
    }

    public void ScareChange(int newScare)
    {
        //later add scare types
        scareMeter -= newScare;
        if (scareMeter <= 0 && isScared == false)
        { isScared = true; scaredIndicator.active = true; patrolTarget = exit; }
    }
    public void Patrol()
    {
        targetRotation = Quaternion.LookRotation(patrolTarget.transform.position - transform.position);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 6 * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, patrolTarget.transform.position, speed * Time.deltaTime);
        if (Vector3.Distance(patrolTarget.transform.position, transform.position) < 5) {
            if (isScared == false) { GotoNextPoint(); } else { Destroy(this.gameObject); }
           
        }
    }
    void GotoNextPoint()
    {
        if (points.Length == 0)
        { return; }
        currentPoint = (currentPoint + 1) % points.Length;
        patrolTarget = points[currentPoint];

    }

}
