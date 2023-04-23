#if UNITY_EDITOR
using UnityEngine;

namespace AutoSaveEditor.Editor {
    public class AutoSaveConfig : ScriptableObject {
        [Tooltip("자동 저장 기능 사용")]
        public bool Enabled = true;

        [Tooltip("자동 저장 빈도가 설정한 분 단위로 활성화됩니다. (초 단위)"), Min(1)]
        public int Frequency = 1;

        [Tooltip("에디터가 자동으로 저장될 때마다 메시지 기록")]
        public bool Logging = true;
    }
}
#endif