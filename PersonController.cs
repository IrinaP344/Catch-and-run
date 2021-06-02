using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonController : MonoBehaviour
{
	Transform girl_transform;
	static int hp = 100;
	static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        girl_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
        	girl_transform.Translate(0,0,2f);
        }
        
        if(Input.GetKeyDown("s"))
        {
        	girl_transform.Translate(0,0,-2f);
        }
        
        if(Input.GetKeyDown("d"))
        {
        	girl_transform.Translate(-2f,0,0);
        }

        if(Input.GetKeyDown("a"))
        {
        	girl_transform.Translate(2f,0,0);
        }
    }

    void OnCollisionEnter(Collision collision_object)
    {
    	if(collision_object.gameObject.tag =="Enemy")
    	{
    		hp = hp - 20;
    		print("Life:" + hp);  
    		if(hp == 0)
    		{
    			SceneManager.LoadScene("scene4");
    		}
    	}

    	if(collision_object.gameObject.tag =="Friend")
    	{
    		score = score + 1;
    		print("Очки:" + score);  
    		if(score == 3)
    		{
    			SceneManager.LoadScene("scene5");
    		}
    	}
	}
}
