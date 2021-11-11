using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadActive : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> quadsphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change()
    {
        quadsphere[2].SetActive(false);
        quadsphere[0].SetActive(true);
    }
}
