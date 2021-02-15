using System;

namespace Andtech {

	/// <summary>
	/// Indicates that the type can be pooled.
	/// </summary>
	public interface IPoolable {

		event EventHandler RequestedReclaim;
	}
}
