using PathologicalGames;
using UnityEngine;

namespace Andtech {

	public static class PoolManagerExtensions {

		public static T Spawn<T>(this SpawnPool spawnPool, T prefab) where T : MonoBehaviour {
			return spawnPool.Spawn(prefab.gameObject).GetComponent<PoolManaged<T>>().Target;
		}
	}
}
