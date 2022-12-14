using UnityEngine;

public class MainScript : MonoBehaviour {
    
    public int Money;
    public float TmpMny;
    public int TmpHP;
    public byte ShipType;
    public int BonusAddHP;
    public int BonusMultHP;
    // public int ShipSize
    // public int ShipSpeedType
    // public int ShipWeaponsType
    
    private void Start() 
    {
        GameObject player = null; //Null por ahora
        Initialize();
    }
    private void Update() 
    {
        
    }
    public void Initialize()
    {
        //Salud
        //TODO: switch
        switch (ShipType) 
        {
            case 1: T  + 1; break;
            case 2: TmpHP  + 10; break;
            default: TmpHP - 1; break;
        }
        TmpHP= (100 + BonusAddHP) * BonusMultHP;
        //Money
        TmpMny = 0f;
    }
    
}