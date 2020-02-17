using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimController : MonoBehaviour
{
    ParticleSystem part;
    [SerializeField] Sprite sp;
    void Awake()
    {
        part = GetComponent<ParticleSystem>();
    }


    public void CardPartAnim()
    {
        part.Play();
        for (int i = 0; i < 2; i++)
        {
            transform.GetChild(i).transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = sp;
        }
      
    }

}
