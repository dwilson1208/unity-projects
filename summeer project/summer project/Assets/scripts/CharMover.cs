using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMover : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    private EnemyFollow enemy;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        enemy = FindObjectOfType<EnemyFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        controller.Move(new Vector3(x, 0, z) * moveSpeed * Time.deltaTime);
    }
}
