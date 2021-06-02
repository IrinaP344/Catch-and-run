using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
	Transform spider_tr;
	float x;
	float z;
    // Start is called before the first frame update
    void Start()
    {
        spider_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision obj)
    {
    	if(obj.gameObject.tag == "Ground")
    	{
    		x = Random.Range(14f, 22f);
    		z = Random.Range(3.4f, -4f);
    		Instantiate(gameObject, new Vector3(x,10f,z), spider_tr.rotation);
    		Destroy(gameObject);
    	}
    	if(obj.gameObject.tag == "Player")
    	{
    		x = Random.Range(14f, 22f);
    		z = Random.Range(3.4f, -4f);
    		Instantiate(gameObject, new Vector3(x,10f,z), spider_tr.rotation);
    		Destroy(gameObject);
    	}
    }
}
