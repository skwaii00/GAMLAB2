using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("dat"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("Egg"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("Farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("basket"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
    }
}