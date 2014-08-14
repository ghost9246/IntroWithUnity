using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {
	private Manager manager;
	private bool fading = false;

	// Use this for initialization
	void Start () {
		manager = Manager.GetInstance ();
	}
	
	// Update is called once per frame
	void Update () {
		if (manager.GetCnt () == 6 && fading == false) {
			fading = true;
			int tickCnt = 0;
			float ticktime = 0.0f;
			Color cr = guiTexture.color;

			while (tickCnt < 10)
			{
				ticktime += Time.deltaTime;
				Debug.Log("delta: " + Time.deltaTime);
				if(ticktime >= 1f) {
					ticktime = 0;
					tickCnt++;
					cr.a -= 12f;
					guiTexture.color = cr;
					transform.position = new Vector3(transform.position.x, transform.position.y, tickCnt+1);
				}
			}

			guiTexture.enabled = false;
		}
	}
}
