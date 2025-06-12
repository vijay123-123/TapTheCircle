// using UnityEngine;

// public class TapTarget : MonoBehaviour
// {
//     public GameManager gameManager;

//     void OnMouseDown()
//     {
//         gameManager.OnTargetTapped();
//     }
// }



using UnityEngine;

public class TapTarget : MonoBehaviour
{
    public GameManager gameManager;

//     void Update()
//     {
//         // Mouse click (for PC testing)
//         if (Input.GetMouseButtonDown(0))
//         {
//             Vector2 mousePos = Input.mousePosition;
//             if (RectTransformUtility.RectangleContainsScreenPoint(
//                 GetComponent<RectTransform>(), mousePos, null))
//             {
//                 gameManager.OnTargetTapped();
//             }
//         }

//         // Touch (for mobile)
//         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
//         {
//             Vector2 touchPos = Input.GetTouch(0).position;
//             if (RectTransformUtility.RectangleContainsScreenPoint(
//                 GetComponent<RectTransform>(), touchPos, null))
//             {
//                 gameManager.OnTargetTapped();
//             }
//         }
        void Update()
{
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
        Vector2 touchPos = Input.GetTouch(0).position;
        if (RectTransformUtility.RectangleContainsScreenPoint(
            GetComponent<RectTransform>(), touchPos))
        {
            gameManager.OnTargetTapped();
        }
    }
}
    }







