using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject GoalText;
    // Start is called before the first frame update
    void Start()
    {
        GoalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Player")
		{
            GoalText.SetActive(true);
            Invoke("setFalse", 4);
		}
	}

    void setFalse()
	{
        GoalText.SetActive(false);
	}
}
