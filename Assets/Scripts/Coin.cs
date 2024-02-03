using System;
using UnityEngine;

public class Coin : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Bag bag))
        {
            bag.AddCoin();
            Destroy(gameObject);
        }
    }
}
