using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zAxis = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xAxis, 0f, zAxis);
    }
}
