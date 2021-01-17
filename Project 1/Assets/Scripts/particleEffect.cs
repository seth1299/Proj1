using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleEffect : MonoBehaviour
{
    public GameObject effect;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject newEffect;
        if (effect != null)
        {
            ParticleSystem system;
            Vector3 offset = new Vector3(0,0,-2);
            newEffect = Instantiate(effect, transform.position + offset, transform.rotation);
            newEffect.SetActive(true);
            
            if((system = newEffect.GetComponent<ParticleSystem>()) != null)
            {
                system.Play();
            }
        }

        //Destroy(effect);
    }


    /*
    public Transform collectFX;
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        collectFX.GetComponent<ParticleSystem>().enableEmission = false;
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var emission = ps.emission;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Triggering particle effect...");
        collectFX.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopFX());
    }

    IEnumerator stopFX()
    {
        Debug.Log("Stopping particle effect...");
        yield return new WaitForSeconds (0.4f);
        collectFX.GetComponent<ParticleSystem>().enableEmission = false;
    }
    */

}
