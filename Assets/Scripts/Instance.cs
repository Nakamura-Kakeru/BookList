using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instance : MonoBehaviour
{
    public GameObject objprefab;
    public GameObject parent;

    public GameObject inputprefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectInstance()
    {



        var obj = Instantiate(objprefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity, parent.transform);

        GetObject objtext = obj.GetComponent<GetObject>();
        GetInput input = inputprefab.GetComponent<GetInput>();

        objtext.Gettext.text = input.GetName.text;

        //text.text = inputField.text;
    }
}
