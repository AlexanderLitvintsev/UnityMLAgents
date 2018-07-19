using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 1;

	public void Damage(int damageCount)
	{
		hp -= damageCount;

		if (hp <= 0) 
		{
            // Particle effect
            SpecialEffectScript.Instance.Explosion(transform.position);

            // Sound of the explosion
            SoundEffectScript.Instance.MakeExplosionSound();

            // Death
            Destroy(gameObject);
		}
	}
}