using UnityEngine;
using System.Collections;

public class SpecialEffectScript : MonoBehaviour {

	public static SpecialEffectScript Instance;
	public ParticleSystem smokeEffect;
	public ParticleSystem fireEffect;

	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of the SpecialEffectScript script.");
		}

		Instance = this;
	}

	public void Explosion(Vector3 position)
	{
		// Smoke Effect
		InstantiateParticleSystem (smokeEffect, position);

		// Fire Effect
		InstantiateParticleSystem (fireEffect, position);
	}

	private ParticleSystem InstantiateParticleSystem(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate (
			prefab,
			position,
			Quaternion.identity) as ParticleSystem;

		Destroy (newParticleSystem.gameObject, newParticleSystem.startLifetime);

		return GetComponent<ParticleSystem>();
	}
}
