using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch(type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Warrior:
                INPC warrior = new Warrior();
                return warrior;
            case NPCType.Wizard:
                INPC wizard = new Wizard();
                return wizard;
            case NPCType.Ron:
                INPC ron = new Ron();
                return ron;
        }
        return null;
    }
}
