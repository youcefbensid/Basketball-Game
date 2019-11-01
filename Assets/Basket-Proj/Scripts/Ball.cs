using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trailParticle;
    // Start is called before the first frame update
    void Start()
    {
        trailParticle.SetActive(false);
        
    }

    public void ActivateTrail()
    {
        trailParticle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Goal")
        {
            ActivateTrail();
            GameObject.FindGameObjectsWithTag("arm")[0].GetComponent<Animator>().SetBool("GoDance", true);
            GameObject.FindGameObjectsWithTag("arm")[1].GetComponent<Animator>().SetBool("GoDance", true);
            GameObject.FindGameObjectsWithTag("arm2")[0].GetComponent<Animator>().SetBool("GoDance", true);
            GameObject.FindGameObjectsWithTag("arm2")[1].GetComponent<Animator>().SetBool("GoDance", true);

        }
    }
}
