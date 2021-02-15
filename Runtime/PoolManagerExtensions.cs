/*
 *	Copyright (c) 2021, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using PathologicalGames;
using UnityEngine;

namespace Andtech {

	public static class PoolManagerExtensions {

		public static T Spawn<T>(this SpawnPool spawnPool, T prefab) where T : MonoBehaviour {
			return spawnPool.Spawn(prefab.gameObject).GetComponent<PoolManaged<T>>().Target;
		}
	}
}
