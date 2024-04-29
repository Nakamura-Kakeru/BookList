using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetObject : MonoBehaviour
{
    private GameObject textobj;
    static Text text;

    public Text Gettext
    {
        get { return text; }
        set { text = textobj.GetComponent<Text>(); }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        textobj = this.transform.Find("Text (Legacy)").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
