using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Securitycamera : MonoBehaviour
    
{
    [SerializeField]
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Findangle()<30)
        {
            Debug.Log("detected");
        }
    }
    public double Findangle()
    {
        Vector3 direction = Player.transform.position- transform.position;
        double angle = Vector3.Angle(direction, transform.forward);
        return angle;
    }
}
