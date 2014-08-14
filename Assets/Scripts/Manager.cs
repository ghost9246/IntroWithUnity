using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	private static Manager inst = new Manager();
	private static int cnt = 0;

	private Manager() {}

	public static Manager GetInstance() {
		return inst;
	}

	public int GetCnt() {
		return cnt;
	}

	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			cnt++;
		}
	}
}
