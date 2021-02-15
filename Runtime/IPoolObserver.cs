/*
 *	Copyright (c) 2021, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

namespace Andtech {

	/// <summary>
	/// Receive pool lifecycle callbacks.
	/// </summary>
	public interface IPoolObserver {

		void OnSpawned();

		void OnDespawned();
	}
}
