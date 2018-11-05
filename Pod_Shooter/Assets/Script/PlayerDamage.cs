using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour, Damagable {
    PlayerLife playerLife;

    public void DealDamage(int Damage)
    {
        playerLife.TakeDamage(Damage);
    }

    void Start () {
        playerLife = GetComponent<PlayerLife>();
	}
	
	void Update () {
		
	}
}
