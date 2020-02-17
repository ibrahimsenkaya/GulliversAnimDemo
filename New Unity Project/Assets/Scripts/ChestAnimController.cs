using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimController : MonoBehaviour
{
    ParticleSystem part;
    [SerializeField] GameObject Card;
    void Awake()
    {
        part =transform.GetChild(3).GetComponent<ParticleSystem>();
     
    }

    public void PlayPartAnim()
    {
        part.Play();
        Instantiate(Card, Vector3.zero, Quaternion.identity);
    }
}
