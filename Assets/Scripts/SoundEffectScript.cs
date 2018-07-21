using UnityEngine;
using System.Collections;

public class SoundEffectScript : MonoBehaviour {

	public static SoundEffectScript Instance;
	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;
    public AudioClip buttonClickSound;
    public AudioClip lostGameSound;

    void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of the SoundEffectScript script.");
		}

		Instance = this;
	}

	public void MakeExplosionSound()
	{
		MakeSound (explosionSound);
	}

	public void MakePlayerShotSound()
	{
		MakeSound (playerShotSound);
	}

	public void MakeEnemyShotSound()
	{
		MakeSound (enemyShotSound);
	}

    public void MakeButtonClickSound()
    {
        MakeSound(buttonClickSound);
    }

    public void MakeLostGameSound()
    {
        MakeSound(lostGameSound);
    }

    private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}
