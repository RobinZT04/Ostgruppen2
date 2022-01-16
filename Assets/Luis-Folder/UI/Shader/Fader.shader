

Shader "Custom/Fader" 
{
	Properties
	{
		_MainTex("Base (RGB) Trans (A)", 2D) = "white" {} //This is the spiral image 
		_RampTex("Ramp (RGB)", 2D) = "white" {} // // Da super image that contains the colors that will be used for drawing the boarder of the spiral as it opens and closes
		_Color("Tint", Color) = (1,1,1,1) // // Och Tint is the variable that mentains the color from which we are going to take the alpha value 
	}
	SubShader
	{
		Tags{ "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent" }
		LOD 100
			
		Lighting Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			//// Well this will define the data that will be used
			struct appdata_t {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
				fixed4 color : COLOR;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				half2 texcoord : TEXCOORD0;
				fixed4 color : COLOR;
			};

			sampler2D _MainTex;
			sampler2D _RampTex;
			float4 _MainTex_ST;
			fixed4 _Color;

			v2f vert(appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				o.color = v.color * _Color;
				return o;
			}
			// Okey Henry so for every pixel there is it has to be used to draw the fader image
			fixed4 frag(v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.texcoord);
				col.rgb = tex2D(_RampTex, float2(((col.a+0.15) - i.color.a*1.2)*4,0.5))*2;
				col.a = lerp(0, 1, clamp((col.a+0.2 - min(i.color.a*1.2, 1.4)) * 20, 0, 1));;

				return col;
			}
				
			ENDCG
		}
	}
}
