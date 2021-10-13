using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DindingDalam : MonoBehaviour
{
    [SerializeField]
    public Material DindingDalamMaterial;
    public Texture myTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[48];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/wallpaper2");
        DindingDalamMaterial.mainTexture = myTexture;

        //depan
        //kiribawah
        vertices[0] = new Vector3(-9.0f, 0.0f, -9.0f);
        vertices[1] = new Vector3(-3.0f, 0.0f, -9.0f);
        vertices[2] = new Vector3(-3.0f, 10.0f, -9.0f);
        vertices[3] = new Vector3(-9.0f, 10.0f, -9.0f);

        uvs[3] = new Vector2(0.0f, 0.5f);
        uvs[2] = new Vector2(0.33333333333333333333f, 0.5f);
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(0.33333333333333333333f, 0.0f);
        //kiriatas
        vertices[4] = new Vector3(-9.0f, 10.0f, -9.0f);
        vertices[5] = new Vector3(-3.0f, 10.0f, -9.0f);
        vertices[6] = new Vector3(-3.0f, 20.0f, -9.0f);
        vertices[7] = new Vector3(-9.0f, 20.0f, -9.0f);

        uvs[7] = new Vector2(0.0f, 1.0f);
        uvs[6] = new Vector2(0.33333333333333333333f, 1.0f);
        uvs[4] = new Vector2(0.0f, 0.5f);
        uvs[5] = new Vector2(0.33333333333333333333f, 0.5f);
        //atas
        vertices[8] = new Vector3(-3.0f, 10.0f, -9.0f);
        vertices[9] = new Vector3(3.0f, 10.0f, -9.0f);
        vertices[10] = new Vector3(3.0f, 20.0f, -9.0f);
        vertices[11] = new Vector3(-3.0f, 20.0f, -9.0f);

        uvs[11] = new Vector2(0.33333333333333333333f, 1.0f);
        uvs[10] = new Vector2(0.66666666666666666666f, 1.0f);
        uvs[8] = new Vector2(0.33333333333333333333f, 0.5f);
        uvs[9] = new Vector2(0.66666666666666666666f, 0.5f);
        //kananatas
        vertices[12] = new Vector3(3.0f, 10.0f, -9.0f);
        vertices[13] = new Vector3(9.0f, 10.0f, -9.0f);
        vertices[14] = new Vector3(9.0f, 20.0f, -9.0f);
        vertices[15] = new Vector3(3.0f, 20.0f, -9.0f);

        uvs[15] = new Vector2(0.66666666666666666666f, 1.0f);
        uvs[14] = new Vector2(1.0f, 1.0f);
        uvs[12] = new Vector2(0.66666666666666666666f, 0.5f);
        uvs[13] = new Vector2(1.0f, 0.5f);
        //kananbawah
        vertices[16] = new Vector3(3.0f, 0.0f, -9.0f);
        vertices[17] = new Vector3(9.0f, 0.0f, -9.0f);
        vertices[18] = new Vector3(9.0f, 10.0f, -9.0f);
        vertices[19] = new Vector3(3.0f, 10.0f, -9.0f);

        uvs[19] = new Vector2(0.66666666666666666666f, 0.5f);
        uvs[18] = new Vector2(1.0f, 0.5f);
        uvs[16] = new Vector2(0.66666666666666666666f, 0.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);

        //kiri
        vertices[20] = new Vector3(-9.0f, 0.0f, 9.0f);
        vertices[21] = new Vector3(-9.0f, 0.0f, -9.0f);
        vertices[22] = new Vector3(-9.0f, 20.0f, -9.0f);
        vertices[23] = new Vector3(-9.0f, 20.0f, 9.0f);

        uvs[23] = new Vector2(0.0f, 1.0f);
        uvs[22] = new Vector2(1.0f, 1.0f);
        uvs[20] = new Vector2(0.0f, 0.0f);
        uvs[21] = new Vector2(1.0f, 0.0f);
        
        //kanan
        vertices[24] = new Vector3(9.0f, 0.0f, -9.0f);
        vertices[25] = new Vector3(9.0f, 0.0f, 9.0f);
        vertices[26] = new Vector3(9.0f, 20.0f, 9.0f);
        vertices[27] = new Vector3(9.0f, 20.0f, -9.0f);

        uvs[27] = new Vector2(0.0f, 1.0f);
        uvs[26] = new Vector2(1.0f, 1.0f);
        uvs[24] = new Vector2(0.0f, 0.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        
        //belakang
        vertices[28] = new Vector3(9.0f, 0.0f, 9.0f);
        vertices[29] = new Vector3(-9.0f, 0.0f, 9.0f);
        vertices[30] = new Vector3(-9.0f, 20.0f, 9.0f);
        vertices[31] = new Vector3(9.0f, 20.0f, 9.0f);

        uvs[31] = new Vector2(0.0f, 1.0f);
        uvs[30] = new Vector2(1.0f, 1.0f);
        uvs[28] = new Vector2(0.0f, 0.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);

        //atas
        vertices[32] = new Vector3(-9.0f, 20.0f, -9.0f);
        vertices[33] = new Vector3(9.0f, 20.0f, -9.0f);
        vertices[34] = new Vector3(9.0f, 20.0f, 9.0f);
        vertices[35] = new Vector3(-9.0f, 20.0f, 9.0f);

        //lis pintu
        //kiri
        vertices[36] = new Vector3(-3.0f, 0.0f, -9.0f);
        vertices[37] = new Vector3(-3.0f, 0.0f, -10.0f);
        vertices[38] = new Vector3(-3.0f, 10.0f, -10.0f);
        vertices[39] = new Vector3(-3.0f, 10.0f, -9.0f);
        //kanan
        vertices[40] = new Vector3(3.0f, 0.0f, -10.0f);
        vertices[41] = new Vector3(3.0f, 0.0f, -9.0f);
        vertices[42] = new Vector3(3.0f, 10.0f, -9.0f);
        vertices[43] = new Vector3(3.0f, 10.0f, -10.0f);
        //atas
        vertices[44] = new Vector3(-3.0f, 10.0f, -10.0f);
        vertices[45] = new Vector3(3.0f, 10.0f, -10.0f);
        vertices[46] = new Vector3(3.0f, 10.0f, -9.0f);
        vertices[47] = new Vector3(-3.0f, 10.0f, -9.0f);
        
        
        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            //depan
            //kiribawah
            0,1,2,
            0,2,3,
            //kiriatas
            4,5,6,
            4,6,7,
            //atas
            8,9,10,
            8,10,11,
            //kananatas
            12,13,14,
            12,14,15,
            //kananbawah
            16,17,18,
            16,18,19,

            //kiri
            20,21,22,
            20,22,23,
            
            //kanan
            24,25,26,
            24,26,27,
            
            //belakang
            28,29,30,
            28,30,31,

            //atas
            // 32,33,34,
            // 32,34,35,

            //lis pintu
            //kiri
            37,38,39,
            37,39,36,
            //atas
            44,45,46,
            44,46,47,
            //kanan
            40,41,42,
            40,42,43
        };
        
        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = DindingDalamMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
