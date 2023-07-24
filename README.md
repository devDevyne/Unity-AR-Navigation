# Unity-AR-Navigation
Unity AR Navigation. (Unity 2019.4.40f1 and Mapbox SDK for Unity)


## 세팅 전 Mapbox 계정 생성 후 Token Key 발급 받기
[Mapbox 홈페이지](https://www.mapbox.com) 

위에 링크에 접속해 Mapbox 계정이 없다면 회원가입을 하고 로그인을 해준다. 

로그인 후 Account에 들어가 토큰을 생성해 주면 된다. 
![스크린샷 2023-07-24 093224](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/febe9a79-2298-4991-aa57-7fa3b49ef250)

token을 생성하게 되면 token key가 발급될 것이다.
여기서 secret token으로 발급 받게 되면 발급 이후 한 번밖에 key를 볼 수 있기에 
따로 저장해 둔다. 


## Unity 2019.4.40f 세팅
Unity에서 Mapbox SDK가 2017버전과 2018버전 외에는 호환이 안된다! 
하지만 약간의 세팅을 통해 2019버전에서도 Mapbox SDk를 사용할 수 있다. 


### 우선 새 프로젝트 생성 후 Mapbox SDK 임포트 해준다. 
[Mapbox SDK for Unity](https://www.mapbox.com/install/unity)

위 링크에서 Mapbox SDK를 다운로드 받는다. 

![Untitled](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/c8a30071-19f8-4508-944a-3aa7b74b9ede)

다운로드 SDK 파일을 임포트 해준다. 

임포트가 끝이 나면 아래와 같이 콘솔창에 error가 뜰 것이다. 

![Untitled (1)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/b03179fd-d0c8-4cbf-9f1f-af0d2c980a65)


### Multiplayer HLAPI, XR Legacy Input Helpers Install 

Package Manager에서 Multiplayer HLAPI(버전 상관 없음, 아마도 1.0.8)이랑 
XR Legacy Input Helpers(마찬가지로 버전 상관 X, 2.1.10) 둘다 설치를 해준다. 

![Untitled (3)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/4e2cff71-1b61-4864-a55f-a26e638f5388)


![Untitled (2)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/7667b976-9ac6-4e5f-b47c-1b27feb42325)

설치가 끝난 후 콘솔창을 확인해보면 아까도 같은 error가 사라져있을 것이다. 


## 안드로이드 플랫폼으로 변경. 

### Mapbox SDK 인증  
프로젝트를 안드로이드로 변경하기 전에 
발급받았던 Token Key를 통해 Mapbox SDK를 인증받아야 한다. 

Mapbox SDK가 설치되고 나면 상단 메뉴에 Mapbox탭이 있을 것이다. 
Mapbox - Setup 을 누르게 되면 Token key를 submit할 수 있는 창이 뜰 것이다. 

![Untitled (4)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/591becc7-8040-4864-aa58-035ff743a410)

발급받았던 Token Key를 submit 하고 
우리는 Mapbox SDK를 통해 AR Navigation을 구현할 예정이기에
아래 Map Prefabs에서 WorldScaleAR을 눌러준다. 


### 안드로이드 프로젝트 세팅


플랫폼을 안드로이드으로 변경 후 Player setting에서 Other setting(기타 설정)에서 
우선 Graphics APIs에서 Vulkan을 제거해준다. (ARCore에서 Vulkan을 지원안함)

![Untitled (5)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/c4ebc7a4-e270-41bf-9722-9191ea3ea757)

다중 스레드 렌더링 해제. 

최소, 타겟 API 수준 설정
AR 같은 경우 API level 24? 부터 가능하기에 최소 API 버전을 Android 7.0(API 24)으로 설정. 
타켓 API는 API level 30이상으로 할 경우 AR이 제대로 안되는 이상한(외않되?) 오류가 있어
Android 10.0(APL level 29)을 타켓 API으로 설정한다. 

![Untitled (6)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/f39653f1-8363-4761-b674-71b7f19d27cd)

그리고 XR 설정에서 ARCore 지원됨을 체크해준다. 

![Untitled (7)](https://github.com/devDevyne/Unity-AR-Navigation/assets/55376183/22843884-a2ac-4bbd-938d-5db99db00cab)



# WorldScaleAR 

