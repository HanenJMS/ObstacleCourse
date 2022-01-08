using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RevolvingObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.down * Time.deltaTime * speed);
    }
}
