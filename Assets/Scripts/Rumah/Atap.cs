using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atap : MonoBehaviour
{
    [SerializeField]
    public Material AtapMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[40];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/atap");
        AtapMaterial.mainTexture = myTexture;

        //bawah
        //kiri
        vertices[0] = new Vector3(-12.0f, 19.0f, 12.0f);
        vertices[1] = new Vector3(-12.0f, 19.0f, -12.0f);
        vertices[2] = new Vector3(0.0f, 25.0f, -12.0f);
        vertices[3] = new Vector3(0.0f, 25.0f, 12.0f);
        //kanan
        vertices[4] = new Vector3(12.0f, 19.0f, 12.0f);
        vertices[5] = new Vector3(12.0f, 19.0f, -12.0f);
        vertices[6] = new Vector3(0.0f, 25.0f, -12.0f);
        vertices[7] = new Vector3(0.0f, 25.0f, 12.0f);
        
        //atas
        //kiri
        vertices[8] = new Vector3(-13.0f, 19.0f, 12.0f);
        vertices[9] = new Vector3(-13.0f, 19.0f, -12.0f);
        vertices[10] = new Vector3(0.0f, 26.0f, -12.0f);
        vertices[11] = new Vector3(0.0f, 26.0f, 12.0f);

        uvs[11] = new Vector2(0.0f, 1.0f);
        uvs[10] = new Vector2(1.0f, 1.0f);
        uvs[8] = new Vector2(0.0f, 0.0f);
        uvs[9] = new Vector2(1.0f, 0.0f);
        
        //kanan
        vertices[12] = new Vector3(13.0f, 19.0f, 12.0f);
        vertices[13] = new Vector3(13.0f, 19.0f, -12.0f);
        vertices[14] = new Vector3(0.0f, 26.0f, -12.0f);
        vertices[15] = new Vector3(0.0f, 26.0f, 12.0f);

        uvs[14] = new Vector2(0.0f, 1.0f);
        uvs[15] = new Vector2(1.0f, 1.0f);
        uvs[13] = new Vector2(0.0f, 0.0f);
        uvs[12] = new Vector2(1.0f, 0.0f);
        
        //depan
        //kiri
        vertices[16] = new Vector3(-12.0f, 19.0f, -12.0f);
        vertices[17] = new Vector3(0.0f, 25.0f, -12.0f);
        vertices[18] = new Vector3(0.0f, 26.0f, -12.0f);
        vertices[19] = new Vector3(-13.0f, 19.0f, -12.0f);
        //kanan
        vertices[20] = new Vector3(0.0f, 25.0f, -12.0f);
        vertices[21] = new Vector3(12.0f, 19.0f, -12.0f);
        vertices[22] = new Vector3(13.0f, 19.0f, -12.0f);
        vertices[23] = new Vector3(0.0f, 26.0f, -12.0f);
        
        //belakang
        //kiri
        vertices[24] = new Vector3(-12.0f, 19.0f, 12.0f);
        vertices[25] = new Vector3(0.0f, 25.0f, 12.0f);
        vertices[26] = new Vector3(0.0f, 26.0f, 12.0f);
        vertices[27] = new Vector3(-13.0f, 19.0f, 12.0f);
        //kanan
        vertices[28] = new Vector3(0.0f, 25.0f, 12.0f);
        vertices[29] = new Vector3(12.0f, 19.0f, 12.0f);
        vertices[30] = new Vector3(13.0f, 19.0f, 12.0f);
        vertices[31] = new Vector3(0.0f, 26.0f, 12.0f);
        
        //samping
        //kiri
        vertices[32] = new Vector3(-12.0f, 19.0f, 12.0f);
        vertices[33] = new Vector3(-12.0f, 19.0f, -12.0f);
        vertices[34] = new Vector3(-13.0f, 19.0f, -12.0f);
        vertices[35] = new Vector3(-13.0f, 19.0f, 12.0f);
        //kanan
        vertices[36] = new Vector3(12.0f, 19.0f, -12.0f);
        vertices[37] = new Vector3(12.0f, 19.0f, 12.0f);
        vertices[38] = new Vector3(13.0f, 19.0f, 12.0f);
        vertices[39] = new Vector3(13.0f, 19.0f, -12.0f);

        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            //bawah
            //kiri
            1,2,3,
            1,3,0,
            //kanan
            5,4,7,
            5,7,6,

            //atas
            //kiri
            8,11,10,
            8,10,9,
            //kanan
            13,14,15,
            13,15,12,

            //depan
            //kiri
            16,19,18,
            16,18,17,
            //kanan
            20,23,22,
            20,22,21,

            //belakang
            //kiri
            24,25,26,
            24,26,27,
            //kanan
            28,29,30,
            28,30,31,

            //samping
            //kiri
            33,32,35,
            33,35,34,
            //kanan
            36,39,38,
            36,38,37
        };
        
        

        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = AtapMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
