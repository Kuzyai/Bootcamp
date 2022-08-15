import cv2
img = cv2.imread('test.png')
cv2.imshow('Result', img)
cv2.waitKey(5000)
# img = cv2.resize(img, (500, 500))
