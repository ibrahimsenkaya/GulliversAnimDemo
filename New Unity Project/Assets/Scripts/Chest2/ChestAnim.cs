using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnim : MonoBehaviour

{
    [SerializeField] GameObject Card;
    [SerializeField] ParticleSystem part1, part2,part3,part4;
    public void yaz()
    {
      
        Instantiate(Card, Vector3.zero, Quaternion.identity);
        part1.Play();
        part2.Play();
        part3.Play();
        part4.Play();
    }
}
