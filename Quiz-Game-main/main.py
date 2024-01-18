import cv2
import mediapipe as mp
import pyautogui
cam = cv2.VideoCapture(0)
face_mesh = mp.solutions.face_mesh.FaceMesh(refine_landmarks=True)
hand_tracking = mp.solutions.hands.Hands(min_detection_confidence=0.2, min_tracking_confidence=0.2)

screen_w, screen_h = pyautogui.size()

while True:
    _, frame = cam.read()

    frame = cv2.flip(frame, 1)

    rgb_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)

    output_face = face_mesh.process(rgb_frame)
    output_hand = hand_tracking.process(rgb_frame)

    landmark_points_face = output_face.multi_face_landmarks
    landmark_points_hand = output_hand.multi_hand_landmarks

    frame_h, frame_w, _ = frame.shape

    if landmark_points_face:
        landmarks_face = landmark_points_face[0].landmark

        for id, landmark in enumerate(landmarks_face[474:478]):
            x = int(landmark.x * frame_w)
            y = int(landmark.y * frame_h)
            cv2.circle(frame, (x, y), 3, (0, 255, 0))

            if id == 1:
                screen_x = screen_w / frame_w * x
                screen_y = screen_h / frame_h * y
                pyautogui.moveTo(screen_x, screen_y)

        left = [landmarks_face[145], landmarks_face[159]]

        for landmark in left:
            x = int(landmark.x * frame_w)
            y = int(landmark.y * frame_h)
            cv2.circle(frame, (x, y), 3, (0, 255, 255))

        if (left[0].y - left[1].y) < 0.004:
            pyautogui.click()
            pyautogui.sleep(1)

    if landmark_points_hand:
        landmarks_hand = landmark_points_hand[0].landmark

        for landmark in landmarks_hand:
            print("hello")

    cv2.imshow("Eye and Hand Controlled Mouse", frame)

    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cam.release()
cv2.destroyAllWindows()