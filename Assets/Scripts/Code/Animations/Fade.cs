using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FadeTransition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FadeTransition() {
        GetComponent<MeshRenderer>().material.DOFade(0.0f, 3f);
    }
}
