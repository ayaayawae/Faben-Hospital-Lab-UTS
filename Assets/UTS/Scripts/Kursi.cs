using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursi : MonoBehaviour
{
 //Declaring Material to be recognized in the Inspector
    // [SerializeField]
    public Material KursiMaterial;

    private Texture kursi1;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[145];
        var uvs = new Vector2[vertices.Length];

        // Load Texture
        kursi1 = Resources.Load<Texture>("Textures/cubetiles");
        KursiMaterial.mainTexture = kursi1;
        var colors = new Color32[vertices.Length];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1, 0, 0);
        vertices[2] = new Vector3(1, 0, 1);
        vertices[3] = new Vector3(0, 0, 1);
        vertices[4] = new Vector3(0, 5, 0);
        vertices[5] = new Vector3(1, 5, 0);
        vertices[6] = new Vector3(1, 5, 1);
        vertices[7] = new Vector3(0, 5, 1);
        vertices[8] = new Vector3(-5, 0, 0);
        vertices[9] = new Vector3(-6, 0, 0);
        vertices[10] = new Vector3(-5, 0, 1);
        vertices[11] = new Vector3(-6, 0, 1);
        vertices[12] = new Vector3(-6, 5, 0);
        vertices[13] = new Vector3(-5, 5, 0);
        vertices[14] = new Vector3(-5, 5, 1);
        vertices[15] = new Vector3(-6, 5, 1);
        vertices[16] = new Vector3(0, 0, -5);
        vertices[17] = new Vector3(1, 0, -5);
        vertices[18] = new Vector3(1, 0, -4);
        vertices[19] = new Vector3(0, 0, -4);
        vertices[20] = new Vector3(0, 5, -5);
        vertices[21] = new Vector3(1, 5, -5);
        vertices[22] = new Vector3(1, 5, -4);
        vertices[23] = new Vector3(0, 5, -4);
        vertices[24] = new Vector3(-5, 0, -5);
        vertices[25] = new Vector3(-6, 0, -5);
        vertices[26] = new Vector3(-5, 0, -4);
        vertices[27] = new Vector3(-6, 0, -4);
        vertices[28] = new Vector3(-6, 5, -5);
        vertices[29] = new Vector3(-5, 5, -4);
        vertices[30] = new Vector3(-5, 5, -5);
        vertices[31] = new Vector3(-6, 5, -4);
        vertices[32] = new Vector3(-6, 6, -5);
        vertices[33] = new Vector3(-6, 6, 1);
        vertices[34] = new Vector3(1, 6, 1);
        vertices[35] = new Vector3(1, 6, -5);
        vertices[36] = new Vector3(-6, 12, 1);
        vertices[37] = new Vector3(-6, 12, 0);
        vertices[38] = new Vector3(1, 12, 1);
        vertices[39] = new Vector3(1, 12, 0);
        vertices[40] = new Vector3(-6, 6, 0);
        vertices[41] = new Vector3(1, 6, 0);


        // Tambahan
        // Penutup sandaran atas
        vertices[42] = new Vector3(-6, 12, 1); //36
        vertices[43] = new Vector3(-6, 12, 0); //37
        vertices[44] = new Vector3(1, 12, 1);  //38
        vertices[45] = new Vector3(1, 12, 0); //39

        // penutup sandaran bawah
        vertices[46] = new Vector3(1, 5, 0); //5
        vertices[47] = new Vector3(1, 5, 1); //6
        vertices[48] = new Vector3(-6, 5, 0); //12
        vertices[49] = new Vector3(-6, 5, 1); //15
        
        // kaki tatakan depan
        vertices[50] = new Vector3(-6, 6, -5); //32
        vertices[51] = new Vector3(1, 6, -5); //35

        // kaki tatakan kanan
        vertices[52] = new Vector3(-6, 5, 0); //12
        vertices[53] = new Vector3(-6, 5, -5); //28
        vertices[54] = new Vector3(-6, 6, -5); //32
        vertices[55] = new Vector3(-6, 6, 0); //40
        
        // kaki tatakan kiri
        vertices[56] = new Vector3(1, 5, 0); //5
        vertices[57] = new Vector3(1, 5, -5); //21
        vertices[58] = new Vector3(1, 6, -5);  //35
        vertices[59] = new Vector3(1, 6, 0); //41

        // tatakan bawah
        vertices[60] = new Vector3(1, 5, 1); //6
        vertices[61] = new Vector3(1, 5, -5); //21
        vertices[62] = new Vector3(-6, 5, 1); //15 
        vertices[63] = new Vector3(-6, 5, -5); //28

        // Kaki Kursi depan kiri
            // Depan
            vertices[64] = new Vector3(1, 5, -5); //21

            // Kanan
            vertices[65] = new Vector3(0, 0, -5); //16
            vertices[66] = new Vector3(0, 5, -5); //20

            // Kiri
            vertices[67] = new Vector3(1, 0, -5); //17
            vertices[68] = new Vector3(1, 5, -5); //21

            // Belakang
            vertices[69] = new Vector3(1, 0, -4); //18
            vertices[70] = new Vector3(0, 0, -4); //19
            vertices[71] = new Vector3(1, 5, -4); //22
            vertices[72] = new Vector3(0, 5, -4); //23

            // Bawah
            vertices[73] = new Vector3(0, 0, -5); //16
            vertices[74] = new Vector3(1, 0, -5); //17
            vertices[75] = new Vector3(1, 0, -4); //18
            vertices[76] = new Vector3(0, 0, -4); //19

            // Atas
            vertices[77] = new Vector3(0, 5, -5); //20
            vertices[78] = new Vector3(1, 5, -5); //21
            vertices[79] = new Vector3(1, 5, -4); //22
            vertices[80] = new Vector3(0, 5, -4); //23

        // Kaki Kursi depan kanan
            // Depan
            vertices[81] = new Vector3(-5, 0, -5); //24
            vertices[82] = new Vector3(-6, 0, -5); //25
            vertices[83] = new Vector3(-6, 5, -5); //28
            vertices[84] = new Vector3(-5, 5, -5); //30

            // Kanan
            vertices[85] = new Vector3(-6, 0, -5); // 25
            vertices[86] = new Vector3(-6, 0, -4); //27
            vertices[87] = new Vector3(-6, 5, -5); //28
            vertices[88] = new Vector3(-6, 5, -4); //31

            // Kiri
            vertices[89] = new Vector3(-5, 0, -5); //24
            vertices[90] = new Vector3(-5, 0, -4); //26
            vertices[91] = new Vector3(-5, 5, -4); //29
            vertices[92] = new Vector3(-5, 5, -5); //30

            // Belakang
            vertices[93] = new Vector3(-5, 0, -4); //26
            vertices[94] = new Vector3(-6, 0, -4); //27
            vertices[95] = new Vector3(-5, 5, -4); //29
            vertices[96] = new Vector3(-6, 5, -4); //31

            // Bawah
            vertices[97] = new Vector3(-5, 0, -5); //24
            vertices[98] = new Vector3(-6, 0, -5); //25
            vertices[99] = new Vector3(-5, 0, -4); //26
            vertices[100] = new Vector3(-6, 0, -4); //27

            // Atas
            vertices[101] = new Vector3(-6, 5, -5); //28
            vertices[102] = new Vector3(-5, 5, -4); //29
            vertices[103] = new Vector3(-5, 5, -5); //30
            vertices[104] = new Vector3(-6, 5, -4); //31

        // Kaki Kursi belakang kanan
            // Depan
            vertices[105] = new Vector3(-6, 5, 0); //12

            // Kanan
            vertices[106] = new Vector3(-6, 0, 0); //9
            vertices[107] = new Vector3(-6, 0, 1); //11
            vertices[108] = new Vector3(-6, 5, 0); //12
            vertices[109] = new Vector3(-6, 5, 1); //15

            // Kiri
            vertices[110] = new Vector3(-5, 0, 0); //8
            vertices[111] = new Vector3(-5, 0, 1); //10
            vertices[112] = new Vector3(-5, 5, 0); //13
            vertices[113] = new Vector3(-5, 5, 1); //14

            // Belakang
            vertices[114] = new Vector3(-5, 0, 1); //10
            vertices[115] = new Vector3(-6, 0, 1); //11
            vertices[116] = new Vector3(-5, 5, 1); //14
            vertices[117] = new Vector3(-6, 5, 1); //15


            // Bawah
            vertices[118] = new Vector3(-5, 0, 0); //8
            vertices[119] = new Vector3(-6, 0, 0); //9
            vertices[120] = new Vector3(-5, 0, 1); //10
            vertices[121] = new Vector3(-6, 0, 1); //11

            // Atas
            vertices[122] = new Vector3(-6, 5, 0); //12
            vertices[123] = new Vector3(-5, 5, 0); //13
            vertices[124] = new Vector3(-5, 5, 1); //14
            vertices[125] = new Vector3(-6, 5, 1); //15

        // Kaki Kursi belakang kiri
            // Depan
            vertices[126] = new Vector3(1, 5, 0); //5

            // Kanan
            vertices[127] = new Vector3(0, 0, 0); //0
            vertices[128] = new Vector3(0, 5, 0); //4

            // Kiri
            vertices[129] = new Vector3(1, 0, 0); //1
            vertices[130] = new Vector3(1, 0, 1); //2
            vertices[131] = new Vector3(1, 5, 0); //5
            vertices[132] = new Vector3(1, 5, 1); //6

            // Belakang
            vertices[133] = new Vector3(1, 0, 1); //2
            vertices[134] = new Vector3(0, 0, 1); //3
            vertices[135] = new Vector3(1, 5, 1); //6
            vertices[136] = new Vector3(0, 5, 1); //7

            // Bawah
            vertices[137] = new Vector3(0, 0, 0); //0
            vertices[138] = new Vector3(1, 0, 0); //1
            vertices[139] = new Vector3(1, 0, 1); //2
            vertices[140] = new Vector3(0, 0, 1); //3

            // Atas
            vertices[141] = new Vector3(0, 5, 0); //4
            vertices[142] = new Vector3(1, 5, 0); //5
            vertices[143] = new Vector3(1, 5, 1); //6
            vertices[144] = new Vector3(0, 5, 1); //7

        // UVS

        // sandaran depan
        uvs[39] = new Vector2(0.5f, 1.0f);
        uvs[37] = new Vector2(0.75f, 1.0f);
        uvs[5] = new Vector2(0.5f, 0.5f);
        uvs[12] = new Vector2(0.75f, 0.5f);

        // sandaran belakang
        uvs[36] = new Vector2(0.5f, 1.0f);
        uvs[38] = new Vector2(0.75f, 1.0f);
        uvs[15] = new Vector2(0.5f, 0.5f);
        uvs[6] = new Vector2(0.75f, 0.5f);

        // penutup sandaran atas
        uvs[42] = new Vector2(0.5f, 1.0f);
        uvs[43] = new Vector2(0.75f, 1.0f);
        uvs[44] = new Vector2(0.5f, 0.5f);
        uvs[45] = new Vector2(0.75f, 0.5f);

        // penutup sandaran bawah
        uvs[49] = new Vector2(0.5f, 1.0f);
        uvs[48] = new Vector2(0.75f, 1.0f);
        uvs[47] = new Vector2(0.5f, 0.5f);
        uvs[46] = new Vector2(0.75f, 0.5f);

        // tatakan atas
        uvs[34] = new Vector2(0.5f, 1.0f);
        uvs[33] = new Vector2(0.75f, 1.0f);
        uvs[35] = new Vector2(0.5f, 0.5f);
        uvs[32] = new Vector2(0.75f, 0.5f);

        // kaki tatakan depan
        uvs[51] = new Vector2(0.5f, 1.0f);
        uvs[50] = new Vector2(0.75f, 1.0f);
        uvs[21] = new Vector2(0.5f, 0.5f);
        uvs[28] = new Vector2(0.75f, 0.5f);

        // kaki tatakan kanan
        uvs[54] = new Vector2(0.5f, 1.0f);
        uvs[55] = new Vector2(0.75f, 1.0f);
        uvs[53] = new Vector2(0.5f, 0.5f);
        uvs[52] = new Vector2(0.75f, 0.5f);

        // kaki tatakan kiri
        uvs[59] = new Vector2(0.5f, 1.0f);
        uvs[58] = new Vector2(0.75f, 1.0f);
        uvs[56] = new Vector2(0.5f, 0.5f);
        uvs[57] = new Vector2(0.75f, 0.5f);

        // kaki tatakan bawah
        uvs[62] = new Vector2(0.5f, 1.0f);
        uvs[60] = new Vector2(0.75f, 1.0f);
        uvs[63] = new Vector2(0.5f, 0.5f);
        uvs[61] = new Vector2(0.75f, 0.5f);

        // Kaki Kursi depan kiri
            // Depan
            uvs[64] = new Vector2(0.5f, 1.0f);
            uvs[20] = new Vector2(0.75f, 1.0f);
            uvs[17] = new Vector2(0.5f, 0.5f);
            uvs[16] = new Vector2(0.75f, 0.5f);

            // Kanan
            uvs[66] = new Vector2(0.5f, 1.0f);
            uvs[23] = new Vector2(0.75f, 1.0f);
            uvs[65] = new Vector2(0.5f, 0.5f);
            uvs[19] = new Vector2(0.75f, 0.5f);

            // Kiri
            uvs[22] = new Vector2(0.5f, 1.0f);
            uvs[68] = new Vector2(0.75f, 1.0f);
            uvs[18] = new Vector2(0.5f, 0.5f);
            uvs[67] = new Vector2(0.75f, 0.5f);

            // Belakang
            uvs[69] = new Vector2(0.5f, 1.0f);
            uvs[68] = new Vector2(0.75f, 1.0f);
            uvs[71] = new Vector2(0.5f, 0.5f);
            uvs[72] = new Vector2(0.75f, 0.5f);

            // Bawah
            uvs[76] = new Vector2(0.5f, 1.0f);
            uvs[75] = new Vector2(0.75f, 1.0f);
            uvs[73] = new Vector2(0.5f, 0.5f);
            uvs[74] = new Vector2(0.75f, 0.5f);

            // Atas
            uvs[77] = new Vector2(0.5f, 1.0f);
            uvs[78] = new Vector2(0.75f, 1.0f);
            uvs[80] = new Vector2(0.5f, 0.5f);
            uvs[79] = new Vector2(0.75f, 0.5f);

        // Kaki Kursi depan kanan
            // Depan
            uvs[84] = new Vector2(0.5f, 1.0f);
            uvs[83] = new Vector2(0.75f, 1.0f);
            uvs[81] = new Vector2(0.5f, 0.5f);
            uvs[82] = new Vector2(0.75f, 0.5f);

            // Kanan
            uvs[87] = new Vector2(0.5f, 1.0f);
            uvs[88] = new Vector2(0.75f, 1.0f);
            uvs[85] = new Vector2(0.5f, 0.5f);
            uvs[86] = new Vector2(0.75f, 0.5f);

            // Kiri
            uvs[91] = new Vector2(0.5f, 1.0f);
            uvs[92] = new Vector2(0.75f, 1.0f);
            uvs[90] = new Vector2(0.5f, 0.5f);
            uvs[89] = new Vector2(0.75f, 0.5f);

            // Belakang
            uvs[96] = new Vector2(0.5f, 1.0f);
            uvs[95] = new Vector2(0.75f, 1.0f);
            uvs[94] = new Vector2(0.5f, 0.5f);
            uvs[93] = new Vector2(0.75f, 0.5f);

            // Bawah
            uvs[99] = new Vector2(0.5f, 1.0f);
            uvs[97] = new Vector2(0.75f, 1.0f);
            uvs[100] = new Vector2(0.5f, 0.5f);
            uvs[98] = new Vector2(0.75f, 0.5f);

            // Atas
            uvs[102] = new Vector2(0.5f, 1.0f);
            uvs[104] = new Vector2(0.75f, 1.0f);
            uvs[103] = new Vector2(0.5f, 0.5f);
            uvs[101] = new Vector2(0.75f, 0.5f);

        // Kaki Kursi belakang kanan
            // Depan
            uvs[13] = new Vector2(0.5f, 1.0f);
            uvs[105] = new Vector2(0.75f, 1.0f);
            uvs[8] = new Vector2(0.5f, 0.5f);
            uvs[9] = new Vector2(0.75f, 0.5f);

            // Kanan
            uvs[108] = new Vector2(0.5f, 1.0f);
            uvs[109] = new Vector2(0.75f, 1.0f);
            uvs[106] = new Vector2(0.5f, 0.5f);
            uvs[107] = new Vector2(0.75f, 0.5f);

            // Kiri
            uvs[113] = new Vector2(0.5f, 1.0f);
            uvs[112] = new Vector2(0.75f, 1.0f);
            uvs[111] = new Vector2(0.5f, 0.5f);
            uvs[110] = new Vector2(0.75f, 0.5f);

            // Belakang
            uvs[117] = new Vector2(0.5f, 1.0f);
            uvs[116] = new Vector2(0.75f, 1.0f);
            uvs[115] = new Vector2(0.5f, 0.5f);
            uvs[114] = new Vector2(0.75f, 0.5f);

            // Bawah
            uvs[118] = new Vector2(0.5f, 1.0f);
            uvs[119] = new Vector2(0.75f, 1.0f);
            uvs[120] = new Vector2(0.5f, 0.5f);
            uvs[121] = new Vector2(0.75f, 0.5f);

            // Atas
            uvs[124] = new Vector2(0.5f, 1.0f);
            uvs[125] = new Vector2(0.75f, 1.0f);
            uvs[123] = new Vector2(0.5f, 0.5f);
            uvs[122] = new Vector2(0.75f, 0.5f);

        // Kaki Kursi belakang kanan
            // Depan
            uvs[126] = new Vector2(0.5f, 1.0f);
            uvs[4] = new Vector2(0.75f, 1.0f);
            uvs[1] = new Vector2(0.5f, 0.5f);
            uvs[0] = new Vector2(0.75f, 0.5f);

            // Kanan
            uvs[128] = new Vector2(0.5f, 1.0f);
            uvs[7] = new Vector2(0.75f, 1.0f);
            uvs[127] = new Vector2(0.5f, 0.5f);
            uvs[3] = new Vector2(0.75f, 0.5f);

            // Kiri
            uvs[132] = new Vector2(0.5f, 1.0f);
            uvs[131] = new Vector2(0.75f, 1.0f);
            uvs[130] = new Vector2(0.5f, 0.5f);
            uvs[129] = new Vector2(0.75f, 0.5f);

            // Belakang
            uvs[136] = new Vector2(0.5f, 1.0f);
            uvs[135] = new Vector2(0.75f, 1.0f);
            uvs[134] = new Vector2(0.5f, 0.5f);
            uvs[133] = new Vector2(0.75f, 0.5f);

            // Bawah
            uvs[140] = new Vector2(0.5f, 1.0f);
            uvs[139] = new Vector2(0.75f, 1.0f);
            uvs[137] = new Vector2(0.5f, 0.5f);
            uvs[138] = new Vector2(0.75f, 0.5f);

            // Atas
            uvs[144] = new Vector2(0.5f, 1.0f);
            uvs[141] = new Vector2(0.75f, 1.0f);
            uvs[143] = new Vector2(0.5f, 0.5f);
            uvs[142] = new Vector2(0.75f, 0.5f);


        mesh.vertices = vertices;
        mesh.triangles = new int[]
        {
            // Kaki Kursi depan kiri
                // Depan
                64, 17, 16,
                16, 20, 64,

                // kanan
                23, 66, 19,
                66, 65, 19,

                // Kiri
                18, 67, 22,
                67, 68, 22,

                // Belakang
                19, 18, 23, 
                18, 22, 23,


                // Bawah
                76, 73, 75,
                75, 73, 74,

                // Atas
                80, 79, 78,
                77, 80, 78,

            // Kaki Kursi Depan Kanan
                // Depan
                84,81,82,
                82,83,84,

                // Kanan
                88,87,85,
                85,86,88,

                // Belakang
                93,95,96,
                93,96,94,

                // Kiri
                89,92,91,
                91,90,89,

                // Atas
                102,103,101,
                101,104,102,
                
                // Bawah
                98,97,99,
                99,100,98,

            // Kaki Belakang kanan
                // Depan
                9,105,13,
                13,8,9,

                // Kanan
                109,108,106,
                106,107,109,

                // Belakang
                114,116,117,
                117,115,114,

                // Kiri
                110,112,113,
                113,111,110,

                // Atas
                125,124,123,
                123,122,125,
                
                // Bawah
                120,121,119,
                119,118,120,

            //Kaki Belakang Kiri
                // Depan
                4,126,1,
                1,0,4,

                // Kanan
                7,128,127,
                127,3,7,

                // Belakang
                135,136,134,
                134,133,135,

                // Kiri
                129,131,132,
                132,130,129,
                
                // Atas
                141,144,143,
                143,142,141,
                
                // Bawah
                139,140,137,
                137,138,139,

          //Tatakan
            // kaki tatakan depan
            21,28,50,
            50,51,21,

            // kaki tatakan kanan 
            52,55,54,
            54,53,52,

            // 41,40,12,
            // 12,5,41,

            // kaki tatakan kiri
            59,56,57,
            57,58,59,

            // tatakan atas
            32,33,34,
            34,35,32,
            
            // tatakan bawah
            63,61,60,
            60,62,63,

        //Senderan Depan
            12,37,39,
            39,5,12,
            
        // Kaki belakang sandaran belakang
            36,37,12,
            12,15,36,
        // Senderan belakang
            38,36,15,
            15,6,38,

        // Kaki kiri sandaran belakang
            39,38,6,
            6,5,39,

        // penutup sandaran atas
            43,42,44,
            44,45,43,

        // penutup sandaran bawah 
            49,48,46,
            46,47,49
        };

        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = KursiMaterial;
        // cubeMaterial.color = new Color32(235, 64, 52, 100);
        mesh.uv = uvs;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
