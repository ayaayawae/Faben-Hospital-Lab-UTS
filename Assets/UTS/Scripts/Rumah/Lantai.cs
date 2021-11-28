using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantai : MonoBehaviour
{
    [SerializeField]
    public Material floorMaterial;
    public Texture myTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[28];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/floor");
        floorMaterial.mainTexture = myTexture;

        vertices[0] = new Vector3(-10.0f, 0.0f, -10.0f);
        vertices[1] = new Vector3(10.0f, 0.0f, -10.0f);
        vertices[2] = new Vector3(10.0f, 0.0f, 10.0f);
        vertices[3] = new Vector3(-10.0f, 0.0f, 10.0f);

        uvs[3] = new Vector2(0.0f, 1.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            0,3,2,
            0,2,1
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = floorMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
