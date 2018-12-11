using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This EventManager can call up to multiple custom events at once when subscribed to.
// Create/Add/Update the delegate, static event, and static method to something meaningful.
// In the class you want to use subscribe methods by adding this: EventManager.testDelegate += MethodIWantToSubscibe;
// Make sure to unsubscribe (most of the time) by adding this: EventManager.testDelegate -= MethodIWantToSubscibe;
// Then to run the events add this to where you want the events subscribed to run at: EventManager.Test();
public class EventManager : MonoBehaviour {
	public delegate void TestDelegate();
	public static event TestDelegate testDelegate;

	public static void Test()
	{
		testDelegate();
	}
}