using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onMouseDown();
    }

    private void onMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("mouse click");
            gameObject.SetActive(false);
        }
    }
}
