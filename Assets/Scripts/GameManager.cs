using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mixing;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        mixing = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
