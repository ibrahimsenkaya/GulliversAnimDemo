using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnim : MonoBehaviour
{
    [SerializeField] ParticleSystem Chargepart;
    [SerializeField] ParticleSystem Boom1,Boom2,Boom3,Flies;
    [SerializeField] GameObject Skin1, Skin2;
    [SerializeField] Sprite sp;
    [SerializeField] GameObject Glow;


 

    public void ChargeIt()
    {
        Instantiate(Glow, new Vector3(0,.2f,-1f), Quaternion.identity);
        Chargepart.Play();
      
    }
    public void Boom()
    {
        Boom1.Play();
        Boom2.Play();
        Boom3.Play();
        Flies.Play();

    }
    public void ShowSkin()
    {
        Skin1.GetComponent<SpriteRenderer>().sprite = sp;

        Skin2.GetComponent<SpriteRenderer>().sprite = sp;
    }
}
