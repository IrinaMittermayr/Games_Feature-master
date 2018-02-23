using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterfall : MonoBehaviour {
    public float scrollSpeed = 0.8f;
	void Update () {
        float offset = Time.time * scrollSpeed;
        GetComponent<Renderer>().materials[1].SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
