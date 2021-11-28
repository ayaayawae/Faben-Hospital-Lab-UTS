using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTable : MonoBehaviour
{
    [SerializeField]
    public Material taplakMeja;
    public Texture myTexture;

    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[40];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/kayu");
        taplakMeja.mainTexture = myTexture;

        // Alas Kaki 1
        vertices[0] = new Vector3(3,0,3);
        vertices[1] = new Vector3(4,0,3);
        vertices[2] = new Vector3(3,0,2);
        vertices[3] = new Vector3(4,0,2);

        uvs[0] = new Vector2(0.0f, 1.0f);
        uvs[1] = new Vector2(1.0f, 1.0f);
        uvs[2] = new Vector2(0.0f, 0.0f);
        uvs[3] = new Vector2(1.0f, 0.0f);

        // Atap Kaki 1
        vertices[4] = new Vector3(3,4,3);
        vertices[5] = new Vector3(4,4,3);
        vertices[6] = new Vector3(3,4,2);
        vertices[7] = new Vector3(4,4,2);

        uvs[4] = new Vector2(0.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 1.0f);
        uvs[6] = new Vector2(0.0f, 0.0f);
        uvs[7] = new Vector2(1.0f, 0.0f);

        // Alas Kaki 2
        vertices[8] = new Vector3(-3,0,3);
        vertices[9] = new Vector3(-4,0,3);
        vertices[10] = new Vector3(-3,0,2);
        vertices[11] = new Vector3(-4,0,2);

        uvs[8] = new Vector2(0.0f, 1.0f);
        uvs[9] = new Vector2(1.0f, 1.0f);
        uvs[10] = new Vector2(0.0f, 0.0f);
        uvs[11] = new Vector2(1.0f, 0.0f);

        // Atap Kaki 2
        vertices[12] = new Vector3(-3,4,3);
        vertices[13] = new Vector3(-4,4,3);
        vertices[14] = new Vector3(-3,4,2);
        vertices[15] = new Vector3(-4,4,2);

        uvs[12] = new Vector2(0.0f, 1.0f);
        uvs[13] = new Vector2(1.0f, 1.0f);
        uvs[14] = new Vector2(0.0f, 0.0f);
        uvs[15] = new Vector2(1.0f, 0.0f);

        // Alas Kaki 3
        vertices[16] = new Vector3(3,0,-3);
        vertices[17] = new Vector3(4,0,-3);
        vertices[18] = new Vector3(3,0,-2);
        vertices[19] = new Vector3(4,0,-2);

        uvs[16] = new Vector2(0.0f, 1.0f);
        uvs[17] = new Vector2(1.0f, 1.0f);
        uvs[18] = new Vector2(0.0f, 0.0f);
        uvs[19] = new Vector2(1.0f, 0.0f);
        // Atap Kaki 3
        vertices[20] = new Vector3(3,4,-3);
        vertices[21] = new Vector3(4,4,-3);
        vertices[22] = new Vector3(3,4,-2);
        vertices[23] = new Vector3(4,4,-2);

        uvs[20] = new Vector2(0.0f, 1.0f);
        uvs[21] = new Vector2(1.0f, 1.0f);
        uvs[22] = new Vector2(0.0f, 0.0f);
        uvs[23] = new Vector2(1.0f, 0.0f);

        // Alas Kaki 4
        vertices[24] = new Vector3(-3,0,-3);
        vertices[25] = new Vector3(-4,0,-3);
        vertices[26] = new Vector3(-3,0,-2);
        vertices[27] = new Vector3(-4,0,-2);
        
        uvs[24] = new Vector2(0.0f, 1.0f);
        uvs[25] = new Vector2(1.0f, 1.0f);
        uvs[26] = new Vector2(0.0f, 0.0f);
        uvs[27] = new Vector2(1.0f, 0.0f);

        // Atap Kaki 4
        vertices[28] = new Vector3(-3,4,-3);
        vertices[29] = new Vector3(-4,4,-3);
        vertices[30] = new Vector3(-3,4,-2);
        vertices[31] = new Vector3(-4,4,-2);

        uvs[28] = new Vector2(0.0f, 1.0f);
        uvs[29] = new Vector2(1.0f, 1.0f);
        uvs[30] = new Vector2(0.0f, 0.0f);
        uvs[31] = new Vector2(1.0f, 0.0f);

        // Bawah Meja
        vertices[32] = new Vector3(-6,4,6);
        vertices[33] = new Vector3(6,4,6);
        vertices[34] = new Vector3(-6,4,-6);
        vertices[35] = new Vector3(6,4,-6);

        uvs[32] = new Vector2(0.0f, 1.0f);
        uvs[33] = new Vector2(1.0f, 1.0f);
        uvs[34] = new Vector2(0.0f, 0.0f);
        uvs[35] = new Vector2(1.0f, 0.0f);

        // Atap Meja
        vertices[36] = new Vector3(-6,5,6);
        vertices[37] = new Vector3(6,5,6);
        vertices[38] = new Vector3(-6,5,-6);
        vertices[39] = new Vector3(6,5,-6);

        uvs[36] = new Vector2(0.0f, 1.0f);
        uvs[37] = new Vector2(1.0f, 1.0f);
        uvs[38] = new Vector2(0.0f, 0.0f);
        uvs[39] = new Vector2(1.0f, 0.0f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        // kaki 1
        colors[0] = new Color32(87, 53, 9, 255);
        colors[1] = new Color32(87, 53, 9, 255);
        colors[2] = new Color32(87, 53, 9, 255);
        colors[3] = new Color32(87, 53, 9, 255);
        colors[4] = new Color32(87, 53, 9, 255);
        colors[5] = new Color32(87, 53, 9, 255);
        colors[6] = new Color32(87, 53, 9, 255);
        colors[7] = new Color32(87, 53, 9, 255);
        // kaki 2
        colors[8] = new Color32(87, 53, 9, 255);
        colors[9] = new Color32(87, 53, 9, 255);
        colors[10] = new Color32(87, 53, 9, 255);
        colors[11] = new Color32(87, 53, 9, 255);
        colors[12] = new Color32(87, 53, 9, 255);
        colors[13] = new Color32(87, 53, 9, 255);
        colors[14] = new Color32(87, 53, 9, 255);
        colors[15] = new Color32(87, 53, 9, 255);
        // kaki 3
        colors[16] = new Color32(87, 53, 9, 255);
        colors[17] = new Color32(87, 53, 9, 255);
        colors[18] = new Color32(87, 53, 9, 255);
        colors[19] = new Color32(87, 53, 9, 255);
        colors[20] = new Color32(87, 53, 9, 255);
        colors[21] = new Color32(87, 53, 9, 255);
        colors[22] = new Color32(87, 53, 9, 255);
        colors[23] = new Color32(87, 53, 9, 255);
        // kaki 4
        colors[24] = new Color32(87, 53, 9, 255);
        colors[25] = new Color32(87, 53, 9, 255);
        colors[26] = new Color32(87, 53, 9, 255);
        colors[27] = new Color32(87, 53, 9, 255);
        colors[28] = new Color32(87, 53, 9, 255);
        colors[29] = new Color32(87, 53, 9, 255);
        colors[30] = new Color32(87, 53, 9, 255);
        colors[31] = new Color32(87, 53, 9, 255);
        // surface meja
        colors[32] = new Color32(87, 53, 9, 255);
        colors[33] = new Color32(87, 53, 9, 255);
        colors[34] = new Color32(87, 53, 9, 255);
        colors[35] = new Color32(87, 53, 9, 255);
        colors[36] = new Color32(87, 53, 9, 255);
        colors[37] = new Color32(87, 53, 9, 255);
        colors[38] = new Color32(87, 53, 9, 255);
        colors[39] = new Color32(87, 53, 9, 255);

        mesh.colors32 = colors;

        mesh.uv = uvs;

        mesh.triangles = new int[]
        {
            2,1,0,
            2,3,1,  // alas kaki 1
            4,5,6,
            5,7,6,  // atap
            0,5,4,
            0,1,5,  //depan
            0,4,6,
            6,2,0,  //kiri
            2,6,3,
            6,7,3,  //bawah
            3,7,5,
            5,1,3,  //belakang

            10,8,9,
            10,9,11, //alas kaki 2
            13,12,15,
            12,14,15, // atap
            13,9,8,
            8,12,13, // depan
            9,13,11,
            13,15,11, // kiri
            11,15,10,
            15,14,10, // belakang
            10,14,12,
            12,8,10,  // kanan

            16,17,18,
            17,19,18, // alas kaki 3
            22,23,20,
            23,21,20,  // atap
            17,16,20,
            20,21,17, // belakang
            19,17,21,
            21,23,19,  // kanan
            18,19,23,
            23,22,18,  // depan
            16,18,22,
            22,20,16,  // kiri

            26,27,24,
            27,25,24,  // alas kaki 4
            28,31,30,
            28,29,31,
            25,28,24,
            25,29,28,  // belakang
            29,25,27,
            27,31,29,  // kiri
            31,27,26,
            26,30,31,  // depan
            30,26,24,
            24,28,30,  // kanan

            34,33,32,
            34,35,33, // bawah meja
            36,37,38,
            37,39,38,  // atas meja
            33,37,32,
            37,36,32,  //depan
            32,36,34,
            36,38,34,  // kiri
            34,38,35,
            38,39,35,  // belakang
            35,39,33,
            39,37,33   // kiri  
        };

        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = taplakMeja;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
