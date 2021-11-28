using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembok : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    public int spinSpeed;
    public Vector3 RotateAmount;

    float width = 1.0f;
    float height = 1.0f;
    float thick = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 1;
        RotateAmount = new Vector3(0.0f, 50.0f, 0.0f);

        Mesh mesh = new Mesh();
        var vertices = new Vector3[24];

        // first surface toward x-positive
        vertices[0] = new Vector3(width, height, thick);
        vertices[1] = new Vector3(width, -height, thick);
        vertices[2] = new Vector3(width, height, -thick);
        vertices[3] = new Vector3(width, -height, -thick);
        // second surface toward y-positive
        vertices[4] = new Vector3(width, height, thick);
        vertices[5] = new Vector3(-width, height, thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(-width, height, -thick);
        // third surface toward z-positive
        vertices[8] = new Vector3(width, height, thick);
        vertices[9] = new Vector3(-width, height, thick);
        vertices[10] = new Vector3(width, -height, thick);
        vertices[11] = new Vector3(-width, -height, thick);
        // fourth surface toward x-negative
        vertices[12] = new Vector3(-width, height, thick);
        vertices[13] = new Vector3(-width, -height, thick);
        vertices[14] = new Vector3(-width, height, -thick);
        vertices[15] = new Vector3(-width, -height, -thick);
        // fifth surface toward y-negative
        vertices[16] = new Vector3(width, -height, thick);
        vertices[17] = new Vector3(-width, -height, thick);
        vertices[18] = new Vector3(width, -height, -thick);
        vertices[19] = new Vector3(-width, -height, -thick);
        // sixth surface toward z-negative
        vertices[20] = new Vector3(width, height, -thick);
        vertices[21] = new Vector3(-width, height, -thick);
        vertices[22] = new Vector3(width, -height, -thick);
        vertices[23] = new Vector3(-width, -height, -thick);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        for(int i = 0; i<24; i++){
            colors[i] = new Color32(128, 128, 128, 255);
        }

        mesh.colors32 = colors;

        mesh.triangles = new int[] {
            2, 0, 1,
            2, 1, 3, //first surface toward x positive
            6, 7, 5,
            4, 6, 5, // second surface toward y positive
            8, 9, 11,
            8, 11, 10, //third surface toward z positive
            12, 14, 13,
            14, 15, 13, //fourth surface toward x negative
            19, 18, 17,
            18, 16, 17, //fifth surface toward y negative
            21, 20, 23,
            20, 22, 23 //sixth surface toward z negative
        };

        mesh.normals = new Vector3[] {
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 0.0f),

            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f),

            new Vector3(0.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 0.0f, 1.0f),
            new Vector3(0.0f, 0.0f, 1.0f),

            new Vector3(-1.0f, 0.0f, 0.0f),
            new Vector3(-1.0f, 0.0f, 0.0f),
            new Vector3(-1.0f, 0.0f, 0.0f),
            new Vector3(-1.0f, 0.0f, 0.0f),

            new Vector3(0.0f, -1.0f, 0.0f),
            new Vector3(0.0f, -1.0f, 0.0f),
            new Vector3(0.0f, -1.0f, 0.0f),
            new Vector3(0.0f, -1.0f, 0.0f),

            new Vector3(0.0f, 0.0f, -1.0f),
            new Vector3(0.0f, 0.0f, -1.0f),
            new Vector3(0.0f, 0.0f, -1.0f),
            new Vector3(0.0f, 0.0f, -1.0f),  
        };

        // mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;

        foreach (Vector3 normal in GetComponent<MeshFilter>().mesh.normals){
            Debug.Log(normal.x + " " + normal.y + " " + normal.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
