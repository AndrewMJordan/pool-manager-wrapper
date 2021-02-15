
namespace Andtech {

	/// <summary>
	/// Receive pool lifecycle callbacks.
	/// </summary>
	public interface IPoolObserver {

		void OnSpawned();

		void OnDespawned();
	}
}
