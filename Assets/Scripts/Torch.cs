using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{

     [SerializeField] GameObject _torche;
     [SerializeField] GameObject _torchePlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _torche.active = false;
            _torchePlayer.active=true;
        }
    }
}
