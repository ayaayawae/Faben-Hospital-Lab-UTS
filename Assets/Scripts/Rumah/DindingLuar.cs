using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DindingLuar : MonoBehaviour
{
    [SerializeField]
    public Material DindingLuarMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[38];
        var uvs = new Vector2[vertices.Length];
        

        myTexture = Resources.Load<Texture>("Textures/wall");
        DindingLuarMaterial.mainTexture = myTexture;

        //depan
        //kiribawah
        vertices[0] = new Vector3(-10.0f, 0.0f, -10.0f);
        vertices[1] = new Vector3(-3.0f, 0.0f, -10.0f);
        vertices[2] = new Vector3(-3.0f, 10.0f, -10.0f);
        vertices[3] = new Vector3(-10.0f, 10.0f, -10.0f);

        uvs[3] = new Vector2(0.0f, 0.5f);
        uvs[2] = new Vector2(0.33333333333333333333f, 0.5f);
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(0.33333333333333333333f, 0.0f);
        //kiriatas
        vertices[4] = new Vector3(-10.0f, 10.0f, -10.0f);
        vertices[5] = new Vector3(-3.0f, 10.0f, -10.0f);
        vertices[6] = new Vector3(-3.0f, 20.0f, -10.0f);
        vertices[7] = new Vector3(-10.0f, 20.0f, -10.0f);

        uvs[7] = new Vector2(0.0f, 1.0f);
        uvs[6] = new Vector2(0.33333333333333333333f, 1.0f);
        uvs[4] = new Vector2(0.0f, 0.5f);
        uvs[5] = new Vector2(0.33333333333333333333f, 0.5f);
        //atas
        vertices[8] = new Vector3(-3.0f, 10.0f, -10.0f);
        vertices[9] = new Vector3(3.0f, 10.0f, -10.0f);
        vertices[10] = new Vector3(3.0f, 20.0f, -10.0f);
        vertices[11] = new Vector3(-3.0f, 20.0f, -10.0f);

        uvs[11] = new Vector2(0.33333333333333333333f, 1.0f);
        uvs[10] = new Vector2(0.66666666666666666666f, 1.0f);
        uvs[8] = new Vector2(0.33333333333333333333f, 0.5f);
        uvs[9] = new Vector2(0.66666666666666666666f, 0.5f);
        //kananatas
        vertices[12] = new Vector3(3.0f, 10.0f, -10.0f);
        vertices[13] = new Vector3(10.0f, 10.0f, -10.0f);
        vertices[14] = new Vector3(10.0f, 20.0f, -10.0f);
        vertices[15] = new Vector3(3.0f, 20.0f, -10.0f);

        uvs[15] = new Vector2(0.66666666666666666666f, 1.0f);
        uvs[14] = new Vector2(1.0f, 1.0f);
        uvs[12] = new Vector2(0.66666666666666666666f, 0.5f);
        uvs[13] = new Vector2(1.0f, 0.5f);
        //kananbawah
        vertices[16] = new Vector3(3.0f, 0.0f, -10.0f);
        vertices[17] = new Vector3(10.0f, 0.0f, -10.0f);
        vertices[18] = new Vector3(10.0f, 10.0f, -10.0f);
        vertices[19] = new Vector3(3.0f, 10.0f, -10.0f);

        uvs[19] = new Vector2(0.66666666666666666666f, 0.5f);
        uvs[18] = new Vector2(1.0f, 0.5f);
        uvs[16] = new Vector2(0.66666666666666666666f, 0.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);

        //kiri
        vertices[20] = new Vector3(-10.0f, 0.0f, 10.0f);
        vertices[21] = new Vector3(-10.0f, 0.0f, -10.0f);
        vertices[22] = new Vector3(-10.0f, 20.0f, -10.0f);
        vertices[23] = new Vector3(-10.0f, 20.0f, 10.0f);

        uvs[23] = new Vector2(0.0f, 1.0f);
        uvs[22] = new Vector2(1.0f, 1.0f);
        uvs[20] = new Vector2(0.0f, 0.0f);
        uvs[21] = new Vector2(1.0f, 0.0f);
        
        //kanan
        vertices[24] = new Vector3(10.0f, 0.0f, -10.0f);
        vertices[25] = new Vector3(10.0f, 0.0f, 10.0f);
        vertices[26] = new Vector3(10.0f, 20.0f, 10.0f);
        vertices[27] = new Vector3(10.0f, 20.0f, -10.0f);

        uvs[27] = new Vector2(0.0f, 1.0f);
        uvs[26] = new Vector2(1.0f, 1.0f);
        uvs[24] = new Vector2(0.0f, 0.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        
        //belakang
        vertices[28] = new Vector3(10.0f, 0.0f, 10.0f);
        vertices[29] = new Vector3(-10.0f, 0.0f, 10.0f);
        vertices[30] = new Vector3(-10.0f, 20.0f, 10.0f);
        vertices[31] = new Vector3(10.0f, 20.0f, 10.0f);

        uvs[31] = new Vector2(0.0f, 1.0f);
        uvs[30] = new Vector2(1.0f, 1.0f);
        uvs[28] = new Vector2(0.0f, 0.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);

        //atap
        //depan
        vertices[32] = new Vector3(-10.0f, 20.0f, -10.0f);
        vertices[33] = new Vector3(0.0f, 25.0f, -10.0f);
        vertices[34] = new Vector3(10.0f, 20.0f, -10.0f);

        uvs[32] = new Vector2(0.0f, 0.0f);
        uvs[33] = new Vector2(0.5f, 0.25f);
        uvs[34] = new Vector2(1.0f, 0.0f);
        
        //belakang
        vertices[35] = new Vector3(-10.0f, 20.0f, 10.0f);
        vertices[36] = new Vector3(0.0f, 25.0f, 10.0f);
        vertices[37] = new Vector3(10.0f, 20.0f, 10.0f);

        uvs[37] = new Vector2(0.0f, 0.0f);
        uvs[36] = new Vector2(0.5f, 0.25f);
        uvs[35] = new Vector2(1.0f, 0.0f);
        
        mesh.vertices = vertices;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            //depan
            //kiribawah
            0,3,2,
            0,2,1,
            //kiriatas
            4,7,6,
            4,6,5,
            //atas
            8,11,10,
            8,10,9,
            //kananatas
            12,15,14,
            12,14,13,
            //kananbawah
            16,19,18,
            16,18,17,

            //kiri
            20,23,22,
            20,22,21,
            
            //kanan
            24,27,26,
            24,26,25,
            
            //belakang
            28,31,30,
            28,30,29,

            //atap
            //depan
            32,33,34,
            //belakang
            37,36,35
        };
        

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = DindingLuarMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
