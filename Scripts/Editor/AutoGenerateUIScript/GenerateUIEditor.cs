using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IFrameWork
{
    public class GenerateUIEditor : EditorWindow
    {
        /// <summary>
        /// �Ƿ�Ϊ����UI�������ɱ���
        /// </summary>
        public static bool IsAll
        {
            get
            {
                return EditorPrefs.GetBool("IsAll", false);
            }
            set
            {
                EditorPrefs.SetBool("IsAll", value);
            }
        }

        /// <summary>
        /// �Ƿ����ɰ�ť�󶨷���
        /// </summary>
        public static bool IsGenerateButtonMethod
        {
            get
            {
                return EditorPrefs.GetBool("IsGenerateButtonMethod", false);
            }
            set
            {
                EditorPrefs.SetBool("IsGenerateButtonMethod", value);

            }
        }

        [MenuItem("Generate/GenerateUIEditor")]
        static void OpenGenerateUIEditor()
        {
            GetWindow<GenerateUIEditor>().Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("UI�������ɹ��߱༭��");
            IsAll = GUILayout.Toggle(IsAll, "�Ƿ���������UI�Ӷ������");
            IsGenerateButtonMethod = GUILayout.Toggle(IsGenerateButtonMethod, "�Ƿ����ɰ�ť�󶨷���");
        }
    }
}
