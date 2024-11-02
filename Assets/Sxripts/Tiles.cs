using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{

    public Magnetism magneticState;
    [SerializeField] EMagneticPolarity tilePolarity;

    void Awake()
    {
        magneticState.updatePolarity(tilePolarity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
