using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portes : MonoBehaviour
{

    [SerializeField] GameObject _porteDroite;
    [SerializeField] GameObject _porteGauche;


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
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre",true);
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre",true);
        }
        

    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre",false);
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre",false);
        }
    }
}
