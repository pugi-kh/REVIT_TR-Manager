## 🏗️ Revit 기반 주택 관리 프로그램

### 📘 프로젝트 개요
- **프로그램 이름**: TR-Manager
- **목적**: Revit 모델링된 건물의 Room 요소를 기반으로, GUI 기반의 세대/층/건물 정보를 통합적으로 관리
- **형태**: Revit Add-in으로 제작되며, Revit을 실행한 상태에서 GUI를 통해 정보 관리 수행
- **관리 운영 구조**:
  - 모든 정보 관리 기능은 독립 GUI에서 동작
  - Revit은 뷰 생성 및 시각적 참조용으로만 활용 (데이터 편집은 GUI에서만 처리)
- **데이터 저장 구조**: Revit 모델의 매개변수 + 외부 JSON 파일을 조합해 관리

### ✅ 주요 기능 요약
- 세대 정보 조회 및 UI 출력
- 세대 정보 수정 → Revit 모델에 실시간 반영 또는 JSON 반영
- 층별 필터링 기능
- 세대별 문의내역 관리
- 전체 문의내역 통합 조회

### 📁 폴더 구조 제안
```
MyHousingPlugin/
├── docs/                ← 명세서, 시나리오, 기술정리 등
├── diagrams/            ← 클래스/시퀀스 다이어그램 등 이미지
├── src/                 ← C# 코드 (WPF + Revit API)
│   ├── Models/
│   ├── Views/
│   ├── Services/
├── ResidenceInfo/       ← 세대별 JSON 저장 위치 (room-101.json 등)
└── assets/              ← UI 아이콘, 이미지 등
```

### ⚙️ 기술 스택
| 항목         | 사용 기술                  |
|--------------|---------------------------|
| 언어         | C# (.NET 6)               |
| UI           | WPF (MVVM)                |
| Revit 연동   | Revit API (Autodesk.Revit.DB) |
| 데이터 저장  | JSON (Newtonsoft.Json)   |
| 버전 관리    | Git / GitHub              |
