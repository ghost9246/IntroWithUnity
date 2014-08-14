using UnityEngine;
using System.Collections;

public class TestMethod : MonoBehaviour {
	
	//    public AndroidJavaObject activity;
	
	
	// 시작하면 자바에 있는 메소드를 호출합니다. 기억합시다. "initActivity"!!!!!
	void Start () {
		using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
		{
			using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
			{
				jo.Call("initActivity", "unity to android"); //여기가 젤 중요함! 
			}
		}
	}
	
	//여기는 자바가 호출하는 메소드입니다. 
	public void AndroidLog (string a)
	{
		transform.GetComponent<GUIText>().text = a;
	}
}