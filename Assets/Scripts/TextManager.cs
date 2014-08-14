using UnityEngine;
using System.Collections;

public class TextManager : MonoBehaviour {
	private Manager manager;

	// Use this for initialization
	void Start () {
		manager = Manager.GetInstance ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (manager.GetCnt ()) {
		case 1:
			guiText.text = ".....용사여.....";
			break;
			
		case 2:
			guiText.text = "(음? 뭐지??)";
			break;
			
		case 3:
			guiText.text = "깨어나세요, 용사여...";
			break;
			
		case 4:
			guiText.text = "(?????)";
			break;
			
		case 5:
			guiText.text = "간나새끼래!\r\n날래날래 일어나라우!";
			break;
			
		case 6:
			guiText.text = "!!!!!!";
			break;
			
		case 7:
			guiText.text = "이야~ 기다리게 했다!";
			break;

		case 8:
			guiText.text = "내 이름은 지박사";
			break;
			
		case 9:
		//	drawer = new IntroDrawer(context, BitmapFactory.decodeResource(getResources(), R.drawable.egg));
		//	setContentView(drawer);
			
			guiText.text = "이 이상한 알을\r\n발견한 사람이지";
			break;
			
		case 10:
			guiText.text = "이 알 속에는 너의 휴대폰의\r\n영혼이 들어 있다";
			break;
			
		case 11:
			guiText.text = "그리고 사랑, 꿈, 희망...\r\n이 또한 함께 들어 있지";
			break;
			
		case 12:
			guiText.text = "하지만 나는 너무 타락해서\r\n이 알을 키울 수가 없어";
			break;
			
		case 13:
			guiText.text = "그래서... 자네가 이 알을\r\n맡아 주었으면 하는데";
			break;
			
		case 14:
			guiText.text = "이 알, 맡아 주겠나?";
			break;

			/*
		case 15:
			AlertDialog.Builder builder = new AlertDialog.Builder(context);
			builder.setMessage("알을 맡겠습니까?").setPositiveButton("Yes", dialogClickListener)
				.setNegativeButton("No", dialogClickListener).show();
			
			break;
			
			// Select Yes
		case 21:
			guiText.text("오오! 고맙네.\r\n자네라면 맡아줄 줄 알았지.");
			break;
			
		case 22:
			guiText.text("그럼 부탁하겠네.");
			break;
			
		case 23:
			guiText.text("이 알, 잘 키워주게나...");
			break;
			
		case 24:
			guiText.text("후하하하하하하하...");
			break;
			
			// Select No
		case 31:
			guiText.text("음? 미안하네.\r\n내가 가는귀가 먹어서...");
			break;
			
		case 32:
			guiText.text("방금 뭐라고 했는지\r\n다시 말해주지 않겠나?");
			progress = 14;
			break;
			
			// Select No 5 times
		case 41:
			guiText.text("그래... 그런가...");
			break;
			
		case 42:
			guiText.text("그렇다면 자네는\r\n더 이상 쓸모가 없겠군");
			break;
			
		case 43:
			guiText.text("");
			break;
			
		case 44:
			System.exit(1);
			*/
		}
	}
}
