using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CoverBreak : MonoBehaviour {
    public bool isBreakable;
    private Collider[] _colliders;


    void FixedUpdate()
    {
        _colliders = Physics.OverlapSphere(transform.position, 7f);

        foreach (Collider c in _colliders) {
            
            if (c.GetComponent<CharacterController>() != null && (c.GetComponent<CharacterController>().velocity.y < -10))
            {
                Debug.Log("Hello");
                Break();
            }
        }
    }

    void Break()
    {
        if (isBreakable)
        {
            this.GetComponent<MeshCollider>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
