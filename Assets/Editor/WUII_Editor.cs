using UnityEngine;
using UnityEditor;

public class WUII_Editor : EditorWindow
{
    public float explosionDelay;
    public int damage;
    public float explosionForce;
    public float explosionRadius;
    public string bombType;

    public bool showHelp;

    [MenuItem("Window/TIME BUSTERS X' WEAPON UI INTEGRATION EDITOR")]

    public static void ShowWindow()
    {
        GetWindow<WUII_Editor>("TIME BUSTERS X' WEAPON UI INTEGRATION EDITOR");
    }

    private void OnGUI()
    {
        //GUILayout.Label("BERLIN 2035's\nINSPECTION DIALOGUE EDITOR", EditorStyles.centeredGreyMiniLabel);
        var midstyle = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter };
        var leftstyle = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleLeft};
        var rightstyle = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleRight };

        Texture2D logo = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/tbx_wuiie_logo.png", typeof(Texture2D));
        GUILayout.Label(logo, GUILayout.Width(512), GUILayout.Height(64));

        GUILayout.BeginVertical();
        GUILayout.Label("------------------------------------------------------------------------------------------------------", EditorStyles.largeLabel);
        GUILayout.EndVertical();

        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Set Delay for Bomb Explosion:", EditorStyles.boldLabel);
        explosionDelay = EditorGUILayout.FloatField("", explosionDelay);
        GUILayout.EndVertical();

        //---------------------------------------------------------------------------------------------------------------------------------------
        GUILayout.Label("");
        if (GUILayout.Button("Apply"))
        {
            Debug.Log("Applied");

            foreach (GameObject bomb in Selection.gameObjects)
            {
                //relevant for the image that is being displayed
            }
        }

        showHelp = EditorGUILayout.Foldout(showHelp, "Help");

        if (showHelp)
        {
            GUILayout.Label("This is the HELP for the Weapon UI Integration Editor:\nTo actually" +
                "change in -game values, change the parameters,\nselect the '_Weapon' and last," +
                "click 'Apply' in this\nwindow.", EditorStyles.helpBox);
        }
    }
}