using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInput : MonoBehaviour
{
    static InputField nameinput;
    static InputField detailinput;

    private GameObject name;
    private GameObject detail;


    public InputField GetName
    {        

        get{return nameinput;}

        set{nameinput = name.GetComponentInChildren<InputField>();}
    }
    public InputField GetDetail
    {

        get { return detailinput; }

        set { detailinput = detail.GetComponentInChildren<InputField>(); }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        name = this.transform.Find("Name").gameObject;
        detail = this.transform.Find("Detail").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
