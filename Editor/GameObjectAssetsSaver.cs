#if UNITY_EDITOR
using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class GameObjectAssetsSaver
    {
        [MenuItem("Common/Mesh/Save from MeshFilter", false)]
        private static void SaveMeshFromMeshFilter()
        {
            var selectedGameObject = Selection.activeGameObject;

            if (selectedGameObject != null)
            {
                if (selectedGameObject.TryGetComponent(out MeshFilter meshFilter))
                {
                    var mesh = meshFilter.sharedMesh;
                    var path = AssetDatabase.GetAssetPath(mesh);

                    if (string.IsNullOrEmpty(path))
                    {
                        const string DEFAULT_NAME = "";
                        const string DEFAULT_MESSAGE = "";

                        path = EditorUtility.SaveFilePanelInProject("Save Mesh", DEFAULT_NAME, "asset", DEFAULT_MESSAGE);

                        AssetDatabase.CreateAsset(mesh, path);
                    }

                    AssetDatabase.SaveAssets();
                }
            }
        }

        [MenuItem("Common/Texture/Save from MeshRenderer")]
        private static void SaveTexturesFromMeshRenderer()
        {
            var selectedGameObject = Selection.activeGameObject;

            if (selectedGameObject != null)
            {
                if (selectedGameObject.TryGetComponent(out MeshRenderer meshRenderer))
                {
                    var materials = meshRenderer.sharedMaterials;

                    for (int m = 0; materials != null && m < materials.Length; m++)
                    {
                        var material = materials[m];

                        var texturePropertyIds = material.GetTexturePropertyNameIDs();

                        for (int t = 0; texturePropertyIds != null && t < texturePropertyIds.Length; t++)
                        {
                            var texturePropertyId = texturePropertyIds[t];

                            var texture = material.GetTexture(texturePropertyId);

                            if (Utility.TryCast(texture, out Texture2D texture2D))
                            {
                                var path = AssetDatabase.GetAssetPath(texture2D);

                                if (string.IsNullOrEmpty(path))
                                {
                                    const string DEFAULT_NAME = "";
                                    const string DEFAULT_MESSAGE = "";

                                    path = EditorUtility.SaveFilePanelInProject("Save Mesh", DEFAULT_NAME, "asset", DEFAULT_MESSAGE);

                                    AssetDatabase.CreateAsset(texture2D, path);
                                }
                            }
                        }
                    }

                    AssetDatabase.SaveAssets();
                }
            }
        }
    }
}
#endif