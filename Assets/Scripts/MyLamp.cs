using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLamp : MonoBehaviour
{
    [SerializeField]
    public Material lampuMeja;
    public Texture texTure;

    float x = 1.0f;
    float y = 0.5f;
    float z = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];

        texTure = Resources.Load<Texture>("Textures/lilin");
        lampuMeja.mainTexture = texTure;
        
        //lower
        vertices[0] = new Vector3(x,0,z);
        vertices[1] = new Vector3(x*2,0,z);
        vertices[2] = new Vector3(x,0,z/2);
        vertices[3] = new Vector3(x*2,0,z/2);
        
        uvs[0] = new Vector2(0.0f, 1.0f);
        uvs[1] = new Vector2(1.0f, 1.0f);
        uvs[2] = new Vector2(0.0f, 0.0f);
        uvs[3] = new Vector2(1.0f, 0.0f);

        //upper
        vertices[4] = new Vector3(x,y,z);
        vertices[5] = new Vector3(x*2,y,z);
        vertices[6] = new Vector3(x,y,z/2);
        vertices[7] = new Vector3(x*2,y,z/2);

        uvs[4] = new Vector2(0.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 1.0f);
        uvs[6] = new Vector2(0.0f, 0.0f);
        uvs[7] = new Vector2(1.0f, 0.0f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];

        colors[0] = new Color32(87, 53, 9, 255);
        colors[1] = new Color32(87, 53, 9, 255);
        colors[2] = new Color32(87, 53, 9, 255);
        colors[3] = new Color32(87, 53, 9, 255);
        colors[4] = new Color32(87, 53, 9, 255);
        colors[5] = new Color32(87, 53, 9, 255);
        colors[6] = new Color32(87, 53, 9, 255);
        colors[7] = new Color32(87, 53, 9, 255);

        mesh.colors32 = colors;

        mesh.uv = uvs;

        mesh.triangles = new int[]{
            2,1,0,
            2,3,1, //alas
            1,4,0,
            1,5,4, //depan
            0,4,2,
            4,6,2, //kiri
            2,6,3,
            6,7,3, //belakang
            3,7,1,
            7,5,1, //kanan
            6,4,7,
            4,5,7  //atap
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = lampuMeja;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
