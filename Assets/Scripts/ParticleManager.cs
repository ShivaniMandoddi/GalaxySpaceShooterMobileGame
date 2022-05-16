using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
	#region SINGLETON PATTERN
	public static ParticleManager _instance;

	public static ParticleManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<ParticleManager>();

				if (_instance == null)
				{
					GameObject container = new GameObject("ParticleManager");
					_instance = container.AddComponent<ParticleManager>();
				}
			}

			return _instance;
		}
	}
	#endregion
	public void PlayingEffect(GameObject effect,Vector3 effectPosition)
    {
        Destroy(Instantiate(effect, effectPosition, Quaternion.identity),2f);
    }
}
