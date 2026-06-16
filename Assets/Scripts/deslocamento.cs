using UnityEngine;

public class deslocamento : MonoBehaviour
{
    private renderer objetoRenderer;
    private Material objetoMaterial;
    private float offset; //deslocamento do material
    private float offsetIncremento; //valor incremento
        private float offsetVelocidade; //valor decremento
    void Start()
    {//acessar componente meshrenderer
        objetoRenderer = GetComponent<MeshRenderer>();
        
        objetoMaterial = objetoRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += offsetIncremento;
        objetoMaterial.SetTextureOffset("_Maintex", new Vector2(offset * offsetVelocidade, 0));
    }
}
