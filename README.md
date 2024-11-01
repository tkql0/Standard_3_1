# Standard_3
 
입문 주차와 비교해서 입력 받는 방식의 차이와 공통점을 비교해보세요.

    - 입문 주차
        - PlayerInput - Behavior - SendMessages
            // SendMessages는 정해져있는 툴을 사용해 입력값만을 받습니다.
    - 숙련 주차
        - PlayerInput - Behavior - Invoke Unity Event
            // Invoke Unity Event는 InputAction.CallbackContext 를 통해 버튼 처럼언제 값을 받을 것인지 정할 수 있습니다.

CharacterManager와 Player의 역할에 대해 고민해보세요.

    CharacterManager
        - 싱글톤을 통해 플레이어를 어디서든 참조할 수 있게 해주는 송신탑

    Player
        CharacterManager에서 Player를 참조했을 때 Player의 기능을 사용할 수 있도록 연결해주는 중계기

핵심 로직을 분석해보세요 (Move, CameraLook, IsGrounded)

    - Move
        InputSystem에서 받아온 값을 _curMovementInput으로 받고 그만큼 Player를 움직이게 해주는 것이 핵심
    - CameraLook
        InputSystem에서 받아온 값을 mouseDelta 으로 받고 그만큼 MainCamera를 움직이게 해주는 것이 핵심
    - IsGrounded
        Player 가 점프를 할 때 무한 점프가 되는 것을 막기 위해 Player가 땅에 공중에 있는지 확인해주고 그 값을 bool로 반환해주는 것이 핵심

Move와 CameraLook 함수를 각각 FixedUpdate, LateUpdate에서 호출하는 이유에 대해 생각해보세요.

    - Move
        FixedUpdate 은 시간 단위로 실행 되기 때문에 프레임 단위로 실행되는 Update 보다 물리적인 행위가 더 부드럽게 작동합니다.
    - CameraLook
        LateUpdate는 Update가 끝난 후 작동하기 때문에 Player의 움직이 실행된 후 쫓아가기 위해서 LateUpdate에서 실행 한다고 알고 있습니다.
