using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int score = 0;

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Stage")
            return;
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log($"Score = {score}");
        }
    }
}
