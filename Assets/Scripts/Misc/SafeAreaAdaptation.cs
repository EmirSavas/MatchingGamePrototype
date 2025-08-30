using UnityEngine;

namespace MatchingGame
{
    public class SafeAreaAdaptation : MonoBehaviour
    {
        [Header("REFERENCES")]
        [SerializeField] private RectTransform safeAreaPanel;


        private void Start()
        {
            ApplySafeArea();
        }

        private void ApplySafeArea()
        {
            Rect safeArea = Screen.safeArea;

            Vector2 anchorMin = safeArea.position;
            Vector2 anchorMax = safeArea.position + safeArea.size;

            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;

            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;

            safeAreaPanel.anchorMin = anchorMin;
            safeAreaPanel.anchorMax = anchorMax;
        }
    }
}
