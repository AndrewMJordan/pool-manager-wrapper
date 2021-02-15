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

	/// <summary>
	/// Wrapper for pooling a gameobject.
	/// </summary>
	/// <typeparam name="T">The type of the targetted component.</typeparam>
	public abstract class PoolManaged<T> : MonoBehaviour {
		public T Target {
			get => target;
			set => Target = value;
		}

		[SerializeField]
		private T target = default;

		private SpawnPool pool;

		public void Reclaim() => pool.Despawn(transform);

		#region POOL_MANAGER
		protected virtual void OnSpawned(SpawnPool pool) {
			this.pool = pool;

			if (target is IPoolable poolable) {
				poolable.RequestedReclaim += Poolable_RequestedReclaim;
			}
			(target as IPoolObserver)?.OnSpawned();
		}

		protected virtual void OnDespawned(SpawnPool pool) {
			this.pool = null;

			if (target is IPoolable poolable) {
				poolable.RequestedReclaim -= Poolable_RequestedReclaim;
			}
			(target as IPoolObserver)?.OnDespawned();
		}
		#endregion

		private void Poolable_RequestedReclaim(object sender, System.EventArgs e) => Reclaim();
	}
}
