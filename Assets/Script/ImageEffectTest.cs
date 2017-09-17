using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CinematicEffects;

[ExecuteInEditMode]
public class ImageEffectTest : MonoBehaviour {

	[SerializeField] Shader m_shader;

	private Material m_Material;
	public Material material
	{
		get
		{
			if (m_Material == null)
				m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(m_shader);

			return m_Material;
		}
	}

	void OnRenderImage( RenderTexture source , RenderTexture destination )
	{

		Graphics.Blit (source, destination, material);

	}
}
