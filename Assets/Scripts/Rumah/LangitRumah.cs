using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangitRumah : MonoBehaviour
{
    [SerializeField]
    public Material LangitRumahMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[48];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/wallpaper");
        LangitRumahMaterial.mainTexture = myTexture;

        //atas
        vertices[0] = new Vector3(-9.0f, 20.0f, -9.0f);
        vertices[1] = new Vector3(9.0f, 20.0f, -9.0f);
        vertices[2] = new Vector3(9.0f, 20.0f, 9.0f);
        vertices[3] = new Vector3(-9.0f, 20.0f, 9.0f);

        uvs[3] = new Vector2(0.0f, 1.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            //atas
            0,1,2,
            0,2,3,
        };

        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = LangitRumahMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
