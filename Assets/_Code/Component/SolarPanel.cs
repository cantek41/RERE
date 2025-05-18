using UnityEngine;

public class SolarPanel : InteractableController
{
    public int Impp = 10;//A
    public int Voc = 50;//V
    public int Vmp = 42;//V
    public int Isc = 11;//V

    public int D_Impp = 10;//A
    public int D_Voc = 50;//V
    public int D_Vmp = 42;//V
    public int D_Isc = 11;//A

    public bool check_Impp = false;//W
    public bool check_Voc = false;//V
    public bool check_Vmp = false;//V
    public bool check_Isc = false;//V

    public Fuse Fuse;

    public void Control_Impp() {
        check_Impp = true;
    }

}
