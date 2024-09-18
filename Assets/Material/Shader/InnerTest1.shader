Shader "Custom/InnerTest1"
{
	Properties
	{
		LineColor("LineColor", color) = (1,1,1,1)
		CubeColor("CubeColor", color) = (1,1,1,1)
		LineWeight("LineWeight", range(0,0.5)) = 0.1
	}
		SubShader
	{
		Tags { "Queue" = "Transparent" }
		Pass {
 
			//���Ҫ��ʾ������߿�ȡ����������ע�ͼ���
			//cull off
			//ZWrite off
			blend srcalpha oneminussrcalpha
			CGPROGRAM
 
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			uniform sampler2D _MainTex;
			uniform float4 _MainTex_ST;
			fixed4 LineColor;
			fixed4 CubeColor;
			fixed LineWeight;
 
			struct a2v {
			  float4 vertex : POSITION;
			  float2 uv : TEXCOORD0;
			};
 
			struct v2f {
			  float4 pos : SV_POSITION;
			  float2 uv : TEXCOORD0;
			};
 
			v2f vert(a2v v) {
			  v2f o;
 
			  o.pos = UnityObjectToClipPos(v.vertex);
			  o.uv = v.uv;
 
			  return o;
			}
 
			float4 frag(v2f i) : SV_Target {
 
			  fixed4 col = CubeColor;//Cube�Ļ�����ɫ
			  col += saturate(step(i.uv.x, LineWeight) + step(1 - LineWeight, i.uv.x) + step(i.uv.y, LineWeight) + step(1 - LineWeight, i.uv.y)) * LineColor;
 
			  if (i.uv.x < LineWeight || i.uv.x > 1 - LineWeight || i.uv.y < LineWeight || i.uv.y > 1 - LineWeight)
			  {
			  	col = LineColor;
			  }
 
			  return  col;
			}
 
			ENDCG
		}
	}
}