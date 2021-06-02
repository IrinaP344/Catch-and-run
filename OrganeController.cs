using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganeController : MonoBehaviour
{
	Transform organs_tr;
	float x;
	float z;
    // Start is called before the first frame update
    void Start()
    {
        organs_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision obj)
    {
    	if(obj.gameObject.tag == "Ground")
    	{
    		x = Random.Range(13f, 21f);
    		z = Random.Range(3.3f, -3f);
    		Instantiate(gameObject, new Vector3(x,10f,z), organs_tr.rotation);
    		Destroy(gameObject);
    	}
    }
}
