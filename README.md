# (C# 코딩) 버거 주문 키오스크

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 버거와 추가옵션(사이드)을 원하는 대로 주문하는 키오스크 프로그램
- 사용한 플랫폼:
  - C#, .NET Framework 4.7.2, Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, RadioButton, CheckBox, PictureBox, ListBox, Button, GroupBox
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - RadioButton을 이용한 메뉴 단일 선택 기능
  - CheckBox를 이용한 추가 옵션 다중 선택 기능
  - PictureBox를 이용한 버거 이미지 표시
  - GroupBox를 이용한 컨트롤 그룹화
  - ListBox를 이용한 주문 내역 실시간 표시
  - 가격 계산 및 천 단위 콤마 포맷 적용
  - 키보드 네비게이션 (Tab, 방향키, Space, Enter)
  - Label을 이용한 에러 메시지 화면 표시

## 실행 화면
- 과제1 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-1.png)

- 구현한 내용 (위 그림 참조)
  - UI 구성 : Label(타이틀), GroupBox 3개(메뉴 선택, 추가 옵션, 주문 내역)
  - 메뉴 선택 : RadioButton 3개(햄버거, 불고기버거, 치킨버거)와 PictureBox 이미지 배치
  - 추가 옵션 : CheckBox 4개(감자튀김, 콜라, 치즈 추가, 소스 추가)
  - 주문하기 버튼 : 선택된 메뉴와 옵션을 ListBox에 표시하고 총 금액 계산
  - 초기화 버튼 : 모든 선택 해제 및 주문 내역 초기화

## 실행 화면
- 과제2 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-2.png)

- 구현한 내용 (위 그림 참조)
  - 에러 메시지 표시 : 메뉴를 선택하지 않고 주문하기 버튼 클릭 시 빨간색 에러 메시지 표시
  - MessageBox 대신 Label을 사용하여 화면에 직접 에러 메시지를 표시
  - 정상 주문 시 에러 메시지 자동 초기화

## 실행 화면
- 과제3 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-3.png)

- 구현한 내용 (위 그림 참조)
  - Tab키로 메뉴 그룹 -> 옵션 그룹 -> 주문하기 버튼 -> 초기화 버튼 순서로 포커스 이동
  - 방향키로 RadioButton과 CheckBox 사이 이동
  - 스페이스바로 항목 선택/해제
  - Enter키로 주문하기 버튼 실행 (AcceptButton 설정)

## 실행 화면
- 과제4 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-4.png)

- 구현한 내용 (위 그림 참조)
  - CheckedChanged 이벤트를 이용하여 선택 즉시 주문 내역 갱신
  - 메뉴나 옵션 선택 시 ListBox에 실시간으로 항목과 가격 표시
  - 총 금액 Label도 선택과 동시에 즉시 업데이트

## 배운 내용
- GroupBox를 이용하여 관련 컨트롤들을 그룹으로 묶는 방법을 배움
- RadioButton은 같은 GroupBox 안에서 자동으로 단일 선택이 되는 것을 확인
- CheckedChanged 이벤트를 활용하면 버튼 클릭 없이도 실시간 반응이 가능함을 배움
- TabIndex와 AcceptButton 속성을 설정하여 키보드만으로 조작 가능한 UI를 만들 수 있음을 배움
- ToString("N0") 포맷을 이용하면 숫자에 천 단위 콤마를 쉽게 적용할 수 있음을 배움
