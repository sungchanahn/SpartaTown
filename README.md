# SpartaTown

## 📖 목차   
1. [프로젝트 소개](#프로젝트-소개)
2. [주요기능](#주요기능)
3. [개발기간](#개발기간)
4. [기술스택](#기술스택)
5. [프로젝트 파일 구조](#프로젝트-파일-구조)
6. [Trouble Shooting](#trouble-shooting)

---

## 프로젝트 소개   
내일배움캠프 학습 공간인 ZEP을 모방하여 탑다운2D 게임을 제작하는 개인 프로젝트입니다.   

---

## 주요기능   
- 기능 1. 캐릭터 이동 및 카메라 따라가기   
Assets - Scripts - Entities에 있는 스크립트를 이용해 아래의 기능을 구현했습니다.
	- 캐릭터 마우스 방향 바라보기 (좌, 우)
	- 플레이어 이동(상 W, 하 S, 좌 A, 우 D)
	- 애니메이션 적용
	- 카메라 따라가기

- 기능 2. 캐릭터 선택 및 이름 설정 (StartScene)   
이름을 설정하지 않고 Join을 누르거나 이름이 2~10글자가 아니면 안내문구가 3초 동안 강조(빨간 글씨)됩니다.   
(Script - Utils - AlertNameSetting.cs, Script - Utils - Button - SetPlayerName.cs, JoinButton.cs)   
캐릭터는 펭귄 Penguin, 우주 비행사 Astronaut 중 하나를 선택할 수 있습니다. 선택한 캐릭터 이미지가 바로 반영됩니다.   
(Script - Utils - Button - SelectCharacterButton.cs)   
![StartScene](https://github.com/user-attachments/assets/e85b42ef-a4b1-4e67-a06c-817c1f2b1b24)   
![StartScene2](https://github.com/user-attachments/assets/852f20fc-5586-4b8e-a3b2-fb95d4452802)   
![SelectCharacter](https://github.com/user-attachments/assets/f75583e1-b515-4295-8ddc-5aa9bfefcad5)   
![SelectedCharacter](https://github.com/user-attachments/assets/c05a3445-f59e-4eb6-82cf-0ea0f29674ea)   

- 기능 3. 인게임(MainScene) Menu 기능   
MainScene에서는 이름 변경, 캐릭터 변경, 참여자 목록 UI를 관리하는 Menu가 있습니다.
![Ingame](https://github.com/user-attachments/assets/1bae9197-0ef9-4b88-bcb5-e019361989ef)   
![Menu](https://github.com/user-attachments/assets/7bb8c92c-1006-4c91-a1fb-9df2010ae2d4)   
	- 이름 변경   
인게임에서 이름을 변경할 수 있습니다. 이때 캐릭터 이동은 멈춥니다.
![ChangeNameAlert](https://github.com/user-attachments/assets/73f2c932-e66c-4daa-a043-2bbf2f9fce81)   
![ChangeName](https://github.com/user-attachments/assets/a0b1eba5-ea8d-466f-84d4-bf426fc2f8b4)   

	- 캐릭터 변경   
인게임에서 캐릭터를 변경할 수 있습니다.
![IngameChangeCharacter](https://github.com/user-attachments/assets/56dfc869-c9ed-491a-85b6-5f22f1bc60e8)   
![Character](https://github.com/user-attachments/assets/48bc53e1-0225-4824-9fe9-27ffd1cab564)
![ChangeNameCharacter](https://github.com/user-attachments/assets/f67f2c6a-e6b7-4116-89cb-544d2fb2c579)   
이름 변경 및 캐릭터 변경이 반영된 모습
   - 참여자 목록   
NPC와 Player의 목록이 표시됩니다. 이름을 변경하면 참여자 목록에도 바로 반영됩니다.   

- 기능 4. NPC 대화
NPC(튜터)와 특정 거리에 가까워지면 상호작용 UI가 활성화됩니다.   
NPC에 Circle Collider 2D를 isTrigger로 부여하여 Player Collider가 닿았을 때, 나갔을 때를 판단합니다.(Scripts - Utils - NPCInteraction.cs)   
![NPCInteraction](https://github.com/user-attachments/assets/56d40ae3-c51e-4781-848e-8455256c103c)

---

## 개발기간   
- 2024.10.10(목) ~ 2024.10.14(월)

---

## 기술스택   
- 유니티 2022.3.17f LTS
- Microsoft Visual Studio 2022

---

## 프로젝트 파일 구조   
Assets   
- Animations   
	캐릭터 애니메이션 idle, walk   
- AssetPackageLibrary   
	유니티 에셋 스토어에서 받은 무료 에셋을 모아둔 파일   
- Fonts   
	[둥근모꼴+ Fixedsys](#https://cactus.tistory.com/193)   
- Images   
	캐릭터 이미지 (idle, walk) - 펭귄 Penguin, 우주 비행사 Astronaut   
- Input   
	Top Down Controller 2D - Input Action Asset   
- Prefabs   
	캐릭터 프리팹 - 펭귄 Penguin, 우주 비행사 Astronaut   
- Scene   
	- StartScene   
	- MainScene   
- Scripts   
	- Entities   
		- Behaviors   
		AimRotation.cs   
		LookingLeftCharacterAimRotation.cs : 왼쪽을 보고있는 캐릭터의 좌우 전환   
		LookingRightCharacterAimRotation.cs : 오른쪽을 보고 있는 캐릭터의 좌우 전환   
		TopDownMovement.cs : 캐릭터 이동   
		- Controllers   
		AnimationController.cs : idle - walk 상태 애니메이션 관리   
		MainCameraController.cs : 캐릭터를 따라 움직이도록 카메라 관리   
		PlayerInputController.cs : input 전처리   
		TopDownController.cs   
	- Manager   
		GameManager.cs : 캐릭터 생성, 시간 표시   
		ParticipantManager.cs : 참여자 목록 관리   
		StartManager.cs : 게임 시작 시 저장된 데이터 (PlayerPrefs) 확인 후 캐릭터 이미지 로드   
		UIManager.cs : UI 활성화/비활성화 관리   
	- Utils   
		AlertNameSetting.cs : 이름 설정 오류 시 안내문구 3초간 강조(빨간 글씨)   
		NPCInteraction.cs : Ontrigger로 플레이어와 상호작용 UI 활성화/비활성화   
		- Button   
		DeletePlayerPrefs.cs : Test를 위한 PlayerPrefs 초기화 버튼   
		HoldInputSystemButton.cs : 게임의 상태 bool IsPlaying을 true, false로 변경. 보통 UI 활성화 시 캐릭터 이동을 막고 싶을 때 호출   
		JoinButton.cs : 이름이 설정되어 있는지 확인 후 StartScene에서 MainScene으로 전환   
		SelectCharacterButton.cs : 캐릭터 선택 및 변경 버튼   
		SetPlayerName.cs	: 이름 설정 및 변경 관리   
- TextMesh Pro   
- TileMap   

---

## Trouble Shooting   
프로젝트를 진행하면서 겪었던 문제들을 블로그에 간단하게 정리했습니다.   
- 1일차에 겪었던 문제들 https://velog.io/@asc98/20241010-TIL
- 2일차에 겪었던 문제들 https://velog.io/@asc98/20241011-TIL
- 3일차에 겪었던 문제들 https://velog.io/@asc98/20241014-TIL
