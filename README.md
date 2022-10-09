# UNITY_GAME
## 1. Cấu trúc game

- Có ít nhất 1 level hoàn chỉnh
- Cấu trúc của 1 level bao gồm:
    - Bản đồ hình vuông đủ rộng để người chơi di chuyển
    - Nhân vật chính do người chơi điều khiển
    - Trên bản đồ luôn tồn tại 3 quả bóng có màu khác nhau: Red, Green, Blue

## 2. Camera

- Góc nhìn 3/4 hoặc TPS
- Camera đi theo nhân vật chính hoặc nhìn bao quát cả bản đồ

## 3. Phong cách đồ họa

- Đồ họa 3D
- Nhân vật chỉ cần là hình khối đơn giản
- Màu sắc tươi sáng

## 4. Gameplay

- Điều khiển một nhân vật đi lại trên bản đồ và thu thập các quả bóng có cùng màu với mình.
- Bắt đầu một level, màu của player sẽ là màu ngẫu nhiên trong 3 màu Red, Green, Blue.
- Khi nhân vật va chạm vào mỗi quả bóng:
    - Quả bóng sẽ biến mất và một quả bóng khác cùng màu được spawn tại vị trí ngẫu nhiên trên bản đồ sau 01 giây
    - Nếu màu của quả bóng trùng với màu của nhân vật:
        - Cộng điểm
        - Thay đổi màu của nhân vật thành một màu ngẫu nhiên trong 3 màu Red, Green, Blue.
    - Nếu màu của quả bóng khác với màu của nhân vật:
        - Trò chơi kết thúc

## 5. Điều khiển

- Điều khiển bằng các phím điều hướng

## 6. Điều kiện thắng/ thua:

- Điều kiện thắng:
    - Player đạt 10 điểm
- Điều kiện thua:
    - Chạm vào quả bóng khác màu với player

## 7. UI

- UI cơ bản yêu cầu:
    - Màn hình bắt đầu level
    - Màn hình khi đang chơi
        - Hiện số điểm đang có
    - Popup thông báo thắng/ thua
